using System;
using System.Collections.Generic;

namespace jmb
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            List<Student> memory = new List<Student>();

            while (flag)
            {
                Menu();
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("***REGISTRATION***");
                    Console.WriteLine("Enter your first name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter your last name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter your gender");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Enter your institution");
                    string institution = Console.ReadLine();
                    Console.WriteLine("Enter your course");
                    string course = Console.ReadLine();
                    Console.WriteLine("Enter birth year");
                    int birthYear = int.Parse(Console.ReadLine());

                    if (DateTime.Now.Year - birthYear >= 18)
                    {
                        var student = new Student(firstName, lastName, gender, birthYear, institution, course);
                        memory.Add(student);
                        Console.WriteLine($"Congratulations, your reg number is {student.GetRegNo()}");
                    }

                    else
                    {
                        Console.WriteLine("You are not qualified to apply");
                        flag = false;
                    }
                }

                else if (choice == 2)
                {
                    Console.WriteLine("***CHECK ADMISSION STATUS***");
                    Console.WriteLine("Enter your reg number:");
                    string regNo = Console.ReadLine();

                    foreach (var item in memory)
                    {
                        if (item.GetRegNo() == regNo)
                        {
                            if (item.GetIsAdmitted() == false)
                            {
                                Console.WriteLine("You are not admitted yet");
                            }
                            else
                            {
                                Console.WriteLine($"Congratulations!! you've been offered admission to study {item.GetCourse()} in {item.GetInstitution()}");
                            }
                        }
                    }

                }

                else if (choice == 3)
                {
                    Console.WriteLine("***UPDATE***");
                    Console.WriteLine("Enter your reg number:");
                    string regNo = Console.ReadLine();

                    foreach (var item in memory)
                    {
                        if (item.GetRegNo() == regNo)
                        {
                            Console.WriteLine($"Enter new first name: {item.GetFirstName()}");
                            string firstName = Console.ReadLine();
                            item.SetFirstName(firstName);
                            Console.WriteLine($"Enter new last name: {item.GetLastName()}");
                            string lastName = Console.ReadLine();
                            item.SetLastName(lastName);
                            Console.WriteLine($"Enter new gender: {item.GetGender()}");
                            string gender = Console.ReadLine();
                            item.SetGender(gender);
                            Console.WriteLine($"Enter new institution: {item.GetInstitution()}");
                            string institution = Console.ReadLine();
                            item.SetInstitution(institution);
                            Console.WriteLine($"Enter your course: {item.GetCourse()}");
                            string course = Console.ReadLine();
                            item.SetCourse(course);
                            Console.WriteLine($"Enter birth year: {item.GetBirthYear()}");
                            int birthYear = int.Parse(Console.ReadLine());
                            item.SetBirthYear(birthYear);

                            Console.WriteLine("Update Succesful");
                        }

                        else
                        {
                            Console.WriteLine("Wrong registration number");
                        }
                    }
                }

                else if (choice == 4)
                {
                    Submenu();
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.WriteLine("***ADMISSION BY REG NO***");
                        Console.WriteLine("Enter your reg number:");
                        string regNo = Console.ReadLine();

                        foreach (var item in memory)
                        {
                            if (item.GetRegNo() == regNo)
                            {
                                item.SetIsAdmitted(true);
                            }
                        }
                        Console.WriteLine("Success");

                    }

                    else if (option == 2)
                    {
                        Console.WriteLine("***ADMISSION BY COURSE***");
                        Console.WriteLine("Enter the course:");
                        string course = Console.ReadLine();

                        foreach (var item in memory)
                        {
                            if (item.GetCourse() == course)
                            {
                                item.SetIsAdmitted(true);
                            }
                        }
                        Console.WriteLine("Success");
                    }

                    else if (option == 3)
                    {
                        Console.WriteLine("***ADMISSION BY INSTITUTION***");
                        Console.WriteLine("Enter the institution:");
                        string institution = Console.ReadLine();

                        foreach (var item in memory)
                        {
                            if (item.GetInstitution() == institution)
                            {
                                item.SetIsAdmitted(true);
                            }
                        }
                        Console.WriteLine("Success");
                    }

                    else if (option == 4)
                    {
                        Menu();
                    }

                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }

                else if (choice == 5)
                {
                    flag = false;
                }

                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("***MAIN MENU***\nEnter 1 to Register\nEnter 2 to Check Admission Status\nEnter 3 to Update\nEnter 4 to Admit Student\nEnter 5 to Exit");
        }

        public static void Submenu()
        {
            Console.WriteLine("Enter 1 Admit by Reg No\nEnter 2 to Admit by Course\nEnter 3 to Admit by Institution\nEnter 4 to go back to main menu");
        }
    }
}
