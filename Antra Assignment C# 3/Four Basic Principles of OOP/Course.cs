using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public class Course
    {
        private string coursename;
        public string CourseName
        {
            get { return coursename; }
            set { coursename = value; }
        }

        private List<string> studentlist;
        public List<string> StudentList
        {
            get { return studentlist; }
            set { studentlist = value; }
        }

    }
}
