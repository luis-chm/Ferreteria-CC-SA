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
            cajeroController = new CajeroController();

            string path = "cajeros.csv";
            cajeroController.LoadCashier(path);

            if (!cajeroController.GetCashier().Any())
            {
                MessageBox.Show("No se encontraron cajeros en el archivo CSV.");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (cajeroController.CheckLogin(usuario, contrasena))
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
    }
}
