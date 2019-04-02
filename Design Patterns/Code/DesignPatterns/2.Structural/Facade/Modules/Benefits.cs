using DesignPatterns._2.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Modules
{
    public class Benefits
    {
        List<Benefit> list;
        public Benefits() {

            list = new List<Benefit>() {
                new Benefit { Name= "Prima Grado", Value= 200 },
                new Benefit { Name = "Transporte", Value = 100 }

            };
        }

        public List<Benefit> GetBenefitsEmployee(string employeeId) {

            // Business rules by employeee

            return list;
        }
    }
}
