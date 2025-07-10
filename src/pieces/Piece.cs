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

    protected enum Direction
    {
        Plus,
        Minus,
        Equal
    }

    protected List<Square> GetPotentialMoves(Direction rank, Direction file)
    {
        if (Square == null) throw new ArgumentNullException(nameof(Square));

        var result = new List<Square>();
        int i = 1;
        while (i <= 7)
        {
            if (0 == 1) { }
            //+=
            else if (rank == Direction.Plus && file == Direction.Equal && Square.Rank + i <= 7)
            { result.Add(new Square(Square.Rank + i, Square.File)); i++; }
            //-=
            else if (rank == Direction.Minus && file == Direction.Equal && Square.Rank - i >= 0)
            { result.Add(new Square(Square.Rank - i, Square.File)); i++; }
            //=+
            else if (rank == Direction.Equal && file == Direction.Plus && Square.File + i <= 7)
            { result.Add(new Square(Square.Rank, Square.File + i)); i++; }
            //=-
            else if (rank == Direction.Equal && file == Direction.Minus && Square.File - i >= 0)
            { result.Add(new Square(Square.Rank, Square.File - i)); i++; }
            //++
            else if (rank == Direction.Plus && file == Direction.Plus && Square.Rank + i <= 7 && Square.File + i <= 7)
            { result.Add(new Square(Square.Rank + i, Square.File + i)); i++; }
            //--
            else if (rank == Direction.Minus && file == Direction.Minus && Square.Rank - i >= 0 && Square.File - i >= 0)
            { result.Add(new Square(Square.Rank - i, Square.File - i)); i++; }
            //+-
            else if (rank == Direction.Plus && file == Direction.Minus && Square.Rank + i <= 7 && Square.File - i >= 0)
            { result.Add(new Square(Square.Rank + i, Square.File - i)); i++; }
            //-+
            else if (rank == Direction.Minus && file == Direction.Plus && Square.Rank - i >= 0 && Square.File + i <= 7)
            { result.Add(new Square(Square.Rank - i, Square.File + i)); i++; }
            else
            { break; }
        }
        return result;
    }

    public abstract override string ToString();
}
