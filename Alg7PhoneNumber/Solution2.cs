using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alg7PhoneNumber
{
    // This solution, use array to replace dictionary
    class Solution2
    {

        public List<string> Combinations(string digits)
        {

            String[] str1;
            str1 = new String[] { null, null, "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
           

            var result = new List<string>();

            if (String.IsNullOrEmpty(digits)) return result;// if input is empty, return result.

            var q = new Queue<string>();
            q.Enqueue(String.Empty);

            while (q.Count > 0)//while queue is not empty
            {
                
                var cur = q.Dequeue(); // get a item
                // if the item lenght equal digit lengh, meaning, we got a comibination and add it to result
                if (cur.Length == digits.Length)
                {
                    result.Add(cur);
                }
                else
                {
                    var n = cur.Length;
                    foreach (var c in str1[digits[n]-'0'])// digits[n] get a char nubmer '2', then minus '0', change to digit.
                    {
                        q.Enqueue(cur + c);
                        //Console.WriteLine(cur+c);
                    }
                    
                }

            }

            return result;
        }


    }
}
