namespace Ferreteria_CC_SA.Models
{
    /// <summary>
    /// Represents the model of a cashier.
    /// </summary>
    public interface ICajero
    {
        /// <summary>
        /// Gets or sets the identifier cajero.
        /// </summary>
        /// <value>
        /// The identifier cajero.
        /// </value>
        int IDCajero { get; set; }
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
        /// Gets or sets the usuario.
        /// </summary>
        /// <value>
        /// The usuario.
        /// </value>
        string Usuario { get; set; }
        /// <summary>
        /// Gets or sets the contrasena.
        /// </summary>
        /// <value>
        /// The contrasena.
        /// </value>
        string Contrasena { get; set; }
    }
}