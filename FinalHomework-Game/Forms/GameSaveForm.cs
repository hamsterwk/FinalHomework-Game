using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
namespace FinalHomework_Game
{
	public partial class GameSaveForm : Form
	{
		private Game savedGame;
		private List<Button> BtnList;
		private int FormStatus;//0: 存档 1: 读档
		private static Color FontColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(57)))), ((int)(((byte)(6)))));
		private static Color FontColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(169)))), ((int)(((byte)(114)))));
		private static Color FontColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));

		public Game SavedGame { get => savedGame; set => savedGame = value; }

		public GameSaveForm(Game game )
		{//存档界面
			FormStatus = 0;
			InitializeComponent(); 
			this.Text = "保存游戏";
			FormName.Text= "保存游戏";
			No1Button.Visible = false;
			No1Button.Enabled = false;
			this.BtnList = new List<Button>() { this.No2Button, this.No3Button, this.No4Button, this.No5Button, this.No6Button };
			SavedGame = game;
			initialTable();
		}
		public GameSaveForm()
		{//读档界面
			FormStatus = 1;
			InitializeComponent();
			this.Text = "读取存档";
			FormName.Text = "读取存档";
			this.BtnList = new List<Button>() { this.No1Button, this.No2Button, this.No3Button, this.No4Button, this.No5Button, this.No6Button };
			initialTable();
		}
		//将已有存档插入对应的槽位；
		private void initialTable()
		{
			foreach(Button btn in BtnList)
			{
				if (FormStatus == 0) btn.Click += new EventHandler(SaveBtn_Click);
				else btn.Click += new EventHandler(LoadBtn_Click);
				btn.MouseEnter += new EventHandler(Confirm_MouseEnter);
				btn.MouseLeave += new EventHandler(Confirm_MouseLeave);
			}
			for (int i = 1; i <= 6; i++) 
			{
				if (File.Exists(("No." + i + ".sav"))) 
				{
					GameArchive gameArchive= GameSystem.ReadGame(i);
					FillSlot(i, gameArchive);
				}else
				{
					if (FormStatus == 1) BtnList[i - 1].Visible = false;
				}
			}
		}
		//将存档插入所选定的槽位；
		private void FillSlot(int row, GameArchive gameArchive) 
		{
			Color FontColorUse;
			FontColorUse = FontColor1;
			//插入存档时间：
			Label archiveTime = new Label();
			archiveTime.Text = gameArchive.SaveTime;
			archiveTime.AutoSize = false;
			archiveTime.Font = new Font("微软雅黑", 12);
			archiveTime.ForeColor = FontColorUse;
			archiveTime.TextAlign = ContentAlignment.MiddleCenter;
			archiveTime.Dock = DockStyle.Fill;
			if (GameArchivePanel.GetControlFromPosition(1, row) != null)
			{
				GameArchivePanel.Controls.Remove(GameArchivePanel.GetControlFromPosition(1, row));
			}
			GameArchivePanel.Controls.Add(archiveTime, 1, row);
			//插入用户名；
			Label playerName = new Label();
			playerName.Text = gameArchive.Game.PlayerName;
			playerName.AutoSize = false;
			playerName.Font = new Font("微软雅黑", 12);
			playerName.ForeColor = FontColorUse;
			playerName.TextAlign = ContentAlignment.MiddleCenter;
			playerName.Dock = DockStyle.Fill;
			if (GameArchivePanel.GetControlFromPosition(2, row) != null)
			{
				GameArchivePanel.Controls.Remove(GameArchivePanel.GetControlFromPosition(2, row));
			}
			GameArchivePanel.Controls.Add(playerName, 2, row);
			//插入剧本名；
			Label chapterName = new Label();
			chapterName.Text = gameArchive.Game.GameChapter.ChapterName;
			chapterName.AutoSize = false;
			chapterName.ForeColor = FontColorUse;
			chapterName.Font = new Font("微软雅黑", 12);
			chapterName.TextAlign = ContentAlignment.MiddleCenter;
			chapterName.Dock = DockStyle.Fill;
			if (GameArchivePanel.GetControlFromPosition(3, row) != null)
			{
				GameArchivePanel.Controls.Remove(GameArchivePanel.GetControlFromPosition(3, row));
			}
			GameArchivePanel.Controls.Add(chapterName, 3, row);
			//插入回合数；
			Label curTurn = new Label();
			curTurn.Text = GameSystem.GetDate(gameArchive.Game.GameChapter.StMonth, gameArchive.Game.GameChapter.StDay + gameArchive.Game.CurTurn);
			curTurn.AutoSize = false;
			curTurn.Font = new Font("微软雅黑", 12);
			curTurn.ForeColor = FontColorUse;
			curTurn.TextAlign = ContentAlignment.MiddleCenter;
			curTurn.Dock = DockStyle.Fill;
			if (GameArchivePanel.GetControlFromPosition(4, row) != null)
			{
				GameArchivePanel.Controls.Remove(GameArchivePanel.GetControlFromPosition(4, row));
			}
			GameArchivePanel.Controls.Add(curTurn, 4, row);
		}
		
		//执行存档操作；
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			Button Btn = (Button)sender;
			int i = int.Parse(Regex.Replace(Btn.Name, @"[^0-9]+", ""));
			if (File.Exists(("No." + i + ".sav")))
			{
				ChoiceDialog saveAlert = new ChoiceDialog("是否覆盖此存档？");
				saveAlert.ShowDialog();
				int code = saveAlert.code;
				saveAlert.Dispose();
				if (saveAlert.code == 0) return;
			}
			GameSystem.SaveGame(i, savedGame);
			this.Close();
		}

		private void LoadBtn_Click(object sender, EventArgs e)
		{
			Button Btn = (Button)sender;
			int i = int.Parse(Regex.Replace(Btn.Name, @"[^0-9]+", ""));
			if (File.Exists(("No." + i + ".sav")))
			{
				ChoiceDialog saveAlert = new ChoiceDialog("确认加载此存档？");
				saveAlert.ShowDialog();
				int code = saveAlert.code;
				saveAlert.Dispose();
				if (saveAlert.code == 0) return;
				Game gameLoaded = GameSystem.ReadGame(i).Game;
				SavedGame = gameLoaded;
				this.Close();
			}
			else
			{
				AlertForm saveFailed = new AlertForm();
				saveFailed.StartPosition = FormStartPosition.CenterParent;
				saveFailed.Hint.Text = "该存档为空！";
				saveFailed.ShowDialog();

			}
		}

		private void retBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void Exit_MouseEnter(object sender, EventArgs e)
		{
			this.retBtn.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2001;
		}

		private void Exit_MouseLeave(object sender, EventArgs e)
		{
			this.retBtn.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;

		}

		private void Exit_MouseDown(object sender, EventArgs e)
		{
		}
		private void Confirm_MouseEnter(object sender, EventArgs e)
		{
			Button Btn = (Button)sender;
			Btn.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2001;
		}

		private void Confirm_MouseLeave(object sender, EventArgs e)
		{
			Button Btn = (Button)sender;
			Btn.BackgroundImage = global::FinalHomework_Game.Properties.Resources.Btn2000;

		}

		private void Confirm_MouseDown(object sender, EventArgs e)
		{

		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;
				return cp;
			}
		}
	}
}
