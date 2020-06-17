using FinalHomework_Game.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalHomework_Game.Forms;
using FinalHomework_Game.GameEvent;

namespace FinalHomework_Game
{
    public partial class MakePlan : Form
    {
        public Game Gamest;
        int RowHeight = 30;
        private int MidCurRow;//添加课程指针
        private int MidCurCol;//添加课程指针
        private int RightFocus;
        private Label RightBarFocus;//右侧计划列表焦点
        private Label MidBarFocus;//中间选择的列表焦点
        private List<Course> PlanList;//复习的计划表
        private List<Label> PlanLabelList;
        private List<Button> BtnList;
        private List<GameEventBase> EventList;
        private bool[] StatusList;
        private static Color FontColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
        private static Color FontColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
        private static Color FontColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
        private static Color FontColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(28)))));


        public void RenderForm(Game curGame)
        {
            //全体初始化
            Gamest = curGame;
            PlanList = new List<Course>() { new Course(), new Course(), new Course(), new Course() };
            PlanLabelList = new List<Label>() { Plan0, Plan1, Plan2, Plan3 };
            BtnList = new List<Button>() { ClearMorning, ClearAfternoon, ClearEvening, ClearNight };
            StatusList = new bool[] {true,true,true,true };
            EventList = new List<GameEventBase>();
            for (int i = 0; i < 4; i++) EventList.Add(GameSystem.GetEvent());
            MidBarFocus = new Label();

            //清空原数据，表格归正
            while (CourseTablePanel.RowCount > 1)
            {
                int delRow = CourseTablePanel.RowCount - 1;
                for(int i = 0; i < 3; i++)
                {
                    CourseTablePanel.Controls.RemoveAt(3*delRow);
                }
                CourseTablePanel.RowStyles.RemoveAt(delRow);
                CourseTablePanel.RowCount--;
                CourseTablePanel.Height = CourseTablePanel.RowCount * RowHeight;
            }
            while (SelectionTable.Controls.Count > 0) SelectionTable.Controls.RemoveAt(0);
            MidCurCol = MidCurRow = 0;

            //渲染日期，进度条，玩家名
            UpdateDate();
            UpdateBar();
            PlayerName.Text = curGame.PlayerName;

            //添加新课程
            foreach (Course course in curGame.GameChapter.CourseList)
            {
                AddCourse(course);
            }
            foreach (Label label in SelectionTable.Controls)
            {
                label.Click += new EventHandler(SetMidFocus);
                label.DoubleClick += new EventHandler(SetMidFocus);
                label.DoubleClick += new EventHandler(DoubleClickMid);
            }

            //渲染右侧计划表
            foreach (Label label in PlanLabelList)
            {
                label.Click += new EventHandler(SetRightFocus);
                label.Text = "未安排";
            }
            DisableLabel(3, "好好休息");
            //通宵事件
            if (curGame.IfNight == 2)
            {
                DisableLabel(0, "昨晚通宵，只能休息");
            }
            //占用考试时间段：
            foreach(Course course in Gamest.GameChapter.CourseList)
            {
                if (course.Deadline == Gamest.CurTurn)
                {
                    DisableLabel(course.TestPeriod, $"参加{course.CourseName}考试");
                    EventList[course.TestPeriod] = new GameEventTest();
                    PlanList[course.TestPeriod] = course;
                }
            }

            RightBarFocus = new Label();
            SetRightFocus(GetRightFocus(), new EventArgs());
        }

        private Label GetRightFocus(int idx=3)
        {
            for(int i = (idx + 1) % 4; i != idx; i = (i + 1) % 4)
            {
                if (StatusList[i])
                {
                    RightFocus = i;
                    return PlanLabelList[i];
                }
            }
            RightFocus = -1;
            return null;
        }

        public MakePlan(Game curGame)
        {
            InitializeComponent();
            GameSystem.SaveGame(1, curGame);
            RenderForm(curGame);

        }
        void DisableLabel(int i, string hint = "未安排")
        {
            Label label = PlanLabelList[i];
            Button button = BtnList[i];
            label.Text = hint;
            label.ForeColor = Color.Black;
            StatusList[i] = false;
            EventList[i] = new GameEventNull();
        }
        void EnableLabel(int i, string hint = "未安排")
        {
            Label label = PlanLabelList[i];
            Button button = BtnList[i];
            label.Text = hint;
            label.ForeColor = Color.Black;
            StatusList[i] = true;
            EventList[i] = GameSystem.GetEvent();
        }
        void UpdateDate()
        {
            //渲染日期部分
            
            int newMonth = Gamest.GameChapter.StMonth;
            int newDay = Gamest.GameChapter.StDay + Gamest.CurTurn;

            Date.Text = GameSystem.GetDate(newMonth, newDay);
            TurnText.Text = $"第 {Gamest.CurTurn+1} 天";
        }
        void UpdateBar()
        {
            //渲染进度条            
            if (Gamest.Buff == 0) BuffLbl.Text = "精神状态：正常"; else if (Gamest.Buff == -2) BuffLbl.Text = "精神状态：疲劳"; else if (Gamest.Buff == 2) BuffLbl.Text = "精神状态：兴奋";
            PressureBar.Value = Gamest.Pressure;
            if (PressureBar.Value >= 75) PressureBar.ForeColor = Color.Red;
            else PressureBar.ForeColor = Color.Green;
        }
        void AddCourse(Course newCourse)
        {
            //当前的课程是否已经考完？
            bool IsFinished = (newCourse.Deadline<Gamest.CurTurn);
            //课程小提示
            ToolTip newCoursePlanTip = new ToolTip();
            newCoursePlanTip.InitialDelay = 500;
            //添加一门课程的信息
            CourseTablePanel.RowCount++;
            CourseTablePanel.Height += RowHeight;
            CourseTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, RowHeight));
            //课程名项
            Label newCourseName = new Label();
            newCourseName.Text = newCourse.CourseName;
            newCourseName.AutoSize = false;
            newCourseName.Font = new Font("宋体", 9, FontStyle.Bold);
            newCourseName.ForeColor = FontColor1;
            newCourseName.TextAlign = ContentAlignment.MiddleCenter;
            newCourseName.Dock = DockStyle.Fill;
            newCoursePlanTip.SetToolTip(newCourseName, newCourse.DetailedDescription);
            CourseTablePanel.Controls.Add(newCourseName, 0, CourseTablePanel.RowCount - 1);
            //课程考试日期
            Label newCourseDDL = new Label();
            newCourseDDL.Text = $"{GameSystem.GetDate(Gamest.GameChapter.StMonth,Gamest.GameChapter.StDay+newCourse.Deadline)} {GameSystem.TimeName[newCourse.TestPeriod]}";
            newCourseDDL.AutoSize = false;
            newCourseDDL.Font = new Font("宋体", 9, FontStyle.Bold);
            newCourseDDL.ForeColor = FontColor1;
            newCourseDDL.TextAlign = ContentAlignment.MiddleCenter;
            newCourseDDL.Dock = DockStyle.Fill;
            CourseTablePanel.Controls.Add(newCourseDDL, 1, CourseTablePanel.RowCount - 1);
            //课程的能力值
            Label newCourseScore = new Label();
            if (IsFinished)
            {
                newCourseScore.Text = "???";
                ToolTip newCourseScoreTip = new ToolTip();
                newCourseScoreTip.InitialDelay = 500;
                newCourseScoreTip.SetToolTip(newCourseScore, "这门课已经考完了，只有等出成绩才能知道分数哦！");
            }
            else
            {
                newCourseScore.Text = newCourse.Score.ToString();
                ToolTip newCourseScoreTip = new ToolTip();
                newCourseScoreTip.InitialDelay = 500;
                newCourseScoreTip.SetToolTip(newCourseScore, "如果现在考这门课的预计分数，实际考试分数会受到临场发挥影响！");
            }
            newCourseScore.AutoSize = false;
            newCourseScore.Font = new Font("宋体", 9, FontStyle.Bold);
            newCourseScore.ForeColor = FontColor1;
            newCourseScore.TextAlign = ContentAlignment.MiddleCenter;
            newCourseScore.Dock = DockStyle.Fill;
            CourseTablePanel.Controls.Add(newCourseScore, 2, CourseTablePanel.RowCount - 1);

            if (IsFinished) return;
            //添加到中间区（前提是可以复习）
            Label newCoursePlan = new Label();
            newCoursePlan.Name = newCourse.CourseName;
            newCoursePlan.Text = $"复习{newCourse.CourseName}";
            newCoursePlan.AutoSize = false;
            newCoursePlan.Height = 50;
            newCoursePlan.Width = 100;
            newCoursePlan.ForeColor = FontColor1;
            newCoursePlan.Font = new Font("宋体", 9, FontStyle.Bold);
            newCoursePlan.TextAlign = ContentAlignment.MiddleCenter;
            newCoursePlan.Dock = DockStyle.Fill;
            newCoursePlanTip.SetToolTip(newCoursePlan, newCourse.DetailedDescription);
            SelectionTable.Controls.Add(newCoursePlan, MidCurCol, MidCurRow);
            MidCurCol += 1;
            if (MidCurCol == 3)
            {
                MidCurCol = 0;
                MidCurRow++;
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            //如果计划为空，事件定义为空事件
            for(int i=0;i<4;i++)
            {
                if(PlanList[i].CourseName=="空")
                {
                    EventList[i] = new GameEventNull();
                }
            }
            //生成计划
            Plan newPlan = new Plan();
            newPlan.PlanList = PlanList;
            newPlan.EventList = EventList;

            //执行计划，进入跳转界面
            GameSystem.PerformGame(Gamest, newPlan);
            //RenderForm(Gamest);
            Interval interval = new Interval(Gamest, newPlan);
            this.Parent.Controls.Add(interval);
            interval.Show();
            this.Parent.Controls.Remove(this);
            Close();
            Dispose();
        }

        private void ClearMorning_Click(object sender, EventArgs e)
        {
            if (StatusList[0] == false) return;
            PlanLabelList[0].Text = "未安排";
            PlanList[0] = new Course();
            SetRightFocus(PlanLabelList[0], e);
        }

        private void ClearAfternoon_Click(object sender, EventArgs e)
        {
            if (StatusList[1] == false) return;
            PlanLabelList[1].Text = "未安排";
            PlanList[1] = new Course();
            SetRightFocus(PlanLabelList[1], e);
        }

        private void ClearEvening_Click(object sender, EventArgs e)
        {
            if (StatusList[2] == false) return;
            PlanLabelList[2].Text = "未安排";
            PlanList[2] = new Course();
            SetRightFocus(PlanLabelList[2], e);
        }

        private void ClearNight_Click(object sender, EventArgs e)
        {
            if (StatusList[3] == false) return;
            PlanLabelList[3].Text = "未安排";
            PlanList[3] = new Course();
            SetRightFocus(PlanLabelList[3], e);
        }

        private void SetRightFocus(object sender, EventArgs e)
        {
            RightFocus = -1;
            if (sender == null) return;
            Label label = (Label)sender;
            int idx = PlanLabelList.FindIndex(l=>l==label);
            if (StatusList[idx] == false) return;
            //移除旧焦点
            RightBarFocus.Font = new Font("宋体", 9);
            RightBarFocus.ForeColor = FontColor1;
            RightBarFocus.BackColor = System.Drawing.Color.Transparent;
            RightBarFocus = label;
            //修改新焦点
            RightBarFocus.Font = new Font("宋体", 9, FontStyle.Bold);
            RightBarFocus.ForeColor = FontColor3;
            RightBarFocus.BackColor = FontColor1;
            //label11.Text = RightBarFocus.Name;
            RightFocus = int.Parse(Regex.Replace(RightBarFocus.Name, @"[^0-9]+", ""));
        }
        private void SetMidFocus(object sender, EventArgs e)
        {
            //移除旧焦点
            MidBarFocus.ForeColor = FontColor1;
            MidBarFocus = (Label)sender;
            //修改新焦点
            MidBarFocus.ForeColor = System.Drawing.Color.Red;
        }

        private void DoubleClickMid(object sender, EventArgs e)
        {
            if (RightBarFocus == null) return;
            if (RightFocus == -1) return;
            MidBarFocus = (Label)sender;
            Course ToReview = (from course in Gamest.GameChapter.CourseList where MidBarFocus.Name == course.CourseName select course).ToList()[0];
            Course newCourse = new Course(ToReview);
            if (Gamest.CurTurn==newCourse.Deadline&&RightFocus>newCourse.TestPeriod)
            {//在考试之后复习，禁止这种操作
                AlertForm alertForm = new AlertForm($"这门课在{GameSystem.TimeName[newCourse.TestPeriod]}就已经考完了！");
                alertForm.ShowDialog();
                return;
            }
            PlanList[RightFocus] = newCourse;
            RightBarFocus.Text = MidBarFocus.Text;
            SetRightFocus(GetRightFocus(RightFocus), e);
        }

        private void BtnNight_Click(object sender, EventArgs e)
        {
            if (StatusList[3] == true)
            {
                PlanList[3] = new Course();
                SetRightFocus(GetRightFocus(), e);
                DisableLabel(3, "好好休息");
                BtnNight.Text = "今晚通宵学习！";
            }
            else
            {
                if (Gamest.IfNight!=0)
                {
                    AlertForm alertForm = new AlertForm("昨晚已经通宵过了！今晚再通宵会要命的！");
                    alertForm.ShowDialog();
                    return;
                }
                EnableLabel(3);
                SetRightFocus(PlanLabelList[3], e);
                BtnNight.Text = "还是好好休息吧！";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ChoiceDialog confirmReturn = new ChoiceDialog("确认退出游戏吗？\r\n当前进度会被自动保存。");
            confirmReturn.ShowDialog();
            if (confirmReturn.code == 0) return;
            Application.Exit();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void BtnSaveGame_Click(object sender, EventArgs e)
        {
            GameSaveForm saveGame = new GameSaveForm(Gamest);
            saveGame.StartPosition = FormStartPosition.CenterParent;
            saveGame.ShowDialog();
            saveGame.Dispose();
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            GameSaveForm gameSave = new GameSaveForm();
            gameSave.StartPosition = FormStartPosition.CenterParent;
            gameSave.ShowDialog();
            if (gameSave.SavedGame == null) return;
            Gamest = gameSave.SavedGame;
            MakePlan makePlan = new MakePlan(Gamest);
            makePlan.TopLevel = false;
            Parent.Controls.Add(makePlan);
            Parent.Controls.Remove(this);
            Close();
            makePlan.Show();
            Dispose();
        }

        private void BtnReturnMenu_Click(object sender, EventArgs e)
        {
            ChoiceDialog confirmReturn = new ChoiceDialog("确认返回主菜单吗？\r\n当前进度会被自动保存。");
            confirmReturn.ShowDialog();
            if (confirmReturn.code == 0) return;
            NewGame newGame = new NewGame();
            this.Parent.Controls.Add(newGame);
            this.Parent.Controls.Remove(this);
            newGame.Show();
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void BtnList_Enter(object sender, EventArgs e)
        {
            Button BtnNow = (Button)sender;
            int idx = BtnList.FindIndex(x => x == BtnNow);
            if (StatusList[idx] == false)
            {
                BtnNow.BackColor = Color.Transparent;
                BtnNow.ForeColor = FontColor1;
                return;
            }
            BtnNow.BackColor = FontColor1;
            BtnNow.ForeColor = FontColor3;
        }

        private void BtnList_Leave(object sender, EventArgs e)
        {
            Button BtnNow = (Button)sender;
            int idx = BtnList.FindIndex(x => x == BtnNow);
            BtnNow.BackColor = Color.Transparent;
            BtnNow.ForeColor = FontColor1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
