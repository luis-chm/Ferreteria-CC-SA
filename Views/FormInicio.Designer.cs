namespace Ferreteria_CC_SA.Views
{
    partial class FormInicio
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
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btn_Cajero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnVenta.Location = new System.Drawing.Point(236, 143);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(67, 25);
            this.btnVenta.TabIndex = 7;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnCliente.Location = new System.Drawing.Point(236, 57);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(67, 25);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnProducto.Location = new System.Drawing.Point(45, 143);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(67, 25);
            this.btnProducto.TabIndex = 5;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            // 
            // btn_Cajero
            // 
            this.btn_Cajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_Cajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btn_Cajero.Location = new System.Drawing.Point(45, 57);
            this.btn_Cajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cajero.Name = "btn_Cajero";
            this.btn_Cajero.Size = new System.Drawing.Size(67, 25);
            this.btn_Cajero.TabIndex = 4;
            this.btn_Cajero.Text = "Cajero";
            this.btn_Cajero.UseVisualStyleBackColor = false;
            this.btn_Cajero.Click += new System.EventHandler(this.btn_Cajero_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(377, 233);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btn_Cajero);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btn_Cajero;
    }
}