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
            if (IsSquareValid(move)) movesList.Add(move);

            move = HorizontalLeftDown(square);
            if (IsSquareValid(move)) movesList.Add(move);

            move = HorizontalRightUp(square);
            if (IsSquareValid(move)) movesList.Add(move);

            move = HorizontalRightDown(square);
            if (IsSquareValid(move)) movesList.Add(move);

            move = VerticalUpLeft(square);
            if (IsSquareValid(move)) movesList.Add(move);

            move = VerticalUpRight(square);
            if (IsSquareValid(move)) movesList.Add(move);

            move = VerticalDownLeft(square);
            if (IsSquareValid(move)) movesList.Add(move);

            move = VerticalDownRight(square);
            if (IsSquareValid(move)) movesList.Add(move);

            movesList.RemoveAll(Visited);

            return movesList;
        }

        /// <summary>
        /// Search predicate.
        /// </summary>
        /// <param name="square">square</param>
        /// <returns>Returns true if a Square had visited.</returns>
        private bool Visited(Square square)
        {
            return square.HasVisited;
        }

        private Square HorizontalLeftUp(Square square)
        {
            return new Square(square.X - 1, square.Y - 2);
        }

        private Square HorizontalLeftDown(Square square)
        {
            return new Square(square.X + 1, square.Y - 2);
        }

        private Square HorizontalRightUp(Square square)
        {
            return new Square(square.X - 1, square.Y + 2);
        }

        private Square HorizontalRightDown(Square square)
        {
            return new Square(square.X + 1, square.Y + 2);
        }

        private Square VerticalUpLeft(Square square)
        {
            return new Square(square.X - 2, square.Y - 1);
        }

        private Square VerticalUpRight(Square square)
        {
            return new Square(square.X - 2, square.Y + 1);
        }

        private Square VerticalDownLeft(Square square)
        {
            return new Square(square.X + 2, square.Y - 1);
        }

        private Square VerticalDownRight(Square square)
        {
            return new Square(square.X + 2, square.Y + 1);
        }

        private bool IsSquareValid(Square square)
        {
            return (square.X >= 0 &&
                square.X < _board.RowSize && 
                square.Y >= 0 &&
                square.Y < _board.RowSize);
        }
    }
}
