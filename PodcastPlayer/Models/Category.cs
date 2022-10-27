using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public string CatName { get; set; }
        
        public Category(string catName)
        {
            CatName = catName;
        }
        public Category()
        {

        }
    }
}
