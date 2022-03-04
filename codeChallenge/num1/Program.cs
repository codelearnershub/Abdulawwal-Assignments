using System;
using System.Collections.Generic;

namespace num1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] qwe = {"abcw", "baz", "foo", "bar", "xtfn", "abcdef" };
            Console.WriteLine(MaxVal(qwe));
        }

        public static int MaxVal(string [] words)
        {
            string current = words[0];
            int max = 1;

            for(int i = 1; i < words.Length; i++)
            {
                if(current.Length <= words[i].Length)
                {
                    if(words[i].Contains(current))
                    {
                        current = words[i];
                    }
                    else
                    {
                        max = current.Length * words[i].Length;
                    }
                    
                }
            }
            return max;
        }
    }
}
