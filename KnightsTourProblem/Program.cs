using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    class Program
    {
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
                List<Square> res = problem.Solve();
                foreach (Square s in res)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
