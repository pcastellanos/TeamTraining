using SOLID.OpenClosed.BusinessLogic;
using SOLID.OpenClosed.Services;
using SOLID.Single_Responsibility;
using System;
using SOLID.Liskov;
using static System.Console;
using SOLID.InterfaceSegregation;
using SOLID.DependencyInversion;

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
                case "3":
                    Liskov();
                    break;
                case "4":
                    InterfaceSegregation();
                    break;
                case "5":
                    DependencyInversion();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Generates a Test Case for the Interface Segregation
        /// </summary>
        private static void InterfaceSegregation()
        {
            ISTestCase.Start();
        }

        private static void OpenClosed()
        {
            IPrinter friendlyPrinter = new FriendlyMessagePrinter();
            WriteLine("Friendly implementation");
            ReadLine();
            friendlyPrinter.GenerateSurveyPDF(29);
            ReadLine();
            IPrinter basicPrinter = new BasicMessagePrinter();
            WriteLine("Basic implementation");
            ReadLine();
            basicPrinter.GenerateSurveyPDF(40);
            ReadLine();
        }

        /// <summary>
        /// Generates a Test Case for the SingleResponsibility
        /// </summary>
        private static void SingleResponsibility()
        {
            SRTestCase.CreateUser();
        }

        private static void Liskov()
        {
            WriteLine("Bad implementation, calculate area");
            ReadLine();
            CalculateAreaBadImplementation.CalculateArea();

            WriteLine("Good implementation, calculate area");
            ReadLine();
            CalculateAreaBetterImplementation.CalculateArea();
        }

        /// <summary>
        /// Dependency inversion principle (DPI)
        /// </summary>
        private static void DependencyInversion() {

            DipTest.RunExampleDip();

        }
    }
}