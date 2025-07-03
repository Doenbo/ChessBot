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

        field[0, 0] = new Rook(Color.Black);
        field[0, 1] = new Knight(Color.Black);
        field[0, 2] = new Bishop(Color.Black);
        field[0, 3] = new Queen(Color.Black);
        field[0, 4] = new King(Color.Black);
        field[0, 5] = new Bishop(Color.Black);
        field[0, 6] = new Knight(Color.Black);
        field[0, 7] = new Rook(Color.Black);

        field[1, 0] = new Pawn(Color.Black);
        field[1, 1] = new Pawn(Color.Black);
        field[1, 2] = new Pawn(Color.Black);
        field[1, 3] = new Pawn(Color.Black);
        field[1, 4] = new Pawn(Color.Black);
        field[1, 5] = new Pawn(Color.Black);
        field[1, 6] = new Pawn(Color.Black);
        field[1, 7] = new Pawn(Color.Black);

        field[6, 0] = new Pawn(Color.White);
        field[6, 1] = new Pawn(Color.White);
        field[6, 2] = new Pawn(Color.White);
        field[6, 3] = new Pawn(Color.White);
        field[6, 4] = new Pawn(Color.White);
        field[6, 5] = new Pawn(Color.White);
        field[6, 6] = new Pawn(Color.White);
        field[6, 7] = new Pawn(Color.White);

        field[7, 0] = new Rook(Color.White);
        field[7, 1] = new Knight(Color.White);
        field[7, 2] = new Bishop(Color.White);
        field[7, 3] = new Queen(Color.White);
        field[7, 4] = new King(Color.White);
        field[7, 5] = new Bishop(Color.White);
        field[7, 6] = new Knight(Color.White);
        field[7, 7] = new Rook(Color.White);
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
            output += "\n";
        }
        return output;
    }


}
