using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Domain
{
    public class Incentive
    {
        public string Concept { get; set; }
        public int Value { get; set; }



        public List<Incentive> FillIncentives() {

            return  new List<Incentive>()
            {
                new Incentive { Concept = "Bono por Proyecto",Value= 200 },
                new Incentive { Concept = "Bono por Calculation",Value= 600 }
            };
        }
    }
}
