namespace ERP.UserInterface.Ventas
{
    partial class frmNuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.ColumnIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblNuevaVenta = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblValorSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblValorIsv = new System.Windows.Forms.Label();
            this.lblIsv = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCliente.Location = new System.Drawing.Point(529, 75);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 18);
            this.lblCliente.TabIndex = 60;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombreCliente.Location = new System.Drawing.Point(381, 75);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(142, 18);
            this.lblNombreCliente.TabIndex = 59;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCliente.Location = new System.Drawing.Point(325, 73);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(40, 24);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "...";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnImprimir.Location = new System.Drawing.Point(12, 381);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 37);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Location = new System.Drawing.Point(675, 326);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 37);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrecio.Location = new System.Drawing.Point(427, 335);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 18);
            this.lblPrecio.TabIndex = 57;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPrecio.Location = new System.Drawing.Point(497, 333);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(95, 24);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.nudCantidad.Location = new System.Drawing.Point(331, 333);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(71, 24);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.Leave += new System.EventHandler(this.nudCantidad_Leave);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCantidad.Location = new System.Drawing.Point(237, 335);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(88, 18);
            this.lblCantidad.TabIndex = 56;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdProducto.Location = new System.Drawing.Point(9, 335);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(111, 18);
            this.lblIdProducto.TabIndex = 55;
            this.lblIdProducto.Text = "ID Producto:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCodigoProducto.Location = new System.Drawing.Point(126, 333);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(95, 24);
            this.txtCodigoProducto.TabIndex = 2;
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVenta.Location = new System.Drawing.Point(789, 73);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 54;
            this.dtpFechaVenta.Visible = false;
            // 
            // gvDetalleVenta
            // 
            this.gvDetalleVenta.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvDetalleVenta.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdProducto,
            this.ColumnDescripcion,
            this.ColumnCantidad,
            this.ColumnPU,
            this.ColumnTotal,
            this.ColumnImpuesto,
            this.ColumnIdInventario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvDetalleVenta.Location = new System.Drawing.Point(12, 113);
            this.gvDetalleVenta.Name = "gvDetalleVenta";
            this.gvDetalleVenta.ReadOnly = true;
            this.gvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetalleVenta.Size = new System.Drawing.Size(775, 201);
            this.gvDetalleVenta.TabIndex = 53;
            this.gvDetalleVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetalleVenta_CellClick);
            // 
            // ColumnIdProducto
            // 
            this.ColumnIdProducto.HeaderText = "ID PRODUCTO";
            this.ColumnIdProducto.Name = "ColumnIdProducto";
            this.ColumnIdProducto.ReadOnly = true;
            this.ColumnIdProducto.Width = 115;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.HeaderText = "DESCRIPCION";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            this.ColumnDescripcion.Width = 150;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "CANTIDAD";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            this.ColumnCantidad.Width = 90;
            // 
            // ColumnPU
            // 
            this.ColumnPU.HeaderText = "PRECIO UNITARIO";
            this.ColumnPU.Name = "ColumnPU";
            this.ColumnPU.ReadOnly = true;
            this.ColumnPU.Width = 150;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "TOTAL";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // ColumnImpuesto
            // 
            this.ColumnImpuesto.HeaderText = "IMPUESTO";
            this.ColumnImpuesto.Name = "ColumnImpuesto";
            this.ColumnImpuesto.ReadOnly = true;
            // 
            // ColumnIdInventario
            // 
            this.ColumnIdInventario.HeaderText = "ID INVENTARIO";
            this.ColumnIdInventario.Name = "ColumnIdInventario";
            this.ColumnIdInventario.ReadOnly = true;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdCliente.Location = new System.Drawing.Point(9, 75);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(98, 18);
            this.lblIdCliente.TabIndex = 52;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtIdCliente.Location = new System.Drawing.Point(113, 73);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(203, 24);
            this.txtIdCliente.TabIndex = 0;
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(12, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 37);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-1, 44);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(800, 15);
            this.lblLinea.TabIndex = 51;
            // 
            // lblNuevaVenta
            // 
            this.lblNuevaVenta.AutoSize = true;
            this.lblNuevaVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevaVenta.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNuevaVenta.Location = new System.Drawing.Point(339, 9);
            this.lblNuevaVenta.Name = "lblNuevaVenta";
            this.lblNuevaVenta.Size = new System.Drawing.Size(121, 18);
            this.lblNuevaVenta.TabIndex = 50;
            this.lblNuevaVenta.Text = "Nueva Venta";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(447, 457);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 18);
            this.lblTotal.TabIndex = 61;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorTotal.Location = new System.Drawing.Point(520, 457);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 18);
            this.lblValorTotal.TabIndex = 62;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblVendedor.Location = new System.Drawing.Point(408, 371);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(106, 18);
            this.lblVendedor.TabIndex = 63;
            this.lblVendedor.Text = "VENDEDOR:";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombreVendedor.Location = new System.Drawing.Point(520, 371);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(0, 18);
            this.lblNombreVendedor.TabIndex = 64;
            // 
            // lblValorSubTotal
            // 
            this.lblValorSubTotal.AutoSize = true;
            this.lblValorSubTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSubTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorSubTotal.Location = new System.Drawing.Point(520, 400);
            this.lblValorSubTotal.Name = "lblValorSubTotal";
            this.lblValorSubTotal.Size = new System.Drawing.Size(0, 18);
            this.lblValorSubTotal.TabIndex = 66;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSubTotal.Location = new System.Drawing.Point(408, 400);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(106, 18);
            this.lblSubTotal.TabIndex = 65;
            this.lblSubTotal.Text = "SUB TOTAL:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnQuitar.Location = new System.Drawing.Point(675, 432);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(114, 37);
            this.btnQuitar.TabIndex = 67;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.Location = new System.Drawing.Point(675, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 37);
            this.btnModificar.TabIndex = 68;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblValorIsv
            // 
            this.lblValorIsv.AutoSize = true;
            this.lblValorIsv.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorIsv.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorIsv.Location = new System.Drawing.Point(520, 429);
            this.lblValorIsv.Name = "lblValorIsv";
            this.lblValorIsv.Size = new System.Drawing.Size(0, 18);
            this.lblValorIsv.TabIndex = 70;
            // 
            // lblIsv
            // 
            this.lblIsv.AutoSize = true;
            this.lblIsv.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsv.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIsv.Location = new System.Drawing.Point(460, 429);
            this.lblIsv.Name = "lblIsv";
            this.lblIsv.Size = new System.Drawing.Size(54, 18);
            this.lblIsv.TabIndex = 69;
            this.lblIsv.Text = "I.S.V:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblObservaciones.Location = new System.Drawing.Point(132, 381);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(47, 18);
            this.lblObservaciones.TabIndex = 72;
            this.lblObservaciones.Text = "Obs:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtObservaciones.Location = new System.Drawing.Point(185, 381);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(206, 88);
            this.txtObservaciones.TabIndex = 71;
            // 
            // frmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 483);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblValorIsv);
            this.Controls.Add(this.lblIsv);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblValorSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.gvDetalleVenta);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblNuevaVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmNuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DataGridView gvDetalleVenta;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblNuevaVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblValorSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblValorIsv;
        private System.Windows.Forms.Label lblIsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdInventario;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}