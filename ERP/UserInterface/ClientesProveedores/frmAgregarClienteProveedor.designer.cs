namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmAgregarClienteProveedor
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
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblAgregarClientesProveedores = new System.Windows.Forms.Label();
            this.gbInsertarClientesProveedores = new System.Windows.Forms.GroupBox();
            this.mskRTN = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarTelefonos = new System.Windows.Forms.Button();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblDireccionClienteProveedor = new System.Windows.Forms.Label();
            this.btnAgregarClienteProveedor = new System.Windows.Forms.Button();
            this.txtDireccionClienteProveedor = new System.Windows.Forms.TextBox();
            this.btnSalirAgregarClienteProveedor = new System.Windows.Forms.Button();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtApellidosClienteProveedor = new System.Windows.Forms.TextBox();
            this.txtNombresProveedor = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblApellidosClienteProveedor = new System.Windows.Forms.Label();
            this.lblNombresClienteProveedor = new System.Windows.Forms.Label();
            this.lblRTN = new System.Windows.Forms.Label();
            this.epValidarTexto = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInsertarClientesProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-23, 71);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 26;
            // 
            // lblAgregarClientesProveedores
            // 
            this.lblAgregarClientesProveedores.AutoSize = true;
            this.lblAgregarClientesProveedores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarClientesProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAgregarClientesProveedores.Location = new System.Drawing.Point(266, 44);
            this.lblAgregarClientesProveedores.Name = "lblAgregarClientesProveedores";
            this.lblAgregarClientesProveedores.Size = new System.Drawing.Size(348, 18);
            this.lblAgregarClientesProveedores.TabIndex = 27;
            this.lblAgregarClientesProveedores.Text = "Agregar Nuevos Clientes/Proveedores";
            // 
            // gbInsertarClientesProveedores
            // 
            this.gbInsertarClientesProveedores.Controls.Add(this.mskRTN);
            this.gbInsertarClientesProveedores.Controls.Add(this.btnAgregarTelefonos);
            this.gbInsertarClientesProveedores.Controls.Add(this.cbTipoUsuario);
            this.gbInsertarClientesProveedores.Controls.Add(this.lblTipoUsuario);
            this.gbInsertarClientesProveedores.Controls.Add(this.lblDireccionClienteProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.btnAgregarClienteProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.txtDireccionClienteProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.btnSalirAgregarClienteProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.txtCorreoElectronico);
            this.gbInsertarClientesProveedores.Controls.Add(this.txtApellidosClienteProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.txtNombresProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.lblCorreoElectronico);
            this.gbInsertarClientesProveedores.Controls.Add(this.lblApellidosClienteProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.lblNombresClienteProveedor);
            this.gbInsertarClientesProveedores.Controls.Add(this.lblRTN);
            this.gbInsertarClientesProveedores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsertarClientesProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInsertarClientesProveedores.Location = new System.Drawing.Point(12, 117);
            this.gbInsertarClientesProveedores.Name = "gbInsertarClientesProveedores";
            this.gbInsertarClientesProveedores.Size = new System.Drawing.Size(857, 312);
            this.gbInsertarClientesProveedores.TabIndex = 28;
            this.gbInsertarClientesProveedores.TabStop = false;
            this.gbInsertarClientesProveedores.Text = "DATOS DEL CLIENTE/PROVEEDOR";
            // 
            // mskRTN
            // 
            this.mskRTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskRTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRTN.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskRTN.Location = new System.Drawing.Point(204, 58);
            this.mskRTN.Mask = "##############";
            this.mskRTN.Name = "mskRTN";
            this.mskRTN.Size = new System.Drawing.Size(203, 27);
            this.mskRTN.TabIndex = 1;
            this.mskRTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskRTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRTN_KeyPress);
            this.mskRTN.Leave += new System.EventHandler(this.mskRTN_Leave);
            // 
            // btnAgregarTelefonos
            // 
            this.btnAgregarTelefonos.BackColor = System.Drawing.Color.White;
            this.btnAgregarTelefonos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTelefonos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefonos.Location = new System.Drawing.Point(585, 174);
            this.btnAgregarTelefonos.Name = "btnAgregarTelefonos";
            this.btnAgregarTelefonos.Size = new System.Drawing.Size(244, 29);
            this.btnAgregarTelefonos.TabIndex = 24;
            this.btnAgregarTelefonos.Text = "Agregar Teléfonos";
            this.btnAgregarTelefonos.UseVisualStyleBackColor = false;
            this.btnAgregarTelefonos.Visible = false;
            this.btnAgregarTelefonos.Click += new System.EventHandler(this.btnAgregarTelefonos_Click);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.BackColor = System.Drawing.Color.White;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Cliente",
            "Proveedor"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(585, 135);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(244, 26);
            this.cbTipoUsuario.TabIndex = 6;
            this.cbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbTipoUsuario_SelectedIndexChanged);
            this.cbTipoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipoUsuario_KeyPress);
            this.cbTipoUsuario.Leave += new System.EventHandler(this.cbTipoUsuario_Leave);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(434, 138);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(116, 18);
            this.lblTipoUsuario.TabIndex = 18;
            this.lblTipoUsuario.Text = "Tipo usuario:";
            this.lblTipoUsuario.Click += new System.EventHandler(this.lblTipoUsuario_Click);
            // 
            // lblDireccionClienteProveedor
            // 
            this.lblDireccionClienteProveedor.AutoSize = true;
            this.lblDireccionClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionClienteProveedor.Location = new System.Drawing.Point(434, 60);
            this.lblDireccionClienteProveedor.Name = "lblDireccionClienteProveedor";
            this.lblDireccionClienteProveedor.Size = new System.Drawing.Size(89, 18);
            this.lblDireccionClienteProveedor.TabIndex = 17;
            this.lblDireccionClienteProveedor.Text = "Dirección:";
            // 
            // btnAgregarClienteProveedor
            // 
            this.btnAgregarClienteProveedor.BackColor = System.Drawing.Color.White;
            this.btnAgregarClienteProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarClienteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarClienteProveedor.Location = new System.Drawing.Point(455, 244);
            this.btnAgregarClienteProveedor.Name = "btnAgregarClienteProveedor";
            this.btnAgregarClienteProveedor.Size = new System.Drawing.Size(114, 37);
            this.btnAgregarClienteProveedor.TabIndex = 8;
            this.btnAgregarClienteProveedor.Text = "&Agregar";
            this.btnAgregarClienteProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarClienteProveedor.Click += new System.EventHandler(this.btnAgregarClienteProveedor_Click);
            // 
            // txtDireccionClienteProveedor
            // 
            this.txtDireccionClienteProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDireccionClienteProveedor.Location = new System.Drawing.Point(585, 58);
            this.txtDireccionClienteProveedor.Multiline = true;
            this.txtDireccionClienteProveedor.Name = "txtDireccionClienteProveedor";
            this.txtDireccionClienteProveedor.Size = new System.Drawing.Size(244, 66);
            this.txtDireccionClienteProveedor.TabIndex = 5;
            this.txtDireccionClienteProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccionClienteProveedor.Leave += new System.EventHandler(this.txtDireccionClienteProveedor_Leave);
            // 
            // btnSalirAgregarClienteProveedor
            // 
            this.btnSalirAgregarClienteProveedor.BackColor = System.Drawing.Color.White;
            this.btnSalirAgregarClienteProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirAgregarClienteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAgregarClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAgregarClienteProveedor.Location = new System.Drawing.Point(288, 244);
            this.btnSalirAgregarClienteProveedor.Name = "btnSalirAgregarClienteProveedor";
            this.btnSalirAgregarClienteProveedor.Size = new System.Drawing.Size(114, 37);
            this.btnSalirAgregarClienteProveedor.TabIndex = 9;
            this.btnSalirAgregarClienteProveedor.Text = "&Salir";
            this.btnSalirAgregarClienteProveedor.UseVisualStyleBackColor = false;
            this.btnSalirAgregarClienteProveedor.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(204, 177);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(203, 27);
            this.txtCorreoElectronico.TabIndex = 4;
            this.txtCorreoElectronico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCorreoElectronico.Leave += new System.EventHandler(this.txtCorreoElectronico_Leave);
            // 
            // txtApellidosClienteProveedor
            // 
            this.txtApellidosClienteProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidosClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtApellidosClienteProveedor.Location = new System.Drawing.Point(204, 136);
            this.txtApellidosClienteProveedor.Name = "txtApellidosClienteProveedor";
            this.txtApellidosClienteProveedor.Size = new System.Drawing.Size(203, 27);
            this.txtApellidosClienteProveedor.TabIndex = 3;
            this.txtApellidosClienteProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellidosClienteProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidosClienteProveedor_KeyPress);
            this.txtApellidosClienteProveedor.Leave += new System.EventHandler(this.txtApellidosClienteProveedor_Leave);
            // 
            // txtNombresProveedor
            // 
            this.txtNombresProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombresProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombresProveedor.Location = new System.Drawing.Point(204, 97);
            this.txtNombresProveedor.Name = "txtNombresProveedor";
            this.txtNombresProveedor.Size = new System.Drawing.Size(203, 27);
            this.txtNombresProveedor.TabIndex = 2;
            this.txtNombresProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombresProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombresProveedor_KeyPress);
            this.txtNombresProveedor.Leave += new System.EventHandler(this.txtNombresProveedor_Leave);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(27, 179);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(163, 18);
            this.lblCorreoElectronico.TabIndex = 3;
            this.lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // lblApellidosClienteProveedor
            // 
            this.lblApellidosClienteProveedor.AutoSize = true;
            this.lblApellidosClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosClienteProveedor.Location = new System.Drawing.Point(27, 138);
            this.lblApellidosClienteProveedor.Name = "lblApellidosClienteProveedor";
            this.lblApellidosClienteProveedor.Size = new System.Drawing.Size(90, 18);
            this.lblApellidosClienteProveedor.TabIndex = 2;
            this.lblApellidosClienteProveedor.Text = "Apellidos:";
            // 
            // lblNombresClienteProveedor
            // 
            this.lblNombresClienteProveedor.AutoSize = true;
            this.lblNombresClienteProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresClienteProveedor.Location = new System.Drawing.Point(27, 99);
            this.lblNombresClienteProveedor.Name = "lblNombresClienteProveedor";
            this.lblNombresClienteProveedor.Size = new System.Drawing.Size(87, 18);
            this.lblNombresClienteProveedor.TabIndex = 1;
            this.lblNombresClienteProveedor.Text = "Nombres:";
            // 
            // lblRTN
            // 
            this.lblRTN.AutoSize = true;
            this.lblRTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTN.Location = new System.Drawing.Point(27, 60);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(48, 18);
            this.lblRTN.TabIndex = 0;
            this.lblRTN.Text = "RTN:";
            // 
            // epValidarTexto
            // 
            this.epValidarTexto.ContainerControl = this;
            // 
            // frmAgregarClienteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 441);
            this.Controls.Add(this.gbInsertarClientesProveedores);
            this.Controls.Add(this.lblAgregarClientesProveedores);
            this.Controls.Add(this.lblLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarClienteProveedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInsertarClienteProveedor";
            this.Load += new System.EventHandler(this.frmAgregarClienteProveedor_Load);
            this.gbInsertarClientesProveedores.ResumeLayout(false);
            this.gbInsertarClientesProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblAgregarClientesProveedores;
        private System.Windows.Forms.GroupBox gbInsertarClientesProveedores;
        private System.Windows.Forms.Label lblRTN;
        private System.Windows.Forms.Label lblNombresClienteProveedor;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblApellidosClienteProveedor;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtApellidosClienteProveedor;
        private System.Windows.Forms.TextBox txtNombresProveedor;
        private System.Windows.Forms.TextBox txtDireccionClienteProveedor;
        private System.Windows.Forms.Button btnSalirAgregarClienteProveedor;
        private System.Windows.Forms.Button btnAgregarClienteProveedor;
        private System.Windows.Forms.Label lblDireccionClienteProveedor;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnAgregarTelefonos;
        private System.Windows.Forms.MaskedTextBox mskRTN;
        private System.Windows.Forms.ErrorProvider epValidarTexto;
    }
}