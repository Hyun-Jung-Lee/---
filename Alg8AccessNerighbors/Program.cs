// PRINT out every neighbors in 2-D array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessNerighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m =
            {
                new[] {1,2,3,4},
                new[] {5,6,7,8},
                new[] {9,10,11,12}
            };
            var solution = new Solution();
            solution.AccessNeighbor2(m);
        }
    }
}
