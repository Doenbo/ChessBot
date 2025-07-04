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
    private int file;
    private int rank;

    public Square(int file, int rank)
    {
        if (file < 0 && file > 7 ||
            rank < 0 && rank > 7)
        {
            throw new ArgumentException();
        }

        this.piece = null;
        this.file = file;
        this.rank = rank;

    }
    public Square(string square)
    {
        if (square.Length != 2)
        { throw new ArgumentException(); }

        //TODO check and format

        this.piece = null;
        this.file = square[0]-65;
        this.rank = 56-square[1];
    }

    public int File { get { return file; } set { file = value; } } //a-h

    public int Rank { get { return rank; } set { rank = value; } } //1-8

    public Piece Piece
    {
        get => piece;
        set
        {
            piece = value;
            piece.Square = this;
        }
    }

    public static Square Convert(string square)
    {
        return new Square(square);
    }

    public static string Convert(Square square)
    {
        return square.ToString();
    }

    public override string ToString()
    {
        return " " + (char)(file+65) + (8-rank);
    }
}
