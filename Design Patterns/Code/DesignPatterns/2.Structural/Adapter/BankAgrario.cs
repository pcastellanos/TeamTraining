using DesignPatterns._2.Structural.Adapter.Interfaces;
using System;
using DesignPatterns._2.Structural.Adapter.Dto;

namespace DesignPatterns._2.Structural.Adapter
{
    internal class BankAgrario : IBank
    {
        public OwnResponseDto ProcessLoan(OwnRequestDto ownRequestDto)
        {
            var message = string.Empty;
            var code = string.Empty;

            Console.WriteLine("We are processing the loan with  Agrario Bank");

            if (!ownRequestDto.tieneReferenciasPersonales)
            {
                code = "300";
                message = "You must have personal references to process the loan \n";
            }
            else
            {
                code = "200";
                message = "The loan can be granted";
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
