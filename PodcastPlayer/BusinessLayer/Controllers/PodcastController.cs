using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer;
using DataAccessLayer.Repository;

namespace BusinessLayer.Controllers
{
    public class PodcastController
    {
        IRepository<Podcast> podcastRepository;
        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }

        //public void CreatePodcast(string episode, string name, double frequency, string category)
        //{
        //    Podcast podcastObj = new Podcast(episode, name, frequency, category);
        //    podcastRepository.Insert(podcastObj);
        //}
        public List<Podcast> RetrieveAllPods()
        {
            return podcastRepository.GetAll();
        }

    }
}
