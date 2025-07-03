using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;
using ChessBot.Pieces;

namespace ChessBot.Game;

public class Field
{
    private Piece[,] field;

    public Field()
    {
        field = new Piece[8, 8];
        field[0, 0] = new Rook(Color.White);
    }

    public override string ToString()
    {
        string output = "";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                output += field[i, j]?.ToString() ?? " ";
            }
        }
        return output;
    }


}
