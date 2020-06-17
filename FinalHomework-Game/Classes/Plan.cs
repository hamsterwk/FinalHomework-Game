using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalHomework_Game.GameEvent;

namespace FinalHomework_Game
{
    public class Plan//计划类
    {
        private List<Course> planList;
        private List<GameEventBase> eventList;
        public Plan()
        {
            planList = new List<Course>();
            eventList = new List<GameEventBase>();
        }

        public List<Course> PlanList { get => planList; set => planList = value; }
        public List<GameEventBase> EventList { get => eventList; set => eventList = value; }
    }
}
