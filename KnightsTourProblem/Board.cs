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
        public int RowSize { get; private set; }
        private Square[,] _board;

        // возможно надо будет инициализировать доску как каждый сквеар
        public Board(int size)
        {
            RowSize = size;
            _board = new Square[RowSize, RowSize];
        }

        public int GetRowSize()
        {
            return RowSize;
        }

        public bool IsCovered()
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < RowSize; j++)
                {
                    if (!(_board[i, j].HasVisited))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Square GetSquare(int x, int y)
        {
            return _board[x, y];
        }

        public bool IsSquareValid(Square square)
        {
            return (square.X < RowSize && square.Y < RowSize);
        }
    }
}
