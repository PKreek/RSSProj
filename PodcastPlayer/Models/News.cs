using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class News : Feed
    {
        public News(string name, string url) : base(name, url)
        {
           
        }

        public News()
        {

        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " Nyhetsnamn: " + Name + "Kategori: " + Category;
        }
    }
}
