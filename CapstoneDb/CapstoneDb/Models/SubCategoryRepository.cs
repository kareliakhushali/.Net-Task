/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneDb.Models
{
    public class SubCategoryRepository
    {
        private List<SubCategory> _subcategory;
        public SubCategoryRepository()
        {
            _subcategory = new List<SubCategory>()
            {
                new SubCategory(){Id=1,Name="Soap"},
                new SubCategory(){Id=2,Name="Shampoo"},
                 new SubCategory(){Id=3,Name="Body Spray"}

            };
        }
        public bool AddSubCategory(Category subcat)
        {
            int index = _subcategory.FindIndex(each => each.Name.ToLower() == subcat.Name.ToLower());
            if (index == -1)
            {
                subcat.Id = _subcategory.Max(each => each.Id) + 1;
                _subcategory.Add(subcat);
                return true;
            }
            else
            {
                return false;
            }
        }
        IEnumerable<SubCategory> IsubCategory.GetAllCategory()
        {
            return _subcategory;
        }
        SubCategory ISubCategory.GetSubCategoryId(int id)
        {
            return _subcategory.FirstOrDefault(c => c.Id == id);
        }
    }
}
*/