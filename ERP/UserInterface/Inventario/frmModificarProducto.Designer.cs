namespace ERP.UserInterface.Inventario
{
    partial class frmModificarProducto
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
            this.gbModificarProducto = new System.Windows.Forms.GroupBox();
            this.dtpFechaElabProducto = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencProducto = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblTituloModificarProducto = new System.Windows.Forms.Label();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbModificarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-10, 72);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 30;
            // 
            // gbModificarProducto
            // 
            this.gbModificarProducto.Controls.Add(this.dtpFechaElabProducto);
            this.gbModificarProducto.Controls.Add(this.dtpFechaVencProducto);
            this.gbModificarProducto.Controls.Add(this.txtObservaciones);
            this.gbModificarProducto.Controls.Add(this.lblObservaciones);
            this.gbModificarProducto.Controls.Add(this.txtCantidad);
            this.gbModificarProducto.Controls.Add(this.lblCantidad);
            this.gbModificarProducto.Controls.Add(this.lstProductos);
            this.gbModificarProducto.Controls.Add(this.lblFechaVencimientoProducto);
            this.gbModificarProducto.Controls.Add(this.lblFechaElaboracionProducto);
            this.gbModificarProducto.Controls.Add(this.txtPuntoReorden);
            this.gbModificarProducto.Controls.Add(this.lblPuntoReorden);
            this.gbModificarProducto.Controls.Add(this.txtPrecioVenta);
            this.gbModificarProducto.Controls.Add(this.lblPrecioVenta);
            this.gbModificarProducto.Controls.Add(this.txtPrecioCompra);
            this.gbModificarProducto.Controls.Add(this.lblPrecioCompra);
            this.gbModificarProducto.Controls.Add(this.txtDescripcion);
            this.gbModificarProducto.Controls.Add(this.lblDescripcionProducto);
            this.gbModificarProducto.Controls.Add(this.txtCodigoProducto);
            this.gbModificarProducto.Controls.Add(this.lblCodigoBarraProducto);
            this.gbModificarProducto.Controls.Add(this.btnModificar);
            this.gbModificarProducto.Controls.Add(this.btnCerrar);
            this.gbModificarProducto.Controls.Add(this.txtNombreProducto);
            this.gbModificarProducto.Controls.Add(this.lblNombreProducto);
            this.gbModificarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModificarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbModificarProducto.Location = new System.Drawing.Point(12, 116);
            this.gbModificarProducto.Name = "gbModificarProducto";
            this.gbModificarProducto.Size = new System.Drawing.Size(857, 536);
            this.gbModificarProducto.TabIndex = 31;
            this.gbModificarProducto.TabStop = false;
            this.gbModificarProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // dtpFechaElabProducto
            // 
            this.dtpFechaElabProducto.CalendarFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaElabProducto.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.dtpFechaElabProducto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaElabProducto.Location = new System.Drawing.Point(626, 311);
            this.dtpFechaElabProducto.Name = "dtpFechaElabProducto";
            this.dtpFechaElabProducto.Size = new System.Drawing.Size(203, 26);
            this.dtpFechaElabProducto.TabIndex = 54;
            this.dtpFechaElabProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaElabProducto_KeyPress);
            // 
            // dtpFechaVencProducto
            // 
            this.dtpFechaVencProducto.CalendarFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencProducto.CalendarForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaVencProducto.CalendarTitleForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaVencProducto.CalendarTrailingForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaVencProducto.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.dtpFechaVencProducto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencProducto.Location = new System.Drawing.Point(626, 353);
            this.dtpFechaVencProducto.Name = "dtpFechaVencProducto";
            this.dtpFechaVencProducto.Size = new System.Drawing.Size(203, 26);
            this.dtpFechaVencProducto.TabIndex = 53;
            this.dtpFechaVencProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaVencProducto_KeyPress);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtObservaciones.Location = new System.Drawing.Point(626, 394);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(203, 44);
            this.txtObservaciones.TabIndex = 51;
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(428, 394);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 18);
            this.lblObservaciones.TabIndex = 52;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCantidad.Location = new System.Drawing.Point(626, 269);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(203, 24);
            this.txtCantidad.TabIndex = 49;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(428, 271);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(88, 18);
            this.lblCantidad.TabIndex = 50;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lstProductos
            // 
            this.lstProductos.BackColor = System.Drawing.Color.SteelBlue;
            this.lstProductos.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.lstProductos.ForeColor = System.Drawing.Color.White;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 19;
            this.lstProductos.Location = new System.Drawing.Point(18, 26);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.ScrollAlwaysVisible = true;
            this.lstProductos.Size = new System.Drawing.Size(366, 403);
            this.lstProductos.TabIndex = 0;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // lblFechaVencimientoProducto
            // 
            this.lblFechaVencimientoProducto.AutoSize = true;
            this.lblFechaVencimientoProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimientoProducto.Location = new System.Drawing.Point(428, 359);
            this.lblFechaVencimientoProducto.Name = "lblFechaVencimientoProducto";
            this.lblFechaVencimientoProducto.Size = new System.Drawing.Size(189, 18);
            this.lblFechaVencimientoProducto.TabIndex = 39;
            this.lblFechaVencimientoProducto.Text = "Fecha Venc. Producto:";
            // 
            // lblFechaElaboracionProducto
            // 
            this.lblFechaElaboracionProducto.AutoSize = true;
            this.lblFechaElaboracionProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaElaboracionProducto.Location = new System.Drawing.Point(428, 317);
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
            this.txtPuntoReorden.Location = new System.Drawing.Point(626, 229);
            this.txtPuntoReorden.Name = "txtPuntoReorden";
            this.txtPuntoReorden.Size = new System.Drawing.Size(203, 24);
            this.txtPuntoReorden.TabIndex = 6;
            this.txtPuntoReorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPuntoReorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoReorden_KeyPress);
            // 
            // lblPuntoReorden
            // 
            this.lblPuntoReorden.AutoSize = true;
            this.lblPuntoReorden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoReorden.Location = new System.Drawing.Point(428, 231);
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
            this.txtPrecioVenta.Location = new System.Drawing.Point(626, 187);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(203, 24);
            this.txtPrecioVenta.TabIndex = 5;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(428, 189);
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
            this.txtPrecioCompra.Location = new System.Drawing.Point(626, 145);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(203, 24);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(428, 147);
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
            this.txtDescripcion.Location = new System.Drawing.Point(626, 105);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(203, 24);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(428, 107);
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
            this.txtCodigoProducto.Location = new System.Drawing.Point(626, 24);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(203, 24);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // lblCodigoBarraProducto
            // 
            this.lblCodigoBarraProducto.AutoSize = true;
            this.lblCodigoBarraProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarraProducto.Location = new System.Drawing.Point(428, 26);
            this.lblCodigoBarraProducto.Name = "lblCodigoBarraProducto";
            this.lblCodigoBarraProducto.Size = new System.Drawing.Size(148, 18);
            this.lblCodigoBarraProducto.TabIndex = 25;
            this.lblCodigoBarraProducto.Text = "Código Producto:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.Location = new System.Drawing.Point(272, 472);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 37);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(441, 472);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombreProducto.Location = new System.Drawing.Point(626, 63);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(203, 24);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(426, 65);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(155, 18);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre Producto:";
            // 
            // lblTituloModificarProducto
            // 
            this.lblTituloModificarProducto.AutoSize = true;
            this.lblTituloModificarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloModificarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloModificarProducto.Location = new System.Drawing.Point(354, 43);
            this.lblTituloModificarProducto.Name = "lblTituloModificarProducto";
            this.lblTituloModificarProducto.Size = new System.Drawing.Size(173, 18);
            this.lblTituloModificarProducto.TabIndex = 32;
            this.lblTituloModificarProducto.Text = "Modificar Producto";
            // 
            // epValidarTextos
            // 
            this.epValidarTextos.ContainerControl = this;
            // 
            // frmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 664);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbModificarProducto);
            this.Controls.Add(this.lblTituloModificarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarProducto";
            this.Load += new System.EventHandler(this.frmModificarProducto_Load);
            this.gbModificarProducto.ResumeLayout(false);
            this.gbModificarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox gbModificarProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaElabProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaVencProducto;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListBox lstProductos;
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblTituloModificarProducto;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
    }
}