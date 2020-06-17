using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework_Game
{
	[Serializable]
	public class GameArchive
	{
		private Game game;
		private string archiveName;
		private string saveTime;
		public Game Game { get => game; set => game = value; }
		public string ArchiveName { get => archiveName; set => archiveName = value; }
		public string SaveTime { get => saveTime; set => saveTime = value; }
	}
}
