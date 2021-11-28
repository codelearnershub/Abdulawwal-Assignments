using System;

namespace number17
{
    class Program
    {
        static void Main(string[] args)
        {


            int maxIndex = 0;
            int secondHighestIndext = 0;

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
                    secondHighestIndext = maxIndex;
                    maxIndex = i;
                }

                else if(scores[i] > scores[secondHighestIndext] && scores[i] < scores[maxIndex])
                {
                    secondHighestIndext = i;
                }
            }
            Console.WriteLine($"the student with highest score is {students[maxIndex]} with {scores[maxIndex]} ");
            Console.WriteLine($"the student with second highest score is {students[secondHighestIndext]} with {scores[secondHighestIndext]} ");
        }
    }
}
