using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Facade.Domain
{
    public class Benefit
    {

        public string Name { get; set; }
        public int Value { get; set; }

        public List<Benefit> FillBenefits() {

            return new List<Benefit>() {
                new Benefit { Name= "Prima Grado", Value= 200 },
                new Benefit { Name = "Transporte", Value = 100 }

            };
        }

    }
}
