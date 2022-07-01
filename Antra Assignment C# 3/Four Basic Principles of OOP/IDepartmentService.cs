using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public interface IDepartmentService<T> where T:class
    {
        void SetHead(T obj,string inst);

        void AddSchoolYear(T obj, string scyr);

        void AddBudget(T obj, decimal bgt);

        void AddCourse(T obj, string crs);
    }

    public class DepartmentService : IDepartmentService<Department>
    {
        public void AddBudget(Department obj, decimal bgt)
        {
            List<decimal> tempList = obj.Budget;
            tempList.Add(bgt);
            obj.Budget = tempList;
            Console.WriteLine($"Deparment {obj.DepartmentName}'s new budget list is:");
            foreach (decimal s in obj.Budget)
            {
                Console.WriteLine($"{s}");
            }
        }

        public void AddCourse(Department obj, string crs)
        {
            List<string> tempList = obj.CourseList;
            tempList.Add(crs);
            obj.CourseList = tempList;
            Console.WriteLine($"Deparment {obj.DepartmentName}'s new course list is:");
            foreach (string s in obj.CourseList)
            {
                Console.WriteLine($"{s}");
            } 
        }

        public void AddSchoolYear(Department obj, string scyr)
        {
            List<string> tempList = obj.SchoolYearList;
            tempList.Add(scyr);
            obj.SchoolYearList = tempList;
            Console.WriteLine($"Deparment {obj.DepartmentName}'s new school year list is:");
            foreach (string s in obj.SchoolYearList)
            {
                Console.WriteLine($"{s}");
            }
        }

        public void SetHead(Department obj, string inst)
        {
            obj.HeadName = inst;
            Console.WriteLine($"Deparment {obj.DepartmentName}'s new head is {obj.HeadName}");
        }
    }
}
