using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgBigBomb
{
    class Solution
    {

        public int DeBomb(int[][] field, int row, int col)
        {
            int h = field.Length, w = field[0].Length;
            int[][] directions =
            {
                new[]{-1,0},//up neighbor
                new[]{1,0}, // down neighbor
                new[]{0,-1}, //left neighbor
                new[]{0,1}
            };

            field[row][col] = 0; // where to place bomb, it will change to zero
            //use BFS to find 
            var q = new Queue<int>();
            q.Enqueue(row);
            q.Enqueue(col);
            while (q.Count > 0)
            {
                // dequeue center item first
                int cr = q.Dequeue();
                int cc = q.Dequeue();

                // get neighbor items
                foreach (var dir in directions)
                {
                    int nr = cr + dir[0];
                    int nc = cc + dir[1];

                    //check neighbor and enqueue, 
                    if (nr >= 0 && nr < h && nc >= 0 && nc < w)
                    {
                        //if neighbor is also a bomb
                        if (field[nr][nc] == 1)
                        {
                            field[nr][nc] = 0;
                            q.Enqueue(nr);
                            q.Enqueue(nc);
                        }
                    }

                }

            }//while loop end

            //after denote all the bomb, check how many bombs left
            int counter = 0;
            for (int r = 0; r < h; r++)
            {
                for (int c = 0; c < w; c++)
                {
                    //loop the 2-d array
                    counter = counter + field[r][c];//if is  bomb, it increase 1, otherwise increase 0, 

                }
            }
            return counter;

        }








    }
}
