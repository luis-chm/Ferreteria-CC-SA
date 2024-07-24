namespace Ferreteria_CC_SA.Models
{
    public interface IProducto
    {
        int IDProducto { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        decimal Precio { get; set; }
        int Cantidad { get; set; }
    }
}