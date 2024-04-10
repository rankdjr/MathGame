namespace MathGame.Models;

internal class Question
{
    public required int FirstNumber { get; set; }
    public required int SecondNumber { get; set; }
    public required string OperationSymbol { get; set; }
    public required int CorrectAnswer { get; set; }

}
