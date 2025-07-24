using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.src.pieces;
using ChessBot.src.enums;

namespace ChessBot.src.game;

public class Board
{
    private Square[,] board;

    public Board()
    {
        board = new Square[8, 8];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                board[i, j] = new Square(i, j);
            }
        }

        board[0, 0].Piece = new Rook(Color.Black); //A8
        board[0, 1].Piece = new Knight(Color.Black); //B8
        board[0, 2].Piece = new Bishop(Color.Black);
        board[0, 3].Piece = new Queen(Color.Black);
        board[0, 4].Piece = new King(Color.Black);
        board[0, 5].Piece = new Bishop(Color.Black);
        board[0, 6].Piece = new Knight(Color.Black);
        board[0, 7].Piece = new Rook(Color.Black);

        board[1, 0].Piece = new Pawn(Color.Black); //A7
        board[1, 1].Piece = new Pawn(Color.Black);
        board[1, 2].Piece = new Pawn(Color.Black);
        board[1, 3].Piece = new Pawn(Color.Black);
        board[1, 4].Piece = new Pawn(Color.Black);
        board[1, 5].Piece = new Pawn(Color.Black);
        board[1, 6].Piece = new Pawn(Color.Black);
        board[1, 7].Piece = new Pawn(Color.Black);

        board[6, 0].Piece = new Pawn(Color.White); //A2
        board[6, 1].Piece = new Pawn(Color.White);
        board[6, 2].Piece = new Pawn(Color.White);
        board[6, 3].Piece = new Pawn(Color.White);
        board[6, 4].Piece = new Pawn(Color.White);
        board[6, 5].Piece = new Pawn(Color.White);
        board[6, 6].Piece = new Pawn(Color.White);
        board[6, 7].Piece = new Pawn(Color.White);

        board[7, 0].Piece = new Rook(Color.White); //A1
        board[7, 1].Piece = new Knight(Color.White);
        board[7, 2].Piece = new Bishop(Color.White);
        board[7, 3].Piece = new Queen(Color.White);
        board[7, 4].Piece = new King(Color.White);
        board[7, 5].Piece = new Bishop(Color.White);
        board[7, 6].Piece = new Knight(Color.White);
        board[7, 7].Piece = new Rook(Color.White);
    }

    public Position GetPosition(string pos)
    {
        if (pos.Length != 2 ||
            pos[0] < 65 || pos[0] > 72 ||
            pos[1] < 49 || pos[1] > 56)
        {
            throw new ArgumentException();
        }

        int file = pos[0] - 65;
        int rank = 56 - pos[1];

        return board[rank, file].Position;
    }

    //TODO HMMMMM Copy of Piece??
    public Piece GetPiece(string pos)
    {
        var tmp = GetPosition(pos);
        return board[tmp.Rank, tmp.File].Piece!;
    }

    public bool Move(string from, string to)
    {
        var posFrom = GetPosition(from);
        var posTo = GetPosition(to);

        var pieceFrom = board[posFrom.Rank, posFrom.File].Piece;
        if(pieceFrom == null) { return false; }

        var pieceTo = board[posTo.Rank, posTo.File].Piece;
        if (pieceTo != null && pieceTo.Color == pieceFrom.Color) { return false; }

        var potMoves = pieceFrom.GetPotentialMoves();
        var cont = potMoves.Any(pos => (pos.Rank == posTo.Rank && pos.File == posTo.File));
        if (!cont) { return false; }

        board[posTo.Rank, posTo.File].Piece = board[posFrom.Rank, posFrom.File].Piece;
        board[posFrom.Rank, posFrom.File].Piece = null!;
        return true;

    }
        
    public override string ToString()
    {
        string output = "";
        for (int i = -1; i < 9; i++)
        {
            for (int j = -1; j < 9; j++)
            {
                //corners
                if (i == -1 && j == -1 || i == -1 && j == 8 || i == 8 && j == -1 || i == 8 && j == 8)
                {
                    output += " ";
                }
                //letters
                else if (i == -1 || i == 8)
                {
                    output += (char)(j + 65);
                }
                //numbers
                else if (j == -1 || j == 8)
                {
                    output += 8 - i;
                }
                //the actual board
                else
                {
                    output += board[i, j].Piece?.ToString() ?? " ";
                }
            }
            output += "\n";
        }
        return output;
    }


}
