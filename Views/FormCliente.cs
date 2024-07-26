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
    public partial class FormCliente : Form
    {
        private IClienteController clienteController;

        public FormCliente(IClienteController clienteController)
        {
            InitializeComponent();
            this.clienteController = clienteController;
            CargarClientes();
        }
        private void CargarClientes()
        {
            try
            {
                clienteController.LoadClient("clientes.csv");
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}");
            }
        }
        private void ActualizarDataGridView()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteController.GetClients();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    var cliente = new Cliente
                    {
                        IDCliente = int.Parse(txtIDCliente.Text),
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Correo = txtCorreo.Text,
                        Telefono = txtTelefono.Text
                    };
                    if (clienteController.AddClient(cliente))
                    {
                        clienteController.SaveClient("clientes.csv");
                        ActualizarDataGridView();
                        MessageBox.Show("Cliente agregado exitosamente.");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar cliente: {ex.Message}");
                }
            }
        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    var cliente = new Cliente
                    {
                        IDCliente = int.Parse(txtIDCliente.Text),
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Correo = txtCorreo.Text,
                        Telefono = txtTelefono.Text
                    };
                    clienteController.EditClient(cliente);
                    clienteController.SaveClient("clientes.csv");
                    ActualizarDataGridView();
                    MessageBox.Show("Cliente editado exitosamente.");
                    txtIDCliente.ReadOnly = false;
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar cliente: {ex.Message}");
                }
            }
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(txtIDCliente.Text);
                clienteController.DeleteClient(idCliente);
                clienteController.SaveClient("clientes.csv");
                ActualizarDataGridView();
                MessageBox.Show("Cliente eliminado exitosamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}");
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarID.Text, out int idCajero))
            {
                ObtenerClienteData(idCajero);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de cajero válido.");
            }
        }
        private void ObtenerClienteData(int idCliente)
        {
            var cliente = clienteController.FindClienteByID(idCliente);
            if (cliente != null)
            {
                txtIDCliente.Text = cliente.IDCliente.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtCorreo.Text = cliente.Correo;
                txtTelefono.Text = cliente.Telefono;
                txtIDCliente.ReadOnly = true;

                MessageBox.Show($"Cliente con ID {idCliente} encontrado.");
                txtBuscarID.Clear();
            }
            else
            {
                MessageBox.Show($"Cliente con ID {idCliente} no encontrado.");
                txtBuscarID.Clear();
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIDCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtIDCliente.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }
    }
}