using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneDb.Models
{
  public  interface ISubcategory
    {
        SubCategory GetSubCategoryId(int id);
        IEnumerable<SubCategory> GetAllSubcategory();

        bool AddSubCategory(SubCategory scat);
       
        public bool Delete(int id);

        public IEnumerable<SubCategory> GetSubCategoriesByCategoryId(int Cid);
        bool CheckInsertUnique(string name , int catId);

        /*public SubCategory GetSubCategoryById(int id);
public IEnumerable<SubCategory> GetAllSubCategory();
public bool AddSubCategory(SubCategory s);
public bool UpdateSubCategory(SubCategory s);
public bool Delete(int id);
public bool CheckUpdateUnique(string name, int subId, int proId);
public bool CheckInsertUnique(string name, int subId);*/
    }
}
