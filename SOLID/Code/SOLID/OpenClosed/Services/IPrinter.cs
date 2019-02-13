using System;
using System.Threading;
using static System.Console;
namespace SOLID.OpenClosed.Services
{
    public interface IPrinter
    {
        void GenerateSurveyPDF(int id);
    }
}
