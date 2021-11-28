using System;
using System.Collections.Generic;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int computerGuess = number.Next(100, 1000);
            Console.WriteLine(computerGuess);
            Console.WriteLine("Enter a 3-digit number:");
            int yourGuess = int.Parse(Console.ReadLine());
            
            if(computerGuess == yourGuess)
            {
                Console.WriteLine("Congratulations, you won $10,000");
            }

            var a = computerGuess.ToString().ToCharArray();
            var b = yourGuess.ToString().ToCharArray();
            int count = 0;

            if(computerGuess != yourGuess)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (a[i] == b[j])
                        {
                            count++;
                            a[i] = ' ';
                        }
                    }
                }
            }  
            
            if(count == 3)
            {
                Console.WriteLine("Congratulations, you won $3,000");
            }
            else if(count == 1 || count == 2)
            {
                Console.WriteLine("Congratulations, you won $1,000");
            }
        }
    }
}
