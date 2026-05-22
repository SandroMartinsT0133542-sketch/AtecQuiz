using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace AtecQuiz
{
    public class QuizManager
    {
        private readonly List<Question> allQuestions;
        private readonly Random random;
        private int currentLevel = 1;

        public QuizManager()
        {
            allQuestions = new List<Question>();
            random = new Random();
        }

        public void LoadQuestionsFromXml(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNodeList questionNodes = xmlDoc.SelectNodes("/quiz/questions/category/level/question");

            foreach (XmlNode questionNode in questionNodes)
            {
                Question question = new Question();

                XmlNodeList answerNodes = questionNode.SelectNodes("answers/answer");
                List<string> answers = new List<string>();
                string correctAnswerText = null;

                for (int i = 0; i < answerNodes.Count; i++)
                {
                    answers.Add(answerNodes[i].InnerText);

                    if (answerNodes[i].Attributes["correct"] != null &&
                        bool.Parse(answerNodes[i].Attributes["correct"].Value))
                    {
                        correctAnswerText = answerNodes[i].InnerText;
                    }
                }

                question.SetQuestionAttributes(
                    int.Parse(questionNode.Attributes["id"].Value),
                    questionNode.ParentNode.ParentNode.Attributes["name"].Value,
                    int.Parse(questionNode.ParentNode.Attributes["number"].Value),
                    questionNode.SelectSingleNode("text").InnerText,
                    answers
                );

                // Set correct answer AFTER SetQuestionAttributes
                if (correctAnswerText != null)
                {
                    question.SetCorrectAnswer(correctAnswerText);
                }

                allQuestions.Add(question);
            }
        }

        public List<string> GetCategories()
        {
            return allQuestions
                .Select(q => q.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        public List<Question> GetRandomQuestions(string category, int count)
        {
            var filteredQuestions = allQuestions
                .Where(q => category == "Mix"
                    ? (q.Level == this.currentLevel)
                    : (q.Category == category && q.Level == this.currentLevel))
                .OrderBy(q => random.Next())
                .Take(count)
                .ToList();

            // Randomize answers
            foreach (var question in filteredQuestions)
            {
                question.RandomizeAnswers(random);
            }

            return filteredQuestions;
        }

        public List<Question> GetAllQuestions()
        {
            return allQuestions;
        }


        public void NextLevel()
        {
            if (currentLevel < 3)
                this.currentLevel++;
        }

        public void ResetLevels()
        {
            this.currentLevel = 1;
        }

        public int GetCurrentLevel()
        {
            return this.currentLevel;
        }

    }
}
