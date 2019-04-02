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
            list = new List<Employee>() {

                new Employee {Id="1",Name= "David", Salary = 3000},
                new Employee {Id="2",Name= "Paula", Salary = 5000},
                new Employee {Id="3",Name= "Lucho", Salary = 6000},
                new Employee {Id="4",Name= "Juan Mira", Salary = 10000}
            };
        }


        public int GetSalaryEmployee(string employeeId) {

            return list.First(p => p.Id.Equals(employeeId)).Salary;
        }
    }
}
