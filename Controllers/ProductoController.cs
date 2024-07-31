using Ferreteria_CC_SA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_CC_SA.Controllers
{
    public class ProductoController : IProductoController
    {
        private List<IProducto> productos;
        private IFileHandler fileHandler;
        private static readonly string filepath = "productos.csv";

        public ProductoController(IFileHandler fileHandler)
        {
            productos = new List<IProducto>();
            this.fileHandler = fileHandler;

        }
        public List<IProducto> GetProducts()
        {
            return productos;
        }

        public void LoadProducts()
        {
            productos.Clear();
            try
            {
                if (!File.Exists(filepath))
                {
                    string header = "IDProducto,Nombre,Descripcion,Precio,Cantidad\n";
                    File.WriteAllText(filepath, header);
                    throw new FileNotFoundException("El archivo de productos no se encontró y se creó uno nuevo. Por favor, agregue productos.");
                }

                var content = File.ReadAllLines(filepath);
                foreach (var line in content.Skip(1))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        var producto = new Producto
                        {
                            IDProducto = int.Parse(parts[0].Trim()),
                            Nombre = parts[1].Trim(),
                            Descripcion = parts[2].Trim(),
                            Precio = decimal.Parse(parts[3].Trim()),
                            Cantidad = int.Parse(parts[4].Trim())
                        };
                        productos.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar productos: {ex.Message}");
            }
        }

        public void SaveProducts()
        {
            try
            {
                var lines = new List<string> { "IDProducto,Nombre,Descripcion,Precio,Cantidad" };
                lines.AddRange(productos.Select(p => $"{p.IDProducto},{p.Nombre},{p.Descripcion},{p.Precio},{p.Cantidad}"));
                File.WriteAllLines(filepath, lines);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar productos: {ex.Message}");
            }
        }

        public bool AddProduct(IProducto producto)
        {
            if (productos.Any(p => p.IDProducto == producto.IDProducto))
            {
                throw new ArgumentException($"El producto con ID {producto.IDProducto} ya existe. Por favor ingrese otro.");
            }
            productos.Add(producto);
            return true;
        }

        public void EditProduct(IProducto producto)
        {
            var prod = productos.FirstOrDefault(p => p.IDProducto == producto.IDProducto);
            if (prod != null)
            {
                prod.Nombre = producto.Nombre;
                prod.Descripcion = producto.Descripcion;
                prod.Precio = producto.Precio;
                prod.Cantidad = producto.Cantidad;
                SaveProducts();
            }
            else
            {
                throw new KeyNotFoundException("El producto con el ID proporcionado no existe.");
            }
        }

        public void DeleteProduct(int idProducto)
        {
            var producto = productos.FirstOrDefault(p => p.IDProducto == idProducto);
            if (producto != null)
            {
                productos.Remove(producto);
                SaveProducts();
            }
            else
            {
                throw new KeyNotFoundException("El producto con el ID proporcionado no existe.");
            }
        }

        public IProducto FindProductByID(int idProducto)
        {
            return productos.FirstOrDefault(p => p.IDProducto == idProducto);
        }

        public void CheckStock(IProducto producto)
        {
            if (producto.Cantidad < 10) // Threshold for low stock
            {
                MessageBox.Show($"El producto con ID {producto.IDProducto} tiene bajo stock: {producto.Cantidad} unidades disponibles.");
            }
        }


    }
}
