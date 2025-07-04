using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.src.enums;

namespace ChessBot.src.game;

internal class Player(Color color)
{
    public Color Color { get; } = color;
}
