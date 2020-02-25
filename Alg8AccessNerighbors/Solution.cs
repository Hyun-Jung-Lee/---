// PRINT out every neighbors in 2-D array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessNerighbors
{
    class Solution
    { 
        //This methods use 2 for loops, out loop is row, inner loop is col 
        public void AccessNeighbor1(int[][] m)
        {
            int h = m.Length, w = m[0].Length;
            for(int row=0; row<h; row++)
            {
                for(int col=0; col<w; col++)
                {
                    Console.WriteLine($"Home:{m[row][col]}\t");
                    //check up neighbor and print, 
                    if (row - 1 >= 0) Console.WriteLine(m[row-1][col]);

                    //check down neighbor and print, 
                    if (row + 1 < h) Console.WriteLine(m[row + 1][col]);

                    //check left neighbor and print, 
                    if (col - 1 >= 0) Console.WriteLine(m[row][col-1]);


                    //check left neighbor and print, 
                    if (col + 1 < w) Console.WriteLine(m[row][col + 1]);
                    Console.WriteLine();
                }
            }
        }

        // This methods use a new array to replace neighbors
        // so we can skip 4 if sentence
        public void AccessNeighbor2(int[][] m)
        {
            int h = m.Length, w = m[0].Length;
            int[][] directions =
            {
                new[]{-1,0},//up neighbor
                new[]{1,0}, // down neighbor
                new[]{0,-1}, //left neighbor
                new[]{0,1}
            };

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < w; col++)
                {
                    Console.Write($"Home:{m[row][col]}\t");
                    foreach(var dir in directions)
                    {
                        int nr = row + dir[0];
                        int nc = col + dir[1];

                        //check neighbor and print, 
                        if (nr>=0 && nr<h && nc>=0 && nc<w )
                        {
                            Console.Write($"{m[nr][nc]}\t");                            
                        }
                        
                    }
                    Console.WriteLine();

                }
            }
        }

    }
}
