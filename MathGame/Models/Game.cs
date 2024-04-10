using System.Security.AccessControl;

namespace MathGame.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType GameType { get; set; } 
    public DifficultyLevel DifficultyLevel { get; set; }
}
