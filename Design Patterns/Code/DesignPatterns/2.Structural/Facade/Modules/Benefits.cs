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

            list = new Benefit().FillBenefits();
        }

        public List<Benefit> GetBenefitsEmployee(string employeeId) {

            // Business rules by employeee

            return list;
        }
    }
}
