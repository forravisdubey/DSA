using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    class TwoSumII
    {
        public static int[] TwoSumSolution1(int[] nums, int target)
        {

            int slow = nums.Length - 1;
            int fast = nums.Length - 2;
            while (slow > 1)
            {
                int sum = nums[slow] + nums[fast];
                if (sum == target)
                {
                    break;
                }
                else
                {
                    if (fast > 0)
                    {
                        fast--;
                    }

                    else
                    {
                        fast = slow - 2;
                        slow--;
                    }
                }

            }

            return new int[2] { fast + 1, slow + 1 };

        }

        public static int[] TwoSum(int[] nums, int sum)
        {

            int i = 0, j = nums.Length - 1;
            while (i < j)
            {
                if (nums[i] + nums[j] == sum)
                    return new int[] { i + 1, j + 1 };
                else if (nums[i] + nums[j] > sum)
                    j--;
                else i++;
            }
            return new int[] { -1, -1 };

        }
    }
}
