using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_CC_SA.Models
{
    /// <summary>
    /// Represents the concrete model of a cashier.
    /// </summary>
    /// <seealso cref="Ferreteria_CC_SA.Models.ICajero" />
    public class Cajero : ICajero
    {
        /// <summary>
        /// Gets or sets the identifier cajero.
        /// </summary>
        /// <value>
        /// The identifier cajero.
        /// </value>
        public int IDCajero { get; set; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the apellido.
        /// </summary>
        /// <value>
        /// The apellido.
        /// </value>
        public string Apellido { get; set; }
        /// <summary>
        /// Gets or sets the usuario.
        /// </summary>
        /// <value>
        /// The usuario.
        /// </value>
        public string Usuario { get; set; }
        /// <summary>
        /// Gets or sets the contrasena.
        /// </summary>
        /// <value>
        /// The contrasena.
        /// </value>
        public string Contrasena { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cajero"/> class.
        /// </summary>
        public Cajero() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cajero"/> class.
        /// </summary>
        /// <param name="idcajero">The idcajero.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="apellido">The apellido.</param>
        /// <param name="usuario">The usuario.</param>
        /// <param name="contrasena">The contrasena.</param>
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
