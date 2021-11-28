using System;

namespace number11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            if (number <= 20)
            {
                Console.WriteLine($"{Words(number)}");
            }

            else if (number > 20 && number <= 99)
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine($"{Words(number)}");

                }
                else
                {
                    int hundred = number / 10;
                    string b = Tens(hundred);

                    int unit = number % 10;
                    string c = Words(unit);

                    Console.WriteLine($"{b} {c}");
                }
            }

            else if (number > 99)
            {

                int a = number / 100;
                int bc = number % 100;

                int b = bc / 10;
                int c = bc % 10;
                if(b == 0 && c == 0)
                {
                    Console.WriteLine($"{Words(a)} hundred");
                }

                else if(c == 0) 
                {
                    Console.WriteLine($"{Words(a)} hundred and {Tens(b)}");
                }

                else if(b == 1)
                {
                    Console.WriteLine($"{Words(a)} hundred and {Words(bc)}");
                } 

                else
                {
                    Console.WriteLine($"{Words(a)} hundred and {Tens(b)} {Words(c)}");
                }
            }
        }

        public static string Words(int num) => num switch
        {
            0 => "Zero",
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            10 => "Ten",
            11 => "Eleven",
            12 => "Twelve",
            13 => "Thirteen",
            14 => "Fourteen",
            15 => "Fifteen",
            16 => "Sixteen",
            17 => "Seventeen",
            18 => "Eighteen",
            19 => "Nineteen",
            20 => "Twenty",
            30 => "Thirty",
            40 => "Forty",
            50 => "Fifty",
            60 => "Sixty",
            70 => "Seventy",
            80 => "Eighty",
            90 => "Nighty",
            _ => null,
        };

        public static string Tens(int num) => num switch
        {
            2 => "Twenty",
            3 => "Thirty",
            4 => "Forty",
            5 => "Fifty",
            6 => "Sixty",
            7 => "Seventy",
            8 => "Eighty",
            9 => "Nighty",
            _ => null,
        };
    }
}
