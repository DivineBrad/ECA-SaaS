using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECA.Models
{
    public class SupInteraction
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        //public Suplier Supplier { get; set; }
    }
}
