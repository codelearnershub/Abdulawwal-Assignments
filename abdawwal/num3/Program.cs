using System;
using System.Collections.Generic;

namespace num3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "*)))";
            IsValid(s);
        }

        public static void IsValid(string s)
        {
            int open = 0;
            int close = 0;
            int star = 0;
            int openClose = 0;
            List<int> openIndex = new List<int>();
            List<int> closeIndex = new List<int>();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == '(')
                {
                    open++;
                    openIndex.Add(i);
                }
                else if (s[i] == ')')
                {
                    close++;
                    closeIndex.Add(i);
                }

                else if (s[i] == '*')
                {
                    star++;

                }
            }

            int chosen = 0;

            for (int j = 0; j < openIndex.Count; j++)
            {
                for (int k = chosen; k < closeIndex.Count; k++)
                {
                    if (openIndex[j] < closeIndex[k])
                    {
                        openClose++;
                        chosen = k;
                        break;
                    }
                }
            }

            if (openClose > 0)
            {
                if (open == close)
                {
                    Console.WriteLine("true");
                }
                else if (open > close)
                {
                    Console.WriteLine((star >= open - close) ? "true" : "false");
                }
                else if (close > open)
                {
                    Console.WriteLine((star >= close - open) ? "true" : "false");
                }
            }

            else
            {
                Console.WriteLine("false");
            }


        }
    }
}
