using System;

namespace jmb
{
    public class Student
    {
        string FirstName;
        string LastName;
        string RegNo;
        string Gender;
        int BirthYear;
        string Institution;
        string Course;
        bool IsAdmitted;

        public Student(string firstName, string lastName, string gender, int birthYear, string institution, string course)
        {
            FirstName = firstName;
            LastName = lastName;
            RegNo = GenerateRegNo();
            Gender = gender;
            BirthYear = birthYear;
            Institution = institution;
            Course = course;
            IsAdmitted = false;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }

        public string GetRegNo()
        {
            return RegNo;
        }

        public void SetRegNo(string regNo)
        {
            this.RegNo = regNo;
        }

        public string GetGender()
        {
            return Gender;
        }

        public void SetGender(string gender)
        {
            this.Gender = gender;
        }

        public int GetBirthYear()
        {
            return BirthYear;
        }

        public void SetBirthYear(int birthYear)
        {
            this.BirthYear = birthYear;
        }

        public string GetInstitution()
        {
            return Institution;
        }

        public void SetInstitution(string institution)
        {
            this.Institution = institution;
        }

        public string GetCourse()
        {
            return Course;
        }

        public void SetCourse(string course)
        {
            this.Course = course;
        }

        public bool GetIsAdmitted()
        {
            return IsAdmitted;
        }

        public void SetIsAdmitted(bool isAdmitted)
        {
            this.IsAdmitted = isAdmitted;
        }

        public string GenerateRegNo()
        {
            Random rand = new Random();
            string number = $"JM{rand.Next(0, 1000).ToString("0000")}{(char)('A' + rand.Next(0,26))}{(char)('A' + rand.Next(0, 26))}";
            return number;
        }
    }
}