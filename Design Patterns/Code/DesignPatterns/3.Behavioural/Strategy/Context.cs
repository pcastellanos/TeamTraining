using System;

namespace DesignPatterns._3.Behavioural.Strategy
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    public class Context
    {
        private IStrategy _beerStrategy;

        /// <summary>
        /// Sets strategy to work
        /// </summary>
        /// <param name="beerStrategy">IStrategy instance</param>
        public void SetBeerStrategy(IStrategy beerStrategy)
        {
            _beerStrategy = beerStrategy;
        }

        /// <summary>
        /// Calls strategy's method
        /// </summary>
        public void GetBeerPrice(double value)
        {
            _beerStrategy.GetBeerPrice(value);
            Console.WriteLine();
        }
    }
}