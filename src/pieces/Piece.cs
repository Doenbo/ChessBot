using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;

namespace ChessBot.Pieces;

public abstract class Piece
{
    protected Piece(Color color)
    {
        Color = color;
    }

    public Color Color { get; }

    public abstract void move();

    public abstract override string ToString();
}
