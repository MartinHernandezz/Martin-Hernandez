using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Hernandez
{
    public class Producto
    {

        public int Id { get; set; }

        public string Descripcion { get; set; } 

        public double Costo { get; set; }

        public double PrecioVenta { get; set; } 

        public double Stock { get; set; }

        public double IdUsuario { get; set; }

        public Producto (int id, string descripcion, double costo, double precioVenta, double stock, double idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
        // No les agrege el "this." pq me parecia mas facil poder hacerlos asi :)
    }
}
