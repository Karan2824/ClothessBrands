using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothessBrands.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public int Quantity { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
