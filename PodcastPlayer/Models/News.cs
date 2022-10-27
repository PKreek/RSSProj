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
            Name = name;
            Url = url;
        }

        public News()
        {

        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Nyhetsnamn " + Name + "Kategori " + Category);
        }
    }
}
