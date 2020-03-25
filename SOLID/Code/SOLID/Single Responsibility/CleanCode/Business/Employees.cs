using SOLID.Single_Responsibility.CleanCode.Entity;
using System;


namespace SOLID.Single_Responsibility.CleanCode.Business
{
    public class Employees
    {

        public void Create(EmployeeEntity employeeEntity) 
        {
            Console.WriteLine("Employee created");
        }

        public void Update(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee updated");
        }

        public void Get(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee data");
        }

        public void Delete(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee deleted");
        }

    }

}
