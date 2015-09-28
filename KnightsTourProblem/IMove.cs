using System.Collections.Generic;

namespace KnightsTourProblem
{
    /// <summary>
    /// Interface IMove contains method GetMove.
    /// All classes that describe a sequence of moves of a chess figure must implement this interface.
    /// </summary>
    interface IMove
    {
        /// <summary>
        /// Method GetMove returns all possible moves of a specified chess figure from current square.
        /// </summary>
        /// <param name="square">Current chessboard square</param>
        /// <returns>List of squares</returns>
        List<Square> GetMove(Square square);
    }
}
