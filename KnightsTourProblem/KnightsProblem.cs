using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    /// <summary>
    /// Class directly implements solution algorithm.
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

        }

        private bool IsPositionsNotValid()
        {
            return (_xStartPosition >= _board.GetRowSize() || _yStartPosition >= _board.GetRowSize());
        }
    }
}
