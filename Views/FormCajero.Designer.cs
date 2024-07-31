namespace Ferreteria_CC_SA.Views
{
    partial class FormCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCajero));
            this.btnEliminarCajero = new System.Windows.Forms.Button();
            this.btnBuscarCajero = new System.Windows.Forms.Button();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.btnEditarCajero = new System.Windows.Forms.Button();
            this.btnAgregarCajero = new System.Windows.Forms.Button();
            this.dgvCajeros = new System.Windows.Forms.DataGridView();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCajeroNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCajeroID = new System.Windows.Forms.Label();
            this.txtIDCajero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCajero
            // 
            this.btnEliminarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnEliminarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCajero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnEliminarCajero.Location = new System.Drawing.Point(176, 305);
            this.btnEliminarCajero.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCajero.Name = "btnEliminarCajero";
            this.btnEliminarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnEliminarCajero.TabIndex = 47;
            this.btnEliminarCajero.Text = "Eliminar";
            this.btnEliminarCajero.UseVisualStyleBackColor = false;
            this.btnEliminarCajero.Click += new System.EventHandler(this.btnEliminarCajero_Click);
            // 
            // btnBuscarCajero
            // 
            this.btnBuscarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnBuscarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCajero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnBuscarCajero.Location = new System.Drawing.Point(737, 31);
            this.btnBuscarCajero.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCajero.Name = "btnBuscarCajero";
            this.btnBuscarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnBuscarCajero.TabIndex = 46;
            this.btnBuscarCajero.Text = "Buscar";
            this.btnBuscarCajero.UseVisualStyleBackColor = false;
            this.btnBuscarCajero.Click += new System.EventHandler(this.btnBuscarCajero_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBuscarID.Location = new System.Drawing.Point(523, 32);
            this.txtBuscarID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(210, 23);
            this.txtBuscarID.TabIndex = 45;
            // 
            // btnEditarCajero
            // 
            this.btnEditarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnEditarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCajero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnEditarCajero.Location = new System.Drawing.Point(105, 305);
            this.btnEditarCajero.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCajero.Name = "btnEditarCajero";
            this.btnEditarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnEditarCajero.TabIndex = 44;
            this.btnEditarCajero.Text = "Editar";
            this.btnEditarCajero.UseVisualStyleBackColor = false;
            this.btnEditarCajero.Click += new System.EventHandler(this.btnEditarCajero_Click);
            // 
            // btnAgregarCajero
            // 
            this.btnAgregarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnAgregarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCajero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnAgregarCajero.Location = new System.Drawing.Point(34, 305);
            this.btnAgregarCajero.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCajero.Name = "btnAgregarCajero";
            this.btnAgregarCajero.Size = new System.Drawing.Size(67, 25);
            this.btnAgregarCajero.TabIndex = 43;
            this.btnAgregarCajero.Text = "Agregar";
            this.btnAgregarCajero.UseVisualStyleBackColor = false;
            this.btnAgregarCajero.Click += new System.EventHandler(this.btnAgregarCajero_Click);
            // 
            // dgvCajeros
            // 
            this.dgvCajeros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.dgvCajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajeros.Location = new System.Drawing.Point(248, 60);
            this.dgvCajeros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCajeros.Name = "dgvCajeros";
            this.dgvCajeros.RowHeadersWidth = 51;
            this.dgvCajeros.RowTemplate.Height = 24;
            this.dgvCajeros.Size = new System.Drawing.Size(556, 229);
            this.dgvCajeros.TabIndex = 42;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblContraseña.Location = new System.Drawing.Point(31, 249);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(84, 17);
            this.lblContraseña.TabIndex = 41;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContrasena.Location = new System.Drawing.Point(33, 267);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(210, 23);
            this.txtContrasena.TabIndex = 40;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblUsername.Location = new System.Drawing.Point(31, 197);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 17);
            this.lblUsername.TabIndex = 39;
            this.lblUsername.Text = "Username";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(33, 216);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 23);
            this.txtUsuario.TabIndex = 38;
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
            this.lblApellido.TabIndex = 37;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(33, 162);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(210, 23);
            this.txtApellido.TabIndex = 36;
            // 
            // lblCajeroNombre
            // 
            this.lblCajeroNombre.AutoSize = true;
            this.lblCajeroNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajeroNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblCajeroNombre.Location = new System.Drawing.Point(31, 91);
            this.lblCajeroNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCajeroNombre.Name = "lblCajeroNombre";
            this.lblCajeroNombre.Size = new System.Drawing.Size(109, 17);
            this.lblCajeroNombre.TabIndex = 35;
            this.lblCajeroNombre.Text = "Nombre Cajero";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(33, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 34;
            // 
            // lblCajeroID
            // 
            this.lblCajeroID.AutoSize = true;
            this.lblCajeroID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajeroID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblCajeroID.Location = new System.Drawing.Point(31, 41);
            this.lblCajeroID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCajeroID.Name = "lblCajeroID";
            this.lblCajeroID.Size = new System.Drawing.Size(69, 17);
            this.lblCajeroID.TabIndex = 33;
            this.lblCajeroID.Text = "ID Cajero";
            // 
            // txtIDCajero
            // 
            this.txtIDCajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCajero.Location = new System.Drawing.Point(33, 60);
            this.txtIDCajero.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDCajero.Name = "txtIDCajero";
            this.txtIDCajero.Size = new System.Drawing.Size(210, 23);
            this.txtIDCajero.TabIndex = 32;
            // 
            // FormCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(838, 360);
            this.Controls.Add(this.btnEliminarCajero);
            this.Controls.Add(this.btnBuscarCajero);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.btnEditarCajero);
            this.Controls.Add(this.btnAgregarCajero);
            this.Controls.Add(this.dgvCajeros);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblCajeroNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCajeroID);
            this.Controls.Add(this.txtIDCajero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCajero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCajero;
        private System.Windows.Forms.Button btnBuscarCajero;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Button btnEditarCajero;
        private System.Windows.Forms.Button btnAgregarCajero;
        private System.Windows.Forms.DataGridView dgvCajeros;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCajeroNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCajeroID;
        private System.Windows.Forms.TextBox txtIDCajero;
    }
}