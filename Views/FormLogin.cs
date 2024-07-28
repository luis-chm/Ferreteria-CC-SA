using Ferreteria_CC_SA.Controllers;
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
    public partial class FormLogin : Form
    {
        private ICajeroController cajeroController;
        public FormLogin()
        {
            InitializeComponent();
            IFileHandler fileHandler = new FileController();
            cajeroController = new CajeroController(fileHandler);
            try
            {
                cajeroController.LoadCashier();
                cajeroController.GenerateInitialCashiers();
                if (!cajeroController.GetCashier().Any())
                {
                    MessageBox.Show("No se encontraron cajeros en el archivo CSV.Message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            try
            {
                if (cajeroController.CheckCashier(usuario, contrasena))
                {
                    MessageBox.Show("Login exitoso. Bienvenido!");
                    FormInicio formInicio = new FormInicio();
                    formInicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante el inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCajeros()
        {
            try
            {
                cajeroController.LoadCashier();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
