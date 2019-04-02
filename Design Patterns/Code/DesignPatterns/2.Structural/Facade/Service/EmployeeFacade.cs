using DesignPatterns._2.Structural.Facade.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Service
{
    public class EmployeeFacade
    {
        public double GetTotalIncomeEmployee(string employeeId) {

            var payRoll = new Payroll();
            var benefit = new Benefits();
            var incentive = new Incentives();

            var salary = payRoll.GetSalaryEmployee(employeeId);
            var totalBenefis = benefit.GetBenefitsEmployee(employeeId).Sum(p => p.Value);
          //  var totalIncetives = incentive.GetIncentivesEmployee(employeeId).Sum(p => p.Value);

            return salary + totalBenefis ;
        }

    }
}
