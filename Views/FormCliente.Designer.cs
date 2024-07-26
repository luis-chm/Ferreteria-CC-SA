namespace Ferreteria_CC_SA.Views
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminarCajero = new System.Windows.Forms.Button();
            this.btnBuscarCajero = new System.Windows.Forms.Button();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.btnEditarCajero = new System.Windows.Forms.Button();
            this.btnAgregarCajero = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCajero
            // 
            this.btnEliminarCajero.Location = new System.Drawing.Point(177, 393);
            this.btnEliminarCajero.Name = "btnEliminarCajero";
            this.btnEliminarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCajero.TabIndex = 63;
            this.btnEliminarCajero.Text = "Eliminar";
            this.btnEliminarCajero.UseVisualStyleBackColor = true;
            this.btnEliminarCajero.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnBuscarCajero
            // 
            this.btnBuscarCajero.Location = new System.Drawing.Point(854, 24);
            this.btnBuscarCajero.Name = "btnBuscarCajero";
            this.btnBuscarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCajero.TabIndex = 62;
            this.btnBuscarCajero.Text = "Buscar";
            this.btnBuscarCajero.UseVisualStyleBackColor = true;
            this.btnBuscarCajero.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(676, 24);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(172, 22);
            this.txtBuscarID.TabIndex = 61;
            // 
            // btnEditarCajero
            // 
            this.btnEditarCajero.Location = new System.Drawing.Point(96, 393);
            this.btnEditarCajero.Name = "btnEditarCajero";
            this.btnEditarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCajero.TabIndex = 60;
            this.btnEditarCajero.Text = "Editar";
            this.btnEditarCajero.UseVisualStyleBackColor = true;
            this.btnEditarCajero.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAgregarCajero
            // 
            this.btnAgregarCajero.Location = new System.Drawing.Point(15, 393);
            this.btnAgregarCajero.Name = "btnAgregarCajero";
            this.btnAgregarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCajero.TabIndex = 59;
            this.btnAgregarCajero.Text = "Agregar";
            this.btnAgregarCajero.UseVisualStyleBackColor = true;
            this.btnAgregarCajero.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(239, 52);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(690, 296);
            this.dgvClientes.TabIndex = 58;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(29, 284);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 16);
            this.lblTelefono.TabIndex = 57;
            this.lblTelefono.Text = "N° Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(32, 307);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(172, 22);
            this.txtTelefono.TabIndex = 56;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(29, 221);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 16);
            this.lblCorreo.TabIndex = 55;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(32, 244);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(172, 22);
            this.txtCorreo.TabIndex = 54;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 155);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 53;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(32, 178);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(172, 22);
            this.txtApellido.TabIndex = 52;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Location = new System.Drawing.Point(29, 90);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(100, 16);
            this.lblClienteNombre.TabIndex = 51;
            this.lblClienteNombre.Text = "Nombre Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 22);
            this.txtNombre.TabIndex = 50;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(29, 29);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(64, 16);
            this.lblClienteID.TabIndex = 49;
            this.lblClienteID.Text = "ID Cliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(32, 52);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(172, 22);
            this.txtIDCliente.TabIndex = 48;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 478);
            this.Controls.Add(this.btnEliminarCajero);
            this.Controls.Add(this.btnBuscarCajero);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.btnEditarCajero);
            this.Controls.Add(this.btnAgregarCajero);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.txtIDCliente);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCajero;
        private System.Windows.Forms.Button btnBuscarCajero;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Button btnEditarCajero;
        private System.Windows.Forms.Button btnAgregarCajero;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.TextBox txtIDCliente;
    }
}