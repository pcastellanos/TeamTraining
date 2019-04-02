using DesignPatterns._2.Structural.Facade.Client;
using DesignPatterns._3.Behavioural.Observer;
using System;

namespace DesignPatterns
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
            Console.WriteLine("************************** Design Patterns **************************");
            Console.WriteLine("Select one option of the following types of patterns to study: ");
            Console.WriteLine("1. Creational ");
            Console.WriteLine("2. Structural ");
            Console.WriteLine("3. Behavioural ");
        }

        /// <summary>
        /// Evaluates the selected option
        /// </summary>
        /// <param name="option">The user's option</param>
        private static void EvaluateOption(string option)
        {
            switch (option)
            {
                case "2":

                    StructuralMenu();
                    break;
                case "3":
                    BehaviouralMenu();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Menu for type of patterns: Behavioural
        /// </summary>
        private static void BehaviouralMenu()
        {
            Console.WriteLine("************************** Behavioural Design Patterns **************************");
            Console.WriteLine("Select one option to study: ");
            Console.WriteLine("1. Observer ");

            switch (Console.ReadLine())
            {
                case "1":
                    ObserverTestCase.PublishNews();
                    break;
                case "2":
                    

                    break;

                default:
                    break;
            }
        }


        private static void StructuralMenu()
        {
            Console.WriteLine("************************** Structural Design Patterns **************************");
            Console.WriteLine("Select one option to study: ");
            Console.WriteLine("1. Facade ");

            switch (Console.ReadLine())
            {
                case "1":
                    ClientTestCase.Process();
                    break;
                case "2":

                    break;

                default:
                    break;
            }
        }
    }
}