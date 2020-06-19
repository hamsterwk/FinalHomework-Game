using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHomework_Game.Forms
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            PlaySpeedBar.Value = PlaySpeedBar.Maximum - GameSystem.DisplaySpeed;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            GameSystem.DisplaySpeed = PlaySpeedBar.Maximum - PlaySpeedBar.Value;
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            PlaySpeedBar.Value = PlaySpeedBar.Maximum - GameSystem.DEFAULT_PLAYSPEED;
            checkBox1.Checked = GameSystem.FastDisplay = false;
        }

        private void PlaySpeedBar_Scroll(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GameSystem.FastDisplay = checkBox1.Checked;
        }
    }
}
