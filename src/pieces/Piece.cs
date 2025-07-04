using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChessBot.src.enums;
using ChessBot.src.game;

namespace ChessBot.src.pieces;

public abstract class Piece(Color color)
{
    public Color Color { get; } = color;

    public Square? Square { get; set; }

    public abstract List<Square> GetPotentialMoves();

    public abstract override string ToString();
}
