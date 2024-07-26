namespace Ferreteria_CC_SA.Models
{
    /// <summary>
    /// Represents the model of a client.
    /// </summary>
    public interface ICliente
    {
        /// <summary>
        /// Gets or sets the identifier cliente.
        /// </summary>
        /// <value>
        /// The identifier cliente.
        /// </value>
        int IDCliente { get; set; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the apellido.
        /// </summary>
        /// <value>
        /// The apellido.
        /// </value>
        string Apellido { get; set; }
        /// <summary>
        /// Gets or sets the correo.
        /// </summary>
        /// <value>
        /// The correo.
        /// </value>
        string Correo { get; set; }
        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>
        /// The telefono.
        /// </value>
        string Telefono { get; set; }
    }
}