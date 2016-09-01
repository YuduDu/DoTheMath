using System;
using System.Collections.Generic;

namespace DoTheMath
{
    public class Exam
    {
        public List<Question> ExamContent { get; set; }
        public DateTime ExamTime { get; set; }

        public int ExamScore { get; set; }

        public Exam()
        {
            ExamContent = new List<Question>();
            ExamTime = DateTime.Now;
            ExamScore = 0;
        }

        public int Score()
        {
            foreach (var question in ExamContent)
            {
                Console.WriteLine(question.score);
                ExamScore += question.score;
            }
            return ExamScore;
        }
    }
}
