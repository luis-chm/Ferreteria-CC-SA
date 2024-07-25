namespace Ferreteria_CC_SA.Models
{
    public interface ICajero
    {
        int IDCajero { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Usuario { get; set; }
        string Contrasena { get; set; }
    }
}