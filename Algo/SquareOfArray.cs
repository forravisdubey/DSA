using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class SquareOfArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int left = 0;
            int right = n - 1;
            int[] result = new int[n];

            for (int index = n - 1; index >= 0; index--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[index] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    result[index] = nums[right] * nums[right];
                    right--;
                }
            }
            return result;
        }
    }
}
