using System.ServiceModel.Syndication;
using System.Xml;

namespace DataAccess
{
    public static class Class1
    {
        public static XmlReader reader = XmlReader.Create("https://www.espn.com/espn/rss/news");
        public static SyndicationFeed feed = SyndicationFeed.Load(reader);

    }
}