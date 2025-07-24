using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Model.Enums;
using ChessBot.Model.Game;

namespace ChessBot.Model.Pieces;

public abstract class Piece(Color color)
{
    public Color Color { get; } = color;

    public Position? Position { get; set; }

    public abstract List<Position> GetPotentialMoves();

    protected enum Direction
    {
        Plus,
        Minus,
        Equal
    }

    protected List<Position> GetPotentialMoves(Direction rank, Direction file)
    {
        if (Position == null) throw new ArgumentNullException(nameof(Square));

        var result = new List<Position>();
        int i = 1;
        while (i <= 7)
        {
            if (0 == 1) { }
            //+=
            else if (rank == Direction.Plus && file == Direction.Equal && Position.Rank + i <= 7)
            { result.Add(new Position(Position.Rank + i, Position.File)); i++; }
            //-=
            else if (rank == Direction.Minus && file == Direction.Equal && Position.Rank - i >= 0)
            { result.Add(new Position(Position.Rank - i, Position.File)); i++; }
            //=+
            else if (rank == Direction.Equal && file == Direction.Plus && Position.File + i <= 7)
            { result.Add(new Position(Position.Rank, Position.File + i)); i++; }
            //=-
            else if (rank == Direction.Equal && file == Direction.Minus && Position.File - i >= 0)
            { result.Add(new Position(Position.Rank, Position.File - i)); i++; }
            //++
            else if (rank == Direction.Plus && file == Direction.Plus && Position.Rank + i <= 7 && Position.File + i <= 7)
            { result.Add(new Position(Position.Rank + i, Position.File + i)); i++; }
            //--
            else if (rank == Direction.Minus && file == Direction.Minus && Position.Rank - i >= 0 && Position.File - i >= 0)
            { result.Add(new Position(Position.Rank - i, Position.File - i)); i++; }
            //+-
            else if (rank == Direction.Plus && file == Direction.Minus && Position.Rank + i <= 7 && Position.File - i >= 0)
            { result.Add(new Position(Position.Rank + i, Position.File - i)); i++; }
            //-+
            else if (rank == Direction.Minus && file == Direction.Plus && Position.Rank - i >= 0 && Position.File + i <= 7)
            { result.Add(new Position(Position.Rank - i, Position.File + i)); i++; }
            else
            { break; }
        }
        return result;
    }

    public abstract override string ToString();
}
