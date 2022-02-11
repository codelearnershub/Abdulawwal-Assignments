using System;
using System.Collections.Generic;

namespace num1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub("ab", "eidboaoo");
        }

        public static void Sub(string s1, string s2)
        {
            int a = s1.Length;
            int b = s2.Length;
            int count = 0;
            List<string> perms = Perm(s1, 0, a - 1);
            var substrings = new List<string>();


            for (int i = 0; i <= b - a; i++)
            {
                string etf = s2.Substring(i, a);
                substrings.Add(etf);
            }


            for (int k = 0; k <= substrings.Count - 1; k++)
            {
                for (int l = 0; l <= perms.Count - 1; l++)
                {
                    if (perms[l] == substrings[k])
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static List<string> Perm(string s, int x, int y)
        {
            List<string> permList = new List<string>();

            if (x == y)
            {
                permList.Add(s);

            }

            else
            {
                for (int i = x; i <= y; i++)
                {
                    s = Sort(s, x, i);
                    Perm(s, x + 1, y);
                    permList.Add(s);
                }

            }

            return permList;
        }

        public static int Fact(int b)
        {
            int fact = 1;
            for (int i = b; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static string Sort(string asd, int i, int j)
        {
            var qwe = asd.ToCharArray();
            char temp = qwe[i];
            qwe[i] = qwe[j];
            qwe[j] = temp;
            return new string(qwe);

        }
    }
}
