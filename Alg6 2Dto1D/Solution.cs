using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg6_2Dto1D
{
    class Solution
    {
        public static int[] Convert(int[][] m)
        {
            //check if m is empty
            if (m == null) return new int[0];
            
            // start row and col of converted
            int row = 0, col = 0;
            //set area of converted high and wide
            int high = m.Length, wide = m[0].Length;
            int p = 0;
            int[] result=new int[high*wide];

            while (true)
            {
                //exit condition
                if (high == 0 || wide == 0) break;
                //covernt the top row
                for(int c=col; c < col + wide; c++)
                {
                    result[p] = m[row][c];
                    p++;
                }
                row = row + 1;//after coverted one row, start row number increase 1
                high = high - 1;


                //exit condition
                if (high == 0 || wide == 0) break;
                //covernt the right col
                for (int r = row; r < row + high; r++)
                {
                    result[p] = m[r][col+wide -1];
                    p++;
                }              
                wide = wide - 1;

                //exit condition
                if (high == 0 || wide == 0) break;
                //covernt the bottom row
                for (int c = col+wide-1; c > col; c--)
                {
                    result[p] = m[row+high-1][c];
                    p++;
                }

                //exit condition
                if (high == 0 || wide == 0) break;
                //covernt the left col
                for (int r = row + high - 1; r >= row; r--)
                {
                    result[p] = m[r][col];
                    p++;
                }
                col = col + 1;
                wide = wide - 1;
            }
            
            return result;
        }
    }
}
