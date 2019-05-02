using DesignPatterns._2.Structural.Adapter.Adapters;
using DesignPatterns._2.Structural.Adapter.Dto;
using DesignPatterns._2.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2.Structural.Adapter
{
    public static class ClientApplication
    {

        public static void Process() {

            var request = new OwnRequestDto
            {
                Id = 888,
                AmountLoan = 900000
            };

            List<IBank> listBank= new List<IBank>();
            listBank.Add(new BankDavivienda());
            listBank.Add(new BankAgrario());
            listBank.Add(new BankAmericanAdapter());


            foreach (var item in listBank)
            {
                var response = item.ProcessLoan(request);

                Console.WriteLine("Code {0} Message: {1} , Date {2}", response.Codigo, response.Message, response.DateProceed);
            }
        }
    }
}
