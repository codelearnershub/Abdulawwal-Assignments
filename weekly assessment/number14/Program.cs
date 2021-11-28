using System;

namespace number14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cai();
        }

        public static void Cai()
        {
            Random number = new Random();
            int num1 = number.Next(0, 10);
            int num2 = number.Next(0, 10);

            bool flag = true;
            while (flag)
            {
                Console.WriteLine($"How much is {num1} times {num2}");
                int choice = int.Parse(Console.ReadLine());

                int answer = num1 * num2;

                if (answer == choice)
                {
                    Console.WriteLine("Very good!");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("No, Please try again");
                }
            }
        }

    }
}
