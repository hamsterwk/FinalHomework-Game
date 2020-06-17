using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.CompilerServices;
using FinalHomework_Game.GameEvent;
namespace FinalHomework_Game
{
    static class GameSystem
    {
        public static Random random;
        public static List<Chapter> ChapterList;
        public static List<Game> SaveGameList;
        public static string chapterDir = @"ChapterData";
        public static int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static int DisplaySpeed = 10;
        public static string[] TimeName = {"上午", "中午", "晚上" };
        public static List<List<string>> LogList;
        public static int ErrorCode=0;
        public static string[] ErrMsg = { "","读取过场文本失败", "无可用的剧本" };
        public static string[] LogMsg={
            "（考试的效果也会稍微影响到压力值。）",
            "（放松过后压力有所下降。）",
            "",
            "（这个时间段的复习计划作废了。）",
            "（这个时间段的复习效率有所下降。）",
            "（这个时间段的复习效率由所上升。）",
            "（对这门课的理解出现了偏差，成绩有所降低。）",
            "（对这门课的理解加深了。）",
            "（这门课此后的复习效率都会下降。）",
            "（这门课此后的复习效率都会有所提升。）",
            "（这个时间段的复习计划被替换了。）",
            };
        internal static readonly int DEFAULT_PLAYSPEED = 10;
        public static int EventWeightSum=0;//事件权重之和。
        public static List<Type> Eventtypes;
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
                    string[] Lines = Regex.Split(reader.ReadToEnd(), "\r\n");
                    newChapter.ChapterName = Lines[0];
                    newChapter.ChapterDescription = Lines[1];
                    newChapter.SumTurn = int.Parse(Lines[2]);
                    newChapter.StMonth = int.Parse(Lines[3]);
                    newChapter.StDay = int.Parse(Lines[4]);
                    for (int i = 5; i < Lines.Count(); i++)
                    {
                        Course newCourse = new Course(Lines[i]);
                        newChapter.CourseList.Add(newCourse);
                    }
                    reader.Close();
                }
                catch { continue; }
                ChapterList.Add(newChapter);
            }
            if (ChapterList.Count() == 0) { ErrorCode = 2; }
        }
        public static void ReadPartLog(int i,string originalLines)
        {
            string[] Lines = Regex.Split(originalLines, "\r\n");
            List<string> curLogList = new List<string>();
            foreach(string line in Lines)
            {
                curLogList.Add(line);
            }
            LogList.Add(curLogList);
        }

        public static void ReadLog()
        {
            
            //读取日志语句
            try
            {
                StreamReader reader = new StreamReader(@"Log.txt", Encoding.UTF8);
                string[] LineSets = Regex.Split(reader.ReadToEnd(), "\r\n\r\n");
                for(int i=0;i<11;i++)
                {
                    
                    ReadPartLog(i,LineSets[i]);
                }
            }
            catch
            {
                ErrorCode = 1;
            }
        }
        public static void Init()
        {
            random = new Random();
            ChapterList = new List<Chapter>();
            SaveGameList = new List<Game>();
            LogList = new List<List<string>>();
            ReadChapter();
            ReadEvent();
        }

        public static void ReadEvent()
        {//读取所有事件
            var EventList = from t in Assembly.GetCallingAssembly().GetTypes() where t.BaseType!=null && t.BaseType==typeof(GameEventBase) select t;
            Eventtypes = new List<Type>();
            foreach(var type in EventList)
            {
                GameEventBase baseevent = (GameEventBase)Activator.CreateInstance(type);
                Eventtypes.Add(type);
                EventWeightSum += baseevent.Weight;
                baseevent.Load();
            }
        }

        public static GameEventBase GetEvent()
        {//随机生成一个事件。
            int code = random.Next(EventWeightSum);
            foreach(var type in Eventtypes)
            {
                GameEventBase baseevent = (GameEventBase)Activator.CreateInstance(type);
                if (baseevent.Weight > code) return baseevent;
                code -= baseevent.Weight;
            }
            return new GameEventBase();
        }

        public static string GetDate(int m, int d)
        {
            while (d >= month[m])
            {
                d -= month[m];
                m = (m + 1) % 12;
            }
            return $"{m + 1}月{d + 1}日";
        }

        public static double GetGPA(int score)
        {
            if (score >= 90) return 4.0;
            else if (score >= 85) return 3.7;
            else if (score >= 82) return 3.3;
            else if (score >= 78) return 3.0;
            else if (score >= 75) return 2.7;
            else if (score >= 74) return 2.3;
            else if (score >= 72) return 2.0;
            else if (score >= 68) return 2.0;
            else if (score >= 64) return 1.5;
            else if (score >= 60) return 1.0;
            else return 0.0;
        }

        public static Course FindRecentCourse(int period,Game game)
        {
            int MinTurn = game.GameChapter.SumTurn, MinPeriod = 3;
            Course course = new Course();
            foreach(Course c in (from cc in game.GameChapter.CourseList where (cc.Deadline>game.CurTurn)||(cc.Deadline==game.CurTurn&&cc.TestPeriod>period) select cc))
            {
                if((c.Deadline < MinTurn)||(c.Deadline==MinTurn && c.TestPeriod<MinPeriod))
                {
                    course = c;
                    MinTurn = c.Deadline;
                    MinPeriod = c.TestPeriod;
                }
            }
            return course;
        }
        /*
        public static void PerformEvent(int period,Game game, Course course, _GameEvent curEvent)
        {
            /*
             *type:
             * 0: 考试
             * 1: 没有安排计划
             * 2: 无事发生
             * 3: 计划被取消
             * 4-5: 修改阶段复习效率
             * 6-7: 修改学科复习效率
             * 8-9: 修改学科能力值
             * 10: 计划被替换
             *
            //特判没有安排计划（仅在这种情况下课程为空）
            if (curEvent.Type==1)
            {
                game.Pressure -= 5;
                return;
            }
            Course curCourse = (from c in game.GameChapter.CourseList where course.CourseName == c.CourseName select c).ToList()[0];
            switch (curEvent.Type)
            {
                case 0://考试
                    curCourse.TestFactor = random.Next(11) - 5;
                    curCourse.Score += curCourse.TestFactor;
                    game.Pressure -= curCourse.TestFactor;
                    break;
                case 10://计划被替换
                    curCourse = FindRecentCourse(period,game);
                    //被替换的一模一样==没替换
                    if (curCourse.CourseName == course.CourseName) { curEvent.Type = 2; }
                    course.Description = course.CourseName;
                    course.CourseName = curCourse.CourseName;
                    break;
                case 3://计划被跳过
                    course.CourseName = "空";
                    course.Description = curCourse.CourseName;
                    break;
            }
            curCourse.ReviewBonus += curEvent.CourseFactor;
            if (curCourse.ReviewBonus < 1) curCourse.ReviewBonus = 1;
            curCourse.Score += (int)(curEvent.MultipleFactor * (curCourse.ReviewBonus + curEvent.CourseFactor)) + curEvent.ConstantFactor;
            if (curEvent.Type != 3)
            {//只要不是被跳过或者没做事，那都是复习了的，需要增加压力
                curCourse.LastReview = game.CurTurn;
                game.Pressure += 5;
            }
        }*/


        public static void PerformGame(Game game, Plan newPlan)
        {
            //首先执行正常计划
            for (int i = 0; i < 3; i++)
            {
                newPlan.EventList[i].PerformEvent(i, newPlan.PlanList[i],game);
            }
            //特判夜晚计划
            if (newPlan.PlanList[3].CourseName != "空")
            {
                newPlan.EventList[3].PerformEvent(3, newPlan.PlanList[3], game);
                game.IfNight = 1;
                if (random.Next(3) == 0) game.IfNight = 2;
            }
            else { game.Pressure -= 5; game.IfNight = 0; }

            //没复习的扣分
            foreach (Course course in game.GameChapter.CourseList)
            {
                if (course.TestFactor != -11) continue;
                if (newPlan.PlanList.Exists(x => x.CourseName == course.CourseName)) continue;
                course.Score -= (game.CurTurn - course.LastReview) * course.IncDecrease + course.BaseDecrease;
            }

            //多退少补
            foreach (Course course in game.GameChapter.CourseList) { course.Score = Math.Max(course.Score, 0); course.Score = Math.Min(course.Score, 100); }

            //buff归位
            if (game.Buff != 0)
            {
                foreach(Course course in game.GameChapter.CourseList) { if(course.TestFactor!=-11)course.Score += game.Buff; }
                game.Buff = 0;
            }

            //压力值的处理
            if (game.Pressure >= 90)
            {
                game.Buff = -2;
                game.Pressure = 50;
            }
            if (game.Pressure <= 10)
            {
                game.Buff = 2;
                game.Pressure = 50;
            }
            game.CurTurn += 1;
        }

        public static void SaveGame(int i, Game game)
        {
            GameArchive gameArchive = new GameArchive();
            gameArchive.Game = game;
            gameArchive.SaveTime = DateTime.Now.ToString("yyyy-MM-dd\r\nHH:mm:ss");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("No." + i + ".sav", FileMode.Create))
            {
                binaryFormatter.Serialize(fs, gameArchive);
            }
        }

        public static GameArchive ReadGame(int i)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("No." + i + ".sav", FileMode.Open))
            {
                GameArchive GameArchive = (GameArchive)binaryFormatter.Deserialize(fs);
                return GameArchive;
            }
        }
    }
}
