using ChessBot.src.enums;
using ChessBot.src.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.pieces;

internal class Pawn(Color color) : Piece(color)
{
    public override List<Square> GetPotentialMoves()
    {
        if (Square == null) throw new ArgumentNullException(nameof(Square));

        var result = new List<Square>();
        if (Color == Color.White)
        {
            if (Square.Rank - 1 >= 0) { result.Add(new Square(Square.Rank - 1, Square.File)); }
            if (Square.Rank - 2 >= 0) { result.Add(new Square(Square.Rank - 2, Square.File)); }
            if (Square.Rank - 1 >= 0 && Square.File + 1 <= 7) { result.Add(new Square(Square.Rank - 1, Square.File + 1)); }
            if (Square.Rank - 1 >= 0 && Square.File - 1 >= 0) { result.Add(new Square(Square.Rank - 1, Square.File - 1)); }
        }
        else
        {
            if (Square.Rank + 1 <= 7) { result.Add(new Square(Square.Rank + 1, Square.File)); }
            if (Square.Rank + 2 <= 7) { result.Add(new Square(Square.Rank + 2, Square.File)); }
            if (Square.Rank + 1 <= 7 && Square.File + 1 <= 7) { result.Add(new Square(Square.Rank + 1, Square.File + 1)); }
            if (Square.Rank + 1 <= 7 && Square.File - 1 >= 0) { result.Add(new Square(Square.Rank + 1, Square.File - 1)); }
        }

        return result;
    }

    public override string ToString() => Color == Color.White ? ((char)0x2659).ToString() : ((char)0x265F).ToString();
}