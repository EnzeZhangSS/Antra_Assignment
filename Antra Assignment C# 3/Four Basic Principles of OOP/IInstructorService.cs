using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public interface IInstructorService<T> : IPersonService<T> where T: Instructor
    {
        void SetHead(Instructor obj);
    }

    public class InstructorService : IInstructorService <Instructor>
    {
        public int AgeCalc(Instructor obj)
        {
            Console.WriteLine($"Instructor {obj.Name}'s age is {(DateTime.Now-obj.Birthday).Days/365}");
            return (DateTime.Now - obj.Birthday).Days / 365;
        }
        public decimal SalaryCalc(Instructor obj)
        {
            Console.WriteLine($"Instructor {obj.Name}'s salary with bonus is {obj.SalaryCalc(obj.Salary,obj.JoinDate)}");
            return obj.SalaryCalc(obj.Salary, obj.JoinDate);
        }
        public decimal UpdateSalary(Instructor obj, decimal newSalary)
        {
            while (newSalary < 0)
            {
                Console.WriteLine("Salary can not be negative. Try another salary:");
                newSalary = decimal.Parse(Console.ReadLine());
            }
            obj.Salary = newSalary;
            Console.WriteLine($"Instructor {obj.Name}'s new salary is {obj.Salary}");
            return obj.Salary;

        }


        public void AddAddress(Instructor obj,string newAddress)
        {
            List<string> tempList = obj.Address;
            tempList.Add(newAddress);
            obj.Address = tempList;
            Console.WriteLine($"Instructor {obj.Name}'s new address list is:");
            foreach(string s in obj.Address)
            {
                Console.WriteLine($"{s}");
            }
        }
        public void SetHead(Instructor obj)
        {
            obj.IsHead = true;
            Console.WriteLine($"Instructor {obj.Name}'s now the head of department {obj.Department}");
        }
    }
}
