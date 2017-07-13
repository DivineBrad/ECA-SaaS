using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECA.Models
{
    public class SupContact
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

    }
}
