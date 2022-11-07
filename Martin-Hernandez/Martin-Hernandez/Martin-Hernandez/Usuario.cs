using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Hernandez
{
    public class Usuario
    {

        public double Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Mail { get; set; }

        public Usuario(double id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Mail = mail;
        }
    }
}
