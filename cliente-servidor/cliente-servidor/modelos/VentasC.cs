using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_servidor.modelos
{
    class VentasC
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int quantitySold { get; set; }
        public int stock { get; set; }
        public DateTime lastSoldDate { get; set; }
        public string bestCustomer { get; set; }
    }
}
