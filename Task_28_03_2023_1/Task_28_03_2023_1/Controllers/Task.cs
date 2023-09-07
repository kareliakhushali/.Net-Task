using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_28_03_2023_1.Controllers
{
    public class Task : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Operation(string data, string opr)
        {
            string ans = string.Empty;
            if (opr.ToLower() == "l" || opr.ToLower() == "lower")
            {
                ans = Task_28_03_2023_1.Models.Opr.tolower(data);
                return Content(ans);
            }
            if (opr.ToLower() == "u" || opr.ToLower() == "upper")
            {
                ans = Task_28_03_2023_1.Models.Opr.toupper(data);
                return Content(ans);
            }
            if (opr.ToLower() == "c" || opr.ToLower() == "count")
            {
                ans = Task_28_03_2023_1.Models.Opr.count(data);
                return Content(ans);
            }
            return Content("Invalid choice");
        }
    }
}
