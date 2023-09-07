using CapstoneDb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProduct _productRepository;
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;

       public HomeController(IProduct productRepository,
             IWebHostEnvironment hostingEnvironment,
            ICategory categoryRepository)
        {
            _productRepository = productRepository;
            _hostingEnvironment = hostingEnvironment;
            _categoryRepository = categoryRepository;

        }
        /* public HomeController(ILogger<HomeController> logger)
         {
             _logger = logger;
         }*/

        public IActionResult Index()
        {
            ViewData["PageTitle"] = "Product List";
            var result =
               from p in _productRepository.GetAllProduct()
               join c in _categoryRepository.GetAllCategory()
               on p.CatId equals c.Id
               select new
               {
                   p.Id,
                   p.Name,
                   p.Profile,
                   p.Qty,
                   p.Rate,
                   p.IsActive,
                   p.CatId,
                   Category = c.Name,
                   p.Brand,
                   p.Generation,
                   p.Sims,
                   p.OS,
                   p.RAM,
                   p.ROM,
                   p.SubId,
                   SubCategory = p.Name,
                   p.Color
               };
            List<ProductViewModel> products = new List<ProductViewModel>();
            foreach (var each in result)
            {
                products.Add(new ProductViewModel()
                {
                    Category = each.Category,
                    CatId = each.CatId,
                    SubId = each.SubId,
                    Name = each.Name,
                    Id = each.Id,
                    Profile = each.Profile,
                    IsActive = each.IsActive,
                    Rate = each.Rate,
                    Qty = each.Qty,
                    Brand = each.Brand,
                    Generation = each.Generation,
                    Sims = each.Sims,
                    OS = each.OS,
                    RAM = each.RAM,
                    ROM = each.ROM,
                    Color = each.Color,
                    SubCategory = each.SubCategory
                });
            }
            return View(products);
        }

        public IActionResult CheckUpdateUnique(String name, int catId, int prodId)
        {
            bool value = _productRepository.CheckUpdateUnique(name, catId, prodId);
            return Json(value);//it will convert your value obtained into json format
        }
        public IActionResult CheckInsertUnique(String name, int catId)
        {
            bool value = _productRepository.CheckInsertUnique(name, catId);
            return Json(value);
        }
        public IActionResult AddProduct()
        {
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View(new ProductViewModel());
        }
        public IActionResult AddProduct1()
        {
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View(new ProductViewModel());
        }
        public IActionResult Save(ProductViewModel p)
        {
            if (ModelState.IsValid)
            {


                String uniqueFileName = string.Empty;
                if (p.Image != null)
                {
                    String uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + p.Image.FileName;
                    String uploadFilePath = Path.Combine(uploadFolder, uniqueFileName);
                    p.Image.CopyTo(new FileStream(uploadFilePath, FileMode.Create));
                    p.Profile = uniqueFileName;
                }
                if (p.Id > 0)
                {
                    if (!_productRepository.UpdateProduct(p))
                    {
                        ViewBag.Category = _categoryRepository.GetAllCategory();
                        return View("AddProduct", p);
                    }
                }
                else
                {
                    if (!_productRepository.AddProduct(p))
                    {
                        ViewBag.Category = _categoryRepository.GetAllCategory();
                        return View("AddProduct", p);
                    };
                }
                return RedirectToAction("Index");
            }
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("AddProduct1", p);
        }




        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            Product p = _productRepository.GetProductById(id);
            ProductViewModel productViewModel = new ProductViewModel()
            {
                Name = p.Name,
                Qty = p.Qty,
                Rate = p.Rate,
                CatId = p.CatId,
                IsActive = p.IsActive,
                Profile = p.Profile,
                Id = p.Id

            };
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("AddProduct", productViewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}