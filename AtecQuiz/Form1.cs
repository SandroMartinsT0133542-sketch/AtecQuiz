using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AtecQuiz
{
    public partial class Form1 : Form
    {
        private QuizManager quizManager;
        private HighScoreManager highScoreManager;
        private List<Question> currentGameQuestions;
        private int currentQuestionIndex;
        private int score;
        private string selectedCategory;
        private string playerName;
        private Button selectedAnswerButton;
        private Question currentQuestion;

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
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perguntas: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            List<string> categories = quizManager.GetCategories();
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("Mix");
            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }
            comboBoxCategory.SelectedIndex = 0;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                MessageBox.Show("Por favor, insira o seu nome!");
                return;
            }

            playerName = txtPlayerName.Text;
            selectedCategory = comboBoxCategory.SelectedItem.ToString();

            // Initialize game
            score = 0;
            currentQuestionIndex = 0;
            currentGameQuestions = new List<Question>();

            // Load 5 random questions for level 1
            LoadNextLevel();

            // Switch to game panel
            panelMenu.Visible = false;
            panelGame.Visible = true;

            DisplayQuestion();
        }

        private void LoadNextLevel()
        {
            if (quizManager.getCurrentLevel() <= 3)
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
                selectedAnswerButton = null;

                lblQuestion.Text = currentQuestion.Text;
                lblScore.Text = $"Acertos: {score}/5";
                lblLevel.Text = $"Nível: {quizManager.getCurrentLevel()}/3";
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

        private void btnAnswer_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Por favor, selecione uma resposta!");
                return;
            }

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
                lblCorrectAnswerMessage.Text = "CORRETO!";
                lblCorrectAnswerMessage.ForeColor = Color.FromArgb(46, 204, 113);
                selectedAnswerButton.BackColor = Color.FromArgb(46, 204, 113);
                lblScore.Text = $"Acertos: {score}/5";
            }
            else
            {
                lblCorrectAnswerMessage.Text = $"ERRADO! A resposta correta é:\n{currentQuestion.Answers[currentQuestion.CorrectAnswerIndex]}";
                lblCorrectAnswerMessage.ForeColor = Color.FromArgb(231, 76, 60);
                selectedAnswerButton.BackColor = Color.FromArgb(231, 76, 60);
                buttons[currentQuestion.CorrectAnswerIndex].BackColor = Color.FromArgb(46, 204, 113);
            }

            btnNextQuestion.Visible = true;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void EndLevel()
        {
            // Check if player progresses to next level
            if (score >= 4 && quizManager.getCurrentLevel() < 3)
            {
                // Player advances to next level
                string message = $"Parabéns {playerName}!\n\nVocê conseguiu {score} acertos!\nAvançou para o Nível {quizManager.getCurrentLevel() + 1}";
                MessageBox.Show(message, "Nível Completo!");

                quizManager.nextLevel();
                currentQuestionIndex = 0;
                score = 0;
                LoadNextLevel();
                DisplayQuestion();
            }
            else if (score >= 4 && quizManager.getCurrentLevel() == 3)
            {
                // Game completed successfully
                string message = $"VITÓRIA!\n\nParabéns {playerName}!\nVocê completou o jogo com {score} acertos!\n\nPontuação final: {score} acertos";
                MessageBox.Show(message, "Jogo Completo!");
                highScoreManager.SaveHighScore(playerName, score);
                ReturnToMenu();
            }
            else
            {
                quizManager.resetLevels();
                // Game over - didn't pass this level
                string message = $"Fim do Jogo!\n\nVocê conseguiu {score} acertos no Nível {quizManager.getCurrentLevel()}.\nNecessário: 4 acertos para avançar.\n\nTente novamente!";
                MessageBox.Show(message, "Game Over");
                highScoreManager.SaveHighScore(playerName, score);
                ReturnToMenu();
            }
        }

        private void btnViewScores_Click(object sender, EventArgs e)
        {
            string scoresDisplay = highScoreManager.GetHighScoresDisplay();
            MessageBox.Show(scoresDisplay, "Pontuações Máximas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que pretende regressar ao menu? Perderá o progresso!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ReturnToMenu();
            }
        }

        private void ReturnToMenu()
        {
            panelGame.Visible = false;
            panelMenu.Visible = true;
            comboBoxCategory.SelectedIndex = 0;
        }

        // Hover effects
        private void btnStartGame_MouseEnter(object sender, EventArgs e)
        {
            btnStartGame.BackColor = Color.FromArgb(39, 174, 96);
            btnStartGame.Font = new Font(btnStartGame.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void btnStartGame_MouseLeave(object sender, EventArgs e)
        {
            btnStartGame.BackColor = Color.FromArgb(46, 204, 113);
            btnStartGame.Font = new Font(btnStartGame.Font, FontStyle.Bold);
        }

        private void btnViewScores_MouseEnter(object sender, EventArgs e)
        {
            btnViewScores.BackColor = Color.FromArgb(41, 128, 185);
            btnViewScores.Font = new Font(btnViewScores.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void btnViewScores_MouseLeave(object sender, EventArgs e)
        {
            btnViewScores.BackColor = Color.FromArgb(52, 152, 219);
            btnViewScores.Font = new Font(btnViewScores.Font, FontStyle.Bold);
        }

        private void btnAnswer_MouseEnter(object sender, EventArgs e)
        {
            if (selectedAnswerButton != (Button)sender)
            {
                ((Button)sender).BackColor = Color.FromArgb(127, 140, 141);
            }
        }

        private void btnAnswer_MouseLeave(object sender, EventArgs e)
        {
            if (selectedAnswerButton != (Button)sender)
            {
                ((Button)sender).BackColor = Color.FromArgb(149, 165, 166);
            }
        }

        private void lblCategoryDisplay_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
