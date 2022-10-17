using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Podcast
    {
        public string Episode { get; set; }
        public string PodName { get; set; }
        public double Frequency { get; set; }
        public string Category { get; set; }

        public Podcast()
        {

        }
        public Podcast(string episode, string name, double frequency, string category)
        {
            Episode = episode;
            PodName = name;
            Frequency = frequency;
            Category = category;
        }
    }
}