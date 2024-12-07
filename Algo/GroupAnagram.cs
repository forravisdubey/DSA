using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms
{
    internal class GroupAnagram
    {
        static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        public static IList<IList<string>> GroupThem(string[] strs)
        {

            List<IList<string>> output = new List<IList<string>>();

            if (strs.Length == 0) return (IList<IList<string>>)output;

            Dictionary<string, IList<string>> ans = new Dictionary<string, IList<string>>();

            foreach (string item in strs)
            {
                string temp = item;
                string key = SortString(item);
                if (ans.ContainsKey(key))
                {
                    ans[key].Add(temp);
                }
                else
                {
                    IList<string> list = (IList<string>)new List<string>();
                    list.Add(temp);
                    ans.Add(key, list);
                }
            }

            foreach (IList<string> val in ans.Values)
            {
                output.Add(val);
            }
            return output;


        }


    }
}
