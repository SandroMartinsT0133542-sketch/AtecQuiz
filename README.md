# AtecQuiz - Jogo da Sabedoria ??

A Windows Forms quiz application built with .NET Framework 4.7.2. AtecQuiz is an interactive knowledge-testing game that challenges players with questions across multiple categories and difficulty levels.

## ?? Table of Contents

- [Features](#features)
- [System Requirements](#system-requirements)
- [Installation](#installation)
- [Application Workflow](#application-workflow)
- [Project Structure](#project-structure)
- [Key Components](#key-components)
- [Quiz Data Format](#quiz-data-format)
- [Usage Guide](#usage-guide)
- [Technical Stack](#technical-stack)

## ? Features

- **Multiple Categories**: Quiz questions organized by categories (Mix, Desporto, Cinema, História, etc.)
- **Level-Based Difficulty**: 3 progressive difficulty levels (1, 2, 3)
- **Dynamic Scoring System**: Real-time score tracking and visual feedback
- **High Score Tracking**: Persistent storage of player scores and dates
- **Time-Based Gameplay**: Progress indicator showing current question position
- **Category Selection Screen**: Interactive button-based category selection with visual feedback
- **Win Screen**: Final score display and score saving functionality
- **Responsive UI**: Clean, modern interface with color-coded buttons and status indicators

## ??? System Requirements

- **Operating System**: Windows 7 or later
- **.NET Framework**: 4.7.2
- **RAM**: 512 MB minimum
- **Disk Space**: 50 MB for application and data files
- **Display**: 1024x768 minimum resolution

## ?? Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/SandroMartinsT0133542-sketch/AtecQuiz.git
   cd AtecQuiz
   ```

2. **Build the Project**:
   - Open `AtecQuiz.sln` in Visual Studio 2019 or later
   - Ensure .NET Framework 4.7.2 is installed
   - Build the solution (Ctrl+Shift+B)

3. **Run the Application**:
   - Press F5 to start debugging, or
   - Navigate to `bin\Debug\` and run `AtecQuiz.exe`

4. **Required Files**:
   - Ensure `quiz.xml` is in the application's working directory
   - Place `highscores.txt` in the same directory (will be created automatically on first save)

## ?? Application Workflow

### 1. **Main Menu Screen**
   - Display: Application title and welcome message
   - Player enters their name in the text field
   - Two action buttons:
     - **"Iniciar Jogo"** (Start Game) - Proceeds to category selection
     - **"Ver Pontuações"** (View Scores) - Shows high scores list

### 2. **Category Selection Screen**
   - Display: "Escolha uma Categoria:" (Choose a Category)
   - Dynamic category buttons created at runtime:
     - **Button Specifications**:
       - Size: 300px × 80px
       - Style: Colored buttons (RoyalBlue default)
       - Hover Effect: Color brightens on mouse enter
       - Selection: Changes to orange when selected
     - **Categories Displayed**: Mix, Desporto, Cinema, História
   - Navigation Buttons:
     - **"Iniciar Jogo"** (green) - Starts quiz with selected category
     - **"Voltar"** (red) - Returns to main menu

### 3. **Game/Quiz Screen**
   - **Question Display**: Large text showing the quiz question
   - **Answer Buttons**: Four answer options with selection highlighting
   - **Score Tracking**: 
     - Current score displayed in top-right
     - Current level/difficulty shown
   - **Progress Indicator**: Shows current question number (e.g., "Progresso: 1/5")
   - **Time Progress**: Visual progress bar
   - **Navigation**:
     - **"Próxima Pergunta"** (Next Question) - Visible after answer submission
     - **"Menu Principal"** (Main Menu) - Exit current game

### 4. **Win Screen**
   - **Final Score Display**: Shows total correct answers
   - **Player Name Input**: Text field for saving the score
   - **Save Button**: Saves the score to `highscores.txt`
   - Automatic return to main menu after score save

## ?? Project Structure

```
AtecQuiz/
??? AtecQuiz.csproj                 # Project configuration
??? Program.cs                      # Application entry point
??? Form1.cs                        # Main form logic and event handlers
??? Form1.Designer.cs               # UI layout and control definitions
??? QuizManager.cs                  # Quiz data loading and management
??? Question.cs                     # Question data model
??? HighScoreManager.cs             # Score persistence
??? Properties/
?   ??? AssemblyInfo.cs
?   ??? Resources.Designer.cs       # Embedded images (quiz_bg, quiz_ready)
?   ??? Settings.Designer.cs
??? quiz.xml                        # Quiz questions data file
??? highscores.txt                  # High scores storage (auto-created)
??? README.md                       # This file
```

## ?? Key Components

### **Program.cs**
- Application entry point
- Initializes Windows Forms
- Launches the main Form1

### **Form1.cs & Form1.Designer.cs**
- **Form1.cs**: Core game logic including:
  - Event handlers for button clicks
  - Game state management
  - Score calculation
  - Category and question loading

- **Form1.Designer.cs**: UI layout with four main panels:
  - `panelMenu`: Main menu with player name input
  - `panelCategorySelection`: Category button selection interface
  - `panelGame`: Quiz question and answer display
  - `panelWinScreen`: Final score and saving

### **QuizManager.cs**
- Loads questions from `quiz.xml`
- Manages categories and questions retrieval
- Filters questions by category and level
- Randomizes question selection

### **Question.cs**
- Data model for quiz questions
- Properties: ID, Category, Level, Text, Answers, Correct Answer

### **HighScoreManager.cs**
- Loads/saves high scores from `highscores.txt`
- Maintains persistent score history
- HighScoreEntry structure: PlayerName | Score | Date

## ?? Quiz Data Format

The `quiz.xml` file follows this hierarchical structure:

```xml
<?xml version="1.0" encoding="utf-8"?>
<quiz>
  <questions>
    <category name="Desporto">
      <level number="1">
        <question id="1">
          <text>Question text here?</text>
          <answers>
            <answer correct="false">Incorrect answer 1</answer>
            <answer correct="false">Incorrect answer 2</answer>
            <answer correct="true">Correct answer</answer>
            <answer correct="false">Incorrect answer 4</answer>
          </answers>
        </question>
        <!-- More questions... -->
      </level>
      <level number="2">
        <!-- Level 2 questions... -->
      </level>
      <level number="3">
        <!-- Level 3 questions... -->
      </level>
    </category>
    <!-- More categories... -->
  </questions>
</quiz>
```

**Key Elements**:
- `category name`: Must match category button text
- `level number`: Difficulty level (1, 2, or 3)
- `question id`: Unique identifier
- `answer correct`: Boolean indicating correct answer

## ?? Usage Guide

### **Playing the Quiz**

1. Read the displayed question carefully
2. Click one of the four answer buttons to make your selection
3. The selected answer will be highlighted in orange
4. Review feedback (correct/incorrect message may be displayed)
5. Click **"Próxima Pergunta"** to continue to the next question
6. After completing all questions, the win screen appears

### **Saving Your Score**

1. After finishing the quiz, the final score is displayed
2. The system may prompt you to enter your name for the score
3. Click **"Salvar Pontuação"** to save your score permanently
4. Your score is added to `highscores.txt`

### **Viewing High Scores**

1. From the main menu, click **"Ver Pontuações"**
2. View the list of saved high scores with dates

