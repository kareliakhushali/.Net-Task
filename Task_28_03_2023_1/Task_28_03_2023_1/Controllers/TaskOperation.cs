using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_28_03_2023_1.Controllers
{
    public class TaskOperation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Operation()
        {
            return View();
        }
        public IActionResult Data()
        {
            return View();
        }
        public IActionResult Task()
        {
            string no1 = Request.Form["no1"];
            string no2 = Request.Form["no2"];
            string choice = Request.Form["opr"];
            if (!int.TryParse(no1, out int n1) || !int.TryParse(no2, out int n2))
            {
                return Content($"Invalid input for Number 1:- {no1} || Number 2:- {no2} Please give a integer value!!");
            }

            switch (choice.ToLower())
            {
                case "add":
                    String ansadd = $"{Models.Opr.Add(n1, n2)}";
                    return Content($"Number 1:- {n1}\n Number 2:- {n2}\n Addition of {n1} and {n2} is:- {ansadd}");
                case "sub":
                    String anssub = $"{Models.Opr.Sub(n1, n2)}";
                    return Content($"Number 1:- {n1}\n Number 2:- {n2}\n Subtraction of {n1} and {n2} is:- {anssub}");
                case "mul":
                    String ansmul = $"{Models.Opr.Mul(n1, n2)}";
                    return Content($"Number 1:- {n1}\n Number 2:- {n2}\n Multiplication of {n1} and {n2} is:- {ansmul}");
                case "div":
                    String ansdiv = $"{Models.Opr.Div(n1, n2)}";
                    return Content($"Number 1:- {n1}\n Number 2:- {n2}\n Division of {n1} and {n2} is:- {ansdiv}");
                case "pow":
                    String anspow = $"{Models.Opr.Pow(n1, n2)}";
                    return Content($"Number 1:- {n1}\n Number 2:- {n2}\n The value of {n1} to the power of {no2} is:- {anspow}");



                default:
                    return Content("Invalid Choice");
            }
        }
        public IActionResult StringTask()
        {
            string data = Request.Form["data"];
            string opr = Request.Form["opr"];
            switch (opr.ToLower())
            {
                case "l":
                    string lower = $"{Models.Opr.tolower(data)}";
                    return Content($"Your Name in Lowercase:- {lower}");
                case "u":
                    string upper = $"{Models.Opr.toupper(data)}";
                    return Content($"Your Name in Uppercase:- {upper}");
                case "c":
                    string count = $"{Models.Opr.count(data)}";
                    return Content($"Your Name {data}:- {count}");
                case "lower":
                    string l = $"{Models.Opr.tolower(data)}";
                    return Content($"Your Name in Lowercase:- {l}");
                case "upper":
                    string u = $"{Models.Opr.toupper(data)}";
                    return Content($"Your Name in Lowercase:- {u}");
                case "count":
                    string c = $"{Models.Opr.count(data)}";
                    return Content($"Your Name {data} is:- {c}");
                default:
                    return Content("Invalid Choice");
            }
        }
        /*public IActionResult Opr(int no1, int no2, string opr)
        {
            String ans = string.Empty;
            if (opr.ToLower() == "a" || opr.ToLower() == "add")
            {
                ans = $"{no1}\n+\n{no2}\n---\n{Task_28_03_2023_1.Models.Opr.Add(no1, no2)}";
                return Content(ans);
            }
            else if (opr.ToLower() == "s" || opr.ToLower() == "sub")
            {
                ans = $"{no1}\n-\n{no2}\n---\n{Task_28_03_2023_1.Models.Opr.Sub(no1, no2)}";
                return Content(ans);
            }
            else if (opr.ToLower() == "m" || opr.ToLower() == "mul")
            {
                ans = $"{no1}\n*\n{no2}\n---\n{Task_28_03_2023_1.Models.Opr.Mul(no1, no2)}";
                return Content(ans);
            }
            else if (opr.ToLower() == "d" || opr.ToLower() == "div")
            {
                ans = $"{no1}\n/\n{no2}\n---\n{Task_28_03_2023_1.Models.Opr.Div(no1, no2)}";
                return Content(ans);
            }
            else if (opr.ToLower() == "p" || opr.ToLower() == "power")
            {
                ans = $"{no1}\n^\n{no2}\n---\n{Task_28_03_2023_1.Models.Opr.Pow(no1, no2)}";
                return Content(ans);
            }
            String value = "Invalid Operation";
            return Content(value);





        }*/
    }
}
