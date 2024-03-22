using ClassWorkEmployee.Model;

namespace ClassWorkEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter the Employee details");

            employee.EmpId = Convert.ToInt32(Console.ReadLine());
            employee.EmployeeName = Console.ReadLine();
            employee.Salary = Convert.ToInt32(Console.ReadLine());
            employee.DOB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Employee Salary:" + employee.ComputeSalary());
            Console.WriteLine();
            Console.WriteLine();

            Manager manager = new Manager();
            manager.EmpId = Convert.ToInt32(Console.ReadLine()); ;
            manager.EmployeeName = Console.ReadLine();
            manager.Salary = Convert.ToInt32(Console.ReadLine()); ;
            manager.DOB = Convert.ToDateTime(Console.ReadLine());
            manager.OnSiteAllowance = Convert.ToInt32(Console.ReadLine()); ;
            manager.Bonus = Convert.ToInt32(Console.ReadLine()); ;

            Console.WriteLine("Employee Salary:" + manager.ComputeSalary());


        }
    }
}
