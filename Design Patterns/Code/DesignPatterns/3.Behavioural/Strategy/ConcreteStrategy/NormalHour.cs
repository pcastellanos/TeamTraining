using System;

namespace DesignPatterns._3.Behavioural.Strategy.ConcreteStrategy
{
    /// <summary>
    /// Defines the algorithm to calculate the beer's price in Normal hour
    /// </summary>
    public class NormalHour : IStrategy
    {
        public double GetBeerPrice(double value)
        {
            Console.WriteLine("You are in Normal Hour, the beer's price is: " + value);
            return value;
        }
    }
}