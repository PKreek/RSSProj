using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Podcast : Feed
    {
        public string PodID { get; set; }
        public double Frequency { get; set; }

        public Podcast()
        {

        }

        public Podcast(string url)
        {
            Url = url;
            Episodes = new List<Episode>();
        }

        public Podcast(string podID, string name, double frequency, string category) 
        {
            PodID = podID;
            Name = name;
            Frequency = frequency;
            Category = category;
           // Episodes = new List<Episode>();
        }

        public Podcast(string name, string url) : base(name, url)
        {
            Name = name;
            Url = url;
            Episodes = new List<Episode>();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Podcastnamn " + Name + "Kategori " + Category);
        }


    }
}