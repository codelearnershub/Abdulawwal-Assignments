using System;

namespace number13
{
    class Program
    {
        static void Main(string[] args)
        {
            Product();
        }

        public static void Product()
        {
            int[] a = new int[3];
            int[] b = new int[3];

            int[,] c = new int[3, 3];

            int[] d = new int[5];


            for (int i = 0, j = 2; i < 3; i++)
            {
                Console.WriteLine($"enter the coefficients of x^{j}");

                int p;
                bool result = int.TryParse(Console.ReadLine(), out p);
                a[i] = int.Parse(Console.ReadLine());
                b[i] = int.Parse(Console.ReadLine());

                j--;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i] * b[j];

                }
            }
            Array.Resize<int>(ref d, 30);

            for (int index = 0; index < 6; index++)
            {
                int sum = 0;
                for (int row = 0; row < c.GetLength(0); row++)
                {
                    for (int col = 0; col < c.GetLength(1); col++)
                    {
                        if (row + col == index)
                        {
                            sum += c[row, col];
                            d[index] = sum;
                        }
                    }
                }
            }
            Console.WriteLine($"{d[1]}x^3 {d[2]}x^2 {d[3]}x {d[4]}");
        }
    }
}
