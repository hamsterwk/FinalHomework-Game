using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalHomework_Game.GameEvent
{
    public class GameEventBase
    {//所有事件的基类。
        public static int TypeID=0;
        public static int weight=1;//该事件的权重。
        public static List<string> MsgList;//该事件显示的文案
        public static string EventName = "BaseEvent";
        public static string Description = "（基本事件。）";
        public virtual int Weight { get => weight; set => weight = value; }
        virtual public string GetLog(Course course, Game game)
        {
            if (MsgList.Count() == 0) return "";
            string rtn = MsgList[GameSystem.random.Next(MsgList.Count())];
            rtn = Regex.Replace(rtn, "<0>", course.CourseName);
            return rtn+Description;
        }

        virtual public int Load()
        {
            return 1;
        }

        virtual public void PerformEvent(int period, Course course1, Game game)
        {//处理事件。
            Course course = (from c in game.GameChapter.CourseList where course1.CourseName == c.CourseName select c).ToList()[0];
            course.Score += course.ReviewBonus;
            course.LastReview = game.CurTurn;
            game.Pressure += 5;
            if (period == 3) game.Pressure += 5;
        }
    }
}
