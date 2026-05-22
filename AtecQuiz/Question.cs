using System;
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
        private string correctAnswerText;

        public Question()
        {
            Answers = new List<string>();
            correctAnswerText = null;
        }

        public void SetQuestionAttributes(int id, string category, int level, string text, List<string> answers)
        {
            Id = id;
            Category = category;
            Level = level;
            Text = text;
            Answers = answers;
        }

        public void SetCorrectAnswer(string answerText)
        {
            correctAnswerText = answerText;
            CorrectAnswerIndex = Answers.IndexOf(answerText);
        }

        public void RandomizeAnswers(Random random)
        {
            if (Answers.Count <= 1)
                return;

            for (int i = Answers.Count - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);
                (Answers[randomIndex], Answers[i]) = (Answers[i], Answers[randomIndex]);
            }

            CorrectAnswerIndex = Answers.IndexOf(correctAnswerText);
        }
    }
}
