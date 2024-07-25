using Ferreteria_CC_SA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_CC_SA.Controllers
{
    public class ProductoController : IProductoController
    {
        private List<IProducto> productos;
        private IFileHandler fileController;
        private string filePath;

        public ProductoController(IFileHandler fileController, string filePath)
        {
            this.fileController = fileController;
            this.filePath = filePath;
            try
            {
                CargarProductos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar productos: {ex.Message}");
            }
        }

        public List<IProducto> ObtenerProductos()
        {
            return productos;
        }

        private void CargarProductos()
        {
            if (!File.Exists(filePath))
            {
                try
                {
                    fileController.GenerateInitialProducts(filePath);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al generar productos iniciales: {ex.Message}");
                }
            }

            try
            {
                productos = fileController.LoadProducts(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar productos del archivo: {ex.Message}");
            }
        }

        public void GuardarProductos()
        {
            try
            {
                fileController.SaveProducts(filePath, productos);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar productos: {ex.Message}");
            }
        }

        public void AgregarProducto(IProducto producto)
        {
            if (productos.Any(p => p.IDProducto == producto.IDProducto))
            {
                throw new InvalidOperationException("El producto con ese ID ya existe.");
            }
            productos.Add(producto);
        }

        public void EditarProducto(int oldID, IProducto producto)
        {
            var prod = productos.FirstOrDefault(p => p.IDProducto == oldID);
            if (prod != null)
            {
                if (productos.Any(p => p.IDProducto == producto.IDProducto && p.IDProducto != oldID))
                {
                    throw new InvalidOperationException($"El producto con ID {producto.IDProducto} ya existe.");
                }
                prod.IDProducto = producto.IDProducto;
                prod.Nombre = producto.Nombre;
                prod.Descripcion = producto.Descripcion;
                prod.Precio = producto.Precio;
                prod.Stock = producto.Stock;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un producto con ID {oldID}.");
            }
        }

        public void EliminarProducto(int idProducto)
        {
            var producto = productos.FirstOrDefault(p => p.IDProducto == idProducto);
            if (producto != null)
            {
                productos.Remove(producto);
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un producto con ID {idProducto}.");
            }
        }
    }
}
