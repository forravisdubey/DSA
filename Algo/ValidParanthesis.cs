using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms
{
    internal class ValidParanthesis
    {
        public static bool ISValid(string s)
        {
            Stack<Char> st = new Stack<Char>();

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (s[i] == ')' && st.Peek() != '(') return false;
                    if (s[i] == '}' && st.Peek() != '{') return false;
                    if (s[i] == ']' && st.Peek() != '[') return false;

                    st.Pop();
                }
            }

            if (st.Count == 0) return true;

            return false;
        }
    }
}
