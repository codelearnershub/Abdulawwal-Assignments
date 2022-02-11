using System;
using System.Collections;
using System.Collections.Generic;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Ok(int num)
        {
            char l = '(';
            char r = ')';
            int a = (num * 2) - 1;
            var asd = new List<string>();
            var x = new Stack();
            var y = new Stack();
            string s = "";
            for (int i = 0; i <= num; i++)
            {
                x.Push(l);
                y.Push(r);
            }

            for (int j = 1; j <= a; j++)
            {
                s += x.Peek();
                s += y.Peek();
            }





        }
    }
}
