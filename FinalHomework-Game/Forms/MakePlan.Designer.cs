namespace FinalHomework_Game
{
    partial class MakePlan
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
            this.Date = new System.Windows.Forms.Label();
            this.TurnText = new System.Windows.Forms.Label();
            this.datePanel = new System.Windows.Forms.Panel();
            this.PlayerName = new System.Windows.Forms.Label();
            this.CourseTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.CoursesScorePanel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SelectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearNight = new System.Windows.Forms.Button();
            this.ClearEvening = new System.Windows.Forms.Button();
            this.ClearAfternoon = new System.Windows.Forms.Button();
            this.Plan3 = new System.Windows.Forms.Label();
            this.Plan2 = new System.Windows.Forms.Label();
            this.Plan1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Plan0 = new System.Windows.Forms.Label();
            this.ClearMorning = new System.Windows.Forms.Button();
            this.BtnNight = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSaveGame = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.BtnLoadGame = new System.Windows.Forms.Button();
            this.BtnReturnMenu = new System.Windows.Forms.Button();
            this.BuffLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PressureBar = new FinalHomework_Game.CustomProgressBar();
            this.datePanel.SuspendLayout();
            this.CourseTablePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.Date.Location = new System.Drawing.Point(3, 2);
            this.Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(393, 28);
            this.Date.TabIndex = 0;
            this.Date.Text = "1 月 1 日";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TurnText
            // 
            this.TurnText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TurnText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.TurnText.Location = new System.Drawing.Point(8, 35);
            this.TurnText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.TurnText.Name = "TurnText";
            this.TurnText.Size = new System.Drawing.Size(388, 28);
            this.TurnText.TabIndex = 1;
            this.TurnText.Text = "第 1 天";
            this.TurnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.Transparent;
            this.datePanel.Controls.Add(this.PlayerName);
            this.datePanel.Controls.Add(this.Date);
            this.datePanel.Controls.Add(this.TurnText);
            this.datePanel.Location = new System.Drawing.Point(14, 29);
            this.datePanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 50);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(396, 106);
            this.datePanel.TabIndex = 2;
            // 
            // PlayerName
            // 
            this.PlayerName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.PlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.PlayerName.Location = new System.Drawing.Point(8, 65);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(388, 35);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.Text = "玩家名称";
            this.PlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseTablePanel
            // 
            this.CourseTablePanel.AutoSize = true;
            this.CourseTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.CourseTablePanel.ColumnCount = 3;
            this.CourseTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.CourseTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.CourseTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.CourseTablePanel.Controls.Add(this.CoursesScorePanel, 0, 0);
            this.CourseTablePanel.Controls.Add(this.label3, 2, 0);
            this.CourseTablePanel.Controls.Add(this.label12, 1, 0);
            this.CourseTablePanel.Location = new System.Drawing.Point(13, 168);
            this.CourseTablePanel.Margin = new System.Windows.Forms.Padding(3, 50, 25, 2);
            this.CourseTablePanel.Name = "CourseTablePanel";
            this.CourseTablePanel.RowCount = 1;
            this.CourseTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CourseTablePanel.Size = new System.Drawing.Size(400, 30);
            this.CourseTablePanel.TabIndex = 3;
            // 
            // CoursesScorePanel
            // 
            this.CoursesScorePanel.BackColor = System.Drawing.Color.Transparent;
            this.CoursesScorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoursesScorePanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CoursesScorePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.CoursesScorePanel.Location = new System.Drawing.Point(3, 0);
            this.CoursesScorePanel.Name = "CoursesScorePanel";
            this.CoursesScorePanel.Size = new System.Drawing.Size(161, 30);
            this.CoursesScorePanel.TabIndex = 0;
            this.CoursesScorePanel.Text = "课程名";
            this.CoursesScorePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(337, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "分数";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.label12.Location = new System.Drawing.Point(170, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "考试时间";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectionTable
            // 
            this.SelectionTable.BackColor = System.Drawing.Color.Transparent;
            this.SelectionTable.ColumnCount = 3;
            this.SelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SelectionTable.Location = new System.Drawing.Point(445, 200);
            this.SelectionTable.Margin = new System.Windows.Forms.Padding(25, 2, 29, 2);
            this.SelectionTable.Name = "SelectionTable";
            this.SelectionTable.RowCount = 6;
            this.SelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectionTable.Size = new System.Drawing.Size(300, 300);
            this.SelectionTable.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.Controls.Add(this.ClearNight, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.ClearEvening, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.ClearAfternoon, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Plan3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Plan2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.Plan1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Plan0, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ClearMorning, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(803, 140);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(185, 400);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // ClearNight
            // 
            this.ClearNight.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.ClearNight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearNight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearNight.FlatAppearance.BorderSize = 0;
            this.ClearNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearNight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClearNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.ClearNight.Location = new System.Drawing.Point(112, 303);
            this.ClearNight.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ClearNight.Name = "ClearNight";
            this.ClearNight.Size = new System.Drawing.Size(70, 97);
            this.ClearNight.TabIndex = 14;
            this.ClearNight.Text = "清空";
            this.ClearNight.UseVisualStyleBackColor = true;
            this.ClearNight.Click += new System.EventHandler(this.ClearNight_Click);
            this.ClearNight.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.ClearNight.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // ClearEvening
            // 
            this.ClearEvening.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.ClearEvening.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearEvening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearEvening.FlatAppearance.BorderSize = 0;
            this.ClearEvening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEvening.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClearEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.ClearEvening.Location = new System.Drawing.Point(112, 203);
            this.ClearEvening.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ClearEvening.Name = "ClearEvening";
            this.ClearEvening.Size = new System.Drawing.Size(70, 97);
            this.ClearEvening.TabIndex = 13;
            this.ClearEvening.Text = "清空";
            this.ClearEvening.UseVisualStyleBackColor = true;
            this.ClearEvening.Click += new System.EventHandler(this.ClearEvening_Click);
            this.ClearEvening.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.ClearEvening.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // ClearAfternoon
            // 
            this.ClearAfternoon.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.ClearAfternoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearAfternoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearAfternoon.FlatAppearance.BorderSize = 0;
            this.ClearAfternoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAfternoon.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClearAfternoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.ClearAfternoon.Location = new System.Drawing.Point(112, 103);
            this.ClearAfternoon.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ClearAfternoon.Name = "ClearAfternoon";
            this.ClearAfternoon.Size = new System.Drawing.Size(70, 97);
            this.ClearAfternoon.TabIndex = 12;
            this.ClearAfternoon.Text = "清空";
            this.ClearAfternoon.UseVisualStyleBackColor = true;
            this.ClearAfternoon.Click += new System.EventHandler(this.ClearAfternoon_Click);
            this.ClearAfternoon.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.ClearAfternoon.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // Plan3
            // 
            this.Plan3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plan3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Plan3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.Plan3.Location = new System.Drawing.Point(43, 303);
            this.Plan3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plan3.Name = "Plan3";
            this.Plan3.Size = new System.Drawing.Size(66, 97);
            this.Plan3.TabIndex = 10;
            this.Plan3.Text = "好好休息";
            this.Plan3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plan2
            // 
            this.Plan2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plan2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Plan2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.Plan2.Location = new System.Drawing.Point(43, 203);
            this.Plan2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plan2.Name = "Plan2";
            this.Plan2.Size = new System.Drawing.Size(66, 97);
            this.Plan2.TabIndex = 9;
            this.Plan2.Text = "未安排";
            this.Plan2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plan1
            // 
            this.Plan1.AllowDrop = true;
            this.Plan1.BackColor = System.Drawing.Color.Transparent;
            this.Plan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plan1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Plan1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.Plan1.Location = new System.Drawing.Point(43, 103);
            this.Plan1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plan1.Name = "Plan1";
            this.Plan1.Size = new System.Drawing.Size(66, 97);
            this.Plan1.TabIndex = 8;
            this.Plan1.Text = "未安排";
            this.Plan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label10.Location = new System.Drawing.Point(3, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 94);
            this.label10.TabIndex = 6;
            this.label10.Text = "通\r\n\r\n宵";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label8.Location = new System.Drawing.Point(3, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 97);
            this.label8.TabIndex = 4;
            this.label8.Text = "晚\r\n\r\n上";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label6.Location = new System.Drawing.Point(3, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 97);
            this.label6.TabIndex = 2;
            this.label6.Text = "下\r\n\r\n午";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 97);
            this.label4.TabIndex = 0;
            this.label4.Text = "上\r\n\r\n午";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plan0
            // 
            this.Plan0.BackColor = System.Drawing.Color.Transparent;
            this.Plan0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plan0.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Plan0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.Plan0.Location = new System.Drawing.Point(43, 3);
            this.Plan0.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Plan0.Name = "Plan0";
            this.Plan0.Size = new System.Drawing.Size(66, 97);
            this.Plan0.TabIndex = 7;
            this.Plan0.Text = "未安排";
            this.Plan0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearMorning
            // 
            this.ClearMorning.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn1000;
            this.ClearMorning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearMorning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearMorning.FlatAppearance.BorderSize = 0;
            this.ClearMorning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearMorning.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClearMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.ClearMorning.Location = new System.Drawing.Point(112, 3);
            this.ClearMorning.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ClearMorning.Name = "ClearMorning";
            this.ClearMorning.Size = new System.Drawing.Size(70, 97);
            this.ClearMorning.TabIndex = 11;
            this.ClearMorning.Text = "清空";
            this.ClearMorning.UseVisualStyleBackColor = true;
            this.ClearMorning.Click += new System.EventHandler(this.ClearMorning_Click);
            this.ClearMorning.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.ClearMorning.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BtnNight
            // 
            this.BtnNight.BackColor = System.Drawing.Color.Transparent;
            this.BtnNight.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.BtnNight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNight.FlatAppearance.BorderSize = 0;
            this.BtnNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnNight.Location = new System.Drawing.Point(800, 562);
            this.BtnNight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNight.Name = "BtnNight";
            this.BtnNight.Size = new System.Drawing.Size(191, 36);
            this.BtnNight.TabIndex = 8;
            this.BtnNight.Text = "今晚通宵学习！";
            this.BtnNight.UseVisualStyleBackColor = false;
            this.BtnNight.Click += new System.EventHandler(this.BtnNight_Click);
            this.BtnNight.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.BtnNight.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
            this.label11.Location = new System.Drawing.Point(453, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 58);
            this.label11.TabIndex = 9;
            this.label11.Text = "将需要复习的课程\r\n双击添加到右侧的计划安排中吧！";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.SubmitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.SubmitBtn.Location = new System.Drawing.Point(521, 531);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(140, 58);
            this.SubmitBtn.TabIndex = 10;
            this.SubmitBtn.Text = "提交计划";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.FinishButton_Click);
            this.SubmitBtn.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.SubmitBtn.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnExit.Location = new System.Drawing.Point(103, 68);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(94, 30);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "退出游戏";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.BtnExit.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.BtnExit.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BtnSaveGame
            // 
            this.BtnSaveGame.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.BtnSaveGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaveGame.FlatAppearance.BorderSize = 0;
            this.BtnSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveGame.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSaveGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnSaveGame.Location = new System.Drawing.Point(3, 35);
            this.BtnSaveGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSaveGame.Name = "BtnSaveGame";
            this.BtnSaveGame.Size = new System.Drawing.Size(94, 29);
            this.BtnSaveGame.TabIndex = 12;
            this.BtnSaveGame.Text = "保存游戏";
            this.BtnSaveGame.UseVisualStyleBackColor = false;
            this.BtnSaveGame.Click += new System.EventHandler(this.BtnSaveGame_Click);
            this.BtnSaveGame.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.BtnSaveGame.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.BtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.BtnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnHelp.Location = new System.Drawing.Point(3, 2);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(94, 29);
            this.BtnHelp.TabIndex = 13;
            this.BtnHelp.Text = "帮助";
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.BtnHelp.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.BtnHelp.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BtnSetting
            // 
            this.BtnSetting.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetting.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.BtnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetting.FlatAppearance.BorderSize = 0;
            this.BtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnSetting.Location = new System.Drawing.Point(103, 2);
            this.BtnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(94, 29);
            this.BtnSetting.TabIndex = 14;
            this.BtnSetting.Text = "设置";
            this.BtnSetting.UseVisualStyleBackColor = false;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            this.BtnSetting.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.BtnSetting.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BtnLoadGame
            // 
            this.BtnLoadGame.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoadGame.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.BtnLoadGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLoadGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLoadGame.FlatAppearance.BorderSize = 0;
            this.BtnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadGame.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLoadGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnLoadGame.Location = new System.Drawing.Point(103, 35);
            this.BtnLoadGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLoadGame.Name = "BtnLoadGame";
            this.BtnLoadGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLoadGame.Size = new System.Drawing.Size(94, 29);
            this.BtnLoadGame.TabIndex = 15;
            this.BtnLoadGame.Text = "读取游戏";
            this.BtnLoadGame.UseVisualStyleBackColor = false;
            this.BtnLoadGame.Click += new System.EventHandler(this.BtnLoadGame_Click);
            this.BtnLoadGame.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.BtnLoadGame.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BtnReturnMenu
            // 
            this.BtnReturnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnReturnMenu.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;
            this.BtnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReturnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReturnMenu.FlatAppearance.BorderSize = 0;
            this.BtnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturnMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.BtnReturnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BtnReturnMenu.Location = new System.Drawing.Point(3, 68);
            this.BtnReturnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReturnMenu.Name = "BtnReturnMenu";
            this.BtnReturnMenu.Size = new System.Drawing.Size(94, 30);
            this.BtnReturnMenu.TabIndex = 16;
            this.BtnReturnMenu.Text = "返回菜单";
            this.BtnReturnMenu.UseVisualStyleBackColor = false;
            this.BtnReturnMenu.Click += new System.EventHandler(this.BtnReturnMenu_Click);
            this.BtnReturnMenu.MouseEnter += new System.EventHandler(this.BtnList_Enter);
            this.BtnReturnMenu.MouseLeave += new System.EventHandler(this.BtnList_Leave);
            // 
            // BuffLbl
            // 
            this.BuffLbl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.BuffLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BuffLbl.Location = new System.Drawing.Point(6, 21);
            this.BuffLbl.Name = "BuffLbl";
            this.BuffLbl.Size = new System.Drawing.Size(289, 23);
            this.BuffLbl.TabIndex = 18;
            this.BuffLbl.Text = "Buff";
            this.BuffLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "我的压力：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnSetting, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnExit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnReturnMenu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnSaveGame, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnLoadGame, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnHelp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(800, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.PressureBar);
            this.panel2.Controls.Add(this.BuffLbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(445, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 106);
            this.panel2.TabIndex = 21;
            // 
            // PressureBar
            // 
            this.PressureBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.PressureBar.Location = new System.Drawing.Point(100, 75);
            this.PressureBar.Name = "PressureBar";
            this.PressureBar.Size = new System.Drawing.Size(204, 23);
            this.PressureBar.TabIndex = 22;
            // 
            // MakePlan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.BackgroundImage = global::FinalHomework_Game.Properties.Resources.MainGame;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnNight);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.SelectionTable);
            this.Controls.Add(this.CourseTablePanel);
            this.Controls.Add(this.datePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MakePlan";
            this.Padding = new System.Windows.Forms.Padding(11, 50, 0, 0);
            this.Text = "MakePlan";
            this.datePanel.ResumeLayout(false);
            this.CourseTablePanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label TurnText;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.TableLayoutPanel CourseTablePanel;
        private System.Windows.Forms.Label CoursesScorePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel SelectionTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ClearNight;
        private System.Windows.Forms.Button ClearEvening;
        private System.Windows.Forms.Button ClearAfternoon;
        private System.Windows.Forms.Label Plan3;
        private System.Windows.Forms.Label Plan2;
        private System.Windows.Forms.Label Plan1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Plan0;
        private System.Windows.Forms.Button ClearMorning;
        private System.Windows.Forms.Button BtnNight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSaveGame;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnLoadGame;
        private System.Windows.Forms.Button BtnReturnMenu;
        private System.Windows.Forms.Label BuffLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private CustomProgressBar PressureBar;
    }
}