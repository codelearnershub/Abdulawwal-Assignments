using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] coin = {"Head" , "Tail"};
           Random rdm = new Random();
           int guess = rdm.Next(coin.Length);
           Console.WriteLine(coin[guess]);


            Console.WriteLine("Guess the flip that the computer generated: 1 = Tail , 0 = Head");
            int ans = int.Parse(Console.ReadLine());

            if(ans == guess)
            {
                Console.WriteLine("Wow!! You guessed correctly.");
            }

            else
            {
                Console.WriteLine("Oops!! You guessed wrongly.");
            }
        }
    }
}
