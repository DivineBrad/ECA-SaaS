using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECA.Models
{
    public class CusInteraction 
    {

        public int ID { get; set; }
        public DateTime date { get; set; }
        public int CustomerID { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        //public Customer Customer { get; set; }

    }
}
