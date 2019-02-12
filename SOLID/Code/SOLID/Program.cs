using SOLID.Single_Responsibility;
using SOLID.Single_Responsibility.Services;
using System;
using static System.Console;

namespace SOLID
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
            EvaluateOption(Console.ReadLine());
        }

        /// <summary>
        /// Menu to evaluate the option to be selected
        /// </summary>
        private static void Menu()
        {
            Console.WriteLine("************************** SOLID **************************");
            Console.WriteLine("Select one option of the following principles to study: ");
            Console.WriteLine("1. Single Responsibility ");
            Console.WriteLine("2. Open/Closed ");
            Console.WriteLine("3. Liskov Substitution ");
            Console.WriteLine("4. Interface Segregation ");
            Console.WriteLine("5. Dependency Inversion ");
        }

        /// <summary>
        /// Evaluates the selected option
        /// </summary>
        /// <param name="option">The user's option</param>
        private static void EvaluateOption(string option)
        {
            switch (option)
            {
                case "1":
                    SingleResponsibility();
                    break;
                case "2":
                    OpenClosed();
                    break;
                default:
                    break;
            }
        }

        private static void OpenClosed()
        {
            PDFPrinter printer = new PDFPrinter();
            printer.GenerateSurveyPDF(29);
            ReadLine();
        }

        /// <summary>
        /// Generates a Test Case for the SingleResponsibility
        /// </summary>
        private static void SingleResponsibility()
        {
            SRTestCase.CreateUser();
        }
    }
}