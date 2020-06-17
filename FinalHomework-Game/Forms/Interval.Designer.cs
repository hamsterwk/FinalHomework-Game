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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interval));
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.LogText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.BackColor = System.Drawing.Color.Transparent;
            this.ContinueBtn.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2001;
            this.ContinueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContinueBtn.FlatAppearance.BorderSize = 0;
            this.ContinueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ContinueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.ContinueBtn.Location = new System.Drawing.Point(463, 559);
            this.ContinueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(107, 30);
            this.ContinueBtn.TabIndex = 1;
            this.ContinueBtn.Text = "下一天";
            this.ContinueBtn.UseVisualStyleBackColor = false;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.Font = new System.Drawing.Font("微软雅黑", 21F, System.Drawing.FontStyle.Bold);
            this.PlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.PlayerName.Location = new System.Drawing.Point(11, 3);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(125, 46);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.Text = "label1";
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogPanel.Controls.Add(this.LogText);
            this.LogPanel.Controls.Add(this.label1);
            this.LogPanel.Location = new System.Drawing.Point(19, 52);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Padding = new System.Windows.Forms.Padding(5);
            this.LogPanel.Size = new System.Drawing.Size(969, 491);
            this.LogPanel.TabIndex = 3;
            // 
            // LogText
            // 
            this.LogText.AutoSize = true;
            this.LogText.BackColor = System.Drawing.Color.Transparent;
            this.LogText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.LogText.Location = new System.Drawing.Point(5, 5);
            this.LogText.Margin = new System.Windows.Forms.Padding(0);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(102, 27);
            this.LogText.TabIndex = 0;
            this.LogText.Text = "TESTTEST";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(959, 481);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Interval
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.BackgroundImage = global::FinalHomework_Game.Properties.Resources.LogForm;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.ContinueBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Interval";
            this.Text = "Interval";
            this.Shown += new System.EventHandler(this.Interval_Shown);
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Label LogText;
        private System.Windows.Forms.Label label1;
    }
}