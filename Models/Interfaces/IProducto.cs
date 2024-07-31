namespace Ferreteria_CC_SA.Models
{
    /// <summary>
    /// Represents the model of a product.
    /// </summary>
    public interface IProducto
    {
        /// <summary>
        /// Gets or sets the identifier producto.
        /// </summary>
        /// <value>
        /// The identifier producto.
        /// </value>
        int IDProducto { get; set; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the descripcion.
        /// </summary>
        /// <value>
        /// The descripcion.
        /// </value>
        string Descripcion { get; set; }
        /// <summary>
        /// Gets or sets the precio.
        /// </summary>
        /// <value>
        /// The precio.
        /// </value>
        decimal Precio { get; set; }
        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        int Cantidad { get; set; }
    }
}