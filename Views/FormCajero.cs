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
    public partial class FormCajero : Form
    {
        private ICajeroController cajeroController;
        public FormCajero(ICajeroController cajeroController)
        {
            InitializeComponent();
            this.cajeroController = cajeroController;
            this.cajeroController.LoadCashier("cajeros.csv");
            ActualizarDataGridView();
        }
        private void btnAgregarCajero_Click(object sender, EventArgs e)
        {
            if (ValidarCajero())
            {
                try
                {
                    var cajero = new Cajero
                    {
                        IDCajero = int.Parse(txtIDCajero.Text),
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Usuario = txtUsuario.Text,
                        Contrasena = txtContrasena.Text
                    };

                    if (cajeroController.AddCashier(cajero))
                    {
                        cajeroController.SaveCashier("cajeros.csv");
                        ActualizarDataGridView();
                        MessageBox.Show("Cajero agregado exitosamente.");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar cajero: {ex.Message}");
                }
            }
        }
        private void btnEditarCajero_Click(object sender, EventArgs e)
        {
            if (ValidarCajero())
            {
                try
                {
                    var cajero = new Cajero
                    {
                        IDCajero = int.Parse(txtIDCajero.Text),
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Usuario = txtUsuario.Text,
                        Contrasena = txtContrasena.Text
                    };
                    cajeroController.EditCashier(cajero);
                    cajeroController.SaveCashier("cajeros.csv");
                    ActualizarDataGridView();
                    MessageBox.Show("Cajero editado exitosamente.");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar cajero: {ex.Message}");
                }
            }
        }
        private void btnEliminarCajero_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDCajero.Text, out int idCajero))
            {
                cajeroController.DeleteCashier(idCajero);
                cajeroController.SaveCashier("cajeros.csv");
                ActualizarDataGridView();
                MessageBox.Show("Cajero eliminado exitosamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }
        private void btnBuscarCajero_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarID.Text, out int idCajero))
            {
                CargarCajero(idCajero);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de cajero válido.");
            }
        }
        private void CargarCajero(int idCajero)
        {
            var cajero = cajeroController.FindCashierByID(idCajero);
            if (cajero != null)
            {
                txtIDCajero.Text = cajero.IDCajero.ToString();
                txtNombre.Text = cajero.Nombre;
                txtApellido.Text = cajero.Apellido;
                txtUsuario.Text = cajero.Usuario;
                txtContrasena.Text = cajero.Contrasena;
                MessageBox.Show($"Cajero con ID {idCajero} encontrado.");
                txtBuscarID.Clear();
            }
            else
            {
                MessageBox.Show($"Cajero con ID {idCajero} no encontrado.");
            }
        }
        private bool ValidarCajero()
        {
            if (string.IsNullOrWhiteSpace(txtIDCajero.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }
            if (!int.TryParse(txtIDCajero.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtIDCajero.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
        }
        private void ActualizarDataGridView()
        {
            dgvCajeros.DataSource = null;
            dgvCajeros.DataSource = cajeroController.GetCashier();
        }
        private void FormCajero_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }
    }
}
