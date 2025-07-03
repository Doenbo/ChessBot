using ChessBot.Enums;
using ChessBot.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.Pieces;

internal class Queen : Piece
{
    public Queen(Color color) : base(color)
    {

    }

    public override void move()
    {
        throw new NotImplementedException();
    }

    public override string ToString() => Color == Color.White ? ((char)0x2655).ToString() : ((char)0x265B).ToString();
}