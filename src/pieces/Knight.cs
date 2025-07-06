using ChessBot.src.enums;
using ChessBot.src.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.pieces;

internal class Knight(Color color) : Piece(color)
{
    public override List<Square> GetPotentialMoves()
    {
        if (Square == null) throw new ArgumentNullException(nameof(Square));

        var result = new List<Square>();
        if (Square.Rank - 2 >= 0 && Square.File - 1 >= 0) { result.Add(new Square(Square.Rank - 2, Square.File - 1)); }
        if (Square.Rank - 2 >= 0 && Square.File + 1 <= 7) { result.Add(new Square(Square.Rank - 2, Square.File + 1)); }
        if (Square.Rank - 1 >= 0 && Square.File - 2 >= 0) { result.Add(new Square(Square.Rank - 1, Square.File - 2)); }
        if (Square.Rank - 1 >= 0 && Square.File + 2 <= 7) { result.Add(new Square(Square.Rank - 1, Square.File + 2)); }
        if (Square.Rank + 1 <= 7 && Square.File - 2 >= 0) { result.Add(new Square(Square.Rank + 1, Square.File - 2)); }
        if (Square.Rank + 1 <= 7 && Square.File + 2 <= 7) { result.Add(new Square(Square.Rank + 1, Square.File + 2)); }
        if (Square.Rank + 2 <= 7 && Square.File - 1 >= 0) { result.Add(new Square(Square.Rank + 2, Square.File - 1)); }
        if (Square.Rank + 2 <= 7 && Square.File + 1 <= 7) { result.Add(new Square(Square.Rank + 2, Square.File + 1)); }
        return result;
    }

    public override string ToString() => Color == Color.White ? ((char)0x2658).ToString() : ((char)0x265E).ToString();
}
