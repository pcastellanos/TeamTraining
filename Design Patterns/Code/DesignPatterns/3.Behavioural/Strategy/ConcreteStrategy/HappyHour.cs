using System;

namespace DesignPatterns._3.Behavioural.Strategy.ConcreteStrategy
{
    /// <summary>
    /// Defines the algorithm to calculate the beer's price in Happy hour
    /// </summary>
    public class HappyHour : IStrategy
    {
        /// <summary>
        /// Implementation of the <see cref="IStrategy.GetBeerPrice(double)"/>
        /// </summary>
        public double GetBeerPrice(double value)
        {
            Console.WriteLine("You are in Happy Hour, the original beer's price is: " + value);

            double result = value / 2;
            Console.WriteLine("The final beer's price is: " + result);

            return result;
        }
    }
}