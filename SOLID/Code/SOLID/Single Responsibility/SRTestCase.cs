using SOLID.Single_Responsibility.BadCode;
using SOLID.Single_Responsibility.CleanCode;
using SOLID.Single_Responsibility.CleanCode.Business;
using SOLID.Single_Responsibility.CleanCode.Entity;

namespace SOLID.Single_Responsibility
{
    /// <summary>
    /// Class to show Single Responsibility Test Case
    /// </summary>
    internal class SRTestCase
    {
        //MessyCode
        internal static void CreateEmployee()
        {
            Employee  employee  = new Employee();

            //HR request to add more data
            employee.CreateEmployee(new Employee{ Id = 1, FirstName = "John", LastName = "Doe", Salary = 500 });

            //Financial chief requets to modify formula
            employee.CalculatePay();

            //Sales request a new report
            employee.PrintReport(); 
        }

        //CleanCode
        internal static void EmployeeProcess()
        {
            EmployeeEntity employeeEntity = new EmployeeEntity { Id = 2, FirstName = "Jane", LastName = "Doe", Salary = 800 };

            Employees _employees = new Employees();
            Reports _reports = new Reports();
            Payments _payments = new Payments();

            _employees.Create(employeeEntity);
            _reports.ManagementReport(employeeEntity);
            _payments.BonusPayment(employeeEntity);

        }

    }
}