using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class TopKFrequencies
    {
        public static int[] GetTopKFrequent(int[] nums, int k)
        {



            //PriorityQueue<int,int> numFreq = new PriorityQueue<int,int>();

            SortedList<int, int> sortedFreq = new SortedList<int, int>(new DescComparer<int>());
            Dictionary<int, int> numFreq = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numFreq.ContainsKey(nums[i]))
                {
                    numFreq[nums[i]] = numFreq[nums[i]] + 1;
                }
                else
                {
                    numFreq.Add(nums[i], 1);
                }
            }

            foreach (int key in numFreq.Keys)
            {
                sortedFreq.Add(numFreq[key], key);
            }

            int[] output = new int[k];
            int cnt = 0;

            foreach (int key in sortedFreq.Keys)
            {
                if (cnt == k) break;
                output[cnt] = sortedFreq[key];
                cnt++;
            }

            return output;

        }
    }

    public class DescComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            if (x == null) return -1;
            if (y == null) return 1;
            return Comparer<T>.Default.Compare(y, x);
        }
    }

}
