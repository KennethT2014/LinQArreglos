using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryingArrayEmployeeObjectsUsingLINQ
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }

        private decimal monthlySalary;

        public Employee(string firstName, string lastName, decimal monthlySalary) 
        {
            FirstName = firstName;
            LastName = lastName;
            monthlySalary = monthlySalary;
        }

        public decimal MonthlySalary
        {
            get { return monthlySalary; }
            set 
            { 
                if(value >= 0M)
                {
                    monthlySalary = value;
                } 
            }
        }
    }
}
