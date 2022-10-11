using DataAccess;
using System.ServiceModel.Syndication;

namespace ConsoleTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SyndicationFeed feed = FeedReader.ReadFeed("https://www.espn.com/espn/rss/news");
            Console.WriteLine(feed.Title.Text);
        }
    }
}