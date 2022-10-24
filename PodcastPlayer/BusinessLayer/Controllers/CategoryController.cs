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
        public List<Category> categories;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }
        public Category AddCategory(string catName)
        {
            Category category = new Category(catName);
            categories.Add(category);
            return category;
        }
        public List<Category> readCategory()
        {
            //CategoryRepository catRep = new CategoryRepository();
            categories = categoryRepository.GetAll();

            return categories;
   
        }

        public void DeleteCategory(int index)
        {
            categoryRepository.Delete(index);      
        }
        //public string ReturnCat(string namn)
        //{
        //    string obj = "";
        //    foreach (var category in categories)
        //    {
        //        if(category.CatName == namn)
        //        {
        //            obj = category;
        //        }
              
        //    }
        //    return obj;
        //}

        public void SaveCategory()
        {
            categoryRepository.Insert(categories);
        }


    }

}
