using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    /// <summary>
    /// Class directly implements solution algorithm. 
    /// The knight's tour problem is the mathematical problem of finding a knight's tour.
    /// A knight's tour is a sequence of moves of a knight on a chessboard such that the knight visits every square only once.
    /// </summary>
    class KnightsProblem
    {
        private Board _board;
        private int _xStartPosition;
        private int _yStartPosition;

        public KnightsProblem(Board board, int xStartPos, int yStartPos)
        {
            _board = board;
            _xStartPosition = xStartPos;
            _yStartPosition = yStartPos;
        }

        public void Solve()
        {
            if (IsPositionsNotValid())
            {
                throw new PositionOutOfRangeException("Position must be less than board size;");
            }

            if (Step(_xStartPosition, _yStartPosition))
            {
                // we did it!
            }
        }

        private bool Step(int xPos, int yPos)
        {
            if (_board.IsCovered())
            {
                return true;
            }
            if (!_board.IsCovered() && !IsMoveExists(xPos, yPos))
            {
                return false;
            }

            return false;
        }

        private bool IsMoveExists(int x, int y)
        {
            return (_board.GetSquare(x, y).GetMoves().Count != 0);
        }

        private bool IsPositionsNotValid()
        {
            return (_xStartPosition >= _board.GetRowSize() || _yStartPosition >= _board.GetRowSize());
        }
    }
}
