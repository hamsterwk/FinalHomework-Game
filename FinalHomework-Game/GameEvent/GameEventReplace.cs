using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalHomework_Game.GameEvent
{
    class GameEventReplace:GameEventBase
    {
        public static new int TypeID = 3;
        private static new int weight = 5;//该事件的权重。
        public static new List<string> MsgList = new List<string>();
        public static new string EventName = "ReplaceEvent";
        public static new string Description = "（这个阶段的复习计划被替换成了最近的一门考试【<1>】。）";
        public override int Weight { get => weight; set => weight = value; }

        public GameEventReplace()
        {

        }

        public override int Load()
        {
            try
            {
                StreamReader reader = new StreamReader($"./Event/{EventName}/Log.txt", Encoding.UTF8);
                string[] LineSets = Regex.Split(reader.ReadToEnd(), "\r\n");
                foreach (string line in LineSets) MsgList.Add(line);
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public override string GetLog(Course course, Game game)
        {
            if (MsgList.Count() == 0) return "";
            if (course.Description == "未替换")
            {
                GameEventDefault gameEventDefault = new GameEventDefault();
                return gameEventDefault.GetLog(course, game);
            }
            string rtn = MsgList[GameSystem.random.Next(MsgList.Count())]+ Description;
            rtn = Regex.Replace(rtn, "<1>", course.CourseName);
            rtn = Regex.Replace(rtn, "<2>", course.Description);
            return rtn;
        }

        public override void PerformEvent(int period, Course course1, Game game)
        {
            Course course = (from c in game.GameChapter.CourseList where course1.CourseName == c.CourseName select c).ToList()[0];
            //寻找最近的课程
            Course courseRep = null;
            foreach(Course course2 in (from c in game.GameChapter.CourseList where c.Deadline>game.CurTurn||(c.Deadline==game.CurTurn&&c.TestPeriod>period) select c))
            {
                if(courseRep==null || (course2.Deadline<courseRep.Deadline) || (course2.Deadline == courseRep.Deadline&& course2.TestPeriod<courseRep.TestPeriod))
                {
                    courseRep = course2;
                }
            }
            if (courseRep != null && courseRep != course)
            {
                course1.Description = course.CourseName;
                course1.CourseName = courseRep.CourseName;
            }
            else { course1.Description = "未替换"; }
            base.PerformEvent(period, course1, game);
        }
    }
}
