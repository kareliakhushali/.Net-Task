using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Task_28_03_2023_1.Models;


namespace Task_28_03_2023_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            String value = "This is the index of the product";
            return Content(value);
        }
        public IActionResult Search()
        {
            string output = string.Empty;
            List<Product> products = GetProducts();
            /* int index = products.FindIndex(each => each.Id == id);
             if (index == -1)
             {
                 return Content($"{id} does not exists");
             }*/
            bool isAll = false;
            int Id;
            if (Request.Form["Id"] == "All")
            {
                isAll = true;
            }
            else if (!int.TryParse(Request.Form["Id"], out Id) || Id <= 0)
            {
                output = $"Invalid Id {Id}";
                return Content(output);
            }
            output += $"{ "Id",-10}{ "Name",-20}{"Qty",-10}{"Rate",-10}\n";
            for (int loop = 1; loop < 50; loop++) output += "-";
            output += "\n";
            foreach (Product pro in products)
            {
                if (isAll)
                {
                    output += $"{pro.Id,-10}{pro.Name,-20}{pro.Qty,-10}{pro.Rate,-10}\n";
                }
                else if (pro.Id == Convert.ToInt32(Request.Form["Id"]))
                {
                    output += $"{pro.Id,-10}{pro.Name,-20}{pro.Qty,-10}{pro.Rate,-10}\n";
                }
            }
            if (output == string.Empty)
            {
                output = $"Product not found";
            }
            return Content(output);




        }
        private List<Product> GetProducts()
        {
     List<Product> products = new List<Product>()
 {
 new Product() {Id=1, Name="Product1",Qty=100,Rate=85},
 new Product() {Id=2, Name="Product2",Qty=120,Rate=50},
 new Product() {Id=3, Name="Product3",Qty=45,Rate=105},
 new Product() {Id=4, Name="Product4",Qty=10,Rate=190},
 };
            return products;
        }

        public IActionResult Display()
        {
            return View();
        }





    }
}
