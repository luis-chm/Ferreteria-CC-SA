using Ferreteria_CC_SA.Controllers;
using Ferreteria_CC_SA.Views;
using System;
using System.Windows.Forms;

namespace Ferreteria_CC_SA.Views
{
    public partial class FormInicio : Form
    {
        private FormInventario formInventario;
        private FormCajero formCajero;
        private FormCliente formCliente;
        private FormVenta formVenta;
        public FormInicio()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btn_Cajero_Click(object sender, EventArgs e)
        {
            if (formCajero == null)
            {
                ICajeroController cajeroController = new CajeroController();
                formCajero = new FormCajero(cajeroController);
                formCajero.FormClosed += (s, args) => this.Show();
            }
            this.Hide();
            formCajero.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (formInventario == null)
            {
                IProductoController productoController = new ProductoController();
                formInventario = new FormInventario(productoController);
                formInventario.FormClosed += (s, args) => this.Show();
            }
            this.Hide();
            formInventario.Show();
        }

       /* private void btnCliente_Click(object sender, EventArgs e)
        {
            if (formCliente == null)
            {
                IClienteController clienteController = new ClienteController();
                formCliente = new FormCliente();
                formCliente.FormClosed += (s, args) => this.Show();
            }
            this.Hide();
            formCliente.Show();
        }

        /*private void btnVenta_Click(object sender, EventArgs e)
        {
            if (formVenta == null)
            {
                IVentaController ventaController = new VentaController();
                formVenta = new FormVenta();
                formVenta.FormClosed += (s, args) => this.Show();
            }
            this.Hide();
            formVenta.Show();
        }*/
    }
}
