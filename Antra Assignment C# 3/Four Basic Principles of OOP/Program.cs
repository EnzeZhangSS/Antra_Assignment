using System;

namespace Four_Basic_Principles_of_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor Joe = new Instructor();
            Joe.Name = "Joe";
            Joe.Birthday = new DateTime(1998, 1, 9);
            Console.WriteLine($"The instructor name is {Joe.Name}, and birthday is {Joe.Birthday.Date}");
            Joe.Salary = 5000;
            Joe.JoinDate = new DateTime(2020, 1, 1);
            Console.WriteLine($"His salary with bonus is:{Joe.SalaryCalc(Joe.Salary,Joe.JoinDate)}");
            InstructorService IS1 = new InstructorService();
            IS1.AgeCalc(Joe);
            IS1.SalaryCalc(Joe);
            Joe.Department = "Math";
            IS1.SetHead(Joe);
        }
    }
}
