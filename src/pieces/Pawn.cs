using ChessBot.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;

namespace ChessBot.Pieces;

internal class Pawn : Piece
{
    public Pawn(Color color) : base(color)
    {

    }

    public override void move()
    {
        throw new NotImplementedException();
    }

    public override string ToString() => Color == Color.White ? ((char)0x2659).ToString() : ((char)0x265F).ToString();
}