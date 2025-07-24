using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot.Model.Game;

public class Game
{
    public Board Board;

    public Game()
    {
        Board = new Board();
    }

    public List<Position> GetPotentialMoves(string square) => Board.GetPiece(square).GetPotentialMoves();
    
    public void Move(Position from, Position to) { }
}
