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
    private int file; //a-h
    private int rank; //1-8

    public Square(int rank, int file)
    {
        if (file < 0 || file > 7 || rank < 0 || rank > 7)
        {
            throw new ArgumentException();
        }

        this.piece = null;
        this.file = file;
        this.rank = rank;

    }

    public int File { get { return file; } set { file = value; } } //a-h

    public int Rank { get { return rank; } set { rank = value; } } //1-8

    public Piece Piece
    {
        get => piece!;

        set
        {
            piece = value;
            piece.Square = this;
        }
    }

    public override string ToString()
    {
        return "" + (char)(file + 65) + (8 - rank);
    }
}
