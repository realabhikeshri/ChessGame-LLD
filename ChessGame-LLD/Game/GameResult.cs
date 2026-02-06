using ChessGame_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Game
{
    public class GameResult
    {
        public GameState State { get; set; }
        public PieceColor? Winner { get; set; }
    }
}
