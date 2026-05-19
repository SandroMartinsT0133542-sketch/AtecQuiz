using System.Drawing;
using System.Windows.Forms;

namespace AtecQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnViewScores = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblCategoryDisplay = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblCorrectAnswerMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerPulse = new System.Windows.Forms.Timer(this.components);
            this.panelCategorySelection = new System.Windows.Forms.Panel();
            this.btnBackFromCategory = new System.Windows.Forms.Button();
            this.btnConfirmCategory = new System.Windows.Forms.Button();
            this.lblCategoryInstructions = new System.Windows.Forms.Label();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWinScreen = new System.Windows.Forms.Panel();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.pictureBoxCategoryBg = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoryBg)).BeginInit();
            this.panelCategorySelection.SuspendLayout();
            this.panelWinScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(111, 256);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(174, 19);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Selecionar Categoria:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxCategory.Location = new System.Drawing.Point(285, 254);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(726, 25);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartGame.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(104, 493);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(946, 60);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Iniciar Jogo";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            this.btnStartGame.MouseEnter += new System.EventHandler(this.BtnStartGame_MouseEnter);
            this.btnStartGame.MouseLeave += new System.EventHandler(this.BtnStartGame_MouseLeave);
            // 
            // btnViewScores
            // 
            this.btnViewScores.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewScores.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnViewScores.ForeColor = System.Drawing.Color.White;
            this.btnViewScores.Location = new System.Drawing.Point(104, 559);
            this.btnViewScores.Name = "btnViewScores";
            this.btnViewScores.Size = new System.Drawing.Size(946, 60);
            this.btnViewScores.TabIndex = 4;
            this.btnViewScores.Text = "Ver Pontuações";
            this.btnViewScores.UseVisualStyleBackColor = false;
            this.btnViewScores.Click += new System.EventHandler(this.BtnViewScores_Click);
            this.btnViewScores.MouseEnter += new System.EventHandler(this.BtnViewScores_MouseEnter);
            this.btnViewScores.MouseLeave += new System.EventHandler(this.BtnViewScores_MouseLeave);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(311, 164);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(10);
            this.lblQuestion.Size = new System.Drawing.Size(700, 130);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Pergunta?";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer1.ForeColor = System.Drawing.Color.White;
            this.btnAnswer1.Location = new System.Drawing.Point(197, 451);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer1.TabIndex = 8;
            this.btnAnswer1.Text = "A) Resposta 1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.BtnAnswer_Click);
            this.btnAnswer1.MouseEnter += new System.EventHandler(this.BtnAnswer_MouseEnter);
            this.btnAnswer1.MouseLeave += new System.EventHandler(this.BtnAnswer_MouseLeave);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer2.ForeColor = System.Drawing.Color.White;
            this.btnAnswer2.Location = new System.Drawing.Point(577, 451);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer2.TabIndex = 9;
            this.btnAnswer2.Text = "B) Resposta 2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.BtnAnswer_Click);
            this.btnAnswer2.MouseEnter += new System.EventHandler(this.BtnAnswer_MouseEnter);
            this.btnAnswer2.MouseLeave += new System.EventHandler(this.BtnAnswer_MouseLeave);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer3.ForeColor = System.Drawing.Color.White;
            this.btnAnswer3.Location = new System.Drawing.Point(197, 516);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer3.TabIndex = 10;
            this.btnAnswer3.Text = "C) Resposta 3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.BtnAnswer_Click);
            this.btnAnswer3.MouseEnter += new System.EventHandler(this.BtnAnswer_MouseEnter);
            this.btnAnswer3.MouseLeave += new System.EventHandler(this.BtnAnswer_MouseLeave);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnswer4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer4.ForeColor = System.Drawing.Color.White;
            this.btnAnswer4.Location = new System.Drawing.Point(577, 516);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer4.TabIndex = 11;
            this.btnAnswer4.Text = "D) Resposta 4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Visible = false;
            this.btnAnswer4.Click += new System.EventHandler(this.BtnAnswer_Click);
            this.btnAnswer4.MouseEnter += new System.EventHandler(this.BtnAnswer_MouseEnter);
            this.btnAnswer4.MouseLeave += new System.EventHandler(this.BtnAnswer_MouseLeave);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblScore.Location = new System.Drawing.Point(916, 733);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(233, 26);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Respostas certas: 0/5";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblLevel.ForeColor = System.Drawing.Color.Plum;
            this.lblLevel.Location = new System.Drawing.Point(749, 120);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(107, 26);
            this.lblLevel.TabIndex = 16;
            this.lblLevel.Text = "Nível: 1/3";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnStartGame);
            this.panelMenu.Controls.Add(this.btnViewScores);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1171, 768);
            this.panelMenu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1160, 186);
            this.label1.TabIndex = 7;
            this.label1.Text = "ATECQuiZ\r\nJogo da Sabedoria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.Location = new System.Drawing.Point(111, 297);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(150, 19);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Insira o seu nome:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPlayerName.Location = new System.Drawing.Point(285, 297);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(726, 24);
            this.txtPlayerName.TabIndex = 6;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.White;
            this.panelGame.Controls.Add(this.btnMainMenu);
            this.panelGame.Controls.Add(this.lblScore);
            this.panelGame.Controls.Add(this.lblLevel);
            this.panelGame.Controls.Add(this.lblCategoryDisplay);
            this.panelGame.Controls.Add(this.progressBar);
            this.panelGame.Controls.Add(this.lblRemainingTime);
            this.panelGame.Controls.Add(this.lblQuestion);
            this.panelGame.Controls.Add(this.btnAnswer1);
            this.panelGame.Controls.Add(this.btnAnswer2);
            this.panelGame.Controls.Add(this.btnAnswer3);
            this.panelGame.Controls.Add(this.btnAnswer4);
            this.panelGame.Controls.Add(this.btnNextQuestion);
            this.panelGame.Controls.Add(this.lblCorrectAnswerMessage);
            this.panelGame.Controls.Add(this.pictureBox1);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1171, 768);
            this.panelGame.TabIndex = 20;
            this.panelGame.Visible = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMainMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(9, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(57, 46);
            this.btnMainMenu.TabIndex = 14;
            this.btnMainMenu.Text = "<<";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // lblCategoryDisplay
            // 
            this.lblCategoryDisplay.AutoSize = true;
            this.lblCategoryDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryDisplay.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblCategoryDisplay.ForeColor = System.Drawing.Color.Orange;
            this.lblCategoryDisplay.Location = new System.Drawing.Point(313, 87);
            this.lblCategoryDisplay.Name = "lblCategoryDisplay";
            this.lblCategoryDisplay.Size = new System.Drawing.Size(157, 26);
            this.lblCategoryDisplay.TabIndex = 18;
            this.lblCategoryDisplay.Text = "Categoria: Mix";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.LightGray;
            this.progressBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar.Location = new System.Drawing.Point(197, 404);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(733, 23);
            this.progressBar.TabIndex = 19;
            this.progressBar.Value = 20;
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingTime.Font = new System.Drawing.Font("Arial", 16F);
            this.lblRemainingTime.ForeColor = System.Drawing.Color.Gray;
            this.lblRemainingTime.Location = new System.Drawing.Point(192, 324);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(155, 25);
            this.lblRemainingTime.TabIndex = 20;
            this.lblRemainingTime.Text = "Progresso: 1/5";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNextQuestion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnNextQuestion.ForeColor = System.Drawing.Color.White;
            this.btnNextQuestion.Location = new System.Drawing.Point(197, 574);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(733, 50);
            this.btnNextQuestion.TabIndex = 13;
            this.btnNextQuestion.Text = "Próxima Pergunta";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Visible = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.BtnNextQuestion_Click);
            // 
            // lblCorrectAnswerMessage
            // 
            this.lblCorrectAnswerMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectAnswerMessage.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblCorrectAnswerMessage.Location = new System.Drawing.Point(355, 323);
            this.lblCorrectAnswerMessage.Name = "lblCorrectAnswerMessage";
            this.lblCorrectAnswerMessage.Size = new System.Drawing.Size(575, 61);
            this.lblCorrectAnswerMessage.TabIndex = 18;
            this.lblCorrectAnswerMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panelCategorySelection
            // 
            this.panelCategorySelection.BackColor = System.Drawing.Color.DarkGray;
            this.panelCategorySelection.Controls.Add(this.btnBackFromCategory);
            this.panelCategorySelection.Controls.Add(this.btnConfirmCategory);
            this.panelCategorySelection.Controls.Add(this.lblCategoryInstructions);
            this.panelCategorySelection.Controls.Add(this.flowLayoutPanelCategories);
            this.panelCategorySelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategorySelection.Location = new System.Drawing.Point(0, 0);
            this.panelCategorySelection.Name = "panelCategorySelection";
            this.panelCategorySelection.Size = new System.Drawing.Size(1171, 768);
            this.panelCategorySelection.TabIndex = 21;
            this.panelCategorySelection.Visible = false;
            // 
            // btnBackFromCategory
            // 
            this.btnBackFromCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBackFromCategory.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnBackFromCategory.ForeColor = System.Drawing.Color.White;
            this.btnBackFromCategory.Location = new System.Drawing.Point(385, 690);
            this.btnBackFromCategory.Name = "btnBackFromCategory";
            this.btnBackFromCategory.Size = new System.Drawing.Size(400, 60);
            this.btnBackFromCategory.TabIndex = 4;
            this.btnBackFromCategory.Text = "Voltar";
            this.btnBackFromCategory.UseVisualStyleBackColor = false;
            this.btnBackFromCategory.Click += new System.EventHandler(this.BtnBackFromCategory_Click);
            // 
            // btnConfirmCategory
            // 
            this.btnConfirmCategory.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmCategory.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnConfirmCategory.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCategory.Location = new System.Drawing.Point(385, 620);
            this.btnConfirmCategory.Name = "btnConfirmCategory";
            this.btnConfirmCategory.Size = new System.Drawing.Size(400, 60);
            this.btnConfirmCategory.TabIndex = 3;
            this.btnConfirmCategory.Text = "Iniciar Jogo";
            this.btnConfirmCategory.UseVisualStyleBackColor = false;
            this.btnConfirmCategory.Click += new System.EventHandler(this.BtnConfirmCategory_Click);
            // 
            // lblCategoryInstructions
            // 
            this.lblCategoryInstructions.AutoSize = true;
            this.lblCategoryInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryInstructions.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCategoryInstructions.ForeColor = System.Drawing.Color.White;
            this.lblCategoryInstructions.Location = new System.Drawing.Point(443, 50);
            this.lblCategoryInstructions.Name = "lblCategoryInstructions";
            this.lblCategoryInstructions.Size = new System.Drawing.Size(285, 29);
            this.lblCategoryInstructions.TabIndex = 7;
            this.lblCategoryInstructions.Text = "Escolha uma Categoria:";
            this.lblCategoryInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.AutoScroll = false;
            this.flowLayoutPanelCategories.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(200, 100);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(770, 480);
            this.flowLayoutPanelCategories.TabIndex = 8;
            // 
            // pictureBoxCategoryBg
            // 
            this.pictureBoxCategoryBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCategoryBg.ErrorImage = null;
            this.pictureBoxCategoryBg.Image = AtecQuiz.Properties.Resources.quiz_ready;
            this.pictureBoxCategoryBg.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCategoryBg.Name = "pictureBoxCategoryBg";
            this.pictureBoxCategoryBg.Size = new System.Drawing.Size(1171, 768);
            this.pictureBoxCategoryBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCategoryBg.TabIndex = 10;
            this.pictureBoxCategoryBg.TabStop = false;
            // 
            // panelWinScreen
            // 
            this.panelWinScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelWinScreen.Controls.Add(this.btnSaveScore);
            this.panelWinScreen.Controls.Add(this.lblPlayerName);
            this.panelWinScreen.Controls.Add(this.txtPlayerName);
            this.panelWinScreen.Controls.Add(this.lblFinalScore);
            this.panelWinScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWinScreen.Location = new System.Drawing.Point(0, 0);
            this.panelWinScreen.Name = "panelWinScreen";
            this.panelWinScreen.Size = new System.Drawing.Size(1171, 768);
            this.panelWinScreen.TabIndex = 22;
            this.panelWinScreen.Visible = false;
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveScore.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnSaveScore.ForeColor = System.Drawing.Color.White;
            this.btnSaveScore.Location = new System.Drawing.Point(104, 493);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(946, 60);
            this.btnSaveScore.TabIndex = 3;
            this.btnSaveScore.Text = "Salvar Pontuação";
            this.btnSaveScore.UseVisualStyleBackColor = false;
            this.btnSaveScore.Click += new System.EventHandler(this.BtnSaveScore_Click);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblFinalScore.Location = new System.Drawing.Point(300, 250);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(576, 37);
            this.lblFinalScore.TabIndex = 0;
            this.lblFinalScore.Text = "Pontuação final: 15 respostas certas";
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 768);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelCategorySelection);
            this.Controls.Add(this.panelWinScreen);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ATECQuiZ - Jogo da Sabedoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoryBg)).EndInit();
            this.panelCategorySelection.ResumeLayout(false);
            this.panelCategorySelection.PerformLayout();
            this.panelWinScreen.ResumeLayout(false);
            this.panelWinScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnViewScores;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCorrectAnswerMessage;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCategoryDisplay;
        private System.Windows.Forms.Timer timerPulse;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Panel panelCategorySelection;
        private System.Windows.Forms.Panel panelWinScreen;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.Button btnConfirmCategory;
        private System.Windows.Forms.Button btnBackFromCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.Label lblCategoryInstructions;
        private PictureBox pictureBoxCategoryBg;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
