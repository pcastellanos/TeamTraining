namespace DesignPatterns.Behavioural.Observer.Interfaces
{
    /// <summary>
    /// Define contracts to work with the suscribers
    /// </summary>
    public interface IObservable
    {
        /// <summary>
        /// Add observer to the suscriber list to notify changes
        /// </summary>
        /// <param name="observerInfo"></param>
        void AddObserver(IObserver observerInfo);

        /// <summary>
        /// Remove observer to the suscriber list
        /// </summary>
        /// <param name="observerInfo"></param>
        void RemoveObserver(IObserver observerInfo);

        /// <summary>
        /// Notify changes to the suscribers
        /// </summary>
        void NotifyAll();
    }
}