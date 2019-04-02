using DesignPatterns._2.Structural.Facade.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Client
{
    public static class Client
    {

        public static void Process() {

            Console.Write("Enter employee Id");
            var employeeId = Console.ReadLine();

            var total = new EmployeeFacade().GetTotalIncomeEmployee(employeeId);

            Console.WriteLine("Total income employee {0} , {1}", employeeId, total);
            Console.ReadLine();
        }

    }
}
