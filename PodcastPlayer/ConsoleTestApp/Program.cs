using DataAccess;
using System.ServiceModel.Syndication;

namespace ConsoleTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SyndicationFeed feed = FeedReader.ReadFeed("https://api.sr.se/api/rss/pod/22209");
            Console.WriteLine(feed.Title.Text);
        }
    }
}