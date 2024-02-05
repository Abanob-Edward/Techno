using Appliaction.Contract;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
     
        public CategoryService(ICategoryRepository _categoryRepository)
        {

            categoryRepository = _categoryRepository;
        }

        public void AddCategory(Category category)
        {
            categoryRepository.add(category);


        }

        public void DeleteCategory(int id)
        {
            categoryRepository.delete(id);  
        }


        public IQueryable<Category> GetCategory()
        {
            return categoryRepository.getAll();
            
        }
         public IQueryable<Category> GetByName(string? Name)
         {
                return categoryRepository.SearchByName(Name);
            
         }



        public Category? GetCategorybyID(int id)
        {
            return categoryRepository.getByID(id);
        }

        public Category UpdateCategory(Category category)
        {
            return categoryRepository.update(category);
        }

        public int GetProductCountByCategoryId(int categoryId)
        {
          
            return categoryRepository.GetProductCountByCategoryId(categoryId);
        }







    }
}
