using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework_Game
{
    [Serializable]
    public class Chapter
    {
        private string chapterName;//剧本名
        private string chapterDescription;//剧本描述
        private List<Course> courseList;//课程列表
        private int sumTurn;//回合总数
        private int stMonth;//起始月，日
        private int stDay;
        public Chapter()
        {

            courseList = new List<Course>();
            sumTurn = 0;
            chapterName = "";
            chapterDescription = "";
            stMonth = StDay = 2;
        }

        public List<Course> CourseList { get => courseList; set => courseList = value; }
        public int SumTurn { get => sumTurn; set => sumTurn = value; }
        public string ChapterName { get => chapterName; set => chapterName = value; }
        public string ChapterDescription { get => chapterDescription; set => chapterDescription = value; }
        public int StMonth { get => stMonth; set => stMonth = value; }
        public int StDay { get => stDay; set => stDay = value; }
    }
}
