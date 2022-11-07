using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Hernandez
{
    public class Venta
    {
        public double Id { get; set; }

        public string Comentarios { get; set; }

        public double IdUsuario { get; set; }


        public Venta(double ID, string comentario, double idUsuario)
        {
            Id = ID;

            Comentarios = comentario;

            IdUsuario = idUsuario;
        }
     }
}
