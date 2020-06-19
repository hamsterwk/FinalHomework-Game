using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalHomework_Game.GameEvent
{
    class GameEventNull:GameEventBase
    {
        public static new int TypeID = 4;
        public static new int weight = 0;//该事件的权重。(该事件不会随机生成。)
        public static new List<string> MsgList = new List<string>();
        public static new string EventName = "NullEvent";
        public static new string Description = "（休息了一下，压力值减少了。）";
        public override int Weight { get => weight; set => weight = value; }
        public GameEventNull()
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

        public override string GetLog( Course course, Game game)
        {
            if (MsgList.Count() == 0) return "";
            string rtn = MsgList[GameSystem.random.Next(MsgList.Count())];
            rtn = Regex.Replace(rtn, "<0>", course.CourseName);
            return rtn + Description;
        }

        public override void PerformEvent(int period, Course course, Game game)
        {
            game.Pressure -= 10;
        }
    }
}
