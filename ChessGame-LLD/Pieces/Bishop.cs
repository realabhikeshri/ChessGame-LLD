using ChessGame_LLD.Board;
using ChessGame_LLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Pieces
{
    public class Bishop : ChessPiece
    {
        public Bishop(Enums.PieceColor color) : base(color) { }

        public override bool CanMove(ChessBoard board, Position from, Position to)
        {
            return Math.Abs(from.Row - to.Row) ==
                   Math.Abs(from.Col - to.Col);
        }
    }
}
