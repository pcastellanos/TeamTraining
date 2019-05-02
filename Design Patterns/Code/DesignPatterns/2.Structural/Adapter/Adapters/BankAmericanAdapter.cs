using DesignPatterns._2.Structural.Adapter.ApiSimulation;
using DesignPatterns._2.Structural.Adapter.ApiSimulation.DtoApi;
using DesignPatterns._2.Structural.Adapter.Dto;
using DesignPatterns._2.Structural.Adapter.Interfaces;
using System;

namespace DesignPatterns._2.Structural.Adapter.Adapters
{
    internal class BankAmericanAdapter : IBank
    {
        private ApiBankAmerican apiBankAmerica;
        public BankAmericanAdapter()
        {
            apiBankAmerica = new ApiBankAmerican();
        }

        public OwnResponseDto ProcessLoan(OwnRequestDto ownRequestDto)
        {
            Console.WriteLine("Conectando con Api Bank American");
            apiBankAmerica.ValidatePersonalInformation(ownRequestDto.Id.ToString());
            var americanResponse = apiBankAmerica.BankLoan(OwnRequestInfoAmerican(ownRequestDto));

            return ReponseAmericanOwnReponse(americanResponse);
        }


        private InfoAmerican OwnRequestInfoAmerican(OwnRequestDto ownRequestDto)
        {
            return new InfoAmerican
            {
                IdUser = ownRequestDto.Id.ToString(),
                Amount = ownRequestDto.AmountLoan,
                IdType = "CE"


            };
        }

        private OwnResponseDto ReponseAmericanOwnReponse(ReponseAmerican reponseAmerican)
        {

            return new OwnResponseDto
            {
                Codigo = reponseAmerican.CodeAmerican,
                Message = string.Format("-->>Message: {0}, Agency: {1}", reponseAmerican.Description, reponseAmerican.Agency),
                DateProceed = DateTime.Now
            };
        }
    }
}
