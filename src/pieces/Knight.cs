using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;

namespace ChessBot.Pieces;

internal class Knight : Piece
{
    public Knight(Color color) : base(color)
    {

    }

    public override void move()
    {
        throw new NotImplementedException();
    }

    public override string ToString() => Color == Color.White ? ((char)0x2658).ToString() : ((char)0x265E).ToString();
}
