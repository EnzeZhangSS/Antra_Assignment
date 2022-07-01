using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public class Instructor : Person
    {
        
        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private bool isHead;
        public bool IsHead
        {
            get { return isHead; }
            set { isHead = value; }
        }


        private DateTime joindate;
        public DateTime JoinDate
        {
            get { return joindate; }
            set { joindate = value; }
        }

        public override decimal SalaryCalc(decimal salary, DateTime joinDate)
        {

            return salary + (1500 * (((DateTime.Now - joinDate).Days) / 365));
        }

    }
}
