using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using buoi5_mvc.Models;
namespace buoi5_mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Delete(int id)
        {
            ProductModels sp = FindById(id);
            if (sp != null)//timf thay
            {
                danhSach.Remove(sp);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(int mahh,ProductModels sp)
        {
            ProductModels item = FindById(mahh);
            if (item != null)
            {
                item.Name = sp.Name;
                item.Quantity = sp.Quantity;
                item.Price = sp.Price;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int mahh)
        {
            //tim ddeens product
            ProductModels sp = FindById(mahh);
            if (sp != null)//Tìm thấy
            {
                return View(sp);
            }
            //Chuyển về Action Index
            return RedirectToAction("Index");
        }

        private ProductModels FindById(int id)
        {
            //dùng LINQ để hỗ trợ tìm kiếm trên mảng.
            //.SingOrDefault() : trả về duy nhất 1 phần tử hoặc NULL.
            return danhSach.SingleOrDefault(p => p.Id == id);
        }
 
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductModels sp)
        {
            danhSach.Add(sp);
            return View("Index", danhSach);
        }

        //List là mảng động
        //static: để giữ giá trị
        static List<ProductModels> danhSach = new List<ProductModels>();
        public IActionResult Index()
        {
            //tạo mới danh sách sản phẩm để hiển thị
            return View(danhSach);
        }
    }
}