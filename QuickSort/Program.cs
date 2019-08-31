using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 20, 270, 2, 270, 50, 500 };
            Console.WriteLine("Before Sort:");
            PrintArray(nums);


            QuickSort(nums, 0, nums.Length-1);

            Console.WriteLine("After Sort:");
            PrintArray(nums);
        }

        //Params: array to sort, left index, right index
        private static void QuickSort(int[] nums, int left, int right)
        {

            //if left == right, only one item left, no need sort.
            if(left < right)
            {
                //Get the index of element of partiton. 
                //partitionIndex is the middle value after pivot swap
                int partitionIndex = Partition(nums, left, right);

                //Use new partition to sort 
                QuickSort(nums, left, partitionIndex - 1);
                QuickSort(nums, partitionIndex + 1, right);
            }

         
        }

        // This funcion choose right as pivot
        private static int Partition(int[] nums, int left, int right)
        {
            var pivot = right;
            var smallIndex = left;

            for(int i = left; i<right; i++)//last one is pivot, so i no need to increase to last one
            {
                // if current value < pivot, switch the value to small index, and increase small index
                //otherwise, check next value, small index didn't change.
                if(nums[i] < nums[pivot])
                {
                    var t = nums[smallIndex];
                    nums[smallIndex] = nums[i];//switch value to small index
                    nums[i] = t;
                    smallIndex++;
                }
            }

            
            //switch pivot to smallIndex  .
            int temp = nums[smallIndex];
            nums[smallIndex] = nums[pivot];
            nums[pivot] = temp;

            return smallIndex ;

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
