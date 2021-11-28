using System;

namespace number16
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIndex = 0;

            Console.WriteLine("Enter the number of students: ");
            int noOfStudents = int.Parse(Console.ReadLine());
            string[] students = new string[noOfStudents];
            int[] scores = new int[noOfStudents];
            for (int i = 0; i < noOfStudents; i++)
            {
                Console.WriteLine("Name of Student: ");
                students[i] = Console.ReadLine();
                Console.WriteLine("Score:");
                scores[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > scores[maxIndex])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine($"the student with highest score is {students[maxIndex]} with {scores[maxIndex]} ");
        }
    }
}
