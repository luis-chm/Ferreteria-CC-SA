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
            this.btnEliminarCajero.Location = new System.Drawing.Point(189, 415);
            this.btnEliminarCajero.Name = "btnEliminarCajero";
            this.btnEliminarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCajero.TabIndex = 47;
            this.btnEliminarCajero.Text = "Eliminar";
            this.btnEliminarCajero.UseVisualStyleBackColor = true;
            this.btnEliminarCajero.Click += new System.EventHandler(this.btnEliminarCajero_Click);
            // 
            // btnBuscarCajero
            // 
            this.btnBuscarCajero.Location = new System.Drawing.Point(866, 46);
            this.btnBuscarCajero.Name = "btnBuscarCajero";
            this.btnBuscarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCajero.TabIndex = 46;
            this.btnBuscarCajero.Text = "Buscar";
            this.btnBuscarCajero.UseVisualStyleBackColor = true;
            this.btnBuscarCajero.Click += new System.EventHandler(this.btnBuscarCajero_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(688, 46);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(172, 22);
            this.txtBuscarID.TabIndex = 45;
            // 
            // btnEditarCajero
            // 
            this.btnEditarCajero.Location = new System.Drawing.Point(108, 415);
            this.btnEditarCajero.Name = "btnEditarCajero";
            this.btnEditarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCajero.TabIndex = 44;
            this.btnEditarCajero.Text = "Editar";
            this.btnEditarCajero.UseVisualStyleBackColor = true;
            this.btnEditarCajero.Click += new System.EventHandler(this.btnEditarCajero_Click);
            // 
            // btnAgregarCajero
            // 
            this.btnAgregarCajero.Location = new System.Drawing.Point(27, 415);
            this.btnAgregarCajero.Name = "btnAgregarCajero";
            this.btnAgregarCajero.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCajero.TabIndex = 43;
            this.btnAgregarCajero.Text = "Agregar";
            this.btnAgregarCajero.UseVisualStyleBackColor = true;
            this.btnAgregarCajero.Click += new System.EventHandler(this.btnAgregarCajero_Click);
            // 
            // dgvCajeros
            // 
            this.dgvCajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajeros.Location = new System.Drawing.Point(251, 74);
            this.dgvCajeros.Name = "dgvCajeros";
            this.dgvCajeros.RowHeadersWidth = 51;
            this.dgvCajeros.RowTemplate.Height = 24;
            this.dgvCajeros.Size = new System.Drawing.Size(690, 296);
            this.dgvCajeros.TabIndex = 42;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(41, 306);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 41;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(44, 329);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(172, 22);
            this.txtContrasena.TabIndex = 40;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(41, 243);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 39;
            this.lblUsername.Text = "Username";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(44, 266);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(172, 22);
            this.txtUsuario.TabIndex = 38;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(41, 177);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 37;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(44, 200);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(172, 22);
            this.txtApellido.TabIndex = 36;
            // 
            // lblCajeroNombre
            // 
            this.lblCajeroNombre.AutoSize = true;
            this.lblCajeroNombre.Location = new System.Drawing.Point(41, 112);
            this.lblCajeroNombre.Name = "lblCajeroNombre";
            this.lblCajeroNombre.Size = new System.Drawing.Size(99, 16);
            this.lblCajeroNombre.TabIndex = 35;
            this.lblCajeroNombre.Text = "Nombre Cajero";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(44, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 22);
            this.txtNombre.TabIndex = 34;
            // 
            // lblCajeroID
            // 
            this.lblCajeroID.AutoSize = true;
            this.lblCajeroID.Location = new System.Drawing.Point(41, 51);
            this.lblCajeroID.Name = "lblCajeroID";
            this.lblCajeroID.Size = new System.Drawing.Size(63, 16);
            this.lblCajeroID.TabIndex = 33;
            this.lblCajeroID.Text = "ID Cajero";
            // 
            // txtIDCajero
            // 
            this.txtIDCajero.Location = new System.Drawing.Point(44, 74);
            this.txtIDCajero.Name = "txtIDCajero";
            this.txtIDCajero.Size = new System.Drawing.Size(172, 22);
            this.txtIDCajero.TabIndex = 32;
            // 
            // FormCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 518);
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
            this.Name = "FormCajero";
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