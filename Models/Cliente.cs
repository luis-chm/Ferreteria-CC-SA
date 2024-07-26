using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_CC_SA.Models
{
    /// <summary>
    /// Represents the concrete model of a client.
    /// </summary>
    /// <seealso cref="Ferreteria_CC_SA.Models.ICliente" />
    public class Cliente : ICliente
    {

        /// <summary>
        /// Gets or sets the identifier cliente.
        /// </summary>
        /// <value>
        /// The identifier cliente.
        /// </value>
        public int IDCliente { get; set; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The name of client.
        /// </value>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the apellido.
        /// </summary>
        /// <value>
        /// The last name of client.
        /// </value>
        public string Apellido { get; set; }
        /// <summary>
        /// Gets or sets the correo.
        /// </summary>
        /// <value>
        /// The email of client.
        /// </value>
        public string Correo { get; set; }
        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>
        /// The telephone of client.
        /// </value>
        public string Telefono { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cliente"/> class.
        /// </summary>
        public Cliente() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cliente"/> class.
        /// </summary>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="apellido">The apellido.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="telefono">The telefono.</param>
        public Cliente(int idCliente, string nombre, string apellido, string correo, string telefono)
        {
            IDCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
