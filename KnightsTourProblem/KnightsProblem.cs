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
        private IMove _move;
        private List<Square> _resultPath;

        public KnightsProblem(Board board, int xStartPos, int yStartPos, IMove move)
        {
            _board = board;
            _xStartPosition = xStartPos;
            _yStartPosition = yStartPos;
            _move = move;
        }

        public List<Square> Solve()
        {
            if (IsPositionsNotValid())
            {
                throw new PositionOutOfRangeException("Position must be less than board size;");
            }

            if (Step(_xStartPosition, _yStartPosition))
            {
                return _resultPath;
            }
            return null;
        }

        private bool Step(int xPos, int yPos)
        {
            if (_board.IsCovered())
            {
                _resultPath = new List<Square>();
                _resultPath.Add(_board.GetSquare(xPos, yPos));
                return true;
            }
            if (!_board.IsCovered() && !IsMoveExists(xPos, yPos))
            {
                return false;
            }
            
            var currentSquare = _board.GetSquare(xPos, yPos);
            currentSquare.HasVisited = true;
            var movesList = _move.GetMove(currentSquare);
            foreach (var move in movesList)
            {
                bool result = Step(move.X, move.Y);
                if (result)
                {
                    _resultPath.Add(currentSquare);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            currentSquare.HasVisited = false;
            return false;
        }

        private bool IsMoveExists(int x, int y)
        {
            return (_move.GetMove(_board.GetSquare(x, y)).Count > 0);
        }

        private bool IsPositionsNotValid()
        {
            return (_xStartPosition >= _board.GetRowSize() || _yStartPosition >= _board.GetRowSize());
        }
    }
}
