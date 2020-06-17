using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework_Game
{
    public class GameResult
    {
        private Chapter gameChapter;
        private double gPA;

        public double GPA { get => gPA; set => gPA = value; }
        public Chapter GameChapter { get => gameChapter; set => gameChapter = value; }
    
        public GameResult(Game curGame)
        {
            gameChapter = curGame.GameChapter;
            GPA = (gameChapter.CourseList.Sum(x=>x.GPA*x.Credit)) / (gameChapter.CourseList.Sum(x=>x.Credit));   
        }
    }
}
