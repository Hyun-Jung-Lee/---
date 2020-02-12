using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg7PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumber = "234";

            var s = new Solution();
            var result = s.Combinations(phoneNumber);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
