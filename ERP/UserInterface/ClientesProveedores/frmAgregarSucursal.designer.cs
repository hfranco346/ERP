namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmAgregarSucursal
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
            this.lblAgregarSucursal = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.gbInsertarSucursal = new System.Windows.Forms.GroupBox();
            this.cbIdProveedor = new System.Windows.Forms.ComboBox();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.btnSalirAgregarSucursal = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDirecciónSucursal = new System.Windows.Forms.Label();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.epValidarTexto = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInsertarSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarSucursal
            // 
            this.lblAgregarSucursal.AutoSize = true;
            this.lblAgregarSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarSucursal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAgregarSucursal.Location = new System.Drawing.Point(320, 44);
            this.lblAgregarSucursal.Name = "lblAgregarSucursal";
            this.lblAgregarSucursal.Size = new System.Drawing.Size(220, 18);
            this.lblAgregarSucursal.TabIndex = 28;
            this.lblAgregarSucursal.Text = "Agregar Nueva Sucursal";
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-23, 71);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 29;
            // 
            // gbInsertarSucursal
            // 
            this.gbInsertarSucursal.Controls.Add(this.cbIdProveedor);
            this.gbInsertarSucursal.Controls.Add(this.lblIdProveedor);
            this.gbInsertarSucursal.Controls.Add(this.btnAgregarSucursal);
            this.gbInsertarSucursal.Controls.Add(this.btnSalirAgregarSucursal);
            this.gbInsertarSucursal.Controls.Add(this.txtDireccion);
            this.gbInsertarSucursal.Controls.Add(this.txtNombre);
            this.gbInsertarSucursal.Controls.Add(this.lblDirecciónSucursal);
            this.gbInsertarSucursal.Controls.Add(this.lblNombreSucursal);
            this.gbInsertarSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsertarSucursal.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInsertarSucursal.Location = new System.Drawing.Point(12, 117);
            this.gbInsertarSucursal.Name = "gbInsertarSucursal";
            this.gbInsertarSucursal.Size = new System.Drawing.Size(857, 312);
            this.gbInsertarSucursal.TabIndex = 28;
            this.gbInsertarSucursal.TabStop = false;
            this.gbInsertarSucursal.Text = "DATOS DE SUCURSAL";
            this.gbInsertarSucursal.Enter += new System.EventHandler(this.gbInsertarSucursal_Enter);
            // 
            // cbIdProveedor
            // 
            this.cbIdProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbIdProveedor.FormattingEnabled = true;
            this.cbIdProveedor.Location = new System.Drawing.Point(330, 201);
            this.cbIdProveedor.Name = "cbIdProveedor";
            this.cbIdProveedor.Size = new System.Drawing.Size(300, 26);
            this.cbIdProveedor.TabIndex = 34;
            this.cbIdProveedor.SelectedIndexChanged += new System.EventHandler(this.cbIdProveedor_SelectedIndexChanged);
            this.cbIdProveedor.Click += new System.EventHandler(this.cbIdProveedor_Click);
            this.cbIdProveedor.Leave += new System.EventHandler(this.cbIdProveedor_Leave);
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.Location = new System.Drawing.Point(202, 204);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(96, 18);
            this.lblIdProveedor.TabIndex = 36;
            this.lblIdProveedor.Text = "Proveedor:";
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.BackColor = System.Drawing.Color.White;
            this.btnAgregarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSucursal.Location = new System.Drawing.Point(330, 258);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(114, 37);
            this.btnAgregarSucursal.TabIndex = 35;
            this.btnAgregarSucursal.Text = "&Agregar";
            this.btnAgregarSucursal.UseVisualStyleBackColor = false;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // btnSalirAgregarSucursal
            // 
            this.btnSalirAgregarSucursal.BackColor = System.Drawing.Color.White;
            this.btnSalirAgregarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirAgregarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAgregarSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAgregarSucursal.Location = new System.Drawing.Point(516, 258);
            this.btnSalirAgregarSucursal.Name = "btnSalirAgregarSucursal";
            this.btnSalirAgregarSucursal.Size = new System.Drawing.Size(114, 37);
            this.btnSalirAgregarSucursal.TabIndex = 34;
            this.btnSalirAgregarSucursal.Text = "&Cerrar";
            this.btnSalirAgregarSucursal.UseVisualStyleBackColor = false;
            this.btnSalirAgregarSucursal.Click += new System.EventHandler(this.btnSalirAgregarSucursal_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDireccion.Location = new System.Drawing.Point(330, 93);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(300, 81);
            this.txtDireccion.TabIndex = 33;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombre.Location = new System.Drawing.Point(330, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 27);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblDirecciónSucursal
            // 
            this.lblDirecciónSucursal.AutoSize = true;
            this.lblDirecciónSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecciónSucursal.Location = new System.Drawing.Point(202, 123);
            this.lblDirecciónSucursal.Name = "lblDirecciónSucursal";
            this.lblDirecciónSucursal.Size = new System.Drawing.Size(89, 18);
            this.lblDirecciónSucursal.TabIndex = 31;
            this.lblDirecciónSucursal.Text = "Dirección:";
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSucursal.Location = new System.Drawing.Point(202, 42);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(78, 18);
            this.lblNombreSucursal.TabIndex = 30;
            this.lblNombreSucursal.Text = "Nombre:";
            // 
            // epValidarTexto
            // 
            this.epValidarTexto.ContainerControl = this;
            // 
            // frmAgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 441);
            this.Controls.Add(this.gbInsertarSucursal);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblAgregarSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarSucursal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarSucursal";
            this.Load += new System.EventHandler(this.frmAgregarSucursal_Load);
            this.gbInsertarSucursal.ResumeLayout(false);
            this.gbInsertarSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarSucursal;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox gbInsertarSucursal;
        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.Label lblDirecciónSucursal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnSalirAgregarSucursal;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.ComboBox cbIdProveedor;
        private System.Windows.Forms.ErrorProvider epValidarTexto;
    }
}