using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random nums = new Random();
                int computerValue = nums.Next(0, 1000);
                Console.WriteLine(computerValue);
                for (; ; )
                {
                    Console.WriteLine("Guess a number between 1 and 1000:");
                    int yourGuess = int.Parse(Console.ReadLine());

                    if (yourGuess == computerValue)
                    {
                        Console.WriteLine("You are correct");
                        Console.WriteLine("Do you want to play again? Y/N:");
                        char option = char.Parse(Console.ReadLine());

                        if (option == 'N')
                        {
                            Console.WriteLine("Thank you");
                            break;
                        }

                    }

                    else if (yourGuess > computerValue)
                    {
                        Console.WriteLine("Guess too high, try again");
                    }

                    else if (yourGuess < computerValue)
                    {
                        Console.WriteLine("Guess too low, try again");
                    }
                }

            }
        }
    }
}
