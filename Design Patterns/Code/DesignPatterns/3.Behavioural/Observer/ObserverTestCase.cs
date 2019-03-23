using DesignPatterns._3.Behavioural.Observer.Publisher;
using DesignPatterns._3.Behavioural.Observer.Suscribers;
using System;

namespace DesignPatterns._3.Behavioural.Observer
{
    /// <summary>
    /// Class to show Observer Test Case
    /// </summary>
    public static class ObserverTestCase
    {
        /// <summary>
        /// Publish news as the Twitter app
        /// </summary>
        public static void PublishNews()
        {
            // Publisher
            GlobantNews globantNews = new GlobantNews();

            // Suscribers
            Tweeter1 tweeter1 = new Tweeter1(globantNews);

            // PublishNews
            globantNews.PublishNews("News about Observer pattern");

            Console.ReadLine();
        }
    }
}