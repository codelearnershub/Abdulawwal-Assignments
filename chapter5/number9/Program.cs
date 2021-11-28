using System;

namespace number9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter  a number");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                    if (sum == 0)
                    {
                        for (int f = i; f <= j; f++)
                        {
                            result += numbers[f].ToString();
                        }
                        break;
                    }
                }
                sum = 0;
            }
            if (String.IsNullOrEmpty(result))
            {
                Console.WriteLine("there is no subsets with sum 0");
            }
            else
            {
                Console.WriteLine($"the sum of {String.Join(',', result)} is 0");
            }
        }
    }
}
