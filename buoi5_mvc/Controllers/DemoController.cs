using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace buoi5_mvc.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ten = "Index";
            return View();
        }

        //[Route("A")] //host/Demo/A
        //[Route("/")] //host/   : dấu / tương đương hót
        //[Route("")] //host/Demo : bỏ action
        public IActionResult Test1()
        {

            ViewBag.Ten = "Ten";
            //gởi tới view index để hiển thị
            return View("Index");
        }

        //[Route("dien-thoai/{hoten}")] //host/Demo : bỏ action
        public IActionResult Test2(string hoten)
        {
            ViewBag.Ten = hoten;
            //gởi tới view index để hiển thị
            return View("Index");
        }

        //[Route("{loai}/{hoten}")] //host/Demo : bỏ action
        public IActionResult Test3(string loai, string hoten)
        {
            ViewBag.Ten = $"{loai} --> {hoten}";
            //gởi tới view index để hiển thị
            return View("Index");
        }
    }
}