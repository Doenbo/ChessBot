using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.game;

public class Position
{
    private int file; //a-h
    private int rank; //1-8

    public Position(int rank, int file)
    {
        if (file < 0 || file > 7 || rank < 0 || rank > 7)
        {
            throw new ArgumentException();
        }

        this.file = file;
        this.rank = rank;
    }

    public int File { get { return file; } set { file = value; } } //a-h

    public int Rank { get { return rank; } set { rank = value; } } //1-8

    public override string ToString()
    {
        return "" + (char)(file + 65) + (8 - rank);
    }
}
