using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalHomework_Game.GameEvent
{
    class GameEventSkip:GameEventBase
    {//事件--跳过回合
        public static new int TypeID = 2;
        private static new int weight = 5;//该事件的权重。
        public static new List<string> MsgList = new List<string>();
        public static new string EventName = "SkipEvent";
        public static new string Description = "（这个阶段的复习计划失效了。）";

        public override int Weight { get => weight; set => weight = value; }

        public GameEventSkip()
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
            string rtn = MsgList[GameSystem.random.Next(MsgList.Count())];
            rtn = Regex.Replace(rtn, "<1>", course.CourseName);
            return rtn + Description;
        }

        public override void PerformEvent(int period, Course course1, Game game)
        {
            course1.CourseName = "空";
            game.Pressure -= 3;
        }
    }
}
