using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public interface IFeedReader
    {

        public Podcast ReadFeed(string url);
        public List<Episode> GetEpisodesList(string url);
    }
}
