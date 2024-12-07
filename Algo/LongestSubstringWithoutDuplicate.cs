using System;
using System.Collections.Generic;
using System.Text;


namespace Algorigthms
{
    public class LongestSubstringWithoutDuplicate
    {
        public static int GetLongestSubString(String s)
        {

            int n = s.Length, ans = 0;
            Dictionary<char, int> map = new Dictionary<char, int>(); // current index of character
            for (int i = 0, j = 0; i < n; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    j = Math.Max(map[s[i]], j);
                }
                ans = Math.Max(ans, i - j + 1);
                map[s[i]]= i + 1;
            }
            return ans;
        }

        public static int MyTry(string s)
        {

            //Dictionary<char, int> charLoc = new Dictionary<char, int>();
            int longestTillNow = 0;
            //for (int i = 0, j=0; i < s.Length; i++)
            //{
            //    if (charLoc.ContainsKey(s[i]))
            //    {
            //        j = Math.Max(i;
            //        //currentLength = i - charLoc[s[i]];
            //        //charLoc[s[i]] = i;
            //        //longestTillNow = Math.Max(longestTillNow, currentLength);
            //    }

            //    longestTillNow = Math.Max(longestTillNow, i-j);
            //    charLoc[s[i]] = i;
            //}

            return longestTillNow;
        }
    }
}
