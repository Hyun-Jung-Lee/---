using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg3CountPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 20, 260, 20, 260, 500, 500 };
            PrintArray(nums);
            
            
            int result = CounterNoSort(nums, 520);
            Console.WriteLine("Count number:");
            Console.WriteLine(result);

        }

        //Counter without Sort .
        static int CounterNoSort(int[] n, int target)
        {
            var count = 0;
            var dict = new Dictionary<int, int>();// key is the array value, value is the times in the array.
            foreach(var i in n)
            {
                var diff = target - i;
                if(dict.ContainsKey(diff))//found the other number in the dict(come from array)
                {
                    count++;
                    dict[diff]--;
                    if(dict[diff] == 0)
                    {
                        dict.Remove(diff);//Number can repeat, but only use one time.
                    }
                }
                else//not found the other number, add current i to the dict
                {
                    if (!dict.ContainsKey(i))
                    {
                        dict[i] = 0;
                    }
                    dict[i]++;
                }
            }

            return count;
        }

        //Sort first, then count pairs numbers to be target.
        static int Counter(int[] n, int target)
        {
            var count = 0;
            // sort first
            Array.Sort(n);
            int l = 0, r = n.Length - 1;
            while (l<r)
            {
                if (n[l] + n[r] < target)
                {
                    l++;
                }
                else if (n[l] + n[r] > target)
                {
                    r--;
                }
                else
                {
                    count++;
                    l++;
                    r--;
                }
            }
            return count;
        }

        static void PrintArray(int[] n)
        {
            foreach(var item in n)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
