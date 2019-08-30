using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 20, 270, 2, 270, 50, 500 };
            Console.WriteLine("Before Sort:");
            PrintArray(nums);


            SelectionSort(nums);

            Console.WriteLine("After Sort:");
            PrintArray(nums);
        }

        private static void SelectionSort(int[] nums)
        {
            int minIndex = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                minIndex = i;
                for(int j =i +1; j < nums.Length; j++)
                {
                    // if find new min, store its index
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //switch min to first position.
                int temp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = temp;
            }
        }


        static void PrintArray(int[] n)
        {
            foreach (var item in n)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

    }
}
