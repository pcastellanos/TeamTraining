using DesignPatterns._3.Behavioural.Observer.Publisher;
using DesignPatterns.Behavioural.Observer.Interfaces;
using System;

namespace DesignPatterns._3.Behavioural.Observer.Suscribers
{
    /// <summary>
    /// First suscriber to GlobantNews
    /// </summary>
    public class Tweeter1 : IObserver
    {
        /// <summary>
        /// Gets GlobantNews reference
        /// </summary>
        private readonly GlobantNews _globantNews;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tweeter1"/> class
        /// <paramref name="globantNews"/>GlobantNews instance
        /// </summary>
        public Tweeter1(GlobantNews globantNews)
        {
            _globantNews = globantNews;
            _globantNews.AddObserver(this);
        }

        /// <summary>
        /// Implementation of <see cref="IObserver.Notify"/>
        /// </summary>
        public void Notify()
        {
            Console.WriteLine($"News Info from Tweeter1: {_globantNews.NewsInfo}");
        }
    }
}