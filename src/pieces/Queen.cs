using ChessBot.src.enums;
using ChessBot.src.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.pieces;

internal class Queen(Color color) : Piece(color)
{
    public override List<Position> GetPotentialMoves()
    {
        if (Position == null) throw new ArgumentNullException(nameof(Position));
        
        var result = new List<Position>();
        result.AddRange(GetPotentialMoves(Direction.Plus, Direction.Equal));
        result.AddRange(GetPotentialMoves(Direction.Minus, Direction.Equal));
        result.AddRange(GetPotentialMoves(Direction.Equal, Direction.Plus));
        result.AddRange(GetPotentialMoves(Direction.Equal, Direction.Minus));
        result.AddRange(GetPotentialMoves(Direction.Plus, Direction.Plus));
        result.AddRange(GetPotentialMoves(Direction.Minus, Direction.Minus));
        result.AddRange(GetPotentialMoves(Direction.Plus, Direction.Minus));
        result.AddRange(GetPotentialMoves(Direction.Minus, Direction.Plus));
        return result;
    }

    public override string ToString() => Color == Color.White ? ((char)0x2655).ToString() : ((char)0x265B).ToString();
}