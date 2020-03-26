using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Domain
{
    public class Employee
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        public List<Employee> FillEmployees() {

            return  new List<Employee>() {

                new Employee {Id="1",Name= "David", Salary = 3000},
                new Employee {Id="2",Name= "Paula", Salary = 5000},
                new Employee {Id="3",Name= "Lucho", Salary = 6000},
                new Employee {Id="4",Name= "Juan Mira", Salary = 10000}
            };

        }
    }
}
