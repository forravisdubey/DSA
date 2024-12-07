using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms.Sorting
{
    internal class SelectionSort
    {
        public static void SelectionSortTest()
        {
            int[] ints = { 8, 5, 3, 6, 5,9 };
            var sortedArray = Sort(ints);
            int[] ints1 = { 8 };
            sortedArray = Sort(ints1);
        }
        public static int[] Sort(int[] nums)
        {
            int smallestIndex = 0;
            
            for(int j = 0; j < nums.Length;j++)
            {
                smallestIndex = j;
                for (int i = j+1; i < nums.Length; i++)
                {
                    if (nums[smallestIndex] > nums[i]) smallestIndex = i;
                }
                var temp = nums[j];
                nums[j] = nums[smallestIndex];
                nums[smallestIndex] = temp;
            }
            return nums;
        }

    }
}
