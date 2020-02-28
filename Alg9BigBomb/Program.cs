//Use BFS to search denote all the bombs
//Then check how many bombs left


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AlgBigBomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] field =
            {
                new[]{0,1,0,0,0,0},
                new[]{0,1,0,0,0,0},
                new[]{1,1,1,1,0,0},
                new[]{0,0,1,0,0,0},
                new[]{0,1,1,1,1,1},
                new[]{1,1,1,1,1,1}

            };
            //check field fist
            View(field);
            //denote bomb
            var solution = new Solution();
            var counter = solution.DeBomb(field, 0, 3);

            //Console.WriteLine(counter);
            Console.WriteLine("Bombs left: {0} ", counter);
            Console.WriteLine();
            View(field);

        }

        static void View(int[][] field)
        {
            foreach(var r in field)
            {
                Console.WriteLine(String.Join("", r));
                
            }
        }
    }
}
