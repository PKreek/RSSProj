using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml.Serialization;


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
            List<Category> listAvRegistreradeCategory = new List<Category>(); 
            try
            {
                listAvRegistreradeCategory = CategorySerializer.Deserialize();
            }
            catch (Exception)
            {

            }
            return listAvRegistreradeCategory;
        }
        public Category GetById(string id)
        {
            Category category = null;
            foreach(var item in CategorySerializer.Deserialize())
            {
                if (item.CategoryId.Equals(id))
                {
                    category = item;
                }
            }
            return category;
        }
        public void Insert ( Category theObject)
        {
            ListOfCategories.Add(theObject);
            SaveChanges();
        }
        public void Update (int index, Category theNewObject)
        {
            if  (index >=0)
            {
                ListOfCategories[index] = theNewObject;
            }
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

        public Category GetByID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
