using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public class Department
    {
        private string departmentName;
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        private string headName;
        public string HeadName
        {
            get { return headName; }
            set { headName = value; }
        }



        private List<decimal> budget;
        public List<decimal> Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        private List<string> schoolyearlist;
        public List<string> SchoolYearList
        {
            get { return schoolyearlist; }
            set { schoolyearlist = value; }
        }



        private List<string> courselist;
        public List<string> CourseList
        {
            get { return courselist; }
            set { courselist = value; }
        }


    }
}
