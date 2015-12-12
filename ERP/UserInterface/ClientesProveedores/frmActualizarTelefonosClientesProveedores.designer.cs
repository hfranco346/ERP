namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmActualizarTelefonosClientesProveedores
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
            this.gbActualizarNumerosTelefonoClientesProveedores = new System.Windows.Forms.GroupBox();
            this.lstNumerosMovil = new System.Windows.Forms.ListBox();
            this.lstNumerosFijos = new System.Windows.Forms.ListBox();
            this.gbNumeroTelefonosClientesProveedores = new System.Windows.Forms.GroupBox();
            this.btnActualizarNumeroClienteProveedor = new System.Windows.Forms.Button();
            this.btnCerrarActualizarNumeros = new System.Windows.Forms.Button();
            this.mskMovilClienteProveedor = new System.Windows.Forms.MaskedTextBox();
            this.lblMovil = new System.Windows.Forms.Label();
            this.lblFijo = new System.Windows.Forms.Label();
            this.mskFijoClienteProveedor = new System.Windows.Forms.MaskedTextBox();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.epValidarNumeros = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLinea = new System.Windows.Forms.Label();
            this.gbActualizarNumerosTelefonoClientesProveedores.SuspendLayout();
            this.gbNumeroTelefonosClientesProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActualizarNumerosTelefonoClientesProveedores
            // 
            this.gbActualizarNumerosTelefonoClientesProveedores.BackColor = System.Drawing.Color.Transparent;
            this.gbActualizarNumerosTelefonoClientesProveedores.Controls.Add(this.lstNumerosMovil);
            this.gbActualizarNumerosTelefonoClientesProveedores.Controls.Add(this.lstNumerosFijos);
            this.gbActualizarNumerosTelefonoClientesProveedores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizarNumerosTelefonoClientesProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbActualizarNumerosTelefonoClientesProveedores.Location = new System.Drawing.Point(12, 32);
            this.gbActualizarNumerosTelefonoClientesProveedores.Name = "gbActualizarNumerosTelefonoClientesProveedores";
            this.gbActualizarNumerosTelefonoClientesProveedores.Size = new System.Drawing.Size(304, 288);
            this.gbActualizarNumerosTelefonoClientesProveedores.TabIndex = 2;
            this.gbActualizarNumerosTelefonoClientesProveedores.TabStop = false;
            this.gbActualizarNumerosTelefonoClientesProveedores.Text = "Actualizar números de teléfono";
            // 
            // lstNumerosMovil
            // 
            this.lstNumerosMovil.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstNumerosMovil.FormattingEnabled = true;
            this.lstNumerosMovil.ItemHeight = 18;
            this.lstNumerosMovil.Location = new System.Drawing.Point(6, 162);
            this.lstNumerosMovil.Name = "lstNumerosMovil";
            this.lstNumerosMovil.Size = new System.Drawing.Size(292, 112);
            this.lstNumerosMovil.TabIndex = 1;
            this.lstNumerosMovil.SelectedIndexChanged += new System.EventHandler(this.lstNumerosMovil_SelectedIndexChanged);
            // 
            // lstNumerosFijos
            // 
            this.lstNumerosFijos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstNumerosFijos.FormattingEnabled = true;
            this.lstNumerosFijos.ItemHeight = 18;
            this.lstNumerosFijos.Location = new System.Drawing.Point(6, 38);
            this.lstNumerosFijos.Name = "lstNumerosFijos";
            this.lstNumerosFijos.Size = new System.Drawing.Size(292, 112);
            this.lstNumerosFijos.TabIndex = 0;
            this.lstNumerosFijos.SelectedIndexChanged += new System.EventHandler(this.lstNumerosFijos_SelectedIndexChanged);
            // 
            // gbNumeroTelefonosClientesProveedores
            // 
            this.gbNumeroTelefonosClientesProveedores.BackColor = System.Drawing.Color.Transparent;
            this.gbNumeroTelefonosClientesProveedores.Controls.Add(this.btnActualizarNumeroClienteProveedor);
            this.gbNumeroTelefonosClientesProveedores.Controls.Add(this.btnCerrarActualizarNumeros);
            this.gbNumeroTelefonosClientesProveedores.Controls.Add(this.mskMovilClienteProveedor);
            this.gbNumeroTelefonosClientesProveedores.Controls.Add(this.lblMovil);
            this.gbNumeroTelefonosClientesProveedores.Controls.Add(this.lblFijo);
            this.gbNumeroTelefonosClientesProveedores.Controls.Add(this.mskFijoClienteProveedor);
            this.gbNumeroTelefonosClientesProveedores.Controls.Add(this.lblSeparacion);
            this.gbNumeroTelefonosClientesProveedores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumeroTelefonosClientesProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbNumeroTelefonosClientesProveedores.Location = new System.Drawing.Point(322, 32);
            this.gbNumeroTelefonosClientesProveedores.Name = "gbNumeroTelefonosClientesProveedores";
            this.gbNumeroTelefonosClientesProveedores.Size = new System.Drawing.Size(304, 288);
            this.gbNumeroTelefonosClientesProveedores.TabIndex = 3;
            this.gbNumeroTelefonosClientesProveedores.TabStop = false;
            this.gbNumeroTelefonosClientesProveedores.Text = "Teléfonos";
            this.gbNumeroTelefonosClientesProveedores.Enter += new System.EventHandler(this.gbNumeroTelefonosClientesProveedores_Enter);
            // 
            // btnActualizarNumeroClienteProveedor
            // 
            this.btnActualizarNumeroClienteProveedor.BackColor = System.Drawing.Color.White;
            this.btnActualizarNumeroClienteProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarNumeroClienteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarNumeroClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarNumeroClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarNumeroClienteProveedor.Location = new System.Drawing.Point(31, 246);
            this.btnActualizarNumeroClienteProveedor.Name = "btnActualizarNumeroClienteProveedor";
            this.btnActualizarNumeroClienteProveedor.Size = new System.Drawing.Size(108, 28);
            this.btnActualizarNumeroClienteProveedor.TabIndex = 2;
            this.btnActualizarNumeroClienteProveedor.Text = "&Actualizar";
            this.btnActualizarNumeroClienteProveedor.UseVisualStyleBackColor = false;
            this.btnActualizarNumeroClienteProveedor.Click += new System.EventHandler(this.btnActualizarNumeroClienteProveedor_Click);
            // 
            // btnCerrarActualizarNumeros
            // 
            this.btnCerrarActualizarNumeros.BackColor = System.Drawing.Color.White;
            this.btnCerrarActualizarNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarActualizarNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarActualizarNumeros.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarActualizarNumeros.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarActualizarNumeros.Location = new System.Drawing.Point(165, 246);
            this.btnCerrarActualizarNumeros.Name = "btnCerrarActualizarNumeros";
            this.btnCerrarActualizarNumeros.Size = new System.Drawing.Size(108, 28);
            this.btnCerrarActualizarNumeros.TabIndex = 3;
            this.btnCerrarActualizarNumeros.Text = "&Cerrar";
            this.btnCerrarActualizarNumeros.UseVisualStyleBackColor = false;
            this.btnCerrarActualizarNumeros.Click += new System.EventHandler(this.btnCerrarActualizarNumeros_Click);
            // 
            // mskMovilClienteProveedor
            // 
            this.mskMovilClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskMovilClienteProveedor.Location = new System.Drawing.Point(94, 130);
            this.mskMovilClienteProveedor.Mask = "0000-0000";
            this.mskMovilClienteProveedor.Name = "mskMovilClienteProveedor";
            this.mskMovilClienteProveedor.Size = new System.Drawing.Size(197, 27);
            this.mskMovilClienteProveedor.TabIndex = 1;
            this.mskMovilClienteProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskMovilClienteProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskMovilClienteProveedor_KeyPress);
            this.mskMovilClienteProveedor.Leave += new System.EventHandler(this.mskMovilClienteProveedor_Leave);
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.Location = new System.Drawing.Point(16, 133);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(57, 18);
            this.lblMovil.TabIndex = 28;
            this.lblMovil.Text = "Móvil:";
            // 
            // lblFijo
            // 
            this.lblFijo.AutoSize = true;
            this.lblFijo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFijo.Location = new System.Drawing.Point(16, 78);
            this.lblFijo.Name = "lblFijo";
            this.lblFijo.Size = new System.Drawing.Size(45, 18);
            this.lblFijo.TabIndex = 26;
            this.lblFijo.Text = "Fijo:";
            // 
            // mskFijoClienteProveedor
            // 
            this.mskFijoClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskFijoClienteProveedor.Location = new System.Drawing.Point(94, 73);
            this.mskFijoClienteProveedor.Mask = "0000-0000";
            this.mskFijoClienteProveedor.Name = "mskFijoClienteProveedor";
            this.mskFijoClienteProveedor.Size = new System.Drawing.Size(197, 27);
            this.mskFijoClienteProveedor.TabIndex = 0;
            this.mskFijoClienteProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFijoClienteProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskFijoClienteProveedor_KeyPress);
            this.mskFijoClienteProveedor.Leave += new System.EventHandler(this.mskFijoClienteProveedor_Leave);
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparacion.ForeColor = System.Drawing.Color.Silver;
            this.lblSeparacion.Location = new System.Drawing.Point(-13, 218);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(358, 18);
            this.lblSeparacion.TabIndex = 54;
            this.lblSeparacion.Text = "___________________________________";
            // 
            // epValidarNumeros
            // 
            this.epValidarNumeros.ContainerControl = this;
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-105, 0);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 58;
            // 
            // frmActualizarTelefonosClientesProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbActualizarNumerosTelefonoClientesProveedores);
            this.Controls.Add(this.gbNumeroTelefonosClientesProveedores);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmActualizarTelefonosClientesProveedores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActualizarTelefonosClientesProveedores";
            this.Load += new System.EventHandler(this.frmActualizarTelefonosClientesProveedores_Load);
            this.gbActualizarNumerosTelefonoClientesProveedores.ResumeLayout(false);
            this.gbNumeroTelefonosClientesProveedores.ResumeLayout(false);
            this.gbNumeroTelefonosClientesProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActualizarNumerosTelefonoClientesProveedores;
        private System.Windows.Forms.ListBox lstNumerosMovil;
        private System.Windows.Forms.ListBox lstNumerosFijos;
        private System.Windows.Forms.GroupBox gbNumeroTelefonosClientesProveedores;
        private System.Windows.Forms.Button btnActualizarNumeroClienteProveedor;
        private System.Windows.Forms.Button btnCerrarActualizarNumeros;
        private System.Windows.Forms.MaskedTextBox mskMovilClienteProveedor;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.Label lblFijo;
        private System.Windows.Forms.MaskedTextBox mskFijoClienteProveedor;
        private System.Windows.Forms.Label lblSeparacion;
        private System.Windows.Forms.ErrorProvider epValidarNumeros;
        private System.Windows.Forms.Label lblLinea;

    }
}