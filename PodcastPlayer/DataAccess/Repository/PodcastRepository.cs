using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;

namespace DataAccessLayer.Repository
{
    public class PodcastRepository : IRepository<Podcast>
    {
        Serializer<Podcast> PodcastSerializer;
        List<Podcast> ListOfPodcasts;


        public PodcastRepository()
        {
            ListOfPodcasts = new List<Podcast>();
            PodcastSerializer = new Serializer<Podcast>(nameof(ListOfPodcasts));
        }

        public List<Podcast> GetAll()
        {
            List<Podcast> listAvRegistreradePodcast = new List<Podcast>();
            try
            {
                listAvRegistreradePodcast = PodcastSerializer.Deserialize();
            }
            catch (Exception)
            {
            }
            return listAvRegistreradePodcast;
        }
        public Podcast GetByID(string id)
        {
            Podcast podcast = null;
            foreach (var item in PodcastSerializer.Deserialize())
            {
                if (item.PodID.Equals(id))
                {
                    podcast = item;
                }
            }
            return podcast;
        }
        public void Insert(Podcast theObject)
        {
            ListOfPodcasts.Add(theObject);
            SaveChanges();
        }
        public void Update(int index, Podcast theNewObject)
        {
            if (index >= 0)
            {
                ListOfPodcasts[index] = theNewObject;
            }
        }
        public void Delete(int index)
        {
            ListOfPodcasts.RemoveAt(index);
            SaveChanges();
        }
        public void SaveChanges()
        {
            PodcastSerializer.Serialize(ListOfPodcasts);
        }
    }
}
