using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Adapter.ApiSimulation.DtoApi
{
    /// <summary>
    /// We guess this comes from a web service in the contract
    /// </summary>
    public class ReponseAmerican
    {
        public string CodeAmerican { get; set; }
        public string Description { get; set; }
        public string Agency { get; set; }
    }
}
