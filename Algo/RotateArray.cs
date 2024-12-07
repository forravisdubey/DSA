using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class RotateArray
    {
        public int[] Rotate(int[] nums, int k)
        {

            int lastIndex = nums.Length - 1;
            int[] output = new int[nums.Length];
            int j = 0;

            for (int i = lastIndex - k + 1; i <= lastIndex; i++)
            {
                output[j] = nums[i];
                j++;
            }

            j = 0;
            for (int i = k; i <= lastIndex; i++)
            {
                output[i] = nums[j];
                j++;
            }

            return output;
        }
    }
}
