using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public interface IStudentService<T> : IPersonService<T> where T : Student
    {
        void AddCourse(Student obj,string course);
        void AddScore(Student obj, string score);
        float GPACalc(Student obj);

    }

    public class StudentService : IStudentService<Student>
    {
        public void AddAddress(Student obj, string newAddress)
        {
            List<string> tempList = obj.Address;
            tempList.Add(newAddress);
            obj.Address = tempList;
            Console.WriteLine($"Student {obj.Name}'s new address list is:");
            foreach (string s in obj.Address)
            {
                Console.WriteLine($"{s}");
            }
        }

        public void AddCourse(Student obj, string course)
        {
            List<string> tempList = obj.CourseList;
            tempList.Add(course);
            obj.CourseList = tempList;
            Console.WriteLine($"Student {obj.Name}'s new course list is:");
            foreach (string s in obj.CourseList)
            {
                Console.WriteLine($"{s}");
            }
        }

        public void AddScore(Student obj, string score)
        {
            List<string> tempList = obj.GradeList;
            tempList.Add(score);
            obj.GradeList = tempList;
            Console.WriteLine($"Student {obj.Name}'s new grade list is:");
            foreach (string c in obj.GradeList)
            { 
                Console.WriteLine($"{c}");
            }
        }

        public int AgeCalc(Student obj)
        {
            Console.WriteLine($"Student {obj.Name}'s age is {(DateTime.Now - obj.Birthday).Days / 365}");
            return (DateTime.Now - obj.Birthday).Days / 365;
        }

        public float GPACalc(Student obj)
        {
            float GPA = 0;
            foreach(string s in obj.GradeList)
            {
                switch (s)
                {
                    case "A":
                        GPA += 4;
                        break;
                    case "B":
                        GPA += 3;
                        break;
                    case "C":
                        GPA += 2;
                        break;
                    case "D":
                        GPA += 1;
                        break;
                }
            }
            GPA = GPA / obj.GradeList.Count;
            return GPA;
        }

        public decimal SalaryCalc(Student obj)
        {
            throw new NotImplementedException();
        }

        public decimal UpdateSalary(Student obj, decimal newSalary)
        {
            throw new NotImplementedException();
        }
    }


}
