namespace ERP.UserInterface.Compras
{
    partial class frmListarOrdenesDeCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.lblNombrProveedor = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblOrdenesDeCompra = new System.Windows.Forms.Label();
            this.gvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.lblDetalleCompra = new System.Windows.Forms.Label();
            this.gvDetalleProducto = new System.Windows.Forms.DataGridView();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarOrden = new System.Windows.Forms.Button();
            this.btnCancelarOrden = new System.Windows.Forms.Button();
            this.lblValorTotalCompra = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(111, 67);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(191, 24);
            this.cmbProveedores.TabIndex = 66;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // lblNombrProveedor
            // 
            this.lblNombrProveedor.AutoSize = true;
            this.lblNombrProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombrProveedor.Location = new System.Drawing.Point(7, 68);
            this.lblNombrProveedor.Name = "lblNombrProveedor";
            this.lblNombrProveedor.Size = new System.Drawing.Size(96, 18);
            this.lblNombrProveedor.TabIndex = 65;
            this.lblNombrProveedor.Text = "Proveedor:";
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-3, 37);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(927, 15);
            this.lblLinea.TabIndex = 64;
            // 
            // lblOrdenesDeCompra
            // 
            this.lblOrdenesDeCompra.AutoSize = true;
            this.lblOrdenesDeCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrdenesDeCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblOrdenesDeCompra.Location = new System.Drawing.Point(369, 2);
            this.lblOrdenesDeCompra.Name = "lblOrdenesDeCompra";
            this.lblOrdenesDeCompra.Size = new System.Drawing.Size(184, 18);
            this.lblOrdenesDeCompra.TabIndex = 63;
            this.lblOrdenesDeCompra.Text = "Ordenes de Compra";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDetalleCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDetalleCompra.Location = new System.Drawing.Point(11, 97);
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
            this.gvDetalleCompra.Size = new System.Drawing.Size(901, 150);
            this.gvDetalleCompra.TabIndex = 67;
            this.gvDetalleCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetalleCompra_CellContentClick);
            this.gvDetalleCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetalleCompra_CellDoubleClick);
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetalleCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDetalleCompra.Location = new System.Drawing.Point(368, 257);
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(187, 18);
            this.lblDetalleCompra.TabIndex = 69;
            this.lblDetalleCompra.Text = "Detalle de la compra";
            // 
            // gvDetalleProducto
            // 
            this.gvDetalleProducto.AllowUserToAddRows = false;
            this.gvDetalleProducto.AllowUserToDeleteRows = false;
            this.gvDetalleProducto.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvDetalleProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvDetalleProducto.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvDetalleProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDetalleProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvDetalleProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalleProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTotal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDetalleProducto.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvDetalleProducto.Location = new System.Drawing.Point(9, 287);
            this.gvDetalleProducto.Name = "gvDetalleProducto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDetalleProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvDetalleProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetalleProducto.Size = new System.Drawing.Size(901, 170);
            this.gvDetalleProducto.TabIndex = 68;
            this.gvDetalleProducto.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetalleProducto_CellEndEdit);
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "TOTAL";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(796, 465);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 37);
            this.btnSalir.TabIndex = 70;
            this.btnSalir.Text = "&Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarOrden
            // 
            this.btnCerrarOrden.BackColor = System.Drawing.Color.White;
            this.btnCerrarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarOrden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarOrden.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarOrden.Location = new System.Drawing.Point(331, 465);
            this.btnCerrarOrden.Name = "btnCerrarOrden";
            this.btnCerrarOrden.Size = new System.Drawing.Size(216, 37);
            this.btnCerrarOrden.TabIndex = 71;
            this.btnCerrarOrden.Text = "&Cerrar orden de compra";
            this.btnCerrarOrden.UseVisualStyleBackColor = false;
            this.btnCerrarOrden.Click += new System.EventHandler(this.btnCerrarOrden_Click);
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.BackColor = System.Drawing.Color.White;
            this.btnCancelarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOrden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarOrden.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarOrden.Location = new System.Drawing.Point(553, 465);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(237, 37);
            this.btnCancelarOrden.TabIndex = 72;
            this.btnCancelarOrden.Text = "&Cancelar orden de compra";
            this.btnCancelarOrden.UseVisualStyleBackColor = false;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // lblValorTotalCompra
            // 
            this.lblValorTotalCompra.AutoSize = true;
            this.lblValorTotalCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorTotalCompra.Location = new System.Drawing.Point(163, 474);
            this.lblValorTotalCompra.Name = "lblValorTotalCompra";
            this.lblValorTotalCompra.Size = new System.Drawing.Size(18, 18);
            this.lblValorTotalCompra.TabIndex = 74;
            this.lblValorTotalCompra.Text = "0";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotalCompra.Location = new System.Drawing.Point(7, 474);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(163, 18);
            this.lblTotalCompra.TabIndex = 73;
            this.lblTotalCompra.Text = "TOTAL COMPRA: L.";
            // 
            // frmListarOrdenesDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 510);
            this.Controls.Add(this.lblValorTotalCompra);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.btnCancelarOrden);
            this.Controls.Add(this.btnCerrarOrden);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.gvDetalleProducto);
            this.Controls.Add(this.gvDetalleCompra);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.lblNombrProveedor);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblOrdenesDeCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListarOrdenesDeCompra";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de compras";
            this.Load += new System.EventHandler(this.frmListarOrdenesDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblNombrProveedor;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblOrdenesDeCompra;
        private System.Windows.Forms.DataGridView gvDetalleCompra;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.DataGridView gvDetalleProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarOrden;
        private System.Windows.Forms.Button btnCancelarOrden;
        private System.Windows.Forms.Label lblValorTotalCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
    }
}