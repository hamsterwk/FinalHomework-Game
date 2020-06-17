using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalHomework_Game.GameEvent
{
    class GameEventTest:GameEventBase
    {
        private int testFactor;
        public static new int TypeID = 1;
        public static new int weight = 0;//该事件的权重。(该事件不会随机生成。)
        public static new List<string> MsgList = new List<string>();
        public static new string EventName = "TestEvent";
        public static new string Description = "（考试效果也会影响到状态。）";
        public override int Weight { get => weight; set => weight = value; }
        public GameEventTest()
        {
            testFactor = GameSystem.random.Next(11) - 5;
        }

        public override int Load()
        {
            try
            {
                StreamReader reader = new StreamReader($"./Event/{EventName}/Log.txt", Encoding.UTF8);
                string[] LineSets = Regex.Split(reader.ReadToEnd(), "\r\n");
                foreach (string line in LineSets) MsgList.Add(line);
                if (MsgList.Count < 11) return -1;
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public override string GetLog(Course course, Game game)
        {
            string rtn = MsgList[course.TestFactor + 5];
            rtn = Regex.Replace(rtn, "<0>", course.CourseName);
            return rtn + Description;
        }

        public override void PerformEvent(int period, Course course1, Game game)
        {
            Course course = (from c in game.GameChapter.CourseList where course1.CourseName == c.CourseName select c).ToList()[0];
            course.TestFactor = testFactor;
            course.Score += testFactor;
            game.Pressure += testFactor;
        }
    }
}
