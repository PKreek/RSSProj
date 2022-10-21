using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer;
using DataAccessLayer.Repository;
using DataAccess;
using System.Reflection;

namespace BusinessLayer.Controllers
{
    public class PodcastController
    {
        IRepository<Podcast> podcastRepository;
        IFeedReader feedReader;
        public List<Podcast> Podcasts;
        List<List<Episode>> episodes = new List<List<Episode>>();
        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            feedReader = new FeedReader();
            readPodcast();
            RetrieveAllEpisodes();
        }
        public Podcast AddPodcast(string url)
        {
            Podcast podcast = feedReader.ReadFeed(url);
            Podcasts.Add(podcast);
            RetrieveAllPods();
            return podcast;
        }
        public void SavePodcast()
        {
            podcastRepository.Insert(Podcasts);
        }
        private void RetrieveAllPods()
        {
            RetrieveAllEpisodes();
        }

        private void RetrieveAllEpisodes()
        {
            episodes = new List<List<Episode>>();
                for (int i = 0; i < Podcasts.Count; i++)
                {
                    episodes.Add(feedReader.GetEpisodesList(Podcasts[i].Url));
                }
        }
        public List<Episode> EpisodesList(Podcast podcast)
        {
            int index = Podcasts.IndexOf(podcast);

            return episodes[index];
        }

        public int NumberOfEpisodes(int index)
        {
            return episodes[index].Count;
        }
      
        public List<Podcast> readPodcast()
        {
            Podcasts = podcastRepository.GetAll();
            return Podcasts;
        }
    }
}
