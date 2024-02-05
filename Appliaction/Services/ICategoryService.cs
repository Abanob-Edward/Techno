using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        Category? GetCategorybyID(int id);
        IQueryable<Category> GetCategory();
        IQueryable<Category> GetByName(string? Name);
        public Category UpdateCategory(Category category);
        public void DeleteCategory(int id);
        int GetProductCountByCategoryId(int categoryId);
    }
}
