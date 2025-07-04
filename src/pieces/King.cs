using ChessBot.src.enums;
using ChessBot.src.game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.pieces;

public class King(Color color) : Piece(color)
{
    public override List<Square> GetPotentialMoves() { return new List<Square>(); }

    public override string ToString() => Color == Color.White ? ((char)0x2654).ToString() : ((char)0x265A).ToString();
}
