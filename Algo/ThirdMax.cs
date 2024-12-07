using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms
{
    internal class ThirdMax
    {
        public static int GEtThirdMax(int[] nums)
        {

            int firstMax = Int32.MinValue;
            int secondMax = Int32.MinValue;
            int thirdMax = Int32.MinValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > firstMax)
                {
                    firstMax = nums[i];
                    continue;
                }

                if (nums[i] > secondMax)
                {
                    secondMax = nums[i];
                    continue;
                }

                if (nums[i] > thirdMax)
                {
                    thirdMax = nums[i];
                    continue;
                }
            }

            if (thirdMax != Int32.MinValue)
            {
                return thirdMax;
            }
            else
            {
                return firstMax;
            }

        }
    }
}
