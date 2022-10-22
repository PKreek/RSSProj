using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Podcast
    {
        public string PodID { get; set; }
        public string PodName { get; set; }
        public double Frequency { get; set; }
        public string Category { get; set; }

        public string Url { get; set; }

        public List<Episode> Episodes { get; set; }

        public Podcast()
        {

        }
        public Podcast(string podID, string name, double frequency, string category)
        {
            PodID = podID;
            PodName = name;
            Frequency = frequency;
            Category = category;
            //Episodes = new List<Episode>();
        }

        public Podcast(string name, string url)
        {
            PodName = name;
            Url = url;
            Episodes = new List<Episode>();
        }

       

    }
}