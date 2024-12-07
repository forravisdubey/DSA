using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class PermInString
    {
        public bool CheckInclusion(string s1, string s2)
        {

            Dictionary<char, int> dict = StringToDict(s1);

            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            for (int i = 0, j = s1.Length - 1; j < s2.Length; j++)
            {
                var subString = s2.Substring(i, s1.Length);
                dict2 = StringToDict(subString);
                if (CompareDict(dict, dict2)) return true;
            }
            return false;
        }

        public Dictionary<char,int> StringToDict(string s1)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (dict.ContainsKey(s1[i]))
                {
                    dict[s1[i]] = dict[s1[i]] + 1;
                }
                else
                {
                    dict[s1[i]] = 1;
                }
            }
            return dict;

        }

        public bool CompareDict(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            var enumer = dict1.Keys.GetEnumerator();
            while(enumer.MoveNext())
            {
                if(!dict2.ContainsKey(enumer.Current) || dict2[enumer.Current] != dict1[enumer.Current]) return false;
            }
            return true;

        }
    }
}
