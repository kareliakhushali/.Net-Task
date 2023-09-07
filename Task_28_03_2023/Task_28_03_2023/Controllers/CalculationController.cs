using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_28_03_2023.Controllers
{
    public class CalculationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Calculate(double no1, double no2, string opr)
        {
            double result;
            if (opr == "+")
            {
                result = no1 + no2;
            }
            else if (opr == "-")
            {
                result = no1 - no2;
            }
            else if (opr == "*")
            {
                result = no1 * no2;
            }
            else if (opr == "/")
            {
                if (no2 == 0)
                {
                    return Content("Error: Cannot divide by zero.");
                }
                result = no1 / no2;
            }
            else if (opr == "p")
            {
                result = Math.Pow(no1, no2);
            }
            else
            {
                return Content("Error: Invalid operator.");
            }

            return Content(string.Format("{0} {1} {2} = {3}", no1, opr, no2, result));
        }
    }
}
