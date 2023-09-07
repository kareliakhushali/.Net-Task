using Capstonedb1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstonedb1.Controllers
{
    public class RegisterController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;
        private IProduct _productRepository;
        private ISubCategory _subCategoryRepository;
        private IRegister _registration;
        public RegisterController(ICategory categoryRepository, IWebHostEnvironment hostingEnvironment, IProduct productRepository, ISubCategory subCategoryRepository, IRegister registration)
        {
            _categoryRepository = categoryRepository;
            _hostingEnvironment = hostingEnvironment;
            _productRepository = productRepository;
            _subCategoryRepository = subCategoryRepository;
            _registration = registration;
        }

        public IActionResult loggedinuser()
        {

            ViewBag.Layout = "~/Views/Shared/_User.cshtml";
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.Layout = "~/Views/Shared/_User.cshtml";
            return View();
        }
        public IActionResult Login()
        {
            ViewData["ErrorMessage"] = TempData["ErrorMessage"];
            ViewBag.Layout = "~/Views/Shared/_User.cshtml";
            return View("Login");
        }

        public IActionResult AddUser(string name, string email, string password)
        {
            Register User = new Register() { Username = name, Email = email, Password = password };
            bool success = _registration.AddUser(User);
            if (success)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, errorMessage = "User with Same Email already Exists." });
            }
        }


        //public IActionResult FindUser(string email, string password)
        //{

        //        Registration user = new Registration() { Email = email, Password = password };


        //   bool isVerified = _registration.VerifyUser(user);
        //    if (!isVerified)
        //    {
        //        TempData["ErrorMessage"] = "User Not Found.";
        //        return RedirectToAction("Login");
        //    }

        //    Registration verifiedUser = _registration.GetUserByEmail(email);

        //    int userId = verifiedUser.Id;

        //    return Json(userId);
        //}

        public IActionResult FindUser(string email, string password)
        {
            Register user = new Register() { Email = email, Password = password };

            bool isVerified = _registration.VerifyUser(user);
            if (!isVerified)
            {
                TempData["ErrorMessage"] = "User Not Found.";
                return RedirectToAction("Login");
            }

            // Get the user object from the database using the email address
            Register verifiedUser = _registration.GetUserByEmail(email);

            // Get the user ID of the verified user
            int userId = verifiedUser.Id;

            // Store the user ID in a cookie that expires in 30 minutes
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(30);
            Response.Cookies.Append("UserId", userId.ToString(), options);

            return RedirectToAction("Index", "Logedin");
        }




        public IActionResult Logout()
        {

            Response.Cookies.Delete("UserId");

            return RedirectToAction("Login");
        }

    }
}
