using DesignPatterns._2.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Modules
{
    public class Payroll
    {
        List<Employee> list;

        public Payroll() {

            list = new Employee().FillEmployees();
        }


        public int GetSalaryEmployee(string employeeId) {

            return list.First(p => p.Id.Equals(employeeId)).Salary;
        }
    }
}
