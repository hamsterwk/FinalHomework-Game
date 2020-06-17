namespace FinalHomework_Game
{
	partial class ChoiceDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.Yes.FlatAppearance.BorderSize = 0;
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.Yes.Location = new System.Drawing.Point(12, 185);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(165, 43);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "是";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.No.FlatAppearance.BorderSize = 0;
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.No.Location = new System.Drawing.Point(183, 185);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(155, 43);
            this.No.TabIndex = 2;
            this.No.Text = "否";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.BackColor = System.Drawing.Color.Transparent;
            this.HintLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.HintLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.HintLabel.Location = new System.Drawing.Point(12, 9);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(326, 173);
            this.HintLabel.TabIndex = 0;
            this.HintLabel.Text = "是否覆盖原存档？";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoiceDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FinalHomework_Game.Properties.Resources.ChoiceForm;
            this.ClientSize = new System.Drawing.Size(350, 240);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.HintLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoiceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaveAlert";
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Yes;
		private System.Windows.Forms.Button No;
        private System.Windows.Forms.Label HintLabel;
    }
}