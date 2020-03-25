using SOLID.Single_Responsibility.CleanCode.Entity;
using System;


namespace SOLID.Single_Responsibility.CleanCode
{
    public class Reports
    {
        public void SalesReport(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee's report for sales");
        }

        public void ManagementReport(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee's report for managers");
        }
    }
}
