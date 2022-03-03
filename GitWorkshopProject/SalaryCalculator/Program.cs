using System;

namespace SalaryCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);
      var expertSalary = EmployeeService.CalculateSalary(EmployeeType.Expert, 9);

      var managerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 7);

      Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));
      Console.WriteLine(string.Format("Engineer's Salary: {0}", managerSalary));
      Console.WriteLine(string.Format("Expert's Salary: {0}", expertSalary));
      Console.ReadLine();
    }
  }
}
