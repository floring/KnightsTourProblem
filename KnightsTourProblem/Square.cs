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

        //public List<Square> GetMoves()
        //{
        //    var movesList = new List<Square>();

        //    Square square;
        //    square = HorizontalLeftUp();
        //    if (square != null) movesList.Add(square);

        //    return movesList;
        //}

        //private Square HorizontalLeftUp()
        //{
        //    var square = new Square(X - 1, Y - 2);
        //    return (Board.IsSquareValid(square)) ? square : null;
        //}

        



    }
}
