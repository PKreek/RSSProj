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
        public List<Podcast> FilteredPodcasts { get; set; }
        

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            feedReader = new FeedReader();
            RetrievePodcasts();

        }

        //public Podcast AddPodcast(string url, string catName)
        //{
        //    Podcast podcast = feedReader.ReadFeed(url);
        //    Podcasts.Add(podcast);
        //    podcast.Category = catName;
        //    //RetrieveEpisodes();
        //    return podcast;
        //}

        //public async void addAsync() 
        //{

        //}


        public async Task<Podcast> AddPodcast(string url, string catName)
        {
            Podcast podcast = new Podcast(url);
            Podcasts.Add(podcast);
            podcast.Category = catName;
            await Task.Run(()=>feedReader.ReadAsync(podcast));

            return podcast;
        }

        public List<Podcast> FilterList (Category category)
        {
            FilteredPodcasts = Podcasts.Where(x => x.Category == category.CatName).ToList();

            return FilteredPodcasts;
        }

        public void DeletePodcast(Category category)
        {
            Podcasts.RemoveAll(x => x.Category.Equals(category.CatName));
            SavePodcast();
        }

        public void DeletePodcast(int index)
        {
            podcastRepository.Delete(index);
        }
        public void SavePodcast()
        {
            podcastRepository.Insert(Podcasts);
        }

        private void RetrievePodcasts()
        {
            Podcasts = podcastRepository.GetAll();
            FilteredPodcasts = Podcasts;
        }
    }
}
