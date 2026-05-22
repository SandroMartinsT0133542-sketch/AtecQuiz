using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AtecQuiz
{
    public partial class Form1 : Form
    {
        private readonly QuizManager quizManager;
        private readonly HighScoreManager highScoreManager;
        private List<Question> currentGameQuestions;
        private int currentQuestionIndex;
        private int score;
        private string selectedCategory;
        private string playerName;
        private Button selectedAnswerButton;
        private Question currentQuestion;
        private bool answerSubmitted;

        public Form1()
        {
            InitializeComponent();
            quizManager = new QuizManager();
            highScoreManager = new HighScoreManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                quizManager.LoadQuestionsFromXml("quiz.xml");
                selectedCategory = "Mix"; // Default category
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar questões: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            List<string> categories = quizManager.GetCategories();
            flowLayoutPanelCategories.Controls.Clear();

            CreateCategoryButton("Mix");

            foreach (string category in categories)
            {
                CreateCategoryButton(category);
            }
        }

        private void CreateCategoryButton(string categoryName)
        {
            Button btn = new Button
            {
                Text = categoryName,
                Width = 300,
                Height = 80,
                Font = new Font("Arial", 14F, FontStyle.Bold),
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Margin = new Padding(15),
                Tag = categoryName,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };
            btn.Click += CategoryButton_Click;
            btn.MouseEnter += CategoryButton_MouseEnter;
            btn.MouseLeave += CategoryButton_MouseLeave;

            flowLayoutPanelCategories.Controls.Add(btn);
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            selectedCategory = btn.Tag.ToString();

            // Highlight selected button
            foreach (Control control in flowLayoutPanelCategories.Controls)
            {
                if (control is Button button)
                {
                    if (button == btn)
                    {
                        button.BackColor = Color.FromArgb(230, 126, 34);
                    }
                    else
                    {
                        button.BackColor = Color.RoyalBlue;
                    }
                }
            }
        }

        private void CategoryButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.ToString() != selectedCategory)
            {
                btn.BackColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void CategoryButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.ToString() != selectedCategory)
            {
                btn.BackColor = Color.RoyalBlue;
            }
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            // Switch to category selection panel
            panelMenu.Visible = false;
            panelCategorySelection.Visible = true;
        }

        private void BtnConfirmCategory_Click(object sender, EventArgs e)
        {

            score = 0;
            currentQuestionIndex = 0;
            currentGameQuestions = new List<Question>();
            quizManager.ResetLevels();

            LoadNextLevel();

            panelCategorySelection.Visible = false;
            panelGame.Visible = true;

            DisplayQuestion();
        }

        private void BtnBackFromCategory_Click(object sender, EventArgs e)
        {
            panelCategorySelection.Visible = false;
            panelMenu.Visible = true;
        }

        private void LoadNextLevel()
        {
            if (quizManager.GetCurrentLevel() <= 3)
            {
                List<Question> levelQuestions = quizManager.GetRandomQuestions(selectedCategory, 5);
                currentGameQuestions.Clear();
                currentGameQuestions.AddRange(levelQuestions);
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < currentGameQuestions.Count)
            {
                currentQuestion = currentGameQuestions[currentQuestionIndex];
                answerSubmitted = false;
                selectedAnswerButton = null;

                lblQuestion.Text = currentQuestion.Text;
                lblScore.Text = $"Respostas correctas: {score}/5";
                lblLevel.Text = $"Nível: {quizManager.GetCurrentLevel()}/3";
                lblCategoryDisplay.Text = $"Categoria: {selectedCategory}";
                lblRemainingTime.Text = $"Progresso: {currentQuestionIndex + 1}/5";

                // Update progress bar
                progressBar.Value = (currentQuestionIndex + 1) * 20;

                // Clear previous state
                lblCorrectAnswerMessage.Text = "";
                lblCorrectAnswerMessage.ForeColor = Color.Black;

                // Display answer options
                SetupAnswerButtons(currentQuestion);

                // Enable answer buttons
                btnAnswer1.Enabled = true;
                btnAnswer2.Enabled = true;
                btnAnswer3.Enabled = true;
                btnAnswer4.Enabled = currentQuestion.Answers.Count > 3;

                btnNextQuestion.Visible = false;
            }
            else
            {
                EndLevel();
            }
        }

        private void SetupAnswerButtons(Question question)
        {
            Button[] buttons = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            for (int i = 0; i < buttons.Length; i++)
            {
                if (i < question.Answers.Count)
                {
                    buttons[i].Text = $"{question.Answers[i]}";
                    buttons[i].Visible = true;
                    buttons[i].BackColor = Color.FromArgb(149, 165, 166);
                    buttons[i].ForeColor = Color.White;
                }
                else
                {
                    buttons[i].Visible = false;
                }
            }
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            if (answerSubmitted)
                return;

            Button clickedButton = (Button)sender;

            // Remove previous selection highlighting
            if (selectedAnswerButton != null)
            {
                selectedAnswerButton.BackColor = Color.FromArgb(149, 165, 166);
            }

            // Highlight selected answer
            selectedAnswerButton = clickedButton;
            selectedAnswerButton.BackColor = Color.FromArgb(230, 126, 34);

            // Auto-submit after selection
            SubmitAnswer();
        }

        private void SubmitAnswer()
        {
            if (selectedAnswerButton == null)
            {
                MessageBox.Show("Por favor, seleccione uma resposta!");
                return;
            }

            answerSubmitted = true;

            // Find which button was clicked
            Button[] buttons = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };
            int selectedAnswer = -1;

            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i] == selectedAnswerButton)
                {
                    selectedAnswer = i;
                    break;
                }
            }

            // Disable all answer buttons
            btnAnswer1.Enabled = false;
            btnAnswer2.Enabled = false;
            btnAnswer3.Enabled = false;
            btnAnswer4.Enabled = false;

            // Show result
            if (selectedAnswer == currentQuestion.CorrectAnswerIndex)
            {
                score++;
                lblCorrectAnswerMessage.Text = "CORRECTO!";
                lblCorrectAnswerMessage.ForeColor = Color.LimeGreen;
                selectedAnswerButton.BackColor = Color.LimeGreen;
                lblScore.Text = $"Respostas correctas: {score}/5";
            }
            else
            {
                lblCorrectAnswerMessage.Text = $"INCORRECTO! A resposta correcta é:\n{currentQuestion.Answers[currentQuestion.CorrectAnswerIndex]}";
                lblCorrectAnswerMessage.ForeColor = Color.Red;
                selectedAnswerButton.BackColor = Color.Red;
                // prevent index out of range if correct answer index is invalid
                if (currentQuestion.CorrectAnswerIndex >= 0 &&
                    currentQuestion.CorrectAnswerIndex < buttons.Length)
                {
                    buttons[currentQuestion.CorrectAnswerIndex].BackColor = Color.LimeGreen;
                }
            }

            btnNextQuestion.Visible = true;
        }

        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void EndLevel()
        {
            // Check if player progresses to next level
            if (score >= 4 && quizManager.GetCurrentLevel() < 3)
            {
                // Player advances to next level
                MessageBox.Show($"Parabéns!\n\nConseguiu {score} respostas correctas!\nAvançou para o Nível {quizManager.GetCurrentLevel() + 1}", "Nível Completo!");

                quizManager.NextLevel();
                currentQuestionIndex = 0;
                score = 0;
                LoadNextLevel();
                DisplayQuestion();
            }
            else if (score >= 4 && quizManager.GetCurrentLevel() == 3)
            {
                // Game completed successfully - show win screen with name input
                panelGame.Visible = false;
                panelWinScreen.Visible = true;
                lblFinalScore.Text = $"Pontuação final: {score} respostas correctas";
                txtPlayerName.Clear();
                txtPlayerName.Focus();
            }
            else
            {
                quizManager.ResetLevels();
                // Game over - didn't pass this level
                string message = $"Fim do Jogo!\n\nConseguiu {score} respostas correctas no Nível {quizManager.GetCurrentLevel()}.\nNecessário: 4 respostas correctas para avançar.\n\nTente novamente!";
                MessageBox.Show(message, "Game Over");
                ReturnToMenu();
            }
        }

        private void BtnViewScores_Click(object sender, EventArgs e)
        {
            string scoresDisplay = highScoreManager.GetHighScoresDisplay();
            MessageBox.Show(scoresDisplay, "Classificações Máximas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que quer regressar ao menu? Vai perder o progresso!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ReturnToMenu();
            }
        }

        private void ReturnToMenu()
        {
            panelGame.Visible = false;
            panelWinScreen.Visible = false;
            panelCategorySelection.Visible = false;
            panelMenu.Visible = true;
        }

        private void BtnSaveScore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                MessageBox.Show("Por favor, introduza o seu nome!");
                return;
            }

            playerName = txtPlayerName.Text;
            highScoreManager.SaveHighScore(playerName, score);
            MessageBox.Show($"Parabéns {playerName}!\nClassificação guardada!", "Vitória!");
            ReturnToMenu();
        }

        // Hover effects
        private void BtnStartGame_MouseEnter(object sender, EventArgs e)
        {
            btnStartGame.BackColor = Color.FromArgb(39, 174, 96);
            btnStartGame.Font = new Font(btnStartGame.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void BtnStartGame_MouseLeave(object sender, EventArgs e)
        {
            btnStartGame.BackColor = Color.FromArgb(46, 204, 113);
            btnStartGame.Font = new Font(btnStartGame.Font, FontStyle.Bold);
        }

        private void BtnViewScores_MouseEnter(object sender, EventArgs e)
        {
            btnViewScores.BackColor = Color.FromArgb(41, 128, 185);
            btnViewScores.Font = new Font(btnViewScores.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void BtnViewScores_MouseLeave(object sender, EventArgs e)
        {
            btnViewScores.BackColor = Color.FromArgb(52, 152, 219);
            btnViewScores.Font = new Font(btnViewScores.Font, FontStyle.Bold);
        }

        private void BtnAnswer_MouseEnter(object sender, EventArgs e)
        {
            if (!answerSubmitted && selectedAnswerButton != (Button)sender)
            {
                ((Button)sender).BackColor = Color.FromArgb(127, 140, 141);
            }
        }

        private void BtnAnswer_MouseLeave(object sender, EventArgs e)
        {
            if (!answerSubmitted && selectedAnswerButton != (Button)sender)
            {
                ((Button)sender).BackColor = Color.FromArgb(149, 165, 166);
            }
        }


    }
}
