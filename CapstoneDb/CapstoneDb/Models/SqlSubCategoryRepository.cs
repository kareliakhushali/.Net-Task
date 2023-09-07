using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneDb.Models
{
    public class SqlSubCategoryRepository : ISubcategory
    {

        private AppDbContext _subcategory;
        public SqlSubCategoryRepository(AppDbContext context)
        {
            _subcategory = context;
        }
        public bool AddSubCategory(SubCategory scat)
        {
            if (CheckInsertUnique(scat.Name,scat.CatId))
            {

                _subcategory.Add(scat);
                _subcategory.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckInsertUnique(string name, int catId)
        {
            SubCategory isDuplicate = _subcategory.SubCategories.FirstOrDefault(each => each.CatId == catId
&& name.ToLower() == each.Name.ToLower());
            return isDuplicate == null ? true : false;
        }

        public IEnumerable<SubCategory> GetAllSubcategory()
        {
            return _subcategory.SubCategories;
        }
        public SubCategory GetSubCategoryId(int id)
        {
            return _subcategory.SubCategories.SingleOrDefault(each => each.Id == id);
        }
        public bool Delete(SubCategory scat)
        {
            SubCategory isDuplicate = _subcategory.SubCategories.FirstOrDefault(each => each.Id == scat.Id);
            if (isDuplicate != null)
            {
                _subcategory.Remove(scat);
                _subcategory.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            SubCategory s = _subcategory.SubCategories.FirstOrDefault(each => each.Id == id);
            if (s != null)
            {
                _subcategory.Remove(s);
                _subcategory.SaveChanges();
                return true;
            }
            return false;
        }
        /* public bool UpdateSubcategory(Subcategory s)
         {
             if (CheckUpdateUnique(s.Id, s.CatId, s.Name))
             {
                 _subcategory.subcategories.Update(s);
                 _subcategory.SaveChanges();
                 return true;
             }
             return false;
         }*/
        public IEnumerable<SubCategory> GetSubCategoriesByCategoryId(int Cid)
        {
            return _subcategory.SubCategories.Where(s => s.CatId == Cid).ToList();
        }

        /*public bool Delete(SubCategory scat)
        {
            SubCategory isDuplicate = _subcategory.SubCategories.FirstOrDefault(each => each.Id == scat.Id);
            if (isDuplicate != null)
            {
                _subcategory.Remove(scat);
                _subcategory.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}



       /* public bool AddSubcategory(Subcategory scat)
        {
            if (CheckInsertUnique(scat.CatId, scat.Name))
            {



                _subcategory.Add(scat);
                _subcategory.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }*/
        /*public bool CheckInsertUnique(int Cid, string name)
        {
           subcategory isDuplicate = _subcategory.subcategories.FirstOrDefault(each => each.CatId == Cid && name.ToLower() == each.Name.ToLower());
            return isDuplicate == null ? true : false;
        }



        public IEnumerable<Subcategory> GetAllSubcategory()
        {
            return _subcategory.subcategories;
        }



        public Subcategory GetSubcategoryId(int id)
        {
            return _subcategory.subcategories.SingleOrDefault(each => each.Id == id);
        }
        public bool Delete(Subcategory scat)
        {
            Subcategory isDuplicate = _subcategory.subcategories.FirstOrDefault(each => each.Id == scat.Id);
            if (isDuplicate != null)
            {
                _subcategory.Remove(scat);
                _subcategory.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateSubcategory(Subcategory s)
        {
            if (CheckUpdateUnique(s.Id, s.CatId, s.Name))
            {
                _subcategory.subcategories.Update(s);
                _subcategory.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CheckUpdateUnique(int Sid, int CatId, string name)
        {
            Subcategory sub = _subcategory.subcategories.FirstOrDefault(each => each.Name.ToLower() == name.ToLower());
            if (sub == null)
                return true;
            sub = _subcategory.subcategories.FirstOrDefault(each => each.Name.ToLower() == name.ToLower() && each.CatId == CatId && each.Id == Sid);
            if (sub != null)
                return true;
            bool flag = false;





            foreach (Subcategory s in _subcategory.Subcategories)
            {
                if (s.Name.ToLower() == name.ToLower() && s.CatId != CatId)
                {
                    flag = true;
                }
                else if (s.Name.ToLower() == name.ToLower() && s.CatId == CatId)
                {
                    return false;
                }
            }
            return flag;
        }
        public IEnumerable<Subcategory> GetSubCategoriesByCategoryId(int Cid)
        {
            return _subcategory.subcategories.Where(s => s.CatId == Cid).ToList();
        }
    }
}*/
