using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml.Serialization;
using System.Data;

namespace DataAccessLayer.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        Serializer<Category> CategorySerializer;
        List<Category> ListOfCategories;

        public CategoryRepository()
        {
            ListOfCategories = new List<Category>();
            CategorySerializer = new Serializer<Category>(nameof(ListOfCategories));
        }

        public List<Category> GetAll()
        {
            try
            {
                ListOfCategories = CategorySerializer.Deserialize();
            }
            catch (Exception)
            {

            }
            return ListOfCategories;
        }
        
        public void Insert (List<Category> theObject)
        {
            ListOfCategories = theObject;
            SaveChanges();
        }
        
        public void Delete (int index)
        {
            ListOfCategories.RemoveAt(index);
            SaveChanges();
        }

        public void SaveChanges ()
        {
            CategorySerializer.Serialize(ListOfCategories);
        }

       
    }
}
