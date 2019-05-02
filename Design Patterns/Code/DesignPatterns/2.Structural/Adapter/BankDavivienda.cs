using DesignPatterns._2.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns._2.Structural.Adapter.Dto;

namespace DesignPatterns._2.Structural.Adapter
{
    internal class BankDavivienda : IBank
    {
        public OwnResponseDto ProcessLoan(OwnRequestDto ownRequestDto)
        {
            var message = string.Empty;
            var code = string.Empty;
            Console.WriteLine("We are processing the loan with Davivienda Bank");

            if (!ownRequestDto.tieneReferenciasPersonales)
            {
                code = "400";
                message = "- You must have personal references to process the loan \n";
            }
            if (ownRequestDto.AmountLoan < 100000)
            {
                code += "600";
                message += "- The amount must be greater than 100000\n";
            }
            return new OwnResponseDto
            {
                Codigo = code,
                Message = message,
                DateProceed = DateTime.Now

            };
        }
    }
}
