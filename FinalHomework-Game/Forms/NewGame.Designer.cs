namespace FinalHomework_Game
{
    partial class NewGame
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
            this.StartGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(191)))), ((int)(((byte)(124)))));
            this.StartGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.StartGame.FlatAppearance.BorderSize = 0;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.StartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.StartGame.Location = new System.Drawing.Point(109, 391);
            this.StartGame.Margin = new System.Windows.Forms.Padding(100, 3, 50, 100);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(100, 100);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "开始游戏";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            this.StartGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartGame_MouseDown);
            this.StartGame.MouseEnter += new System.EventHandler(this.StartGame_MouseEnter);
            this.StartGame.MouseLeave += new System.EventHandler(this.StartGame_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(191)))), ((int)(((byte)(124)))));
            this.Exit.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.Exit.Location = new System.Drawing.Point(791, 391);
            this.Exit.Margin = new System.Windows.Forms.Padding(100, 3, 100, 100);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 100);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "退出游戏";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // LoadGame
            // 
            this.LoadGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(191)))), ((int)(((byte)(124)))));
            this.LoadGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.LoadGame.FlatAppearance.BorderSize = 0;
            this.LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadGame.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.LoadGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.LoadGame.Location = new System.Drawing.Point(450, 391);
            this.LoadGame.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(100, 100);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.Text = "加载游戏";
            this.LoadGame.UseVisualStyleBackColor = false;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            this.LoadGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoadGame_MouseDown);
            this.LoadGame.MouseEnter += new System.EventHandler(this.LoadGame_MouseEnter);
            this.LoadGame.MouseLeave += new System.EventHandler(this.LoadGame_MouseLeave);
            // 
            // NewGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::FinalHomework_Game.Properties.Resources.background_StartMenu;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StartGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewGame_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button LoadGame;
    }
}