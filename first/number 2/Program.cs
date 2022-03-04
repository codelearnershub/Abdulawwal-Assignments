using System;

namespace Question_2
{
    class Program
    {

        
        static void Main(string[] args)
        {
            int headCount = 0;
            int tailCount = 0;

            Console.WriteLine("Do you want to toss? Y/N:");
            char option = char.Parse(Console.ReadLine());

            if(option == 'Y')
            {
                for(;;)
                {
                    if(Flip() == true)
                    {
                        headCount++;
                    }

                    else
                    {
                        tailCount++;
                    }

                    // Console.WriteLine(" Enter No to stop the game: ");
                    // string choice = Console.ReadLine();

                    // if(choice == "No")
                    // {
                    //     break;
                    // }

                    
                }
                Console.WriteLine($"The head was tossed {headCount} and the tail was tossed {tailCount}");
            }
        }

        public static bool Flip ()
        {
            string [] toss = {"Head" , "Tail"};
            bool flip = true;
            Random rdm = new Random();
            int index = rdm.Next(toss.Length);
            Console.WriteLine(toss[index]);

            if(index == 0)
            {
                flip = true;
            }
            else if(index == 1)
            {
                flip = false;
            }

            return flip;
        }
    }
}