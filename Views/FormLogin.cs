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
    /// <summary>
    /// Defines the operations for Form Login
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormLogin : Form
    {
        /// <summary>
        /// Defines a interface of cajero controller
        /// </summary>
        private ICajeroController cajeroController;
        /// <summary>
        /// Initializes a new instance of the <see cref="FormLogin"/> class.
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            IFileHandler fileHandler = new FileController();
            cajeroController = new CajeroController(fileHandler);

            CargarCajeros();
            string path = "cajeros.csv";
            cajeroController.GenerateInitialCashiers(path);
            if (!cajeroController.GetCashier().Any())
            {
                MessageBox.Show("No se encontraron cajeros en el archivo CSV.");
            }
        }
        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

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
        /// <summary>
        /// Load the cashiers.
        /// </summary>
        private void CargarCajeros()
        {
            try
            {
                cajeroController.LoadCashier("cajeros.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cajeros: {ex.Message}");
            }
        }
    }
}
