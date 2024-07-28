using Ferreteria_CC_SA.Controllers;
using Ferreteria_CC_SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_CC_SA.Views
{
    public partial class FormInventario : Form
    {
        /*private ProductoController productoController;

        public FormInventario()
        {
            InitializeComponent();
            string filePath = "productos.csv";
            IFileHandler fileController = new FileController();
            try
            {
                productoController = new ProductoController(fileController, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el controlador de productos: {ex.Message}");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    IDProducto = int.Parse(txtIDProducto.Text),
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcionProducto.Text,
                    Precio = decimal.Parse(txtPrecioProducto.Text),
                    Cantidad = int.Parse(txtStockProducto.Text)
                };

                productoController.AgregarProducto(producto);
                productoController.GuardarProductos();
                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}");
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    IDProducto = int.Parse(txtIDProducto.Text),
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcionProducto.Text,
                    Precio = decimal.Parse(txtPrecioProducto.Text),
                    Stock = int.Parse(txtStockProducto.Text)
                };

                productoController.EditarProducto(int.Parse(txtOldIDProducto.Text), producto);
                productoController.GuardarProductos();
                MessageBox.Show("Producto editado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar producto: {ex.Message}");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIDProducto.Text);
                productoController.EliminarProducto(idProducto);
                productoController.GuardarProductos();
                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
            }
        }*/
    }
}
