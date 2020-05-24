using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FinalHomework_Game
{
    public class Course
    {
        //课程类
        private int score;//最终得分
        private double credit;//学分
        private int reviewBonus;//每次复习可以增加的分数
        private int baseDecrease, incDecrease, lastReview;//若未复习，减少(curTurn-lastReview)*inc+base分
        private string courseName;//课程名
        private string description;//课程描述
        private int deadline;//考试日期对应的回合;

        public Course(int score, double credit, int reviewBonus, int baseDecrease, int incDecrease, int lastReview, string courseName, string description)
        {
            this.score = score;
            this.credit = credit;
            this.reviewBonus = reviewBonus;
            this.baseDecrease = baseDecrease;
            this.incDecrease = incDecrease;
            this.lastReview = lastReview;
            this.courseName = courseName;
            this.description = description;
        }

        public Course(string text)
        {
            string[] textList = Regex.Split(text, "\t");
            this.courseName = textList[0];
            this.description = textList[1];
            this.score = int.Parse(textList[2]);
            this.credit = double.Parse(textList[3]);
            this.reviewBonus = int.Parse(textList[4]);
            this.baseDecrease = int.Parse(textList[5]);
            this.incDecrease = int.Parse(textList[6]);
            this.deadline = int.Parse(textList[7]);
        }

        public int Score { get { return score; } set { score = value; } }
        public string CourseName { get { return courseName; } set { courseName = value; } }

        public int BaseDecrease { get => baseDecrease; set => baseDecrease = value; }
        public int IncDecrease { get => incDecrease; set => incDecrease = value; }
        public int LastReview { get => lastReview; set => lastReview = value; }
        public int ReviewBonus { get => reviewBonus; set => reviewBonus = value; }
        public string Description { get => description; set => description = value; }
        public int Deadline { get => deadline; set => deadline = value; }
    }
}
