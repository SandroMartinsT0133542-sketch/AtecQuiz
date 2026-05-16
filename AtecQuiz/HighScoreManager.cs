using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AtecQuiz
{
    public class HighScoreEntry
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }

    public class HighScoreManager
    {
        private const string HIGH_SCORES_FILE = "highscores.txt";
        private List<HighScoreEntry> highScores;

        public HighScoreManager()
        {
            highScores = new List<HighScoreEntry>();
            LoadHighScores();
        }

        public void LoadHighScores()
        {
            highScores.Clear();

            if (File.Exists(HIGH_SCORES_FILE))
            {
                try
                {
                    string[] lines = File.ReadAllLines(HIGH_SCORES_FILE);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            highScores.Add(new HighScoreEntry
                            {
                                PlayerName = parts[0],
                                Score = int.Parse(parts[1]),
                                Date = DateTime.Parse(parts[2])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    // If file is corrupted, start fresh
                    highScores.Clear();
                }
            }
        }

        public void SaveHighScore(string playerName, int score)
        {
            highScores.Add(new HighScoreEntry
            {
                PlayerName = playerName,
                Score = score,
                Date = DateTime.Now
            });

            // Sort by score descending and keep only top 10
            highScores = highScores
                .OrderByDescending(h => h.Score)
                .Take(10)
                .ToList();

            SaveHighScoresToFile();
        }

        private void SaveHighScoresToFile()
        {
            try
            {
                List<string> lines = new List<string>();
                foreach (var entry in highScores)
                {
                    lines.Add($"{entry.PlayerName}|{entry.Score}|{entry.Date:yyyy-MM-dd HH:mm:ss}");
                }
                File.WriteAllLines(HIGH_SCORES_FILE, lines);
            }
            catch (Exception)
            {
                // If save fails, continue anyway
            }
        }

        public List<HighScoreEntry> GetTopHighScores()
        {
            return highScores
                .OrderByDescending(h => h.Score)
                .ToList();
        }

        public string GetHighScoresDisplay()
        {
            if (highScores.Count == 0)
                return "Sem pontuações registadas";

            string display = "Top 10 Pontuações:\n";
            display += "==================\n";

            int position = 1;
            foreach (var entry in GetTopHighScores())
            {
                display += $"{position}. {entry.PlayerName}: {entry.Score} respostas certas\n";
                position++;
            }

            return display;
        }
    }
}
