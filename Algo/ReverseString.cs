using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class ReverseString
    {
        public void TwoPointerMethod(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i <= j; i++, j--)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
    }
}
