using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Before Reverse ");
            Console.WriteLine(String.Join(",", arr));

            int left = -1;
            int right = arr.Length;
            int temp;

            while(left++ < right--)
            {
                //Console.WriteLine("left: {0}", left);
                //Console.WriteLine("right: {0}", right);
                temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                //left++;
                //right--;
            }

            Console.WriteLine("After Reverse ");
            Console.WriteLine(String.Join(",", arr));


        }
    }
}
