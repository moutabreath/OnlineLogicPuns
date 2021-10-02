using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineLogicPuns
{
    public class PermutationsFinder
    {
        public static List<string> FindAllPermutations(string st, int index)
        {
            List<string> perms = new List<string>();
            if (st.Length == index)
            {
                return perms;
            }
            perms.Add(st);
            for (int i = 0; i < st.Length; i++)
            {
                string st1 = SwapChars(st, i, index);
                perms.AddRange(FindAllPermutations(st1, ++index));
            }
            return perms;
        }

        private static string SwapChars(string st, int index1, int index2)
        {
            char temp = st.ElementAt(index1);
            char c = st.ElementAt(index2);
            StringBuilder sb = new StringBuilder();
            if (index2 == index1)
            {
                sb = new StringBuilder(st);
            }
            else
            {
                for (int j = 0; j < st.Length; j++)
                {
                    if (j == index2)
                    {
                        sb.Append(temp);
                        continue;
                    }

                    if (j == index1)
                    {
                        sb.Append(c);
                        continue;
                    }
                    sb.Append(st.ElementAt(j));
                }
            }
            return sb.ToString();
        }
    }
}
