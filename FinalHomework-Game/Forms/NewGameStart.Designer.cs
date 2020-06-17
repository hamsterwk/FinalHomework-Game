namespace FinalHomework_Game
{
    partial class NewGameStart
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
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.previousChapter = new System.Windows.Forms.Button();
            this.NextChapter = new System.Windows.Forms.Button();
            this.ChapterDescriptionPanel = new System.Windows.Forms.Panel();
            this.ChapterDescription = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Begin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChapterDescriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.PlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.PlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(28)))));
            this.PlayerName.Location = new System.Drawing.Point(135, 14);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerName.MaxLength = 10;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlayerName.Size = new System.Drawing.Size(163, 27);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PlayerName.TextChanged += new System.EventHandler(this.PlayerName_TextChanged);
            // 
            // previousChapter
            // 
            this.previousChapter.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.previousChapter.FlatAppearance.BorderSize = 0;
            this.previousChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousChapter.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.previousChapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.previousChapter.Location = new System.Drawing.Point(17, 425);
            this.previousChapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousChapter.Name = "previousChapter";
            this.previousChapter.Size = new System.Drawing.Size(75, 32);
            this.previousChapter.TabIndex = 4;
            this.previousChapter.Text = "上一个";
            this.previousChapter.UseVisualStyleBackColor = true;
            this.previousChapter.Click += new System.EventHandler(this.previousChapter_Click);
            this.previousChapter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previousChapter_MouseDown);
            this.previousChapter.MouseEnter += new System.EventHandler(this.previousChapter_MouseEnter);
            this.previousChapter.MouseLeave += new System.EventHandler(this.previousChapter_MouseLeave);
            // 
            // NextChapter
            // 
            this.NextChapter.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.NextChapter.FlatAppearance.BorderSize = 0;
            this.NextChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextChapter.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.NextChapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.NextChapter.Location = new System.Drawing.Point(911, 425);
            this.NextChapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextChapter.Name = "NextChapter";
            this.NextChapter.Size = new System.Drawing.Size(75, 32);
            this.NextChapter.TabIndex = 5;
            this.NextChapter.Text = "下一个";
            this.NextChapter.UseVisualStyleBackColor = true;
            this.NextChapter.Click += new System.EventHandler(this.NextChapter_Click);
            this.NextChapter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NextChapter_MouseDown);
            this.NextChapter.MouseEnter += new System.EventHandler(this.NextChapter_MouseEnter);
            this.NextChapter.MouseLeave += new System.EventHandler(this.NextChapter_MouseLeave);
            // 
            // ChapterDescriptionPanel
            // 
            this.ChapterDescriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChapterDescriptionPanel.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Description;
            this.ChapterDescriptionPanel.Controls.Add(this.ChapterDescription);
            this.ChapterDescriptionPanel.Location = new System.Drawing.Point(12, 149);
            this.ChapterDescriptionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChapterDescriptionPanel.Name = "ChapterDescriptionPanel";
            this.ChapterDescriptionPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ChapterDescriptionPanel.Size = new System.Drawing.Size(973, 271);
            this.ChapterDescriptionPanel.TabIndex = 6;
            // 
            // ChapterDescription
            // 
            this.ChapterDescription.AutoSize = true;
            this.ChapterDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChapterDescription.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ChapterDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.ChapterDescription.Location = new System.Drawing.Point(3, 3);
            this.ChapterDescription.Name = "ChapterDescription";
            this.ChapterDescription.Size = new System.Drawing.Size(257, 27);
            this.ChapterDescription.TabIndex = 0;
            this.ChapterDescription.Text = "TESTTESTTESTTESTTEST";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnCancel.Location = new System.Drawing.Point(600, 471);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(100, 2, 3, 20);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 100);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "返  回";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.BtnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnCancel_MouseDown);
            this.BtnCancel.MouseEnter += new System.EventHandler(this.BtnCancel_MouseEnter);
            this.BtnCancel.MouseLeave += new System.EventHandler(this.BtnCancel_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Hint1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Hint2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(12, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 50);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Begin
            // 
            this.Begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Begin.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.Begin.FlatAppearance.BorderSize = 0;
            this.Begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Begin.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.Begin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.Begin.Location = new System.Drawing.Point(300, 471);
            this.Begin.Margin = new System.Windows.Forms.Padding(3, 2, 100, 20);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(100, 100);
            this.Begin.TabIndex = 3;
            this.Begin.Text = "开始游戏";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            this.Begin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Begin_MouseDown);
            this.Begin.MouseEnter += new System.EventHandler(this.Begin_MouseEnter);
            this.Begin.MouseLeave += new System.EventHandler(this.Begin_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FinalHomework_Game.Properties.Resources.panel1;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 50);
            this.panel1.TabIndex = 11;
            // 
            // NewGameStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::FinalHomework_Game.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.ChapterDescriptionPanel);
            this.Controls.Add(this.NextChapter);
            this.Controls.Add(this.previousChapter);
            this.Controls.Add(this.Begin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "NewGameStart";
            this.Text = "NewGameStart";
            this.ChapterDescriptionPanel.ResumeLayout(false);
            this.ChapterDescriptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button previousChapter;
        private System.Windows.Forms.Button NextChapter;
        private System.Windows.Forms.Panel ChapterDescriptionPanel;
        private System.Windows.Forms.Label ChapterDescription;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Panel panel1;
    }
}