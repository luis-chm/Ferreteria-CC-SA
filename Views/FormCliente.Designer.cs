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
            this.btnEliminarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnEliminarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnEliminarCajero.Location = new System.Drawing.Point(176, 305);
            this.btnEliminarCajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCajero.Name = "btnEliminarCajero";
            this.btnEliminarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnEliminarCajero.TabIndex = 63;
            this.btnEliminarCajero.Text = "Eliminar";
            this.btnEliminarCajero.UseVisualStyleBackColor = false;
            this.btnEliminarCajero.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnBuscarCajero
            // 
            this.btnBuscarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnBuscarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnBuscarCajero.Location = new System.Drawing.Point(650, 31);
            this.btnBuscarCajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCajero.Name = "btnBuscarCajero";
            this.btnBuscarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnBuscarCajero.TabIndex = 62;
            this.btnBuscarCajero.Text = "Buscar";
            this.btnBuscarCajero.UseVisualStyleBackColor = false;
            this.btnBuscarCajero.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBuscarID.Location = new System.Drawing.Point(436, 31);
            this.txtBuscarID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(210, 23);
            this.txtBuscarID.TabIndex = 61;
            // 
            // btnEditarCajero
            // 
            this.btnEditarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnEditarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnEditarCajero.Location = new System.Drawing.Point(105, 305);
            this.btnEditarCajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarCajero.Name = "btnEditarCajero";
            this.btnEditarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnEditarCajero.TabIndex = 60;
            this.btnEditarCajero.Text = "Editar";
            this.btnEditarCajero.UseVisualStyleBackColor = false;
            this.btnEditarCajero.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAgregarCajero
            // 
            this.btnAgregarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnAgregarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnAgregarCajero.Location = new System.Drawing.Point(34, 305);
            this.btnAgregarCajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCajero.Name = "btnAgregarCajero";
            this.btnAgregarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnAgregarCajero.TabIndex = 59;
            this.btnAgregarCajero.Text = "Agregar";
            this.btnAgregarCajero.UseVisualStyleBackColor = false;
            this.btnAgregarCajero.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(248, 60);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(469, 229);
            this.dgvClientes.TabIndex = 58;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblTelefono.Location = new System.Drawing.Point(31, 249);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 17);
            this.lblTelefono.TabIndex = 57;
            this.lblTelefono.Text = "N° Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.Location = new System.Drawing.Point(33, 267);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(210, 23);
            this.txtTelefono.TabIndex = 56;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblCorreo.Location = new System.Drawing.Point(31, 197);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(53, 17);
            this.lblCorreo.TabIndex = 55;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreo.Location = new System.Drawing.Point(33, 216);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(210, 23);
            this.txtCorreo.TabIndex = 54;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblApellido.Location = new System.Drawing.Point(31, 144);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 17);
            this.lblApellido.TabIndex = 53;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(33, 162);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(210, 23);
            this.txtApellido.TabIndex = 52;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblClienteNombre.Location = new System.Drawing.Point(31, 91);
            this.lblClienteNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(111, 17);
            this.lblClienteNombre.TabIndex = 51;
            this.lblClienteNombre.Text = "Nombre Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(33, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 50;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblClienteID.Location = new System.Drawing.Point(31, 41);
            this.lblClienteID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(71, 17);
            this.lblClienteID.TabIndex = 49;
            this.lblClienteID.Text = "ID Cliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDCliente.Location = new System.Drawing.Point(33, 60);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(210, 23);
            this.txtIDCliente.TabIndex = 48;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(734, 360);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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