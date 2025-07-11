﻿using ChessBot.src.enums;
using ChessBot.src.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.pieces;

internal class Bishop(Color color) : Piece(color)
{
    public override List<Square> GetPotentialMoves()
    {
        if (Square == null) throw new ArgumentNullException(nameof(Square));

        var result = new List<Square>();
        result.AddRange(GetPotentialMoves(Direction.Plus, Direction.Plus));
        result.AddRange(GetPotentialMoves(Direction.Minus, Direction.Minus));
        result.AddRange(GetPotentialMoves(Direction.Plus, Direction.Minus));
        result.AddRange(GetPotentialMoves(Direction.Minus, Direction.Plus));
        return result;
    }

    public override string ToString() => Color == Color.White? ((char)0x2657).ToString() : ((char)0x265D).ToString();
}
