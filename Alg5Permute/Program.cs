using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg5Permute
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            //var result = s.Permute(3);
            var result = s.Parentheses(3);
            foreach (String str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
