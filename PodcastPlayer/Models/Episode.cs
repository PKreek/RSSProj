using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Episode
    {
        public  int EpisodeId { get; set; }
        public string EpisodeName { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTime EpisodeDate { get; set; }
        public string EpisodeDescription { get; set; }
        
        public Episode() { }
        
        public Episode(string name, string description)
        {
            EpisodeName = name;
            EpisodeDescription = description;
        }
    }

}
