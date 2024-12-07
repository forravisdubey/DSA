using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class Anagram
    {
        /// <summary>
        /// An anagram is a word or phrase formed by rearranging the letters of a different word or phrase
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {

            if (s == null && t == null)
                return true;
            if (s == null || t == null)
                return false;
            if (s.Length != t.Length)
                return false;

            int[] freq = new int[26];
            foreach (char c in s)
                freq[c - 'a']++;

            foreach (var c in t)
            {
                freq[c - 'a']--;
                if (freq[c - 'a'] < 0)
                    return false;
            }

            foreach (var f in freq)
            {
                if (f != 0)
                    return false;
            }

            return true;

        }
    }
}
