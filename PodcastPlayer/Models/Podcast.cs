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

        public Podcast()
        {

        }

        public Podcast(string url) : base(url)
        {
            
        }


        public Podcast(string name, string url) : base(name, url)
        {
   
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Podcastnamn " + Name + "Kategori " + Category);
        }


    }
}