namespace FinalHomework_Game
{
    partial class Interval
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
            this.LogBox = new System.Windows.Forms.TextBox();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Font = new System.Drawing.Font("宋体", 12F);
            this.LogBox.Location = new System.Drawing.Point(19, 52);
            this.LogBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(965, 460);
            this.LogBox.TabIndex = 0;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(463, 548);
            this.ContinueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(107, 39);
            this.ContinueBtn.TabIndex = 1;
            this.ContinueBtn.Text = "下一天";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("宋体", 24F);
            this.PlayerName.Location = new System.Drawing.Point(12, 9);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(137, 40);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.Text = "label1";
            // 
            // Interval
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.LogBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Interval";
            this.Text = "Interval";
            this.Shown += new System.EventHandler(this.Interval_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Label PlayerName;
    }
}