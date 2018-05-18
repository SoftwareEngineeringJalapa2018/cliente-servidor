using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_servidor.modelos
{
    class Ventas
    {
        public int id { get; set; }
        public string nombreProducto { get; set; }
        public int stuck { get; set;}
        public DateTime fechaVendido { get; set; }
        public string nombreCliente { get; set; }
    }
}
