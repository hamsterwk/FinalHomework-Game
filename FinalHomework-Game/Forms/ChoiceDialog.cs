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
	public partial class ChoiceDialog : Form
	{
		//code为1时，替换，为0时不替换；
		internal int code=0;

		public ChoiceDialog(string Hint="")
		{
			InitializeComponent();
			this.HintLabel.Text = Hint;
		}

		private void Yes_Click(object sender, EventArgs e)
		{
			code = 1;
			this.Close();
		}

		private void No_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
