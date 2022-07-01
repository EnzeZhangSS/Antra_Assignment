using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public class Student : Person
    {
        private List<string> courselist;
        public List<string> CourseList
        {
            get { return courselist; }
            set { courselist = value; }
        }
        private List<string> gradelist;
        public List<string> GradeList
        {
            get { return gradelist; }
            set { gradelist = value; }
        }
    }
}
