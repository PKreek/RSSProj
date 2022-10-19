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

            Podcast podcast = new Podcast(feed.Title.Text, url);
            foreach(SyndicationItem item in feed.Items)
            {
                Episode episode = new Episode(item.Title.Text);
                //podcast.Episodes.Add(episode);
            }

            return podcast;
        }

        public List<Episode> GetEpisodesList(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            List<Episode> episodes = new List<Episode>();


            foreach (SyndicationItem item in feed.Items)
            {
                Episode episode = new Episode(item.Title.Text);
                episodes.Add(episode);
            }

            return episodes;
        }

    }
}