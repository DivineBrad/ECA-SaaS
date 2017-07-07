using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECA.Models
{
    public class Tenant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TAddressID { get; set; }
       // public TenantAddress Address { get; set; }
    }
}
