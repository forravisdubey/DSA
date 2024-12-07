using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms.Sorting
{
    public class InsertionSort
    {
        public static void InsertionSortTest()
        {
            int[] ints = { 8, 5, 3, 6, 5, };
            var sortedArray = Sort(ints);
            int[] ints1 = { 8 };
            sortedArray = Sort(ints1);
        }

        public static int[] Sort(int[] nums)
        {
            for (int j = nums.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                       // Swap(nums, i);
                    }
                }
            }
            return nums;
        }
    }
}
