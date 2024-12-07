using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorigthms.Sorting
{
    public class QuickSort
    {

        public static void QuickSortTest()
        {
            //Test 1
            int[] ints = { 8, 5, 3, 6, 5, 9, 2, 9, 2 };
            Sort(ints);

            //Test 2
            int[] ints1 = { 8 };
            Sort(ints1);
        }

        private static void Sort(int[] nums)
        {
            QSort(nums, 0, nums.Length - 1);
        }

        private static void QSort(int[] nums, int left, int right)
        {
            if (left >= right) return;

            int pivotIndex = right;
            int pivot = nums[pivotIndex];

            int i = Partition(nums, left, right);

            QSort(nums, left, i - 1);
            QSort(nums, i + 1, right);
        }

        private static int Partition(int[] nums, int left, int right)
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

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i]; nums[i] = nums[j]; nums[j] = temp;
        }

        #region working
        //private static void Sort(int[] nums)
        //{
        //    QSort(nums, 0, nums.Length - 1);
        //}

        //private static void QSort(int[] nums, int lowIndex, int highIndex)
        //{
        //    if (lowIndex >= highIndex) return;

        //    int pivotIndex = highIndex;
        //    int pivot = nums[pivotIndex];

        //    int i = Partition(nums, lowIndex, highIndex, pivot);

        //    QSort(nums, lowIndex, i - 1);
        //    QSort(nums, i + 1, highIndex);
        //}

        //private static int Partition(int[] nums, int lowIndex, int highIndex, int pivot)
        //{

        //    int i = lowIndex;
        //    int j = highIndex - 1;
        //    while (i < j)
        //    {
        //        while (nums[i] <= pivot && i < j) i++;
        //        while (nums[j] >= pivot && i < j) j--;
        //        Swap(nums, i, j);
        //    }
        //    if (nums[i] > nums[highIndex]) Swap(nums, i, highIndex);
        //    else i = highIndex;

        //    return i;
        //}

        //private static void Swap(int[] nums, int i, int j)
        //{
        //    var temp = nums[i];
        //    nums[i] = nums[j];
        //    nums[j] = temp;
        //}

        #endregion


    }
}
