using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothessBrands.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
