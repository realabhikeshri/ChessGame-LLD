using ChessGame_LLD.Board;
using ChessGame_LLD.Enums;
using ChessGame_LLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Pieces
{
    public abstract class ChessPiece
    {
        public PieceColor Color { get; }

        protected ChessPiece(PieceColor color)
        {
            Color = color;
        }

        public abstract bool CanMove(
            ChessBoard board,
            Position from,
            Position to);
    }
}
