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
        public List<Podcast> Podcasts { get; set; }
        List<List<Episode>> episodes;
        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            feedReader = new FeedReader();
            RetrieveAllPods();
        }

        //public void CreatePodcast(string episode, string name, double frequency, string category)
        //{
        //    Podcast podcastObj = new Podcast(episode, name, frequency, category);
        //    podcastRepository.Insert(podcastObj);
        //}
        public Podcast AddPodcast(string url)
        {
            Podcast podcast = feedReader.ReadFeed(url);
            podcastRepository.Insert(podcast);
            RetrieveAllPods();
            return podcast;
        }
        //public List<Podcast> RetrieveAllPods()
        //{
        //    return podcastRepository.GetAll();
        //}

        private void RetrieveAllPods()
        {
            Podcasts = podcastRepository.GetAll();
            RetrieveAllEpisodes();
        }

        private void RetrieveAllEpisodes()
        {
            episodes = new List<List<Episode>>();
            for(int i = 0; i < Podcasts.Count; i++)
            {
                episodes.Add(feedReader.GetEpisodesList(Podcasts[i].Url));
            }
        }

        //public List<Episode> EpisodesList(Podcast podcast)
        //{
        //    List<Episode> episodes = feedReader.GetEpisodesList(podcast.Url);

        //    return episodes;
        //}

        public List<Episode> EpisodesList(Podcast podcast)
        {
            int index = Podcasts.IndexOf(podcast);

            return episodes[index];
        }

        public int NumberOfEpisodes(int index)
        {
            return episodes[index].Count;
        }
    }
}
