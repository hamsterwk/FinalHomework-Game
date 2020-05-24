using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework_Game
{
    public class Event
    {
        private int eventID;//事件ID
        //事件参数
        private int MultipleFactor, AddFactor, ConstantFactor, CourseFactor;
        public Event(int _e)//根据事件ID补全其它参数
        {
            eventID = _e;
            MultipleFactor = 1;
            AddFactor = 0;
            ConstantFactor = 0;
            CourseFactor = 0;
            if (_e < 75) return;
        }
    }
}
