using System.Collections.Generic;

namespace AtecQuiz
{
    public class Question
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Level { get; set; }
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question()
        {
            Answers = new List<string>();
        }

        public void setQuestionAttributes(int id, string category, int level, string text, List<string> answers)
        {
            Id = id;
            Category = category;
            Level = level;
            Text = text;
            Answers = answers;
        }

        public void setCorrectAnswerIndex(int index)
        {
            CorrectAnswerIndex = index;
        }

    }
}
