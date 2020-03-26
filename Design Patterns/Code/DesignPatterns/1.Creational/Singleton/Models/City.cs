using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1.Creational.Singleton.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string PopulationProper { get; set; }

        public string ISO2 { get; set; }
        public string Capital { get; set; }
        


        public override string ToString()
        {
            return $"{Name}, {Country}";
        }
    }
}
