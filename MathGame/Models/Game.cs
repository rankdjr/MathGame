using System.Security.AccessControl;

namespace MathGame.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType GameType { get; set; } // This already exists and fits perfectly
    public DifficultyLevel DifficultyLevel { get; set; } // Continue using this to dictate the difficulty across the game
}
