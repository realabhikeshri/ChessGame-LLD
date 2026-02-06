using ChessGame_LLD.Enums;
using ChessGame_LLD.Pieces;
using ChessGame_LLD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Board
{
    public class ChessBoard
    {
        public Cell[,] Grid { get; } = new Cell[8, 8];

        public ChessBoard()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    Grid[i, j] = new Cell();
        }

        public ChessPiece GetPiece(Position pos) =>
            Grid[pos.Row, pos.Col].Piece;

        public void MovePiece(Position from, Position to)
        {
            Grid[to.Row, to.Col].Piece = Grid[from.Row, from.Col].Piece;
            Grid[from.Row, from.Col].Piece = null;
        }

        public bool IsInside(Position p) =>
            p.Row >= 0 && p.Row < 8 && p.Col >= 0 && p.Col < 8;

        public void Initialize()
        {
            // Pawns
            for (int i = 0; i < 8; i++)
            {
                Grid[1, i].Piece = new Pawn(PieceColor.Black);
                Grid[6, i].Piece = new Pawn(PieceColor.White);
            }

            // Rooks
            Grid[0, 0].Piece = new Rook(PieceColor.Black);
            Grid[0, 7].Piece = new Rook(PieceColor.Black);
            Grid[7, 0].Piece = new Rook(PieceColor.White);
            Grid[7, 7].Piece = new Rook(PieceColor.White);

            // Knights
            Grid[0, 1].Piece = new Knight(PieceColor.Black);
            Grid[0, 6].Piece = new Knight(PieceColor.Black);
            Grid[7, 1].Piece = new Knight(PieceColor.White);
            Grid[7, 6].Piece = new Knight(PieceColor.White);

            // Bishops
            Grid[0, 2].Piece = new Bishop(PieceColor.Black);
            Grid[0, 5].Piece = new Bishop(PieceColor.Black);
            Grid[7, 2].Piece = new Bishop(PieceColor.White);
            Grid[7, 5].Piece = new Bishop(PieceColor.White);

            // Queens
            Grid[0, 3].Piece = new Queen(PieceColor.Black);
            Grid[7, 3].Piece = new Queen(PieceColor.White);

            // Kings
            Grid[0, 4].Piece = new King(PieceColor.Black);
            Grid[7, 4].Piece = new King(PieceColor.White);
        }

    }
}
