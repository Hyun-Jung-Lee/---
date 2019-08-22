using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg6_2Dto1D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m = new[]
            {
                new[]{1,2,3,4},
                new[]{10,11,12,5},
                new[]{9,8,7,6}
            };

           //Console.WriteLine(m[0].Length);
            
           for(int i=0; i< m.Length; i++)
            {
                for(int j=0; j<m[i].Length; j++)
                {
                    Console.Write(m[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var result = Solution.Convert(m);
            Console.WriteLine(String.Join("->", result));

        }//Main end
    }
}
