using System;

namespace number10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the score: ");
            int score = int.Parse(Console.ReadLine());

            if (score < 0 || score > 9)
            {
                Console.WriteLine("Wrong Input");
            }

            else if (score > 0 && score < 9)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == score && score <= 3)
                    {
                        score *= 10;
                    }

                    else if (i == score && score <= 6)
                    {
                        score *= 100;
                    }
                    else if (i == score && score <= 9)
                    {
                        score *= 1000;
                    }
                }
                Console.WriteLine(score);
            }
        }
    }
}
