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
        private IProductoController productoController;
        public FormInventario(IProductoController productoController)
        {
            InitializeComponent();
            this.productoController = productoController;
            try
            {
                this.productoController.LoadProducts();
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarProducto())
            {
                try
                {
                    var producto = new Producto
                    {
                        IDProducto = new Random().Next(1000, 9999),
                        Nombre = txtNombreProducto.Text,
                        Descripcion = txtDescripcionProducto.Text,
                        Precio = decimal.Parse(txtPrecioProducto.Text),
                        Cantidad = int.Parse(txtStockProducto.Text)
                    };

                    if (productoController.AddProduct(producto))
                    {
                        productoController.SaveProducts();
                        ActualizarDataGridView();
                        MessageBox.Show("Producto agregado exitosamente.");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarProducto())
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
                    productoController.EditProduct(producto);
                    productoController.SaveProducts();
                    ActualizarDataGridView();
                    MessageBox.Show("Producto editado exitosamente.");
                    txtIDProducto.ReadOnly = false;
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDProducto.Text, out int idProducto))
            {
                try
                {
                    productoController.DeleteProduct(idProducto);
                    productoController.SaveProducts();
                    ActualizarDataGridView();
                    MessageBox.Show("Producto eliminado exitosamente.");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarID.Text, out int idProducto))
            {
                try
                {
                    CargarProducto(idProducto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
            }
        }

        private void CargarProducto(int idProducto)
        {
            try
            {
                var producto = productoController.FindProductByID(idProducto);
                if (producto != null)
                {
                    txtIDProducto.Text = producto.IDProducto.ToString();
                    txtIDProducto.ReadOnly = true;
                    txtNombreProducto.Text = producto.Nombre;
                    txtDescripcionProducto.Text = producto.Descripcion;
                    txtPrecioProducto.Text = producto.Precio.ToString();
                    txtStockProducto.Text = producto.Cantidad.ToString();
                    MessageBox.Show($"Producto con ID {idProducto} encontrado.");
                    txtBuscarID.Clear();
                }
                else
                {
                    MessageBox.Show($"Producto con ID {idProducto} no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarProducto()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(txtStockProducto.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtIDProducto.Clear();
            txtIDProducto.ReadOnly = false;
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            txtPrecioProducto.Clear();
            txtStockProducto.Clear();
        }

        private void ActualizarDataGridView()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productoController.GetProducts();
        }
    }
}
