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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblCategoryDisplay = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblCorrectAnswerMessage = new System.Windows.Forms.Label();
            this.timerPulse = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(23, 219);
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
            this.comboBoxCategory.Location = new System.Drawing.Point(197, 217);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(814, 25);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnStartGame.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(27, 648);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(984, 60);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Iniciar Jogo";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            this.btnStartGame.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
            this.btnStartGame.MouseLeave += new System.EventHandler(this.btnStartGame_MouseLeave);
            // 
            // btnViewScores
            // 
            this.btnViewScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnViewScores.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnViewScores.ForeColor = System.Drawing.Color.White;
            this.btnViewScores.Location = new System.Drawing.Point(27, 714);
            this.btnViewScores.Name = "btnViewScores";
            this.btnViewScores.Size = new System.Drawing.Size(984, 60);
            this.btnViewScores.TabIndex = 4;
            this.btnViewScores.Text = "Ver Pontuações";
            this.btnViewScores.UseVisualStyleBackColor = false;
            this.btnViewScores.Click += new System.EventHandler(this.btnViewScores_Click);
            this.btnViewScores.MouseEnter += new System.EventHandler(this.btnViewScores_MouseEnter);
            this.btnViewScores.MouseLeave += new System.EventHandler(this.btnViewScores_MouseLeave);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(290, 138);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(10);
            this.lblQuestion.Size = new System.Drawing.Size(646, 65);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Pergunta?";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAnswer1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer1.ForeColor = System.Drawing.Color.White;
            this.btnAnswer1.Location = new System.Drawing.Point(200, 364);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer1.TabIndex = 8;
            this.btnAnswer1.Text = "A) Resposta 1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer1.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer1.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAnswer2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer2.ForeColor = System.Drawing.Color.White;
            this.btnAnswer2.Location = new System.Drawing.Point(580, 364);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer2.TabIndex = 9;
            this.btnAnswer2.Text = "B) Resposta 2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer2.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer2.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAnswer3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer3.ForeColor = System.Drawing.Color.White;
            this.btnAnswer3.Location = new System.Drawing.Point(200, 429);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer3.TabIndex = 10;
            this.btnAnswer3.Text = "C) Resposta 3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer3.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer3.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAnswer4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnswer4.ForeColor = System.Drawing.Color.White;
            this.btnAnswer4.Location = new System.Drawing.Point(580, 429);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(353, 50);
            this.btnAnswer4.TabIndex = 11;
            this.btnAnswer4.Text = "D) Resposta 4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Visible = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer4.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer4.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblScore.Location = new System.Drawing.Point(764, 262);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(90, 18);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Acertos: 0/5";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblLevel.Location = new System.Drawing.Point(860, 262);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(73, 18);
            this.lblLevel.TabIndex = 16;
            this.lblLevel.Text = "Nível: 1/3";
            this.lblLevel.Click += new System.EventHandler(this.lblLevel_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lblCategory);
            this.panelMenu.Controls.Add(this.comboBoxCategory);
            this.panelMenu.Controls.Add(this.lblPlayerName);
            this.panelMenu.Controls.Add(this.txtPlayerName);
            this.panelMenu.Controls.Add(this.btnStartGame);
            this.panelMenu.Controls.Add(this.btnViewScores);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1061, 817);
            this.panelMenu.TabIndex = 19;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.Location = new System.Drawing.Point(23, 260);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(150, 19);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Insira o seu nome:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPlayerName.Location = new System.Drawing.Point(197, 260);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(814, 24);
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
            this.panelGame.Size = new System.Drawing.Size(1061, 817);
            this.panelGame.TabIndex = 20;
            this.panelGame.Visible = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMainMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(9, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(57, 46);
            this.btnMainMenu.TabIndex = 14;
            this.btnMainMenu.Text = "<<";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblCategoryDisplay
            // 
            this.lblCategoryDisplay.AutoSize = true;
            this.lblCategoryDisplay.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategoryDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblCategoryDisplay.Location = new System.Drawing.Point(197, 319);
            this.lblCategoryDisplay.Name = "lblCategoryDisplay";
            this.lblCategoryDisplay.Size = new System.Drawing.Size(110, 18);
            this.lblCategoryDisplay.TabIndex = 18;
            this.lblCategoryDisplay.Text = "Categoria: Mix";
            this.lblCategoryDisplay.Click += new System.EventHandler(this.lblCategoryDisplay_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.LightGray;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.progressBar.Location = new System.Drawing.Point(294, 219);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(640, 10);
            this.progressBar.TabIndex = 19;
            this.progressBar.Value = 20;
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new System.Drawing.Font("Arial", 9F);
            this.lblRemainingTime.ForeColor = System.Drawing.Color.Gray;
            this.lblRemainingTime.Location = new System.Drawing.Point(846, 235);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(88, 15);
            this.lblRemainingTime.TabIndex = 20;
            this.lblRemainingTime.Text = "Progresso: 1/5";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNextQuestion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnNextQuestion.ForeColor = System.Drawing.Color.White;
            this.btnNextQuestion.Location = new System.Drawing.Point(200, 487);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(733, 50);
            this.btnNextQuestion.TabIndex = 13;
            this.btnNextQuestion.Text = "Próxima Pergunta";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Visible = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblCorrectAnswerMessage
            // 
            this.lblCorrectAnswerMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectAnswerMessage.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblCorrectAnswerMessage.Location = new System.Drawing.Point(311, 12);
            this.lblCorrectAnswerMessage.Name = "lblCorrectAnswerMessage";
            this.lblCorrectAnswerMessage.Size = new System.Drawing.Size(700, 77);
            this.lblCorrectAnswerMessage.TabIndex = 18;
            this.lblCorrectAnswerMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1060, 186);
            this.label1.TabIndex = 7;
            this.label1.Text = "ATECQuiZ\r\nJogo da Sabedoria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AtecQuiz.Properties.Resources.quiz_ready3;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 708);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 817);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ATECQuiZ - Jogo da Sabedoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label label1;
        private PictureBox pictureBox1;
    }
}
