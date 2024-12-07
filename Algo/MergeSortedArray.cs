using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int i = 0;
            int j = 0;
            int[] output = new int[m + n];

            while (i < m && j < n)
            {

                if (nums1[i] < nums2[j])
                {
                    output[i + j] = nums1[i];
                    i++;
                }
                else
                {
                    output[i + j] = nums2[j];
                    j++;
                }
            }

            while (i < m)
            {
                output[i + j] = nums1[i];
                i++;
            }

            while (j < n)
            {
                output[i + j] = nums2[j];
                j++;
            }


            for (int p = 0; p < m + n; p++)
            {
                nums1[p] = output[p];
            }

        }
    }
}
