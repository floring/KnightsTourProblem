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
            const int xStart = 8;
            const int yStart = 2;
            const int boardSize = 5;

            var board = new Board(boardSize);
            var problem = new KnightsProblem(board, xStart, yStart);
            try
            {
                problem.Solve();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
