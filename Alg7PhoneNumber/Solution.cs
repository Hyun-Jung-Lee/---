using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//find all possible letter combinations for given digits phone number
// the length of phone number is not fixed

namespace Alg7PhoneNumber
{
    class Solution
    {
        public List<string> Combinations(string digits)
        {
            var dict = new Dictionary<char, char[]> {
                {'2', new[]{'a','b','c'} },
                {'3', new[]{'d','e','f'} },
                {'4', new[]{'g','h','i'} },
                {'5', new[]{'j','k','l'} },
                {'6', new[]{'m','n','o'} },
                {'7', new[]{'q','r','s'} },
                {'8', new[]{'t','u','v'} },
                {'9', new[]{'w','x','y', 'z' } },

            };//dict end

            var result = new List<string>();

            if (String.IsNullOrEmpty(digits)) return result;// if input is empty, return result.

            var q = new Queue<string>();
            q.Enqueue(String.Empty);

            while (q.Count > 0)//while queue is not empty
            {
                var n = 0;
                var cur = q.Dequeue(); // get a item
                // if the item lenght equal digit lengh, meaning, we got a comibination and add it to result
                if (cur.Length == digits.Length)
                {
                    result.Add(cur);
                }
                else
                {
                    foreach (var c in dict[digits[n]])
                    {
                        q.Enqueue(cur+c);
                        //Console.WriteLine(cur+c);
                    }
                    n = n + 1;// after run over current digit, move to next digit
                }
                
            }

            return result;
        }
    }
}
