using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.src.game;

public class Game
{
    public Board Board;

    public Game()
    {
        Board = new Board();
    }

    public List<Square> GetPotentialMoves(string square) => Board.GetSquare(square).Piece.GetPotentialMoves();
    
    public void Move(Square from, Square to) { }
}
