using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalHomework_Game.GameEvent
{
    class GameEventCourseAdd:GameEventBase
    {
        public static new int TypeID = 8;
        private static new int weight = 3;//该事件的权重。
        public static new List<string> MsgList = new List<string>();
        public static new string EventName = "CourseAddEvent";
        public static new string Description = "【<0>】之后的复习效率都会相对提高。";
        public override int Weight { get => weight; set => weight = value; }
        public int AddFactor;
        public GameEventCourseAdd()
        {
            AddFactor = GameSystem.random.Next(3) + 1;
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
            string rtn = MsgList[GameSystem.random.Next(MsgList.Count())]+ Description;
            rtn = Regex.Replace(rtn, "<0>", course.CourseName);
            return rtn;
        }

        public override void PerformEvent(int period, Course course1, Game game)
        {
            base.PerformEvent(period, course1, game);
            Course course = (from c in game.GameChapter.CourseList where course1.CourseName == c.CourseName select c).ToList()[0];
            course.ReviewBonus += AddFactor;
        }
    }
}
