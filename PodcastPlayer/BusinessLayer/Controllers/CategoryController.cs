using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLayer.Controllers
{
    public class CategoryController
    {
        IRepository<Category> categoryRepository;
        public List<Category> categories { get; set; } = new List<Category>();

        Validering validering = new Validering();

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
            readCategory();
        }

        public Category AddCategory(string catName)
        {
            Category category = new Category(catName);
            categories.Add(category);
            return category;
        }

        private void readCategory()
        {
            categories = categoryRepository.GetAll();
        }
  
        public void DeleteCategory(int index)
        {
            categoryRepository.Delete(index);
            SaveCategory();
        }
        
        public void SaveCategory()
        {
            categoryRepository.Insert(categories);
        }


    }

}
