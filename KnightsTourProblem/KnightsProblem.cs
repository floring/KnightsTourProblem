using System;
using System.Collections.Generic;

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
        private int _currentIteration;

        public KnightsProblem(Board board, int xStartPos, int yStartPos, IMove move)
        {
            _board = board;
            _xStartPosition = xStartPos;
            _yStartPosition = yStartPos;
            _move = move;
        }

        public String Solve()
        {
            if (IsPositionsNotValid())
            {
                throw new PositionOutOfRangeException("Position must be less than board size;");
            }
            
            if (Step(_xStartPosition, _yStartPosition))
            {
                return _board.Draw();
            }
            return "Cannot find the sequence of moves.";
        }

        private bool Step(int xPos, int yPos)
        {
            _currentIteration++;

            var currentSquare = _board.GetSquare(xPos, yPos);
            currentSquare.HasVisited = true;
            currentSquare.Value = _currentIteration;

            Console.WriteLine(_board.Draw());

            if (_board.IsCovered())
            {
                _resultPath = new List<Square>();
                _resultPath.Add(_board.GetSquare(xPos, yPos));
                return true;
            }

            var moves = _move.GetMove(currentSquare);
            foreach (var move in moves)
            {
                bool result = Step(move.X, move.Y);
                if (result)
                {
                    _resultPath.Add(currentSquare);
                    return true;
                }
            }

            Console.WriteLine(_board.Draw());

            _currentIteration--;
            currentSquare.Value = 0;
            currentSquare.HasVisited = false;
            return false;
        }

        private bool IsMoveExists(int x, int y)
        {
            return (_move.GetMove(_board.GetSquare(x, y)).Count > 0);
        }

        private bool IsPositionsNotValid()
        {
            return (_xStartPosition < 0 ||
                _xStartPosition >= _board.GetRowSize() || 
                _yStartPosition < 0 ||
                _yStartPosition >= _board.GetRowSize());
        }
    }
}
