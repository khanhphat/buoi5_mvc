using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace buoi5_mvc.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calculate(double A, double B, string pheptoan)
        {
            ViewBag.A = A; ViewBag.B = B;
            
            double kq = 0;
            switch(pheptoan)
            {
                case "+": kq = A + B; break;
                case "-": kq = A - B; break;
                case "*": kq = A * B; break;
                case "/": kq = A / B; break;
                case "^": kq = Math.Pow(A,B); break;
                case "%": kq = A % B; break;
            }
            ViewBag.KQ = kq;
            return View("Index");
        }
    }
}