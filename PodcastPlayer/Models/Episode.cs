﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    public class Episode
    {
        public string EpisodeName { get; set; }
        public string EpisodeDescription { get; set; }

        public Episode()
        {
            EpisodeName = "";
            EpisodeDescription = "";
        }
        
        public Episode(string name, string description)
        {
            EpisodeName = name;
            EpisodeDescription = description;
        }
    }

}
