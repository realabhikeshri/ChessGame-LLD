using ChessGame_LLD.Board;
using ChessGame_LLD.Enums;
using ChessGame_LLD.Players;
using ChessGame_LLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Game
{
    public class ChessGame
    {
        private readonly ChessBoard _board;
        private Player _current;

        public ChessGame(Player white, Player black)
        {
            _board = new ChessBoard();
            _board.Initialize();
            _current = white;
        }

        public void MakeMove(Position from, Position to)
        {
            var piece = _board.GetPiece(from);
            if (piece == null || piece.Color != _current.Color)
                throw new Exception("Invalid move");

            if (!piece.CanMove(_board, from, to))
                throw new Exception("Illegal move");

            _board.MovePiece(from, to);
            _current = _current.Color == PieceColor.White ?
                       new Player("Black", PieceColor.Black) :
                       new Player("White", PieceColor.White);
        }
    }
}
