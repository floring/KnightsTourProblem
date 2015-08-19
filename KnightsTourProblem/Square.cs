using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    /// <summary>
    /// Represents chessboard square entity.
    /// </summary>
    class Square
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool HasVisited { get; set; }

        public Square(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return new StringBuilder().Append(X).Append(':').Append(Y).ToString();
        }
    }
}
