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
        private int _x;
        private int _y;

        public Board(int size)
        {
            _x = size;
            _y = size;
        }
    }
}
