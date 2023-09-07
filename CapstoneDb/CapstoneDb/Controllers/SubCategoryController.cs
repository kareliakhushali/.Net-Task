using CapstoneDb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneDb.Controllers
{
    public class SubCategoryController : Controller
    {
        private ISubcategory _subcategoryRepository;
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;


        public SubCategoryController(ISubcategory subcategoryRepository, IWebHostEnvironment hostEnvironment, ICategory categoryRepository)
        {
            _subcategoryRepository = subcategoryRepository;
            _hostingEnvironment = hostEnvironment;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            ViewData["PageTitle"] = " SubCategory List";
            var result =
            from p in _subcategoryRepository.GetAllSubcategory()
            join c in _categoryRepository.GetAllCategory()
            on p.CatId equals c.Id
            select new
            {
                p.Id,
                p.Name,
     // p.Profile,
     // p.Qty,
     // p.Rate,
     // p.IsActive,
     p.CatId,
                Category = c.Name
     //c.Name





 };
            List<SubCategoryViewModel> sub = new List<SubCategoryViewModel>();
            foreach (var each in result)
            {
                sub.Add(new SubCategoryViewModel()
                {
                    Category = each.Category,
                    CatId = each.CatId,
                    Name = each.Name,
                    Id = each.Id,
                    //Profile = each.Profile,
                    //  Rate = each.Rate,
                    // Qty = each.Qty,
                    // IsActive = each.IsActive,
                });
            }
            return View(sub);
        }
        public IActionResult AddSubcategory(int CatId, string name)
        {
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View(new SubCategoryViewModel());

        }
        public IActionResult CheckInsertUnique(String name, int catId)
        {
            bool value = _subcategoryRepository.CheckInsertUnique(name, catId);
            return Json(value);
        }


        /*public IActionResult AddSubCategory(int CatId, string name)
        {
            SubCategory subcategory = new SubCategory() { CatId = CatId, Name = name };
            return Json(_subcategoryRepository.AddSubCategory(subcategory));
        }*/
        public IActionResult FindId(int Sid)
        {
            return Json(_subcategoryRepository.GetSubCategoriesByCategoryId(Sid));
        }

        public IActionResult Delete(int id)
        {
            var subcategory = _subcategoryRepository.GetSubCategoriesByCategoryId(id);
            if (subcategory == null)
            {
                return NotFound();
            }
            _subcategoryRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Save(SubCategoryViewModel p)
        {

            if (ModelState.IsValid)
            {
                String uniqueFileName = string.Empty;
                if (p.Id > 0)
                {
                    ViewBag.Category = _categoryRepository.GetAllCategory();
                    return View("AddSubCategory", p);



                }
                else
                {
                    if (!_subcategoryRepository.AddSubCategory(p))
                    {
                        ViewBag.Category = _categoryRepository.GetAllCategory();
                        return View("AddSubCategory", p);
                    }



                }
                return RedirectToAction("Index");
            }
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("AddSubCategory", p);
        }

    }


}

    
    /*private IWebHostEnvironment _hostingEnvironment;
    private ISubcategory _subcategoryRepository;
    private ICategory _categoryRepository;
    public SubCategoryController(
        IWebHostEnvironment hostEnvironment,
        ISubcategory subcategoryRepository,
        ICategory categoryRepository)
    {
        _categoryRepository = categoryRepository;
        _subcategoryRepository = subcategoryRepository;
        _hostingEnvironment = hostEnvironment;
    }
    public IActionResult Index()
    {

  return View(_subcategoryRepository.GetAllSubCategory());
    }
    public IActionResult AddCategory(string name)
    {
        SubCategory subcategory = new SubCategory() { Name = name };
        return Json(_subcategoryRepository.AddSubCategory(subcategory));
    }
*/
/*}
}*/
