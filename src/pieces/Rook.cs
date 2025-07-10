using ChessBot.src.enums;
using ChessBot.src.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.pieces;

public class Rook(Color color) : Piece(color)
{
    public override List<Square> GetPotentialMoves()
    {
        if (Square == null) throw new ArgumentNullException(nameof(Square));

        var result = new List<Square>();
        result.AddRange(GetPotentialMoves(Direction.Plus, Direction.Equal));
        result.AddRange(GetPotentialMoves(Direction.Minus, Direction.Equal));
        result.AddRange(GetPotentialMoves(Direction.Equal, Direction.Plus));
        result.AddRange(GetPotentialMoves(Direction.Equal, Direction.Minus));
        return result;
    }

    public override string ToString() => Color == Color.White ? ((char)0x2656).ToString() : ((char)0x265C).ToString();
}
