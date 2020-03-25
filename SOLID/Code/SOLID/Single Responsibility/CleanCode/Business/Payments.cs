using SOLID.Single_Responsibility.CleanCode.Entity;
using System;


namespace SOLID.Single_Responsibility.CleanCode.Business
{
    public class Payments
    {
        public void OrdinaryPayment(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee's payment");
        }

        public void BonusPayment(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee's bonus payment");
        }

        public void VacationsPayment(EmployeeEntity employeeEntity)
        {
            Console.WriteLine("Employee's vacations payment");
        }
    }
}
