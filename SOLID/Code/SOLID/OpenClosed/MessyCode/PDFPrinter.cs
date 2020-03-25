using static System.Console;
using System.Threading;

namespace SOLID.OpenClosed.MessyCode
{
    public class PDFPrinter
    {
        public void GenerateSurveyPDF(int id)
        {
            WriteLine($"Printing survey {id}");
            for (int i = 0; i < 5; i++)
            {
                WriteLine("Working....");
                Thread.Sleep(500);
            }

            WriteLine($"PDF of survey {id} is ready to be downloaded!!");
        }
    }
}
