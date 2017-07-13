using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECA.Models
{
    public class CusContact
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BillingAddress { get; set; }
        public string ShipAddress { get; set; }
    }
}
