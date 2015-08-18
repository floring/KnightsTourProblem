using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem
{
    /// <summary>
    /// Represents chess square entity.
    /// </summary>
    public class Square
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool HasVisited { get; set; }

    }
}
