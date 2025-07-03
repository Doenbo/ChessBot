using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Enums;
using ChessBot.Pieces;

namespace ChessBot.Game;

public class Board
{
    private Piece[,] board;

    public Board()
    {
        board = new Piece[8, 8];

        board[0, 0] = new Rook(Color.Black, 0, 0);
        board[0, 1] = new Knight(Color.Black, 0, 0);
        board[0, 2] = new Bishop(Color.Black, 0, 0);
        board[0, 3] = new Queen(Color.Black, 0, 0);
        board[0, 4] = new King(Color.Black, 0, 0);
        board[0, 5] = new Bishop(Color.Black, 0, 0);
        board[0, 6] = new Knight(Color.Black, 0, 0);
        board[0, 7] = new Rook(Color.Black, 0, 0);

        board[1, 0] = new Pawn(Color.Black, 0, 0);
        board[1, 1] = new Pawn(Color.Black, 0, 0);
        board[1, 2] = new Pawn(Color.Black, 0, 0);
        board[1, 3] = new Pawn(Color.Black, 0, 0);
        board[1, 4] = new Pawn(Color.Black, 0, 0);
        board[1, 5] = new Pawn(Color.Black, 0, 0);
        board[1, 6] = new Pawn(Color.Black, 0, 0);
        board[1, 7] = new Pawn(Color.Black, 0, 0);

        board[6, 0] = new Pawn(Color.White, 0, 0);
        board[6, 1] = new Pawn(Color.White, 0, 0);
        board[6, 2] = new Pawn(Color.White, 0, 0);
        board[6, 3] = new Pawn(Color.White, 0, 0);
        board[6, 4] = new Pawn(Color.White, 0, 0);
        board[6, 5] = new Pawn(Color.White, 0, 0);
        board[6, 6] = new Pawn(Color.White, 0, 0);
        board[6, 7] = new Pawn(Color.White, 0, 0);

        board[7, 0] = new Rook(Color.White, 0, 0);
        board[7, 1] = new Knight(Color.White, 0, 0);
        board[7, 2] = new Bishop(Color.White, 0, 0);
        board[7, 3] = new Queen(Color.White, 0, 0);
        board[7, 4] = new King(Color.White, 0, 0);
        board[7, 5] = new Bishop(Color.White, 0, 0);
        board[7, 6] = new Knight(Color.White, 0, 0);
        board[7, 7] = new Rook(Color.White, 0, 0);
    }

    public override string ToString()
    {
        string output = "";
        for (int i = -1; i < 9; i++)
        {
            for (int j = -1; j < 9; j++)
            {
                if (i == -1 || i == 8 || j == -1 || j == 8)
                {
                    output += "X";
                }
                else
                {
                    output += board[i, j]?.ToString() ?? " ";
                }
            }
            output += "\n";
        }
        return output;
    }


}
