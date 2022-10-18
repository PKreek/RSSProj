using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer;
using DataAccessLayer.Repository;
using DataAccess;

namespace BusinessLayer.Controllers
{
    public class PodcastController
    {
        IRepository<Podcast> podcastRepository;
        IFeedReader feedReader;
        public List<Podcast> Podcasts { get; set; }
        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            feedReader = new FeedReader();
            Podcasts = new List<Podcast>();
        }

        //public void CreatePodcast(string episode, string name, double frequency, string category)
        //{
        //    Podcast podcastObj = new Podcast(episode, name, frequency, category);
        //    podcastRepository.Insert(podcastObj);
        //}
        public Podcast AddPodcast(string url)
        {
            Podcast podcast = feedReader.ReadFeed(url);
            Podcasts.Add(podcast);
            return podcast;
        }
        public List<Podcast> RetrieveAllPods()
        {
            return podcastRepository.GetAll();
        }

    }
}
