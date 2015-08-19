using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    class KnightMove : IMove
    {
        private Board _board;

        public KnightMove(Board board)
        {
            _board = board;
        }

        public List<Square> GetMove(Square square)
        {
            var movesList = new List<Square>();

            var move = HorizontalLeftUp(square);
            if (move != null) movesList.Add(move);

            return movesList;
        }

        private Square HorizontalLeftUp(Square square)
        {
            var move = new Square(square.X - 1, square.Y - 2);
            return (IsSquareValid(move)) ? move : null;
        }


        public bool IsSquareValid(Square square)
        {
            return (square.X < _board.RowSize && square.Y < _board.RowSize);
        }
    }
}
