using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_servidor.modelos
{
    public class Ventas
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int QuantitySold { get; set;}
        public DateTime LastSoldDate { get; set; }
        public string BestCustomer { get; set; }

        /*public int SalesOrderID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public double total_sales { get; set; }
        public double discounts { get; set; }*/
    }
}
