using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ferreteria_CC_SA.Models.Producto;

namespace Ferreteria_CC_SA.Models
{

    public class Producto : IProducto
    {
        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto() { }

        public Producto(int idproducto, string nombre, string descripcion, decimal precio, int cantidad)
        {
            IDProducto = idproducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }

    }
}
