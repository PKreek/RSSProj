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
            //CategoryRepository catRep = new CategoryRepository();
            categories = categoryRepository.GetAll();

        }
        public bool validationToLong(string text)
        {
            bool test = false;
            test = validering.toLong(text);
            return test;
        }
        public bool validationIsEmpty(string text)
        {
            bool test = false;
            test = validering.isEmpty(text);
            return test;
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
