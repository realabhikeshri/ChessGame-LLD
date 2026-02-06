using ChessGame_LLD.Board;
using ChessGame_LLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Pieces
{
    public class Pawn : ChessPiece
    {
        public Pawn(Enums.PieceColor color) : base(color) { }

        public override bool CanMove(ChessBoard board, Position from, Position to)
        {
            int dir = Color == Enums.PieceColor.White ? -1 : 1;
            return from.Col == to.Col && to.Row - from.Row == dir;
        }
    }
}
