using System;

namespace number15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in hexadecimal notation");
            string num = Console.ReadLine();
            double result = 0d;
            int pos = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                int number;
                bool isNumber = int.TryParse(num[i].ToString(), out number);
                if (isNumber)
                {
                    double val = number * Math.Pow(16, pos);
                    result += val;
                }
                else
                {
                    double val = GetNumber(num[i]) ?? 0 * Math.Pow(16, pos);
                    result += val;
                }
                pos++;
            }

            Console.WriteLine(result);


        }

        static int? GetNumber(char cha) => cha switch
        {
            'A' => 10,
            'B' => 11,
            'C' => 12,
            'D' => 13,
            'E' => 14,
            'F' => 15,
            _ => null,
        };
    }
}
