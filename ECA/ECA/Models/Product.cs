using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECA.Models
{
    
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double ProdPrice { get; set; }
        public int prodQuantity { get; set; }
        public int ProdCode { get; set; }

        public Product()
        {

        }
        public Product(string productName, double prodPrice, int prodQuantity, int prodCode )
        {
             
        }


    }
}
