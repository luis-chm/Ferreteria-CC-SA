using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ferreteria_CC_SA.Models.Producto;

namespace Ferreteria_CC_SA.Models
{
    /// <summary>
    /// Represents the concrete model of a product.
    /// </summary>
    /// <seealso cref="Ferreteria_CC_SA.Models.IProducto" />
    public class Producto : IProducto
    {
        /// <summary>
        /// Gets or sets the identifier producto.
        /// </summary>
        /// <value>
        /// The identifier producto.
        /// </value>
        public int IDProducto { get; set; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the descripcion.
        /// </summary>
        /// <value>
        /// The descripcion.
        /// </value>
        public string Descripcion { get; set; }
        /// <summary>
        /// Gets or sets the precio.
        /// </summary>
        /// <value>
        /// The precio.
        /// </value>
        public decimal Precio { get; set; }
        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public int Stock { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Producto"/> class.
        /// </summary>
        public Producto() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Producto"/> class.
        /// </summary>
        /// <param name="idproducto">The idproducto.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="descripcion">The descripcion.</param>
        /// <param name="precio">The precio.</param>
        /// <param name="stock">The stock.</param>
        public Producto(int idproducto, string nombre, string descripcion, decimal precio, int stock)
        {
            IDProducto = idproducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }

    }
}
