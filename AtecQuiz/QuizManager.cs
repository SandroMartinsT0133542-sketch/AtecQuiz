using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

// Estrutura do XML de perguntas
//quiz
// └── questions
//      └── category (name="Desporto / História / Cinema")
//           └── level (number="1 / 2 / 3")
//                └── question (id="1..10")
//                     ├── text
//                     └── answers
//                          └── answer (correct="true" na correta)

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

                question.SetQuestionAttributes(
                    int.Parse(questionNode.Attributes["id"].Value),
                    questionNode.ParentNode.ParentNode.Attributes["name"].Value,
                    int.Parse(questionNode.ParentNode.Attributes["number"].Value),
                    questionNode.SelectSingleNode("text").InnerText,
                    questionNode.SelectNodes("answers/answer").Cast<XmlNode>().Select(a => a.InnerText).ToList()
                );

                XmlNodeList answerNodes = questionNode.SelectNodes("answers/answer");

                for (int i = 0; i < answerNodes.Count; i++)
                {
                    question.Answers.Add(answerNodes[i].InnerText);

                    if (answerNodes[i].Attributes["correct"] != null &&
                        bool.Parse(answerNodes[i].Attributes["correct"].Value))
                    {
                        question.SetCorrectAnswerIndex(i);
                    }
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
