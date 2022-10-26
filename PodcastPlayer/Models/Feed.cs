using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Feed
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public List<Episode> Episodes { get; set; }

        public Feed (string name, string url)
        {
            Name = name;
            Url = url;
        }

        public Feed()
        {

        }

        public Feed(string url)
        {
            Url = url;
        }

        public virtual void DisplayInfo()
        {

        }
    }
}
