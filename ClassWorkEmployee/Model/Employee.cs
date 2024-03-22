using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkEmployee.Model
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public DateTime DOB { get; set; }

        public virtual double ComputeSalary()
        {
            return Salary;
        }


    }
}
