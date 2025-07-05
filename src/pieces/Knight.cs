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
        return new List<Square>
        {
            new Square(Square.Rank-2, Square.File-1),
            new Square(Square.Rank-2, Square.File+1),
            new Square(Square.Rank-1, Square.File-2),
            new Square(Square.Rank-1, Square.File+2),
            new Square(Square.Rank+1, Square.File-2),
            new Square(Square.Rank+1, Square.File+2),
            new Square(Square.Rank+2, Square.File-1),
            new Square(Square.Rank+2, Square.File+1),
        };
    }

    public override string ToString() => Color == Color.White ? ((char)0x2658).ToString() : ((char)0x265E).ToString();
}
