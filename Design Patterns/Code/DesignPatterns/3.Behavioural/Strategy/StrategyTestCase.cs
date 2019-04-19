using DesignPatterns._3.Behavioural.Strategy.ConcreteStrategy;
using System;

namespace DesignPatterns._3.Behavioural.Strategy
{
    /// <summary>
    /// Class to show the Strategy Test Case
    /// </summary>
    public static class StrategyTestCase
    {
        /// <summary>
        /// Choose a new strategy to get the beer's price
        /// </summary>
        public static void GetBeerPrice()
        {
            Strategy.Context beerPrice = new Context();

            DateTime currentTime = new DateTime(2019, 4, 23, 15, 0, 0);
            Console.WriteLine("Current time: " + currentTime);

            beerPrice.SetBeerStrategy(GetBeerStrategy(currentTime));
            beerPrice.GetBeerPrice(10);

            currentTime = currentTime.AddHours(4);
            Console.WriteLine("Current time: " + currentTime);
            beerPrice.SetBeerStrategy(GetBeerStrategy(currentTime));
            beerPrice.GetBeerPrice(10);

            Console.ReadKey();
        }

        /// <summary>
        /// Gets the strategy taking into the account the current time
        /// </summary>
        /// <param name="currentTime">Current time to evaluate</param>
        /// <returns>Strategy instance</returns>
        private static IStrategy GetBeerStrategy(DateTime currentTime)
        {
            IStrategy result = new NormalHour();

            if (currentTime.Hour >= 19 && currentTime.Hour <= 20)
            {
                result = new HappyHour();
            }

            return result;
        }
    }
}