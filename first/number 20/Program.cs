
using System;

namespace Question_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1Power = 0;
            double num2Power = 0;
            double num3Power = 0;

            for (int a = 1; a <= 500; a++)
            {
                num1Power = Math.Pow(a , 2);

                for (int b = a; b <= 500; b++)
                {
                    num2Power = Math.Pow(b , 2);

                    for (int c = b; c <= 500; c++)
                    {
                        num3Power = Math.Pow(c , 2);
                        
                        if (num3Power == num2Power + num1Power)
                        {
                            Console.WriteLine($"The pythagorean triple are {c},{b},{a}");
                        }
                    }
                }
            }
        }
    }
}
