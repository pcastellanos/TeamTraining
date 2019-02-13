using SOLID.Single_Responsibility.Services;
using System.Threading;
using static System.Console;

namespace SOLID.Single_Responsibility.Business
{
    public class FriendlyMessagePrinter : IPrinter
    {
        public void GenerateSurveyPDF(int id)
        {
            WriteLine($"Hi!!! I'm printing the survey {id}");
            for (int i = 0; i < 5; i++)
            {
                WriteLine("give me a minute, I'm finishing....");
                Thread.Sleep(500);
            }

            WriteLine($"PDF is ready, enjoy it!!!");
        }
    }
}
