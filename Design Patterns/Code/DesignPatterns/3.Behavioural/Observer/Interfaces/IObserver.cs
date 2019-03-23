namespace DesignPatterns.Behavioural.Observer.Interfaces
{
    /// <summary>
    /// Define contracts to notify changes to the suscribers
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Notifiy changes to the suscribers
        /// </summary>
        void Notify();
    }
}