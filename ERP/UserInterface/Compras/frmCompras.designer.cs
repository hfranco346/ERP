namespace ERP.UserInterface.Compras
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.gvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuntoReorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaElaboracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaVencimineto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombrProveedor = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblNuevaCompra = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.gvOrdenProducto = new System.Windows.Forms.DataGridView();
            this.ColumnCodigoProductoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcionOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioCompraOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioVentaOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuntoReordenOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaElaboracionOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaVencimientoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdProductoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsGvOrdenarProducto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProductoOrdenar = new System.Windows.Forms.Label();
            this.lblListadoGeneralProducto = new System.Windows.Forms.Label();
            this.btnEmitirOrden = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblValorTotalCompra = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrdenProducto)).BeginInit();
            this.cmsGvOrdenarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.White;
            this.btnAgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(310, 66);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(40, 24);
            this.btnAgregarProveedor.TabIndex = 56;
            this.btnAgregarProveedor.Text = "...";
            this.btnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompra.Location = new System.Drawing.Point(812, 65);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCompra.TabIndex = 61;
            this.dtpFechaCompra.Visible = false;
            // 
            // gvDetalleCompra
            // 
            this.gvDetalleCompra.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvDetalleCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDetalleCompra.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNombre,
            this.ColumnDescripcion,
            this.ColumnCantidad,
            this.ColumnPrecioCompra,
            this.ColumnVenta,
            this.ColumnPuntoReorden,
            this.ColumnFechaElaboracion,
            this.ColumnFechaVencimineto,
            this.ColumnIdProducto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDetalleCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDetalleCompra.Location = new System.Drawing.Point(12, 138);
            this.gvDetalleCompra.Name = "gvDetalleCompra";
            this.gvDetalleCompra.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDetalleCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetalleCompra.Size = new System.Drawing.Size(901, 201);
            this.gvDetalleCompra.TabIndex = 60;
            this.gvDetalleCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetalleCompra_CellDoubleClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "CODIGO PRODUCTO";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "NOMBRE";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.HeaderText = "DESCRIPCION";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "CANTIDAD";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            // 
            // ColumnPrecioCompra
            // 
            this.ColumnPrecioCompra.HeaderText = "PRECIO COMPRA";
            this.ColumnPrecioCompra.Name = "ColumnPrecioCompra";
            this.ColumnPrecioCompra.ReadOnly = true;
            // 
            // ColumnVenta
            // 
            this.ColumnVenta.HeaderText = "PRECIO VENTA";
            this.ColumnVenta.Name = "ColumnVenta";
            this.ColumnVenta.ReadOnly = true;
            // 
            // ColumnPuntoReorden
            // 
            this.ColumnPuntoReorden.HeaderText = "PUNTO REORDEN";
            this.ColumnPuntoReorden.Name = "ColumnPuntoReorden";
            this.ColumnPuntoReorden.ReadOnly = true;
            // 
            // ColumnFechaElaboracion
            // 
            this.ColumnFechaElaboracion.HeaderText = "FECHA ELABORACION";
            this.ColumnFechaElaboracion.Name = "ColumnFechaElaboracion";
            this.ColumnFechaElaboracion.ReadOnly = true;
            // 
            // ColumnFechaVencimineto
            // 
            this.ColumnFechaVencimineto.HeaderText = "FECHA VENCIMIENTO";
            this.ColumnFechaVencimineto.Name = "ColumnFechaVencimineto";
            this.ColumnFechaVencimineto.ReadOnly = true;
            // 
            // ColumnIdProducto
            // 
            this.ColumnIdProducto.HeaderText = "ID PRODUCTO";
            this.ColumnIdProducto.Name = "ColumnIdProducto";
            this.ColumnIdProducto.ReadOnly = true;
            this.ColumnIdProducto.Visible = false;
            // 
            // lblNombrProveedor
            // 
            this.lblNombrProveedor.AutoSize = true;
            this.lblNombrProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombrProveedor.Location = new System.Drawing.Point(9, 67);
            this.lblNombrProveedor.Name = "lblNombrProveedor";
            this.lblNombrProveedor.Size = new System.Drawing.Size(96, 18);
            this.lblNombrProveedor.TabIndex = 59;
            this.lblNombrProveedor.Text = "Proveedor:";
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-1, 36);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(927, 15);
            this.lblLinea.TabIndex = 58;
            // 
            // lblNuevaCompra
            // 
            this.lblNuevaCompra.AutoSize = true;
            this.lblNuevaCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevaCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNuevaCompra.Location = new System.Drawing.Point(393, 1);
            this.lblNuevaCompra.Name = "lblNuevaCompra";
            this.lblNuevaCompra.Size = new System.Drawing.Size(138, 18);
            this.lblNuevaCompra.TabIndex = 57;
            this.lblNuevaCompra.Text = "Nueva Compra";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(113, 66);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(191, 24);
            this.cmbProveedores.TabIndex = 62;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // gvOrdenProducto
            // 
            this.gvOrdenProducto.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvOrdenProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvOrdenProducto.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvOrdenProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrdenProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvOrdenProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrdenProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoProductoOrden,
            this.ColumnNombreOrden,
            this.ColumnDescripcionOrden,
            this.ColumnCantidadOrden,
            this.ColumnPrecioCompraOrden,
            this.ColumnPrecioVentaOrden,
            this.ColumnPuntoReordenOrden,
            this.ColumnFechaElaboracionOrden,
            this.ColumnFechaVencimientoOrden,
            this.ColumnIdProductoOrden,
            this.ColumnTotalCompra});
            this.gvOrdenProducto.ContextMenuStrip = this.cmsGvOrdenarProducto;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvOrdenProducto.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvOrdenProducto.Location = new System.Drawing.Point(12, 388);
            this.gvOrdenProducto.Name = "gvOrdenProducto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrdenProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvOrdenProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrdenProducto.Size = new System.Drawing.Size(901, 201);
            this.gvOrdenProducto.TabIndex = 63;
            this.gvOrdenProducto.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrdenProducto_CellEndEdit);
            this.gvOrdenProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvOrdenProducto_KeyPress);
            // 
            // ColumnCodigoProductoOrden
            // 
            this.ColumnCodigoProductoOrden.HeaderText = "CODIGO PRODUCTO";
            this.ColumnCodigoProductoOrden.Name = "ColumnCodigoProductoOrden";
            // 
            // ColumnNombreOrden
            // 
            this.ColumnNombreOrden.HeaderText = "NOMBRE";
            this.ColumnNombreOrden.Name = "ColumnNombreOrden";
            // 
            // ColumnDescripcionOrden
            // 
            this.ColumnDescripcionOrden.HeaderText = "DESCRIPCION";
            this.ColumnDescripcionOrden.Name = "ColumnDescripcionOrden";
            // 
            // ColumnCantidadOrden
            // 
            this.ColumnCantidadOrden.HeaderText = "CANTIDAD";
            this.ColumnCantidadOrden.Name = "ColumnCantidadOrden";
            // 
            // ColumnPrecioCompraOrden
            // 
            this.ColumnPrecioCompraOrden.HeaderText = "PRECIO COMPRA";
            this.ColumnPrecioCompraOrden.Name = "ColumnPrecioCompraOrden";
            // 
            // ColumnPrecioVentaOrden
            // 
            this.ColumnPrecioVentaOrden.HeaderText = "PRECIO VENTA";
            this.ColumnPrecioVentaOrden.Name = "ColumnPrecioVentaOrden";
            // 
            // ColumnPuntoReordenOrden
            // 
            this.ColumnPuntoReordenOrden.HeaderText = "PUNTO REORDEN";
            this.ColumnPuntoReordenOrden.Name = "ColumnPuntoReordenOrden";
            // 
            // ColumnFechaElaboracionOrden
            // 
            this.ColumnFechaElaboracionOrden.HeaderText = "FECHA ELABORACION";
            this.ColumnFechaElaboracionOrden.Name = "ColumnFechaElaboracionOrden";
            // 
            // ColumnFechaVencimientoOrden
            // 
            this.ColumnFechaVencimientoOrden.HeaderText = "FECHA VENCIMIENTO";
            this.ColumnFechaVencimientoOrden.Name = "ColumnFechaVencimientoOrden";
            // 
            // ColumnIdProductoOrden
            // 
            this.ColumnIdProductoOrden.HeaderText = "ID PRODUCTO";
            this.ColumnIdProductoOrden.Name = "ColumnIdProductoOrden";
            this.ColumnIdProductoOrden.Visible = false;
            // 
            // ColumnTotalCompra
            // 
            this.ColumnTotalCompra.HeaderText = "TOTAL COMPRA";
            this.ColumnTotalCompra.Name = "ColumnTotalCompra";
            this.ColumnTotalCompra.Visible = false;
            // 
            // cmsGvOrdenarProducto
            // 
            this.cmsGvOrdenarProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devolverToolStripMenuItem});
            this.cmsGvOrdenarProducto.Name = "cmsGvOrdenarProducto";
            this.cmsGvOrdenarProducto.Size = new System.Drawing.Size(121, 26);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            this.devolverToolStripMenuItem.Click += new System.EventHandler(this.devolverToolStripMenuItem_Click);
            // 
            // lblProductoOrdenar
            // 
            this.lblProductoOrdenar.AutoSize = true;
            this.lblProductoOrdenar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductoOrdenar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProductoOrdenar.Location = new System.Drawing.Point(371, 358);
            this.lblProductoOrdenar.Name = "lblProductoOrdenar";
            this.lblProductoOrdenar.Size = new System.Drawing.Size(183, 18);
            this.lblProductoOrdenar.TabIndex = 64;
            this.lblProductoOrdenar.Text = "Producto a Ordenar";
            // 
            // lblListadoGeneralProducto
            // 
            this.lblListadoGeneralProducto.AutoSize = true;
            this.lblListadoGeneralProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblListadoGeneralProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblListadoGeneralProducto.Location = new System.Drawing.Point(354, 108);
            this.lblListadoGeneralProducto.Name = "lblListadoGeneralProducto";
            this.lblListadoGeneralProducto.Size = new System.Drawing.Size(217, 18);
            this.lblListadoGeneralProducto.TabIndex = 65;
            this.lblListadoGeneralProducto.Text = "Producto del Proveedor";
            // 
            // btnEmitirOrden
            // 
            this.btnEmitirOrden.BackColor = System.Drawing.Color.White;
            this.btnEmitirOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmitirOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirOrden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirOrden.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEmitirOrden.Location = new System.Drawing.Point(352, 595);
            this.btnEmitirOrden.Name = "btnEmitirOrden";
            this.btnEmitirOrden.Size = new System.Drawing.Size(220, 37);
            this.btnEmitirOrden.TabIndex = 66;
            this.btnEmitirOrden.Text = "&Emitir orden de compra";
            this.btnEmitirOrden.UseVisualStyleBackColor = false;
            this.btnEmitirOrden.Click += new System.EventHandler(this.btnEmitirOrden_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(799, 596);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 37);
            this.btnSalir.TabIndex = 67;
            this.btnSalir.Text = "&Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblValorTotalCompra
            // 
            this.lblValorTotalCompra.AutoSize = true;
            this.lblValorTotalCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorTotalCompra.Location = new System.Drawing.Point(168, 614);
            this.lblValorTotalCompra.Name = "lblValorTotalCompra";
            this.lblValorTotalCompra.Size = new System.Drawing.Size(18, 18);
            this.lblValorTotalCompra.TabIndex = 69;
            this.lblValorTotalCompra.Text = "0";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotalCompra.Location = new System.Drawing.Point(12, 614);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(163, 18);
            this.lblTotalCompra.TabIndex = 68;
            this.lblTotalCompra.Text = "TOTAL COMPRA: L.";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblObservaciones.Location = new System.Drawing.Point(530, 65);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 18);
            this.lblObservaciones.TabIndex = 71;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtObservaciones.Location = new System.Drawing.Point(670, 65);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(243, 67);
            this.txtObservaciones.TabIndex = 70;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 645);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblValorTotalCompra);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmitirOrden);
            this.Controls.Add(this.lblListadoGeneralProducto);
            this.Controls.Add(this.lblProductoOrdenar);
            this.Controls.Add(this.gvOrdenProducto);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.gvDetalleCompra);
            this.Controls.Add(this.lblNombrProveedor);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblNuevaCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompras";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrdenProducto)).EndInit();
            this.cmsGvOrdenarProducto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.DataGridView gvDetalleCompra;
        private System.Windows.Forms.Label lblNombrProveedor;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblNuevaCompra;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.DataGridView gvOrdenProducto;
        private System.Windows.Forms.Label lblProductoOrdenar;
        private System.Windows.Forms.Label lblListadoGeneralProducto;
        private System.Windows.Forms.Button btnEmitirOrden;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ContextMenuStrip cmsGvOrdenarProducto;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuntoReorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaElaboracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaVencimineto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProducto;
        private System.Windows.Forms.Label lblValorTotalCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoProductoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcionOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioCompraOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioVentaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuntoReordenOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaElaboracionOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaVencimientoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProductoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalCompra;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}