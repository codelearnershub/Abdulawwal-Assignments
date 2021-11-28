using System;

namespace number15
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

            string[] rights = { "Very good!", "Excellent!", "Nice work!", "Keep up the good work!" };
            string[] wrongs = { "No.Please try again.", "Wrong.Try once more.", "Don't give up!", "No. Keep trying." };


            bool flag = true;
            while (flag)
            {
                Console.WriteLine($"How much is {num1} times {num2}");
                int choice = int.Parse(Console.ReadLine());

                int answer = num1 * num2;

                if (answer == choice)
                {
                    int rightIndex = number.Next(rights.Length + 1);
                    Console.WriteLine($"{rights[rightIndex]}");
                    flag = false;
                }
                else
                {
                    int wrongIndex = number.Next(rights.Length + 1);
                    Console.WriteLine($"{wrongs[wrongIndex]}");
                }
            }
        }
    }
}
