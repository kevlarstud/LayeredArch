using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        //store unique identifier of product-6 digits
        public int ProductID { get; set; }

        //Should be letter and spaces allowed
        public string ProductName { get; set; }

        //cannot be less than 50
        public int Price { get; set; }

        //cannot be negative
        public int Quantity { get; set; }

        //should be mobiles or laptop
        public string Category { get; set; }

        //should be current date
        public DateTime ManufactureDate { get; set; }
    }
}
