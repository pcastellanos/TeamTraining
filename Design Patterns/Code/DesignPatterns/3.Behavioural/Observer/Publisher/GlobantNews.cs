using DesignPatterns.Behavioural.Observer.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns._3.Behavioural.Observer.Publisher
{
    /// <summary>
    /// Notify news about the GlobantCompany
    /// </summary>
    public class GlobantNews : IObservable
    {
        /// <summary>
        /// Suscribers list
        /// </summary>
        private List<IObserver> suscribers;

        /// <summary>
        /// Gets or sets the news information
        /// </summary>
        public string NewsInfo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobantNews"/> class
        /// </summary>
        public GlobantNews()
        {
            suscribers = new List<IObserver>();
        }

        /// <summary>
        /// Implementation of <see cref="IObservable.AddObserver(IObserver)"/>
        /// </summary>
        public void AddObserver(IObserver observerInfo)
        {
            suscribers.Add(observerInfo);
        }

        /// <summary>
        /// Implementation of <see cref="IObservable.AddObserver(IObserver)"/>
        /// </summary>
        public void NotifyAll()
        {
            suscribers.ForEach(s => s.Notify());
        }

        /// <summary>
        /// Implementation of <see cref="IObservable.AddObserver(IObserver)"/>
        /// </summary>
        public void RemoveObserver(IObserver observerInfo)
        {
            suscribers.Remove(observerInfo);
        }

        /// <summary>
        /// Publish news
        /// </summary>
        /// <param name="newsInfo">News information</param>
        public void PublishNews(string newsInfo)
        {
            NewsInfo = newsInfo;
            NotifyAll();
        }
    }
}