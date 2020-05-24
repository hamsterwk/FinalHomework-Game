using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalHomework_Game
{
    static class GameSystem
    {
        public static Random random;
        public static List<Chapter> ChapterList;
        public static List<Game> SaveGameList;
        public static string text;
        public static string chapterDir = @"ChapterData";
        static void ReadChapter()
        {//从文件夹中读取各个剧本
            DirectoryInfo dir = new DirectoryInfo(chapterDir);
            FileInfo[] inf = dir.GetFiles();
            foreach (FileInfo finf in inf)
            {
                Chapter newChapter = new Chapter();
                try
                {
                    FileStream stream = finf.OpenRead();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    string[] Lines = Regex.Split(reader.ReadToEnd(), "\n");
                    newChapter.ChapterName = Lines[0];
                    newChapter.ChapterDescription = Lines[1];
                    newChapter.SumTurn = int.Parse(Lines[2]);
                    for (int i = 3; i < Lines.Count(); i++)
                    {
                        Course newCourse = new Course(Lines[i]);
                        newChapter.CourseList.Add(newCourse);
                    }
                }
                catch { continue; }
                ChapterList.Add(newChapter);
            }

        }
        public static void Init()
        {
            random = new Random();
            ChapterList = new List<Chapter>();
            SaveGameList = new List<Game>();
            ReadChapter();
        }

        public static void Main(Game Gamest)
        {

        }
    }
}
