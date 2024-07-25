using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_CC_SA.Models
{
    public class Cajero : ICajero
    {
        public int IDCajero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public Cajero() { }

        public Cajero(int idcajero, string nombre, string apellido, string usuario, string contrasena)
        {
            IDCajero = idcajero;
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            Contrasena = contrasena;
        }
    }
}
