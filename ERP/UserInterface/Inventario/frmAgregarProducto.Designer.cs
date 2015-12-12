namespace ERP.UserInterface.Inventario
{
    partial class frmAgregarProducto
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
            this.lblTituloAgregarProducto = new System.Windows.Forms.Label();
            this.gbAgregarProducto = new System.Windows.Forms.GroupBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.dtpFechaVencProducto = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaElabProducto = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimientoProducto = new System.Windows.Forms.Label();
            this.lblFechaElaboracionProducto = new System.Windows.Forms.Label();
            this.txtPuntoReorden = new System.Windows.Forms.TextBox();
            this.lblPuntoReorden = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoBarraProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-12, 76);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 28;
            // 
            // lblTituloAgregarProducto
            // 
            this.lblTituloAgregarProducto.AutoSize = true;
            this.lblTituloAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloAgregarProducto.Location = new System.Drawing.Point(327, 47);
            this.lblTituloAgregarProducto.Name = "lblTituloAgregarProducto";
            this.lblTituloAgregarProducto.Size = new System.Drawing.Size(226, 18);
            this.lblTituloAgregarProducto.TabIndex = 27;
            this.lblTituloAgregarProducto.Text = "Agregar Nuevo Producto";
            // 
            // gbAgregarProducto
            // 
            this.gbAgregarProducto.Controls.Add(this.cbProveedor);
            this.gbAgregarProducto.Controls.Add(this.lblProveedor);
            this.gbAgregarProducto.Controls.Add(this.txtCantidadProducto);
            this.gbAgregarProducto.Controls.Add(this.lblCantidadProducto);
            this.gbAgregarProducto.Controls.Add(this.dtpFechaVencProducto);
            this.gbAgregarProducto.Controls.Add(this.dtpFechaElabProducto);
            this.gbAgregarProducto.Controls.Add(this.lblFechaVencimientoProducto);
            this.gbAgregarProducto.Controls.Add(this.lblFechaElaboracionProducto);
            this.gbAgregarProducto.Controls.Add(this.txtPuntoReorden);
            this.gbAgregarProducto.Controls.Add(this.lblPuntoReorden);
            this.gbAgregarProducto.Controls.Add(this.txtPrecioVenta);
            this.gbAgregarProducto.Controls.Add(this.lblPrecioVenta);
            this.gbAgregarProducto.Controls.Add(this.txtPrecioCompra);
            this.gbAgregarProducto.Controls.Add(this.lblPrecioCompra);
            this.gbAgregarProducto.Controls.Add(this.txtDescripcion);
            this.gbAgregarProducto.Controls.Add(this.lblDescripcionProducto);
            this.gbAgregarProducto.Controls.Add(this.txtCodigoProducto);
            this.gbAgregarProducto.Controls.Add(this.lblCodigoBarraProducto);
            this.gbAgregarProducto.Controls.Add(this.btnAgregar);
            this.gbAgregarProducto.Controls.Add(this.btnSalir);
            this.gbAgregarProducto.Controls.Add(this.txtNombreProducto);
            this.gbAgregarProducto.Controls.Add(this.lblNombreProducto);
            this.gbAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbAgregarProducto.Location = new System.Drawing.Point(12, 132);
            this.gbAgregarProducto.Name = "gbAgregarProducto";
            this.gbAgregarProducto.Size = new System.Drawing.Size(857, 359);
            this.gbAgregarProducto.TabIndex = 26;
            this.gbAgregarProducto.TabStop = false;
            this.gbAgregarProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(625, 227);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(203, 26);
            this.cbProveedor.TabIndex = 9;
            this.cbProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProveedor_KeyPress);
            this.cbProveedor.Leave += new System.EventHandler(this.cbProveedor_Leave);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(432, 230);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(96, 18);
            this.lblProveedor.TabIndex = 42;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCantidadProducto.Location = new System.Drawing.Point(198, 185);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(203, 24);
            this.txtCantidadProducto.TabIndex = 3;
            this.txtCantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProducto_KeyPress);
            this.txtCantidadProducto.Leave += new System.EventHandler(this.txtCantidadProducto_Leave);
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(27, 187);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(158, 18);
            this.lblCantidadProducto.TabIndex = 41;
            this.lblCantidadProducto.Text = "Cantidad Producto";
            // 
            // dtpFechaVencProducto
            // 
            this.dtpFechaVencProducto.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaVencProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpFechaVencProducto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencProducto.Location = new System.Drawing.Point(625, 185);
            this.dtpFechaVencProducto.Name = "dtpFechaVencProducto";
            this.dtpFechaVencProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFechaVencProducto.RightToLeftLayout = true;
            this.dtpFechaVencProducto.Size = new System.Drawing.Size(203, 24);
            this.dtpFechaVencProducto.TabIndex = 8;
            this.dtpFechaVencProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaVencProducto_KeyPress);
            // 
            // dtpFechaElabProducto
            // 
            this.dtpFechaElabProducto.CalendarForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaElabProducto.CalendarTitleForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaElabProducto.CalendarTrailingForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaElabProducto.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaElabProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpFechaElabProducto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaElabProducto.Location = new System.Drawing.Point(625, 144);
            this.dtpFechaElabProducto.Name = "dtpFechaElabProducto";
            this.dtpFechaElabProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFechaElabProducto.RightToLeftLayout = true;
            this.dtpFechaElabProducto.Size = new System.Drawing.Size(203, 24);
            this.dtpFechaElabProducto.TabIndex = 7;
            this.dtpFechaElabProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaElabProducto_KeyPress);
            // 
            // lblFechaVencimientoProducto
            // 
            this.lblFechaVencimientoProducto.AutoSize = true;
            this.lblFechaVencimientoProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimientoProducto.Location = new System.Drawing.Point(430, 188);
            this.lblFechaVencimientoProducto.Name = "lblFechaVencimientoProducto";
            this.lblFechaVencimientoProducto.Size = new System.Drawing.Size(189, 18);
            this.lblFechaVencimientoProducto.TabIndex = 39;
            this.lblFechaVencimientoProducto.Text = "Fecha Venc. Producto:";
            // 
            // lblFechaElaboracionProducto
            // 
            this.lblFechaElaboracionProducto.AutoSize = true;
            this.lblFechaElaboracionProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaElaboracionProducto.Location = new System.Drawing.Point(432, 148);
            this.lblFechaElaboracionProducto.Name = "lblFechaElaboracionProducto";
            this.lblFechaElaboracionProducto.Size = new System.Drawing.Size(179, 18);
            this.lblFechaElaboracionProducto.TabIndex = 35;
            this.lblFechaElaboracionProducto.Text = "Fecha Elab. Producto";
            // 
            // txtPuntoReorden
            // 
            this.txtPuntoReorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPuntoReorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoReorden.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPuntoReorden.Location = new System.Drawing.Point(625, 102);
            this.txtPuntoReorden.Name = "txtPuntoReorden";
            this.txtPuntoReorden.Size = new System.Drawing.Size(203, 24);
            this.txtPuntoReorden.TabIndex = 6;
            this.txtPuntoReorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoReorden_KeyPress);
            this.txtPuntoReorden.Leave += new System.EventHandler(this.txtPuntoReorden_Leave);
            // 
            // lblPuntoReorden
            // 
            this.lblPuntoReorden.AutoSize = true;
            this.lblPuntoReorden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoReorden.Location = new System.Drawing.Point(432, 108);
            this.lblPuntoReorden.Name = "lblPuntoReorden";
            this.lblPuntoReorden.Size = new System.Drawing.Size(154, 18);
            this.lblPuntoReorden.TabIndex = 33;
            this.lblPuntoReorden.Text = "Punto de Reorden";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioVenta.Location = new System.Drawing.Point(625, 62);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(203, 24);
            this.txtPrecioVenta.TabIndex = 5;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(432, 64);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(143, 18);
            this.lblPrecioVenta.TabIndex = 31;
            this.lblPrecioVenta.Text = "Precio de Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioCompra.Location = new System.Drawing.Point(198, 226);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(203, 24);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            this.txtPrecioCompra.Leave += new System.EventHandler(this.txtPrecioCompra_Leave);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(27, 230);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(158, 18);
            this.lblPrecioCompra.TabIndex = 29;
            this.lblPrecioCompra.Text = "Precio de Compra:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcion.Location = new System.Drawing.Point(198, 144);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(203, 24);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(27, 146);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(108, 18);
            this.lblDescripcionProducto.TabIndex = 27;
            this.lblDescripcionProducto.Text = "Descripción:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCodigoProducto.Location = new System.Drawing.Point(198, 58);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(203, 24);
            this.txtCodigoProducto.TabIndex = 0;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave);
            // 
            // lblCodigoBarraProducto
            // 
            this.lblCodigoBarraProducto.AutoSize = true;
            this.lblCodigoBarraProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarraProducto.Location = new System.Drawing.Point(27, 60);
            this.lblCodigoBarraProducto.Name = "lblCodigoBarraProducto";
            this.lblCodigoBarraProducto.Size = new System.Drawing.Size(148, 18);
            this.lblCodigoBarraProducto.TabIndex = 25;
            this.lblCodigoBarraProducto.Text = "Código Producto:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Location = new System.Drawing.Point(283, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 37);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAgregar_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(435, 294);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 37);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSalir_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombreProducto.Location = new System.Drawing.Point(198, 102);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(203, 24);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            this.txtNombreProducto.Leave += new System.EventHandler(this.txtNombreProducto_Leave);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(27, 104);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(155, 18);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre Producto:";
            // 
            // epValidarTextos
            // 
            this.epValidarTextos.ContainerControl = this;
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 503);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblTituloAgregarProducto);
            this.Controls.Add(this.gbAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarProducto";
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            this.gbAgregarProducto.ResumeLayout(false);
            this.gbAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTituloAgregarProducto;
        private System.Windows.Forms.GroupBox gbAgregarProducto;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaVencProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaElabProducto;
        private System.Windows.Forms.Label lblFechaVencimientoProducto;
        private System.Windows.Forms.Label lblFechaElaboracionProducto;
        private System.Windows.Forms.TextBox txtPuntoReorden;
        private System.Windows.Forms.Label lblPuntoReorden;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoBarraProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
    }
}