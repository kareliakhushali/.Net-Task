using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneDb.Models
{
    public class SqlCategoryRepository : ICategory
    {
        private AppDbContext _category;
        public SqlCategoryRepository(AppDbContext context)
        {
            _category = context;
        }
        public bool AddCategory(Category cat)
        {
            Category isDuplicate = _category.Categories.FirstOrDefault(each => each.Name.ToLower() == cat.Name.ToLower());
            if (isDuplicate == null)
            {
                _category.Add(cat);
                _category.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<Category> GetAllCategory()
        {
            return _category.Categories;
        }
        public Category GetCategoryId(int id)
        {
            return _category.Categories.SingleOrDefault(each => each.Id == id);
        }

        public bool Delete(int id)
        {
            Category c = _category.Categories.FirstOrDefault(each => each.Id == id);
            if (c != null)
            {
                _category.Remove(c);
                _category.SaveChanges();
                return true;
            }
            return false;
        }

    }

}

