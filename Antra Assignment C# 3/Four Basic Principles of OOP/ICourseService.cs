using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public interface ICourseService<T>
    {
        void AddStudent(T obj, string student);
    }

    public class CourseService : ICourseService<Course>
    {
        public void AddStudent(Course obj, string student)
        {
            List<string> tempList = obj.StudentList;
            tempList.Add(student);
            obj.StudentList = tempList;
            Console.WriteLine($"Course {obj.CourseName}'s new student list is:");
            foreach (string s in obj.StudentList)
            {
                Console.WriteLine($"{s}");
            }

        }

    }

}
