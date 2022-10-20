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

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }
        public Category AddCategory(string catName)
        {
            Category category = new Category(catName);
            categoryRepository.Insert(category);
            return category;
        }
        public List<Category> readCategory()
        {
            //CategoryRepository catRep = new CategoryRepository();
            List<Category> catList = categoryRepository.GetAll();

            return catList;
   
        }


    }

}
