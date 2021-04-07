using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothessBrands.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public int CustomersID { get; set; }
        public Customers Customers { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
