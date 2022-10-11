using System.ServiceModel.Syndication;
using System.Xml;

namespace DataAccess
{
    public static class FeedReader
    {
        public static SyndicationFeed ReadFeed (string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            return feed;
        }
    }
}