namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmTelefonosClientesProveedores
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
            this.components = new System.ComponentModel.Container();
            this.gpTelefonosClientes = new System.Windows.Forms.GroupBox();
            this.btnSalirAgregarTelefonosClienteProveedor = new System.Windows.Forms.Button();
            this.btnAgregarTelefonosClienteProveedor = new System.Windows.Forms.Button();
            this.mskTelefonoMovilClienteProveedor = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Móvil = new System.Windows.Forms.ListBox();
            this.lblTelefonoMovilClienteProveedor = new System.Windows.Forms.Label();
            this.lblTelefonoFijoCliente = new System.Windows.Forms.Label();
            this.mskTelefonoFijoClienteProveedor = new System.Windows.Forms.MaskedTextBox();
            this.Fijos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.epValidarNumeros = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLinea = new System.Windows.Forms.Label();
            this.gpTelefonosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // gpTelefonosClientes
            // 
            this.gpTelefonosClientes.BackColor = System.Drawing.Color.Transparent;
            this.gpTelefonosClientes.Controls.Add(this.btnSalirAgregarTelefonosClienteProveedor);
            this.gpTelefonosClientes.Controls.Add(this.btnAgregarTelefonosClienteProveedor);
            this.gpTelefonosClientes.Controls.Add(this.mskTelefonoMovilClienteProveedor);
            this.gpTelefonosClientes.Controls.Add(this.label8);
            this.gpTelefonosClientes.Controls.Add(this.Móvil);
            this.gpTelefonosClientes.Controls.Add(this.lblTelefonoMovilClienteProveedor);
            this.gpTelefonosClientes.Controls.Add(this.lblTelefonoFijoCliente);
            this.gpTelefonosClientes.Controls.Add(this.mskTelefonoFijoClienteProveedor);
            this.gpTelefonosClientes.Controls.Add(this.Fijos);
            this.gpTelefonosClientes.Controls.Add(this.label9);
            this.gpTelefonosClientes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTelefonosClientes.ForeColor = System.Drawing.Color.SteelBlue;
            this.gpTelefonosClientes.Location = new System.Drawing.Point(12, 30);
            this.gpTelefonosClientes.Name = "gpTelefonosClientes";
            this.gpTelefonosClientes.Size = new System.Drawing.Size(304, 288);
            this.gpTelefonosClientes.TabIndex = 43;
            this.gpTelefonosClientes.TabStop = false;
            this.gpTelefonosClientes.Text = "Números de Teléfono";
            this.gpTelefonosClientes.Enter += new System.EventHandler(this.gpTelefonosClientes_Enter);
            // 
            // btnSalirAgregarTelefonosClienteProveedor
            // 
            this.btnSalirAgregarTelefonosClienteProveedor.BackColor = System.Drawing.Color.White;
            this.btnSalirAgregarTelefonosClienteProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirAgregarTelefonosClienteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAgregarTelefonosClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAgregarTelefonosClienteProveedor.Location = new System.Drawing.Point(34, 245);
            this.btnSalirAgregarTelefonosClienteProveedor.Name = "btnSalirAgregarTelefonosClienteProveedor";
            this.btnSalirAgregarTelefonosClienteProveedor.Size = new System.Drawing.Size(114, 37);
            this.btnSalirAgregarTelefonosClienteProveedor.TabIndex = 56;
            this.btnSalirAgregarTelefonosClienteProveedor.Text = "&Salir";
            this.btnSalirAgregarTelefonosClienteProveedor.UseVisualStyleBackColor = false;
            this.btnSalirAgregarTelefonosClienteProveedor.Click += new System.EventHandler(this.btnSalirAgregarTelefonosClienteProveedor_Click);
            // 
            // btnAgregarTelefonosClienteProveedor
            // 
            this.btnAgregarTelefonosClienteProveedor.BackColor = System.Drawing.Color.White;
            this.btnAgregarTelefonosClienteProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTelefonosClienteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTelefonosClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefonosClienteProveedor.Location = new System.Drawing.Point(157, 245);
            this.btnAgregarTelefonosClienteProveedor.Name = "btnAgregarTelefonosClienteProveedor";
            this.btnAgregarTelefonosClienteProveedor.Size = new System.Drawing.Size(114, 37);
            this.btnAgregarTelefonosClienteProveedor.TabIndex = 55;
            this.btnAgregarTelefonosClienteProveedor.Text = "&Agregar";
            this.btnAgregarTelefonosClienteProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarTelefonosClienteProveedor.Click += new System.EventHandler(this.btnAgregarTelefonosClienteProveedor_Click);
            // 
            // mskTelefonoMovilClienteProveedor
            // 
            this.mskTelefonoMovilClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefonoMovilClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskTelefonoMovilClienteProveedor.Location = new System.Drawing.Point(94, 71);
            this.mskTelefonoMovilClienteProveedor.Mask = "0000-0000";
            this.mskTelefonoMovilClienteProveedor.Name = "mskTelefonoMovilClienteProveedor";
            this.mskTelefonoMovilClienteProveedor.Size = new System.Drawing.Size(197, 27);
            this.mskTelefonoMovilClienteProveedor.TabIndex = 27;
            this.mskTelefonoMovilClienteProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefonoMovilClienteProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefonoMovilClienteProveedor_KeyPress);
            this.mskTelefonoMovilClienteProveedor.Leave += new System.EventHandler(this.mskTelefonoMovilClienteProveedor_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(-30, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(358, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "___________________________________";
            // 
            // Móvil
            // 
            this.Móvil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Móvil.ForeColor = System.Drawing.Color.SteelBlue;
            this.Móvil.FormattingEnabled = true;
            this.Móvil.ItemHeight = 18;
            this.Móvil.Location = new System.Drawing.Point(157, 128);
            this.Móvil.Name = "Móvil";
            this.Móvil.Size = new System.Drawing.Size(134, 94);
            this.Móvil.TabIndex = 29;
            this.Móvil.SelectedIndexChanged += new System.EventHandler(this.Móvil_SelectedIndexChanged);
            // 
            // lblTelefonoMovilClienteProveedor
            // 
            this.lblTelefonoMovilClienteProveedor.AutoSize = true;
            this.lblTelefonoMovilClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoMovilClienteProveedor.Location = new System.Drawing.Point(16, 74);
            this.lblTelefonoMovilClienteProveedor.Name = "lblTelefonoMovilClienteProveedor";
            this.lblTelefonoMovilClienteProveedor.Size = new System.Drawing.Size(57, 18);
            this.lblTelefonoMovilClienteProveedor.TabIndex = 28;
            this.lblTelefonoMovilClienteProveedor.Text = "Móvil:";
            // 
            // lblTelefonoFijoCliente
            // 
            this.lblTelefonoFijoCliente.AutoSize = true;
            this.lblTelefonoFijoCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoFijoCliente.Location = new System.Drawing.Point(16, 38);
            this.lblTelefonoFijoCliente.Name = "lblTelefonoFijoCliente";
            this.lblTelefonoFijoCliente.Size = new System.Drawing.Size(45, 18);
            this.lblTelefonoFijoCliente.TabIndex = 26;
            this.lblTelefonoFijoCliente.Text = "Fijo:";
            // 
            // mskTelefonoFijoClienteProveedor
            // 
            this.mskTelefonoFijoClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefonoFijoClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskTelefonoFijoClienteProveedor.Location = new System.Drawing.Point(94, 33);
            this.mskTelefonoFijoClienteProveedor.Mask = "####-####";
            this.mskTelefonoFijoClienteProveedor.Name = "mskTelefonoFijoClienteProveedor";
            this.mskTelefonoFijoClienteProveedor.Size = new System.Drawing.Size(197, 27);
            this.mskTelefonoFijoClienteProveedor.TabIndex = 1;
            this.mskTelefonoFijoClienteProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefonoFijoClienteProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefonoFijoClienteProveedor_KeyPress);
            this.mskTelefonoFijoClienteProveedor.Leave += new System.EventHandler(this.mskTelefonoFijoClienteProveedor_Leave);
            // 
            // Fijos
            // 
            this.Fijos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fijos.ForeColor = System.Drawing.Color.SteelBlue;
            this.Fijos.FormattingEnabled = true;
            this.Fijos.ItemHeight = 18;
            this.Fijos.Location = new System.Drawing.Point(19, 128);
            this.Fijos.Name = "Fijos";
            this.Fijos.Size = new System.Drawing.Size(129, 94);
            this.Fijos.TabIndex = 0;
            this.Fijos.SelectedIndexChanged += new System.EventHandler(this.Fijos_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(-13, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(358, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "___________________________________";
            // 
            // epValidarNumeros
            // 
            this.epValidarNumeros.ContainerControl = this;
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-264, -2);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 44;
            // 
            // frmTelefonosClientesProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 330);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gpTelefonosClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelefonosClientesProveedores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelefonosClientesProveedores";
            this.Load += new System.EventHandler(this.frmTelefonosClientesProveedores_Load);
            this.gpTelefonosClientes.ResumeLayout(false);
            this.gpTelefonosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTelefonosClientes;
        private System.Windows.Forms.MaskedTextBox mskTelefonoMovilClienteProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Móvil;
        private System.Windows.Forms.Label lblTelefonoMovilClienteProveedor;
        private System.Windows.Forms.Label lblTelefonoFijoCliente;
        private System.Windows.Forms.MaskedTextBox mskTelefonoFijoClienteProveedor;
        private System.Windows.Forms.ListBox Fijos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregarTelefonosClienteProveedor;
        private System.Windows.Forms.Button btnSalirAgregarTelefonosClienteProveedor;
        private System.Windows.Forms.ErrorProvider epValidarNumeros;
        private System.Windows.Forms.Label lblLinea;
    }
}