using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    /// <summary>
    /// Represents chessboard entity.
    /// Each cell of this board is Squre class.
    /// </summary>
    class Board
    {
        private int _rowSize;
        private Square[,] _board;

        public Board(int size)
        {
            _rowSize = size;
            _board = new Square[_rowSize, _rowSize];
        }

        public int GetRowSize()
        {
            return _rowSize;
        }

        public bool isCovered()
        {
            for (int i = 0; i < _rowSize; i++)
            {
                for (int j = 0; j < _rowSize; j++)
                {
                    if (!(_board[i, j].HasVisited))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
