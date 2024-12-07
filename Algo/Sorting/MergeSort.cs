using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms.Sorting
{
    public class MergeSort
    {
        public static void MergeSorTest()
        {
            int[] ints = { 8, 5, 3, 6, 5, 9, 2,9 };
            DivideForMerge(ints);
            int[] ints1 = { 8 };
            DivideForMerge(ints1);
        }

        #region Easy to understand
        public static void DivideForMerge(int[] nums)
        {
            int high = nums.Length;
            if (high < 2) return;
            int mid = (high) / 2;
            int[] arr1 = new int[mid];
            int[] arr2 = new int[high - mid];
            int i = 0;
            while (i < arr1.Length) arr1[i] = nums[i++];
            i = 0;
            while (i < arr2.Length) arr2[i] = nums[mid + i++];

            DivideForMerge(arr1);
            DivideForMerge(arr2);
            MergeSortedArray(nums, arr1, arr2);
        }

        public static int[] MergeSortedArray(int[] nums, int[] arr1, int[] arr2)
        {
            int i=0, j = 0,k=0;
            
            while (i < arr1.Length && j < arr2.Length) {
                
                nums[k++] = (arr1[i] < arr2[j]) ? arr1[i++] : arr2[j++];
            }

            while(i< arr1.Length) nums[k++] = arr1[i++];
            while(j< arr2.Length) nums[k++] = arr2[j++];
            
            return nums;
        }
        #endregion

    }
}
