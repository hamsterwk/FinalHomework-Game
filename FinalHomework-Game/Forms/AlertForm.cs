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
	public partial class AlertForm : Form
	{
		public AlertForm(string Msg="")
		{
			InitializeComponent();
			Hint.Text = Msg;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
