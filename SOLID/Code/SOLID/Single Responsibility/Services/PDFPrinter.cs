using System;
using System.Threading;
using static System.Console;
namespace SOLID.Single_Responsibility.Services
{
    public interface IPrinter
    {
        void GenerateSurveyPDF(int id);
    }
}
