using System;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] suits = { "spades", "hearts", "diamonds", "clubs" };
            char[] cards = { 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'K', 'Q' };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine($"{suits[i]} {cards[j]}");
                }
            }
        }
    }
}
