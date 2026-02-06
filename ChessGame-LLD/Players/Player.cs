using ChessGame_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame_LLD.Players
{
    public class Player
    {
        public string Name { get; }
        public PieceColor Color { get; }

        public Player(string name, PieceColor color)
        {
            Name = name;
            Color = color;
        }
    }
}
