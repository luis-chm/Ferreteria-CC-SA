using Ferreteria_CC_SA.Models;
using System.Collections.Generic;

namespace Ferreteria_CC_SA.Controllers
{
    public interface IProductoController
    {
        List<IProducto> ObtenerProductos();
        void AgregarProducto(IProducto producto);
        void EditarProducto(int oldID, IProducto producto);
        void EliminarProducto(int idProducto);
    }
}