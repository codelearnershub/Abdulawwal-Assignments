using System;

namespace number12
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
        }

        public static void Add()
        {
            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];


            for (int i = 0, j=2 ; i < 3; i++)
            {
                Console.WriteLine($"enter the coefficients of x^{j}");
                a[i] = int.Parse(Console.ReadLine());
                b[i] = int.Parse(Console.ReadLine());

                j--;
            }

            for (int i = 0; i < 3; i++)
            {
                c[i] = a[i] + b[i];
            }

            Console.WriteLine($"[{a[0]}x^2 + {a[1]}x + ({a[2]})] + [{b[1]}x + ({b[2]})] = {c[0]}x^2 + {c[1]}x + ({c[2]})");
        }
    }
}
