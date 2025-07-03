using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;

namespace ChessBot.Pieces;

public abstract class Piece(Color color, int x, int y)
{
    public Color Color { get; } = color;
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    //public abstract void getM();

    public abstract void move();

    public abstract override string ToString();
}
