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
        public string Name { get; set; }
        public double Frequency { get; set; }
        public string Category { get; set; }

        public Podcast()
        {

        }
        public Podcast(string episode, string name, double frequency, string category)
        {
            Episode = episode;
            Name = name;
            Frequency = frequency;
            Category = category;
        }
    }
}