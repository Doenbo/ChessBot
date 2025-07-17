using ChessBot.src.enums;
using ChessBot.src.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.pieces;

public class King(Color color) : Piece(color)
{
    public override List<Position> GetPotentialMoves()
    {
        if (Position == null) throw new ArgumentNullException(nameof(Position));

        var result = new List<Position>();
        if (Position.Rank - 1 >= 0 && Position.File - 1 >= 0) { result.Add(new Position(Position.Rank - 1, Position.File - 1)); }
        if (Position.Rank - 1 >= 0 && Position.File + 1 <= 7) { result.Add(new Position(Position.Rank - 1, Position.File + 1)); }
        if (Position.Rank + 1 <= 7 && Position.File - 1 >= 0) { result.Add(new Position(Position.Rank + 1, Position.File - 1)); }
        if (Position.Rank + 1 <= 7 && Position.File + 1 <= 7) { result.Add(new Position(Position.Rank + 1, Position.File + 1)); }
        if (Position.Rank - 1 >= 0 ) { result.Add(new Position(Position.Rank - 1, Position.File)); }
        if (Position.Rank + 1 <= 7 ) { result.Add(new Position(Position.Rank + 1, Position.File)); }
        if (Position.File - 1 >= 0 ) { result.Add(new Position(Position.Rank, Position.File - 1)); }
        if (Position.File + 1 <= 7 ) { result.Add(new Position(Position.Rank, Position.File + 1)); }
        return result;
    }

    public override string ToString() => Color == Color.White ? ((char)0x2654).ToString() : ((char)0x265A).ToString();
}
