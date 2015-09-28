using System;

namespace KnightsTourProblem
{
    class Program
    {
        /// <summary>
        /// Main entry point to program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int xStart = 2;
            const int yStart = 2;
            const int boardSize = 5;

            var board = new Board(boardSize);
            var move = new KnightMove(board);
            var problem = new KnightsProblem(board, xStart, yStart, move);
            try
            {
                String solution = problem.Solve();
                Console.WriteLine(solution);
            }
            catch (PositionOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
