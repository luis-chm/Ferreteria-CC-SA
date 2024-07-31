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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btn_Cajero = new System.Windows.Forms.Button();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.pbVenta = new System.Windows.Forms.PictureBox();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.pbCajero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btnVenta.Location = new System.Drawing.Point(236, 203);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(77, 25);
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
            this.btnCliente.Location = new System.Drawing.Point(236, 84);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(77, 25);
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
            this.btnProducto.Location = new System.Drawing.Point(45, 203);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(77, 25);
            this.btnProducto.TabIndex = 5;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btn_Cajero
            // 
            this.btn_Cajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_Cajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cajero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.btn_Cajero.Location = new System.Drawing.Point(45, 84);
            this.btn_Cajero.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cajero.Name = "btn_Cajero";
            this.btn_Cajero.Size = new System.Drawing.Size(77, 25);
            this.btn_Cajero.TabIndex = 4;
            this.btn_Cajero.Text = "Cajero";
            this.btn_Cajero.UseVisualStyleBackColor = false;
            this.btn_Cajero.Click += new System.EventHandler(this.btn_Cajero_Click);
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::Ferreteria_CC_SA.Properties.Resources.Client;
            this.pbCliente.Location = new System.Drawing.Point(236, 12);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(77, 67);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 11;
            this.pbCliente.TabStop = false;
            // 
            // pbVenta
            // 
            this.pbVenta.Image = global::Ferreteria_CC_SA.Properties.Resources.Sell;
            this.pbVenta.Location = new System.Drawing.Point(236, 131);
            this.pbVenta.Name = "pbVenta";
            this.pbVenta.Size = new System.Drawing.Size(77, 67);
            this.pbVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVenta.TabIndex = 10;
            this.pbVenta.TabStop = false;
            // 
            // pbProducto
            // 
            this.pbProducto.Image = global::Ferreteria_CC_SA.Properties.Resources.Product;
            this.pbProducto.Location = new System.Drawing.Point(45, 131);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(77, 67);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducto.TabIndex = 9;
            this.pbProducto.TabStop = false;
            // 
            // pbCajero
            // 
            this.pbCajero.Image = global::Ferreteria_CC_SA.Properties.Resources.Cashier;
            this.pbCajero.Location = new System.Drawing.Point(45, 12);
            this.pbCajero.Name = "pbCajero";
            this.pbCajero.Size = new System.Drawing.Size(77, 67);
            this.pbCajero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCajero.TabIndex = 8;
            this.pbCajero.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(383, 242);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.pbVenta);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.pbCajero);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btn_Cajero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btn_Cajero;
        private System.Windows.Forms.PictureBox pbCajero;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.PictureBox pbVenta;
        private System.Windows.Forms.PictureBox pbCliente;
    }
}