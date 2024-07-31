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
        public event Action FormClienteClosed;
        public FormCliente(IClienteController clienteController)
        {
            InitializeComponent();
            this.clienteController = clienteController;
            try
            {
                this.clienteController.LoadClient();
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            FormClienteClosed?.Invoke();
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
                        clienteController.SaveClient();
                        ActualizarDataGridView();
                        MessageBox.Show("Cliente agregado exitosamente.");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    clienteController.SaveClient();
                    ActualizarDataGridView();
                    MessageBox.Show("Cliente editado exitosamente.");
                    txtIDCliente.ReadOnly = false;
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDCliente.Text, out int idCliente))
            {
                try
                {
                    clienteController.DeleteClient(idCliente);
                    clienteController.SaveClient();
                    ActualizarDataGridView();
                    MessageBox.Show("Cliente eliminado exitosamente.");
                    txtIDCliente.ReadOnly = false;
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
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarID.Text, out int idCliente))
            {
                try
                {
                    ObtenerClienteData(idCliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
            }
        }
        private void ObtenerClienteData(int idCliente)
        {
            try
            {
                var cliente = clienteController.FindClienteByID(idCliente);
                if (cliente != null)
                {
                    txtIDCliente.Text = cliente.IDCliente.ToString();
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtCorreo.Text = cliente.Correo;
                    txtTelefono.Text = cliente.Telefono;
                    MessageBox.Show($"Cliente con ID {idCliente} encontrado.");
                    txtIDCliente.ReadOnly = true;
                    txtBuscarID.Clear();
                }
                else
                {
                    MessageBox.Show($"Cliente con ID {idCliente} no encontrado.");
                    txtBuscarID.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void ActualizarDataGridView()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteController.GetClients();
        }
    }
}