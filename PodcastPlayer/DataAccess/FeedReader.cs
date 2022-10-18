using DataAccessLayer;
using Models;
using System.ServiceModel.Syndication;
using System.Xml;

namespace DataAccess
{
    public class FeedReader : IFeedReader
    {
        public Podcast ReadFeed (string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            Podcast podcast = new Podcast(feed.Title.Text);

            return podcast;
        }
    }
}