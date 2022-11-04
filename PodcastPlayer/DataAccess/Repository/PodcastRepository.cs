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

            try
            {
                ListOfPodcasts = PodcastSerializer.Deserialize();
            }
            catch (Exception)
            {
            }
            return ListOfPodcasts;
        }
        
        public void Insert(List<Podcast> theObject)
        {
            ListOfPodcasts = theObject;
            SaveChanges();
        }
        
        public void Delete(int index)
        {
            ListOfPodcasts.RemoveAt(index);
            SaveChanges();
        }
        public void SaveChanges()
        {
            try
            {
                PodcastSerializer.Serialize(ListOfPodcasts);
            }
            catch(Exception)
            {

            }
        }
    }
}
