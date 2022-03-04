using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "DDUUDDUDUUUD";
            Console.WriteLine($"The number of steps is {a.Length}");
            Console.WriteLine($"The number of valley is {Valley(a)}");
        }

        public static int Valley(string qwe)
        {
            int level = 0;
            int a = 0;
            for (int i = 0; i < qwe.Length - 1; i++)
            {
                if (qwe[i] == 'D' && qwe[i + 1] == 'U')
                {
                    level += 1;
                }

                if (qwe[i] == 'U' && qwe[i + 1] == 'D')
                {
                    level += 1;
                }
            }

            if (level % 2 == 0)
            {
                a = level / 2;
            }
            return a;
        }
    }

}
