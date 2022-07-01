using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        
        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday;  }
            set { birthday = value; }
        }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private List<string> address = new List<string>();
        
        public List<string> Address
        {
            get { return address; }
            set { address = value; }
        }
        public virtual decimal SalaryCalc(decimal salary, DateTime joinDate)
        {

            return salary + (1000 * (((DateTime.Now - joinDate).Days) / 365));
        }
    }
}
