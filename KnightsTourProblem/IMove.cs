using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    interface IMove
    {
        List<Square> GetMove(Square square);
    }
}
