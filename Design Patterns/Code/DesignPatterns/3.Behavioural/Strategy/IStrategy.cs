namespace DesignPatterns._3.Behavioural.Strategy
{
    /// <summary>
    /// Defines a common interface to all supported strategy algorithms.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Gets the beer's price
        /// </summary>
        double GetBeerPrice(double value);
    }
}