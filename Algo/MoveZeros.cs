using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class MoveZeros
    {

		public static void InPlace(int[] nums)
		{
			if (nums == null || nums.Length <= 1) return;
			int curr = 0, next = 1;

			while (next <= nums.Length - 1)
			{
				if (nums[curr] == 0)
				{
					if (nums[next] == 0){
						next++;
						continue;
					}
					else{
						nums[curr] = nums[next];
						nums[next] = 0;
					}
				}
				curr++;
				next++;
			}
		}

		public static void NoAdditionalArrayTwoLoop(int[] nums)
		{
			int zeroCounter = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != 0)
				{
					nums[i- zeroCounter] = nums[i];
				}
                else
                {
					zeroCounter++;

				}
			}

			for (int i = nums.Length- zeroCounter; i < nums.Length; i++)
			{
				nums[i] = 0;
			}
		}
	}
}
