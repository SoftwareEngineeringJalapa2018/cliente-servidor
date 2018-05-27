using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_servidor.modelos
{
    class VentasPhp
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int quantitysold { get; set; }
        public DateTime lastsolddate { get; set; }
        public string bestcustomer { get; set; }
    }
}
