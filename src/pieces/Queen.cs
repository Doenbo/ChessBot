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
    public override List<Square> GetPotentialMoves()
    {
        if (Square == null) throw new ArgumentNullException(nameof(Square));
        
        var result = new List<Square>();
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

    private enum Direction
    {
        Plus,
        Minus,
        Equal
    }

    private List<Square> GetPotentialMoves(Direction rank, Direction file)
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

    public override string ToString() => Color == Color.White ? ((char)0x2655).ToString() : ((char)0x265B).ToString();
}