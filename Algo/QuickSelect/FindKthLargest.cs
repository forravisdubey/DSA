using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms.QuickSelect
{

    public class FindKthLargest
    {
        public int TestKthLargest(int[] nums, int k)
        {

            QSelectRec(nums, 0, nums.Length - 1, nums.Length - k);
            return nums[nums.Length - k];
        }

        private void QSelectRec(int[] nums, int left, int right, int desiredIndex)
        {
            int lastSwapLoc = Partition(nums, left, right);
            if (desiredIndex == lastSwapLoc) return;
            if (desiredIndex < lastSwapLoc) QSelectRec(nums, left, lastSwapLoc - 1, desiredIndex);
            else QSelectRec(nums, lastSwapLoc + 1, right, desiredIndex);
        }

        private int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[right];
            int lastSwapLoc = left;
            for (int i = left; i < right; i++)
            {
                if (nums[i] < pivot)
                {
                    Swap(nums, i, lastSwapLoc);
                    lastSwapLoc++;
                }
            }
            Swap(nums, lastSwapLoc, right);
            return lastSwapLoc;
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i]; nums[i] = nums[j]; nums[j] = temp;
        }
    }
}
