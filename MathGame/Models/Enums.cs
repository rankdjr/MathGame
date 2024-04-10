namespace MathGame.Models;

internal enum GameState
{
    MainMenu,
    GameHistory,
    QuestionTypeSelection,
    Settings,
    Standard,
    Survival,
    QuitGame
}

internal enum GameType
{
    Standard,
    Survival,
}

internal enum DifficultyLevel
{
    Easy,
    Medium,
    Hard,
    Insane,
}

internal enum QuestionType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
}

