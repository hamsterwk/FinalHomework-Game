using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework_Game
{
    public class Game//游戏状态
    {
        private string playerName;//玩家姓名
        private Chapter gameChapter;//选用剧本
        private int curTurn;//当前回合
        public Game()
        {
            playerName = "无名氏";
            gameChapter = new Chapter();
            curTurn = 0;
        }

        public string PlayerName { get => playerName; set => playerName = value; }
        public int CurTurn { get => curTurn; set => curTurn = value; }
        internal Chapter GameChapter { get => gameChapter; set => gameChapter = value; }

        public void PerformTurn(Plan CurPlan)
        {//根据提交的计划，执行一个回合
           
        }
    }
}
