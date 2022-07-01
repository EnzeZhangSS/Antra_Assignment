using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Basic_Principles_of_OOP
{
    public interface IPersonService<T> where T : class
    {
        int AgeCalc(T obj);
        decimal SalaryCalc(T obj);
        decimal UpdateSalary(T obj,decimal newSalary);
        void AddAddress(T obj,string newAddress);

    }
}
