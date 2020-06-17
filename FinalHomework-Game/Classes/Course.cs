using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FinalHomework_Game
{
    [Serializable]
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
        private int testPeriod;//考试时间段{0，1，2}：{上午，下午，晚上}
        private int testFactor;//考试时的临场发挥系数
        public Course()
        {
            this.score = 0;
            this.credit = 0;
            this.reviewBonus = 0;
            this.baseDecrease = 0;
            this.incDecrease = 0;
            this.lastReview = 0;
            this.courseName = "空";
            this.description = "空";
            this.testFactor = -11;
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
            this.testPeriod = int.Parse(textList[8]);
            this.testFactor = -11;
        }

        public Course(Course a)
        {
            this.score = a.score;
            this.credit = a.credit;
            this.reviewBonus = a.reviewBonus;
            this.baseDecrease = a.baseDecrease;
            this.incDecrease = a.incDecrease;
            this.lastReview = a.lastReview;
            this.courseName = a.courseName;
            this.description = a.description;
            this.deadline = a.deadline;
            this.testPeriod = a.testPeriod;
            this.testFactor = a.testFactor;
        }

        public int Score { get { return score; } set { score = value; } }
        public string CourseName { get { return courseName; } set { courseName = value; } }

        public int BaseDecrease { get => baseDecrease; set => baseDecrease = value; }
        public int IncDecrease { get => incDecrease; set => incDecrease = value; }
        public int LastReview { get => lastReview; set => lastReview = value; }
        public int ReviewBonus { get => reviewBonus; set => reviewBonus = value; }
        public string Description { get => description; set => description = value; }
        public int Deadline { get => deadline; set => deadline = value; }

        public double GPA { get => GameSystem.GetGPA(score); }
        public double Credit { get => credit; set => credit = value; }
        public int TestFactor { get => testFactor; set => testFactor = value; }
        public int TestPeriod { get => testPeriod; set => testPeriod = value; }

        public string DetailedDescription
        {
            get => $"课程名：{courseName}\r\n说明：{description}\r\n学分：{credit}";
        }
    }
}
