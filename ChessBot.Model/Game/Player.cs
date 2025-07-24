using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Model.Enums;

namespace ChessBot.Model.Game;

internal class Player(Color color)
{
    public Color Color { get; } = color;
}
