using System;

namespace SOLID.Single_Responsibility.BadCode
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Salary { get; set; }

        public int CalculatePay()
        {
            Console.WriteLine("Employee's Salary");
            return 0; 
        }

        public bool CreateEmployee(Employee employee)
        {
            Console.WriteLine("Employee created");
            return true;
        }

        public void PrintReport()
        {
            Console.WriteLine("Employee's Report");
        }

        public void PrintReportSales()
        {
            Console.WriteLine("Employee's Report for Sales");
        }
    }
}
