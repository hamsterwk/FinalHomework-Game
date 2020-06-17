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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            NewGame form1 = new NewGame();
            form1.TopLevel = false;
            this.MainPanel.Controls.Add(form1);
            form1.Show();
        }

        private void MainPanel_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (GameSystem.ErrorCode != 0)
            {
                AlertForm alertForm = new AlertForm(GameSystem.ErrMsg[GameSystem.ErrorCode]);
                alertForm.ShowDialog();
                Application.Exit();
            }
        }
    }
}
