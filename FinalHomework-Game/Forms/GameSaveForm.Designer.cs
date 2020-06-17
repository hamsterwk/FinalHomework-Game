namespace FinalHomework_Game
{
	partial class GameSaveForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveInfoPanel = new System.Windows.Forms.Panel();
            this.FormName = new System.Windows.Forms.Label();
            this.GameArchivePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.autoName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.autoTurn = new System.Windows.Forms.Label();
            this.autoPlayerName = new System.Windows.Forms.Label();
            this.No2Button = new System.Windows.Forms.Button();
            this.No1Button = new System.Windows.Forms.Button();
            this.No3Button = new System.Windows.Forms.Button();
            this.No4Button = new System.Windows.Forms.Button();
            this.No5Button = new System.Windows.Forms.Button();
            this.No6Button = new System.Windows.Forms.Button();
            this.retBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SaveInfoPanel.SuspendLayout();
            this.GameArchivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.SaveInfoPanel);
            this.panel1.Controls.Add(this.GameArchivePanel);
            this.panel1.Location = new System.Drawing.Point(100, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 0;
            // 
            // SaveInfoPanel
            // 
            this.SaveInfoPanel.Controls.Add(this.FormName);
            this.SaveInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.SaveInfoPanel.Name = "SaveInfoPanel";
            this.SaveInfoPanel.Size = new System.Drawing.Size(794, 69);
            this.SaveInfoPanel.TabIndex = 11;
            // 
            // FormName
            // 
            this.FormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormName.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Bold);
            this.FormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.FormName.Location = new System.Drawing.Point(0, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(794, 69);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "读取存档";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameArchivePanel
            // 
            this.GameArchivePanel.ColumnCount = 6;
            this.GameArchivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.GameArchivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.GameArchivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.GameArchivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.GameArchivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.GameArchivePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GameArchivePanel.Controls.Add(this.label7, 2, 0);
            this.GameArchivePanel.Controls.Add(this.label10, 0, 6);
            this.GameArchivePanel.Controls.Add(this.label13, 4, 0);
            this.GameArchivePanel.Controls.Add(this.label9, 0, 5);
            this.GameArchivePanel.Controls.Add(this.label4, 0, 0);
            this.GameArchivePanel.Controls.Add(this.label8, 0, 4);
            this.GameArchivePanel.Controls.Add(this.label3, 0, 1);
            this.GameArchivePanel.Controls.Add(this.label6, 0, 3);
            this.GameArchivePanel.Controls.Add(this.label5, 0, 2);
            this.GameArchivePanel.Controls.Add(this.label1, 1, 1);
            this.GameArchivePanel.Controls.Add(this.label12, 1, 0);
            this.GameArchivePanel.Controls.Add(this.autoName, 3, 1);
            this.GameArchivePanel.Controls.Add(this.label11, 3, 0);
            this.GameArchivePanel.Controls.Add(this.autoTurn, 4, 1);
            this.GameArchivePanel.Controls.Add(this.autoPlayerName, 2, 1);
            this.GameArchivePanel.Controls.Add(this.No2Button, 5, 2);
            this.GameArchivePanel.Controls.Add(this.No1Button, 5, 1);
            this.GameArchivePanel.Controls.Add(this.No3Button, 5, 3);
            this.GameArchivePanel.Controls.Add(this.No4Button, 5, 4);
            this.GameArchivePanel.Controls.Add(this.No5Button, 5, 5);
            this.GameArchivePanel.Controls.Add(this.No6Button, 5, 6);
            this.GameArchivePanel.Location = new System.Drawing.Point(3, 78);
            this.GameArchivePanel.Name = "GameArchivePanel";
            this.GameArchivePanel.RowCount = 7;
            this.GameArchivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.GameArchivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameArchivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameArchivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameArchivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameArchivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameArchivePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameArchivePanel.Size = new System.Drawing.Size(794, 420);
            this.GameArchivePanel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label7.Location = new System.Drawing.Point(203, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 42);
            this.label7.TabIndex = 23;
            this.label7.Text = "姓名";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label10.Location = new System.Drawing.Point(8, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "5";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label13.Location = new System.Drawing.Point(573, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 42);
            this.label13.TabIndex = 20;
            this.label13.Text = "游戏内日期";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label9.Location = new System.Drawing.Point(8, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label8.Location = new System.Drawing.Point(8, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "3";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 63);
            this.label3.TabIndex = 4;
            this.label3.Text = "自动存档";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label6.Location = new System.Drawing.Point(3, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 63);
            this.label6.TabIndex = 7;
            this.label6.Text = "2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "autosave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label12.Location = new System.Drawing.Point(43, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 42);
            this.label12.TabIndex = 22;
            this.label12.Text = "存档时间";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoName
            // 
            this.autoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoName.AutoSize = true;
            this.autoName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoName.Location = new System.Drawing.Point(414, 66);
            this.autoName.Name = "autoName";
            this.autoName.Size = new System.Drawing.Size(61, 15);
            this.autoName.TabIndex = 19;
            this.autoName.Text = "string";
            this.autoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label11.Location = new System.Drawing.Point(323, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 42);
            this.label11.TabIndex = 18;
            this.label11.Text = "剧本名";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoTurn
            // 
            this.autoTurn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoTurn.AutoSize = true;
            this.autoTurn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoTurn.Location = new System.Drawing.Point(643, 66);
            this.autoTurn.Name = "autoTurn";
            this.autoTurn.Size = new System.Drawing.Size(34, 15);
            this.autoTurn.TabIndex = 21;
            this.autoTurn.Text = "int";
            // 
            // autoPlayerName
            // 
            this.autoPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoPlayerName.AutoSize = true;
            this.autoPlayerName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoPlayerName.Location = new System.Drawing.Point(229, 66);
            this.autoPlayerName.Name = "autoPlayerName";
            this.autoPlayerName.Size = new System.Drawing.Size(61, 15);
            this.autoPlayerName.TabIndex = 24;
            this.autoPlayerName.Text = "string";
            // 
            // No2Button
            // 
            this.No2Button.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.No2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.No2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No2Button.FlatAppearance.BorderSize = 0;
            this.No2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No2Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.No2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.No2Button.Location = new System.Drawing.Point(753, 108);
            this.No2Button.Name = "No2Button";
            this.No2Button.Size = new System.Drawing.Size(38, 57);
            this.No2Button.TabIndex = 9;
            this.No2Button.Text = "确认";
            this.No2Button.UseVisualStyleBackColor = true;
            // 
            // No1Button
            // 
            this.No1Button.BackColor = System.Drawing.Color.Transparent;
            this.No1Button.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.No1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.No1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No1Button.FlatAppearance.BorderSize = 0;
            this.No1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No1Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.No1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.No1Button.Location = new System.Drawing.Point(753, 45);
            this.No1Button.Name = "No1Button";
            this.No1Button.Size = new System.Drawing.Size(38, 57);
            this.No1Button.TabIndex = 25;
            this.No1Button.Text = "确认";
            this.No1Button.UseVisualStyleBackColor = false;
            this.No1Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Confirm_MouseDown);
            this.No1Button.MouseEnter += new System.EventHandler(this.Confirm_MouseEnter);
            this.No1Button.MouseLeave += new System.EventHandler(this.Confirm_MouseLeave);
            // 
            // No3Button
            // 
            this.No3Button.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.No3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.No3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No3Button.FlatAppearance.BorderSize = 0;
            this.No3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No3Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.No3Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.No3Button.Location = new System.Drawing.Point(753, 171);
            this.No3Button.Name = "No3Button";
            this.No3Button.Size = new System.Drawing.Size(38, 57);
            this.No3Button.TabIndex = 26;
            this.No3Button.Text = "确认";
            this.No3Button.UseVisualStyleBackColor = true;
            // 
            // No4Button
            // 
            this.No4Button.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.No4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.No4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No4Button.FlatAppearance.BorderSize = 0;
            this.No4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No4Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.No4Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.No4Button.Location = new System.Drawing.Point(753, 234);
            this.No4Button.Name = "No4Button";
            this.No4Button.Size = new System.Drawing.Size(38, 57);
            this.No4Button.TabIndex = 27;
            this.No4Button.Text = "确认";
            this.No4Button.UseVisualStyleBackColor = true;
            // 
            // No5Button
            // 
            this.No5Button.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.No5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.No5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No5Button.FlatAppearance.BorderSize = 0;
            this.No5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No5Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.No5Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.No5Button.Location = new System.Drawing.Point(753, 297);
            this.No5Button.Name = "No5Button";
            this.No5Button.Size = new System.Drawing.Size(38, 57);
            this.No5Button.TabIndex = 28;
            this.No5Button.Text = "确认";
            this.No5Button.UseVisualStyleBackColor = true;
            // 
            // No6Button
            // 
            this.No6Button.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.No6Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.No6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No6Button.FlatAppearance.BorderSize = 0;
            this.No6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No6Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.No6Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.No6Button.Location = new System.Drawing.Point(753, 360);
            this.No6Button.Name = "No6Button";
            this.No6Button.Size = new System.Drawing.Size(38, 57);
            this.No6Button.TabIndex = 29;
            this.No6Button.Text = "确认";
            this.No6Button.UseVisualStyleBackColor = true;
            // 
            // retBtn
            // 
            this.retBtn.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.retBtn.FlatAppearance.BorderSize = 0;
            this.retBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.retBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.retBtn.Location = new System.Drawing.Point(457, 566);
            this.retBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retBtn.Name = "retBtn";
            this.retBtn.Size = new System.Drawing.Size(75, 32);
            this.retBtn.TabIndex = 26;
            this.retBtn.Text = "返回";
            this.retBtn.UseVisualStyleBackColor = true;
            this.retBtn.Click += new System.EventHandler(this.retBtn_Click);
            this.retBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            this.retBtn.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.retBtn.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // GameSaveForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::FinalHomework_Game.Properties.Resources.LoadGameFace;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.retBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameSaveForm";
            this.Padding = new System.Windows.Forms.Padding(100, 50, 0, 0);
            this.Text = "SaveGame";
            this.panel1.ResumeLayout(false);
            this.SaveInfoPanel.ResumeLayout(false);
            this.GameArchivePanel.ResumeLayout(false);
            this.GameArchivePanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel GameArchivePanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label autoTurn;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label autoName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label autoPlayerName;
		private System.Windows.Forms.Button No2Button;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button No1Button;
        private System.Windows.Forms.Panel SaveInfoPanel;
        private System.Windows.Forms.Button retBtn;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button No3Button;
        private System.Windows.Forms.Button No4Button;
        private System.Windows.Forms.Button No5Button;
        private System.Windows.Forms.Button No6Button;
    }
}