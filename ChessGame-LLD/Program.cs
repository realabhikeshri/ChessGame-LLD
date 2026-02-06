using ChessGame_LLD.Enums;
using ChessGame_LLD.Game;
using ChessGame_LLD.Players;
using ChessGame_LLD.Utils;

class Program
{
    static void Main()
    {
        var white = new Player("White", PieceColor.White);
        var black = new Player("Black", PieceColor.Black);

        var game = new ChessGame(white, black);

        game.MakeMove(new Position(6, 0), new Position(5, 0));
        game.MakeMove(new Position(1, 0), new Position(2, 0));

        Console.WriteLine("Moves executed successfully");
    }
}
