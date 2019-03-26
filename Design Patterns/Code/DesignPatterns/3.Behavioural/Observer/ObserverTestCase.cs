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
            Tweeter2 tweeter2 = new Tweeter2(globantNews);

            // PublishNews
            globantNews.PublishNews("News about Observer pattern");

            // Remove the first one
            globantNews.RemoveObserver(tweeter1);

            // Publish another news
            globantNews.PublishNews("News #2");

            Console.ReadLine();
        }
    }
}