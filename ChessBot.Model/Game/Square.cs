﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBot.Model.Pieces;

namespace ChessBot.Model.Game;

//TODO Factory Pattern?
//-> So only board can call this constructor
//https://stackoverflow.com/questions/2016719/how-to-create-a-constructor-that-is-only-usable-by-a-specific-class-c-friend
public class Square(int rank, int file)
{
    private Piece? piece = null;

    public Position Position { get; } = new Position(rank, file);

    public Piece? Piece //{ get; set; }
    {
        get => piece!;

        set
        {
            piece = value;
            if (piece != null)
            {
                piece.Position = Position;
            }
        }
    }
}
