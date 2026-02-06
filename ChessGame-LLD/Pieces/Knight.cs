using ChessGame_LLD.Board;
using ChessGame_LLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Pieces
{
    public class Knight : ChessPiece
    {
        public Knight(Enums.PieceColor color) : base(color) { }

        public override bool CanMove(ChessBoard board, Position from, Position to)
        {
            int r = Math.Abs(from.Row - to.Row);
            int c = Math.Abs(from.Col - to.Col);
            return (r == 2 && c == 1) || (r == 1 && c == 2);
        }
    }
}
