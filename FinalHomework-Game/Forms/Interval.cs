using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using FinalHomework_Game.GameEvent;

namespace FinalHomework_Game
{
    public partial class Interval : Form
    {
        private Game curGame;
        private Plan curPlan;
        private void SlowPrint(string str)
        {
            LogText.Text = "";
            Application.DoEvents();
            Thread.Sleep(500);
            foreach(char buf in str)
            {
                LogText.Text = LogText.Text + buf;
                LogText.Refresh();
                Thread.Sleep(GameSystem.DisplaySpeed);
            }
        }


        private string GenSingleLog(int period,Course course,GameEventBase gameEvent)
        {
            string rtn = "";
            if (period != 3) rtn += $"今天{GameSystem.TimeName[period]}，";
            else rtn += "感觉还是需要努把力，所以今天通宵学习，";
            string eventLog = gameEvent.GetLog(course,curGame);
            rtn += eventLog;
            return rtn;
        }
        private void PrintLog(Game gamest, Plan curPlan)
        {//输出日志：
            String strLog = "";
            strLog = strLog + GameSystem.GetDate(gamest.GameChapter.StMonth, gamest.GameChapter.StDay+gamest.CurTurn-1)+"：\r\n";
            //按照计划依次执行
            for(int i = 0; i < 3; i++)
            {
                Course curCourse = curPlan.PlanList[i];
                GameEventBase curEvent = curPlan.EventList[i];
                strLog+= GenSingleLog(i,curCourse,curEvent)+"\r\n";
            }

            if (curPlan.PlanList[3].CourseName != "空")
            {
                strLog += GenSingleLog(3, curPlan.PlanList[3], curPlan.EventList[3]) + "\r\n";
                if (gamest.IfNight==2)
                {
                    strLog += "实在是太困了，所以明天上午可能得好好休息了（明天上午将无法安排计划）。\r\n";
                }
            }

            if(curGame.Buff==-2)
            {
                string curLog = $"过高的压力值使我产生了疲劳。（所有学科的能力值都会有所降低。）\r\n";
                strLog += curLog;
            }
            if (curGame.Buff == 2)
            {
                string curLog = $"较低的压力值使我精神抖擞。（所有学科的能力值都会有所提高。）\r\n";
                strLog += curLog;
            }
            SlowPrint(strLog);
        }

        public void PrintResult(GameResult result)
        {
            String strLog = "";
            strLog += $"终于考完了所有的考试，一切都结束了，愉快的假期也正式开始了。\r\n";
            strLog += $"今天是公布成绩的日子，我打开教务系统，查到了自己的成绩：\r\n";
            foreach(Course course in result.GameChapter.CourseList)
            {
                string curLog = $"{course.CourseName}，得分：{course.Score}，绩点：{course.GPA}\r\n";
                strLog += curLog;
            }
            strLog += $"最后是总绩点：{result.GPA}";
            SlowPrint(strLog);
        }

        public Interval(Game gamest, Plan newPlan)
        {
            InitializeComponent();
            LogText.Parent = label1;
            LogText.AutoSize = false;
            LogText.Dock = DockStyle.Fill;
            this.TopLevel = false;
            PlayerName.Text = $"{gamest.PlayerName}的日记：";
            ContinueBtn.Enabled = false;
            curGame = gamest;
            curPlan = newPlan;
        }

        private void Interval_Shown(object sender, EventArgs e)
        {
            PrintLog(curGame, curPlan);
            ContinueBtn.Enabled = true;
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            if (ContinueBtn.Text == "游戏结束")
            {
                NewGame form1 = new NewGame();
                form1.TopLevel = false;
                this.Parent.Controls.Add(form1);
                this.Parent.Controls.Remove(this);
                form1.Show();
                this.Close();
                this.Dispose();
                return;
            }
            
            if (curGame.CurTurn <= curGame.GameChapter.SumTurn)
            {
                MakePlan makePlan = new MakePlan(curGame);
                makePlan.TopLevel = false;
                this.Parent.Controls.Add(makePlan);
                this.Parent.Controls.Remove(this);
                makePlan.Show();
                this.Close();
                this.Dispose();
            }
            else
            {
                GameResult result = new GameResult(curGame);
                ContinueBtn.Text = "游戏结束";
                ContinueBtn.Enabled = false;
                PrintResult(result);
                ContinueBtn.Enabled = true;
            }
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {
            Application.DoEvents();
        }
    }
}
