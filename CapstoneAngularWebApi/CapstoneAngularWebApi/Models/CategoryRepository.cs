using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneAngularWebApi.Models
{
    public class CategoryRepository:ICategory
    {
        AppDbContext _category;
        public CategoryRepository(AppDbContext category)
        {
            _category = category;
        }
        public bool AddCategory(Category c)
        {
            if (CheckInsertUnique(c.Name,c.Id))
            {
                _category.Add(c);
                _category.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CheckInsertUnique(string name,int id)
        {
            Category isDuplicate = _category.Category.FirstOrDefault(each => each.Id == id && name.ToLower() == each.Name.ToLower());

            return isDuplicate == null ? true : false;
        }
        public bool UpdateCategory(Category c)
        {
            //if (CheckUpdateUnique(p.Name, p.CatId, p.Id))
            //{
            _category.ChangeTracker.Clear();
            _category.Category.Update(c);
            _category.SaveChanges();
            return true;

            //}*/
            // return false;

        }
        public bool CheckUpdateUnique(string name, int id)
        {
           Category cat = _category.Category.FirstOrDefault(each => each.Name.ToLower() == name.ToLower());
            if (cat == null)
                return true;
            cat = _category.Category.FirstOrDefault
                (each => each.Name.ToLower() == name.ToLower() && each.Id == id && each.Id == id);
            if (cat != null)
                return true;
            bool flag = false;
            foreach (Category c in _category.Category)
            {
                if (c.Name.ToLower() == name.ToLower() && c.Id != id)
                {
                    flag = true;
                }
                else if (c.Name.ToLower() == name.ToLower() && c.Id == id)
                {
                    return false;
                }
            }
            return flag;
        }
        public bool Delete(int id)
        {
            Category c = _category.Category.FirstOrDefault(each => each.Id == id);
            if (c!= null)
            {
                _category.Remove(c);
                _category.SaveChanges();
                return true;
            }
            return false;
        }
        public IEnumerable<Category> GetAllCategory()
        {
            return _category.Category;
        }

        public Category GetCategoryById(int id)
        {
            return _category.Category.FirstOrDefault(each => each.Id == id);
        }


    }
}
