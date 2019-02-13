using SOLID.OpenClosed.Services;
using static System.Console;
using System.Threading;

namespace SOLID.OpenClosed.BusinessLogic
{
    public class FriendlyMessagePrinter : IPrinter
    {
        public void GenerateSurveyPDF(int id)
        {
            WriteLine($"Hi!!! I'm printing the survey {id}");
            for (int i = 0; i < 5; i++)
            {
                WriteLine("give me a minute, I'm just finishing....");
                Thread.Sleep(500);
            }

            WriteLine($"PDF is ready, enjoy it!!!");
        }
    }
}
