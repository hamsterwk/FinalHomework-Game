using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHomework_Game
{
    public partial class NewGameStart : Form
    {
        private int ChapterIdx;
        public NewGameStart()
        {
            InitializeComponent();
            this.TopLevel = false;
            ChapterIdx =0;
            SetChapter();
        }

        private void SetChapter()
        {
            Chapter curChapter = GameSystem.ChapterList[ChapterIdx];
            string Description = "剧本名：" + curChapter.ChapterName+"\n";
            Description = Description + "剧本描述：" + curChapter.ChapterDescription + "\n";
            Description = Description + "总天数：" + curChapter.SumTurn + "\n";
            Description = Description + "包含的课程：\n";
            for(int i=0;i< curChapter.CourseList.Count(); i++)
            {
                Course curCourse = curChapter.CourseList[i];
                Description = Description + curCourse.CourseName + "：";
                Description = Description + curCourse.Description;
                if (i != curChapter.CourseList.Count() - 1) Description = Description + "\n";
            }
            ChapterDescription.Text = Description;
            if (ChapterIdx == 0) previousChapter.BackgroundImage =FinalHomework_Game.Properties.Resources.Btn2003;
            else previousChapter.BackgroundImage = FinalHomework_Game.Properties.Resources.Btn2000;
            if (ChapterIdx == GameSystem.ChapterList.Count() - 1) NextChapter.BackgroundImage = FinalHomework_Game.Properties.Resources.Btn2003;
            else NextChapter.BackgroundImage = FinalHomework_Game.Properties.Resources.Btn2000;
        }

        private void previousChapter_Click(object sender, EventArgs e)
        {
            if (ChapterIdx == 0) return;
            ChapterIdx -= 1;
            SetChapter();
        }

        private void NextChapter_Click(object sender, EventArgs e)
        {
            if (ChapterIdx == GameSystem.ChapterList.Count()-1) return;
            ChapterIdx += 1;
            SetChapter();
        }

        private void PlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Begin_Click(object sender, EventArgs e)
        {
            string text = PlayerName.Text;
            if (text == null || text == "")
            {
                AlertForm alertForm = new AlertForm("玩家名不能为空！");
                alertForm.ShowDialog();
                return;
            }
            Game newGame = new Game();
            newGame.CurTurn = 0;
            newGame.GameChapter = GameSystem.ChapterList[ChapterIdx];
            newGame.PlayerName = text;
            newGame.Buff = 0;
            newGame.Pressure = 50;
            newGame.IfNight = 0;
            MakePlan makePlan = new MakePlan(newGame);
            makePlan.TopLevel = false;
            this.Parent.Controls.Add(makePlan);
            this.Parent.Controls.Remove(this);
            makePlan.Show();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            NewGame form1 = new NewGame();
            form1.TopLevel = false;
            this.Parent.Controls.Add(form1);
            this.Parent.Controls.Remove(this);
            this.Close();
            form1.Show();
        }

        private void previousChapter_MouseEnter(object sender, EventArgs e)
        {
            if (ChapterIdx == 0) return;
            this.previousChapter.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2001;
        }

        private void previousChapter_MouseLeave(object sender, EventArgs e)
        {
            if (ChapterIdx == 0) return; 
            this.previousChapter.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
        }

        private void previousChapter_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void NextChapter_MouseEnter(object sender, EventArgs e)
        {
            if (ChapterIdx == GameSystem.ChapterList.Count() - 1) return;
            this.NextChapter.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2001;
        }

        private void NextChapter_MouseLeave(object sender, EventArgs e)
        {
            if (ChapterIdx == GameSystem.ChapterList.Count() - 1) return;
            this.NextChapter.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;

        }

        private void NextChapter_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Begin_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void BtnCancel_MouseEnter(object sender, EventArgs e)
        {
            this.BtnCancel.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1001;
        }

        private void BtnCancel_MouseLeave(object sender, EventArgs e)
        {
            this.BtnCancel.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;

        }

        private void BtnCancel_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Begin_MouseLeave(object sender, EventArgs e)
        {
            this.Begin.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
        }

        private void Begin_MouseEnter(object sender, EventArgs e)
        {
            this.Begin.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1001;
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
