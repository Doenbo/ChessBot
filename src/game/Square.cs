using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.src.pieces;

namespace ChessBot.src.game;

public class Square
{
    private Piece? piece;

    public Square(char file, int rank)
    {
        if (file < 'a' && file > 'h' ||
            rank < 1 && rank > 8)
        {
            throw new ArgumentException();
        }
    }

    public char File { get; set; } //a-h
    public int Rank { get; set; } //1-8
    public Piece Piece
    {
        get { return Piece; }
        set
        {
            piece = value;
            piece.Square = this;
        }
    }

    public override string ToString()
    {
        return piece?.ToString() ?? " ";
    }
}
