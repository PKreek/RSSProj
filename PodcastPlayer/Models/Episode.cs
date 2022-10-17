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
    }
}
