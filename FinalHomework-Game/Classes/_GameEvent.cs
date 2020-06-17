using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework_Game
{
    public class _GameEvent
    {
        private int eventID;//事件ID
        //事件参数
        private int  addFactor, constantFactor, courseFactor;
        private double multipleFactor;
        private static double[] factorList = { -1.5, -1, 1.25, 1.5, 2 };
        private int type;
        /*
         *type:
         * 0: 考试
         * 1: 没有安排计划
         * 2: 无事发生
         * 3: 计划被取消
         * 4-5: 修改阶段复习效率
         * 6-7: 修改学科复习效率
         * 8-9: 修改学科能力值
         * 10: 计划被替换
         */
        public _GameEvent(int _e)//根据事件ID补全其它参数
        {
            eventID = _e;
            multipleFactor = 1;
            constantFactor = 0;
            courseFactor = 0;
            if (eventID == 100)
            {//这门学课考试
                type = 0;
            }else if(eventID==-1)
            {//无安排
                type = 1;
            }
            else if(eventID<75)
            {//无事发生
                type = 2;
            }
            else if (eventID <= 79)
            {//计划被跳过
                type = 3;
                multipleFactor = 0;
            }
            else if (eventID <= 84)
            {//修改阶段复习效率 80,81,82,83,84 ->{-1.5,-1,1.25,1.5,2}
                type = 4; multipleFactor = 1.5;
                if (eventID <= 81) multipleFactor *= -1;
                else type++;
            }
            else if (eventID <= 89)
            {//修改学科复习效率
                type = 6;
                courseFactor = eventID - 87;
                if (eventID >= 87) type++;
            }
            else if (eventID <= 94)
            {//修改学科能力值
                type = 8;
                constantFactor = eventID - 92;
                if (eventID >= 92) type++;
            }
            else { type = 10; }
        }
        public double MultipleFactor { get => multipleFactor; set => multipleFactor = value; }
        public int AddFactor { get => addFactor; set => addFactor = value; }
        public int ConstantFactor { get => constantFactor; set => constantFactor = value; }
        public int CourseFactor { get => courseFactor; set => courseFactor = value; }
        public int Type { get => type; set => type = value; }
    }
}
