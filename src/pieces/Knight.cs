using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.src.enums;

namespace ChessBot.src.pieces;

internal class Knight(Color color) : Piece(color)
{
    public override void Move()
    {
        throw new NotImplementedException();
    }

    public override string ToString() => Color == Color.White ? ((char)0x2658).ToString() : ((char)0x265E).ToString();
}
