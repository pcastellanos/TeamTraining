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

            list = new Incentive().FillIncentives();
        }

        public List<Incentive> GetIncentivesEmployee(string employeeId) {

            // Add business rules by employee

            return list;

        }

    }
}
