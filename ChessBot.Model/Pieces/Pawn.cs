using ChessBot.Model.Enums;
using ChessBot.Model.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.Model.Pieces;

internal class Pawn(Color color) : Piece(color)
{
    public override List<Position> GetPotentialMoves()
    {
        if (Position == null) throw new ArgumentNullException(nameof(Position));

        var result = new List<Position>();
        if (Color == Color.White)
        {
            if (Position.Rank - 1 >= 0) { result.Add(new Position(Position.Rank - 1, Position.File)); }
            if (Position.Rank - 2 >= 0) { result.Add(new Position(Position.Rank - 2, Position.File)); }
            if (Position.Rank - 1 >= 0 && Position.File + 1 <= 7) { result.Add(new Position(Position.Rank - 1, Position.File + 1)); }
            if (Position.Rank - 1 >= 0 && Position.File - 1 >= 0) { result.Add(new Position(Position.Rank - 1, Position.File - 1)); }
        }
        else
        {
            if (Position.Rank + 1 <= 7) { result.Add(new Position(Position.Rank + 1, Position.File)); }
            if (Position.Rank + 2 <= 7) { result.Add(new Position(Position.Rank + 2, Position.File)); }
            if (Position.Rank + 1 <= 7 && Position.File + 1 <= 7) { result.Add(new Position(Position.Rank + 1, Position.File + 1)); }
            if (Position.Rank + 1 <= 7 && Position.File - 1 >= 0) { result.Add(new Position(Position.Rank + 1, Position.File - 1)); }
        }

        return result;
    }

    public override string ToString() => Color == Color.White ? ((char)0x2659).ToString() : ((char)0x265F).ToString();
}