using DesignPatterns._2.Structural.Adapter;
using DesignPatterns._2.Structural.Facade.Client;
using DesignPatterns._3.Behavioural.Observer;
using DesignPatterns._3.Behavioural.Strategy;
using DesignPatterns._3.Behavioural.ChainOfResponsability;
using System;

namespace DesignPatterns
{
    using _4._Factory;

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
                case "1":
                    CreationalMenu();
                    break;
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
            Console.WriteLine("2. Strategy ");
            Console.WriteLine("3. Chain Of Responsability");

            switch (Console.ReadLine())
            {
                case "1":
                    ObserverTestCase.PublishNews();
                    break;

                case "2":
                    StrategyTestCase.GetBeerPrice();
                    break;

                default:
                    Filter.FilterUsers();
                    Console.ReadLine();
                    break;
            }
        }

        private static void StructuralMenu()
        {
            Console.WriteLine("************************** Structural Design Patterns **************************");
            Console.WriteLine("Select one option to study: ");
            Console.WriteLine("1. Facade ");
            Console.WriteLine("2. Adapter ");

            switch (Console.ReadLine())
            {
                case "1":
                    Client.Process();
                    break;

                case "2":
                    ClientApplication.Process();
                    Console.ReadLine();
                    break;

                default:
                    break;
            }
        }

        private static void CreationalMenu()
        {
            Console.WriteLine("************************** Creational Design Patterns **************************");
            Console.WriteLine("Select one option to study: ");
            Console.WriteLine("1. Factory ");

            switch (Console.ReadLine())
            {
                case "1":
                    FactoryTestCase.DrawShapes();
                    break;
            }
        }
    }
}