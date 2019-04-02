using DesignPatterns._2.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Modules
{
    public class Incentives
    {
        List<Incentive> list;
        public Incentives() {

            list = new List<Incentive>()
            {
                new Incentive { Concept = "Bono por SSP",Value= 200 },
                new Incentive { Concept = "Bono por Calculation",Value= 600 }
            };
        }

        public List<Incentive> GetIncentivesEmployee(string employeeId) {

            // Add business rules by employee

            return list;

        }

    }
}
