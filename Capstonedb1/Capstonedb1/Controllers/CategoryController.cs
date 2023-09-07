using Capstonedb1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstonedb1.Controllers
{
    public class CategoryController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;
        private ISubCategory _subCategory;
        public CategoryController(ICategory categoryRepository, ISubCategory subCategory, IWebHostEnvironment hostingEnvironment)
        {
            _categoryRepository = categoryRepository;
            _hostingEnvironment = hostingEnvironment;
            _subCategory = subCategory;
        }
        public IActionResult Index()
        {
           /* ViewData["ErrorMessage"] = TempData["ErrorMessage"];
            ViewData["SuccessMessage"] = TempData["SuccessMessage"];*/
            return View(_categoryRepository.GetAllCategory());
        }

        public IActionResult AddCategory(string name)
        {
            Category category = new Category() { Name = name };
            return Json(_categoryRepository.AddCategory(category));
        }
        public IActionResult RemoveCategory(int Cid)
        {

            bool isCategoryPresentInSubCategory = _subCategory.GetAllSubCategory().Any(sc => sc.CatId == Cid);

            if (isCategoryPresentInSubCategory)
            {
                TempData["ErrorMessage"] = "Cannot delete category as it is present in subcategory.";
                return RedirectToAction("Index");
            }

            Category category = _categoryRepository.GetCategoryId(Cid);
            _categoryRepository.RemoveCategory(category);
            TempData["SuccessMessage"] = " Category Deleted Sucessfully.";
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int Cid, string name)
        {
            var category = _categoryRepository.GetCategoryId(Cid);

            if (category == null)
            {
                return NotFound();
            }

            category.Name = name;
            _categoryRepository.UpdateCategory(category);

            return Json(new { success = true });
        }


    }
}
