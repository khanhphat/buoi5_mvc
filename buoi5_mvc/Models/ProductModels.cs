using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buoi5_mvc.Models
{
    public class ProductModels
    {
        [Display(Name = "Mã hàng hóa")]
        public int Id { get; set; }
        [Display(Name = "Tên hàng hóa")]
        public string Name { get; set; }
        [Display(Name = "Giá sản phẩm")]
        public double Price { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        [Display(Name = "Hết hàng")]
        public bool Empty => Quantity == 0; //c#7.0

        //JS: arrow, C# : LINQ
        //public bool HetHang
        //{
        //    get { return Quantity == 0; }
        //}
    }
}
