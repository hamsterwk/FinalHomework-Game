using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalHomework_Game.GameEvent;

namespace FinalHomework_Game
{
    public partial class NewGame : Form
    {
        public int keyValue=0;
        public NewGame()
        {
            InitializeComponent();/*
            string tmp = "";
            foreach (string line in GameEventDefault.MsgList) tmp += line + "\r\n";
            AlertForm alertForm = new AlertForm(tmp);
            alertForm.ShowDialog();*/
            this.TopLevel = false;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            NewGameStart form1 = new NewGameStart();
            this.Parent.Controls.Add(form1);
            this.Parent.Controls.Remove(this);
            this.Close();
            form1.Show();
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            GameSaveForm gameSave = new GameSaveForm();
            gameSave.StartPosition = FormStartPosition.CenterParent;
            gameSave.ShowDialog();
            if (gameSave.SavedGame == null) return;
            MakePlan makePlan = new MakePlan(gameSave.SavedGame);
            makePlan.TopLevel = false;
            this.Parent.Controls.Add(makePlan);
            this.Parent.Controls.Remove(this);
            this.Close();
            gameSave.Dispose();
            makePlan.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame_MouseEnter(object sender, EventArgs e)
        {
            this.StartGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1001;
        }

        private void StartGame_MouseLeave(object sender, EventArgs e)
        {
            this.StartGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
        }

        private void StartGame_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void NewGame_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void LoadGame_MouseEnter(object sender, EventArgs e)
        {
            this.LoadGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1001;
        }

        private void LoadGame_MouseLeave(object sender, EventArgs e)
        {
            this.LoadGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;

        }

        private void LoadGame_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1001;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Exit.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;

        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
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
