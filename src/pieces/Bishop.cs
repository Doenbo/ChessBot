using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;

namespace ChessBot.Pieces;

internal class Bishop : Piece
{
    public Bishop(Color color) : base(color)
    {

    }

    public override void move()
    {
        throw new NotImplementedException();
    }

    public override string ToString() => Color == Color.White? ((char)0x2657).ToString() : ((char)0x265D).ToString();
    
}
