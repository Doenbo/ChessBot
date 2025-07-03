using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;

namespace ChessBot.Pieces;

public class King(Color color, int x, int y) : Piece(color, x, y)
{ 
    public override void move()
    {
        throw new NotImplementedException();
    }

    public override string ToString() => Color == Color.White ? ((char)0x2654).ToString() : ((char)0x265A).ToString();
}
