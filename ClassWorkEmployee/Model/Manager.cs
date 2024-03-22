using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkEmployee.Model
{
    internal class Manager: Employee
    {
        public double OnSiteAllowance { get; set; }
        public double Bonus { get; set; }
        public override double ComputeSalary()
        {
            return base.ComputeSalary() + OnSiteAllowance + Bonus;
        }

    }
}
