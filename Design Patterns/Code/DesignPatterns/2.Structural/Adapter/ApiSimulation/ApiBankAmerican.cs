using DesignPatterns._2.Structural.Adapter.ApiSimulation.DtoApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Adapter.ApiSimulation
{
    internal class ApiBankAmerican
    {
        private bool passedCriminalRecord = false;

        public ApiBankAmerican()
        {
            passedCriminalRecord = false;
        }
        public void ValidatePersonalInformation(string id)
        {

            Console.WriteLine("Validate  Interpol service .. ");

            if (id == "888")
            {
                passedCriminalRecord = false;
            }
            else
            {
                passedCriminalRecord = true;
            }

        }

        public ReponseAmerican BankLoan(InfoAmerican infoAmerican)
        {

            var response = new ReponseAmerican();
            if (!passedCriminalRecord)
            {
                response.CodeAmerican = "01";
                response.Description = "The user has a criminal Records\n";
                response.Agency = "Interpol";
            }
            if (infoAmerican.Amount > 4000)
            {
                response.CodeAmerican += ",02";
                response.Description += ",The bank does not approve loans greater than 4000\n";
                response.Agency += " ,Bank";
            }
            if (!infoAmerican.IdType.Equals("CE"))
            {
                response.CodeAmerican += ",03";
                response.Description += ",The bank only accepted ID Type = CE\n";
                response.Agency += " ,Bank";
            }

            return response;
        }
    }
}
