using Ferreteria_CC_SA.Models;
using System.Collections.Generic;

namespace Ferreteria_CC_SA.Controllers
{
    public interface IProductoController
    {
        List<IProducto> GetProducts();
        void LoadProducts();
        void SaveProducts();
        bool AddProduct(IProducto producto);
        void EditProduct(IProducto producto);
        void DeleteProduct(int idProducto);
        IProducto FindProductByID(int idProducto);
        void CheckStock(IProducto producto);
    }
}