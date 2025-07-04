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
            new Square(Square.File-2, Square.Rank-1),
            new Square(Square.File-2, Square.Rank+1),
            new Square(Square.File-1, Square.Rank-2),
            new Square(Square.File-1, Square.Rank+2),
            new Square(Square.File+1, Square.Rank-2),
            new Square(Square.File+1, Square.Rank+2),
            new Square(Square.File+2, Square.Rank-1),
            new Square(Square.File+2, Square.Rank+1),
        };
    }

    public override string ToString() => Color == Color.White ? ((char)0x2658).ToString() : ((char)0x265E).ToString();
}
