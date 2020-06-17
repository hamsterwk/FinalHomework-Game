using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework_Game
{
    [Serializable]
    public class Game//游戏状态
    {
        private string playerName;//玩家姓名
        private Chapter gameChapter;//选用剧本
        private int curTurn;//当前回合
        private int pressure;//压力值
        private int ifNight;//是否有通宵的后果：0:无，1:通宵，无事发生，2:通宵，而且早晨无法复习
        private int buff;//0无，2精神抖擞，-2疲劳
        public Game()
        {
            playerName = "无名氏";
            gameChapter = new Chapter();
            curTurn = 0;
        }

        public string PlayerName { get => playerName; set => playerName = value; }
        public int CurTurn { get => curTurn; set => curTurn = value; }
        public int Buff { get => buff; set => buff = value; }
        public int IfNight { get => ifNight; set => ifNight = value; }
        public int Pressure { get => pressure; set => pressure = value; }
        internal Chapter GameChapter { get => gameChapter; set => gameChapter = value; }

    }
}
