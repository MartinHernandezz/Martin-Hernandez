using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Hernandez
{
    public class ProductoVendido
    {
        public double Id { get; set; }

        public double IdProducto { get; set; } 

        public double Stock { get; set; }   

        public double IdVenta { get; set; }

        public ProductoVendido(double id, double idProducto, double stock, double idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }
    }
}
