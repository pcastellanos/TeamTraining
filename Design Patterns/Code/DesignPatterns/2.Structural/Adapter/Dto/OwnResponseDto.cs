
using System;

namespace DesignPatterns._2.Structural.Adapter.Dto
{
    /// <summary>
    /// Our DTO to manage response
    /// </summary>
    public class OwnResponseDto
    {
        public string Codigo { get; set; }
        public string Message { get; set; }
        public DateTime DateProceed { get; set; }

    }
}
