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

        public Board(int size)
        {
            RowSize = size;

            // Create the array to store the squares.
            _board = new Square[RowSize, RowSize];
            // Populate the board with Square objects.
            for (int i = 0; i < RowSize; ++i)
            {
                for (int j = 0; j < RowSize; ++j)
                {
                    _board[i, j] = new Square(i, j);
                }
            }
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

        public String Draw()
        {
            var stringBuilder = new StringBuilder();

            // get the value of longest element in board
            int maxRowLength = 0;
            for (int i = 0; i < RowSize; i++)
                for (int j = 0; j < RowSize; j++)
                {
                    int curLength = _board[i, j].Value.ToString().Length;
                    if (curLength > maxRowLength) maxRowLength = curLength;
                }

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < RowSize; j++)
                {
                    string format = "{0," + maxRowLength + "} ";
                    stringBuilder.AppendFormat(String.Format(format, _board[i, j].Value));
                }
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}
