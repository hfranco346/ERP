namespace ERP.UserInterface.Inventario
{
    partial class frmConsutarProducto
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
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTituloAgregarProducto = new System.Windows.Forms.Label();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.btnTodosProductos = new System.Windows.Forms.Button();
            this.btnProductosActivos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProveedor = new System.Windows.Forms.RadioButton();
            this.rbCodigoBarra = new System.Windows.Forms.RadioButton();
            this.rbNombreProducto = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.gvProductos = new System.Windows.Forms.DataGridView();
            this.btnProductosInactivos = new System.Windows.Forms.Button();
            this.btnReorden = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.gbInventario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-3, 63);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(954, 15);
            this.lblLinea.TabIndex = 4;
            // 
            // lblTituloAgregarProducto
            // 
            this.lblTituloAgregarProducto.AutoSize = true;
            this.lblTituloAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloAgregarProducto.Location = new System.Drawing.Point(422, 35);
            this.lblTituloAgregarProducto.Name = "lblTituloAgregarProducto";
            this.lblTituloAgregarProducto.Size = new System.Drawing.Size(100, 18);
            this.lblTituloAgregarProducto.TabIndex = 5;
            this.lblTituloAgregarProducto.Text = "Inventario\r\n";
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.btnTodosProductos);
            this.gbInventario.Controls.Add(this.btnProductosActivos);
            this.gbInventario.Controls.Add(this.groupBox1);
            this.gbInventario.Controls.Add(this.gvProductos);
            this.gbInventario.Controls.Add(this.btnProductosInactivos);
            this.gbInventario.Controls.Add(this.btnReorden);
            this.gbInventario.Controls.Add(this.btnsalir);
            this.gbInventario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInventario.Location = new System.Drawing.Point(12, 112);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(920, 406);
            this.gbInventario.TabIndex = 3;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "TODOS LOS PRODUCTOS";
            // 
            // btnTodosProductos
            // 
            this.btnTodosProductos.BackColor = System.Drawing.Color.White;
            this.btnTodosProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosProductos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosProductos.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTodosProductos.Location = new System.Drawing.Point(16, 352);
            this.btnTodosProductos.Name = "btnTodosProductos";
            this.btnTodosProductos.Size = new System.Drawing.Size(95, 37);
            this.btnTodosProductos.TabIndex = 5;
            this.btnTodosProductos.Text = "&Todos";
            this.btnTodosProductos.UseVisualStyleBackColor = false;
            this.btnTodosProductos.Click += new System.EventHandler(this.btnTodosProductos_Click);
            // 
            // btnProductosActivos
            // 
            this.btnProductosActivos.BackColor = System.Drawing.Color.White;
            this.btnProductosActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductosActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosActivos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosActivos.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnProductosActivos.Location = new System.Drawing.Point(218, 352);
            this.btnProductosActivos.Name = "btnProductosActivos";
            this.btnProductosActivos.Size = new System.Drawing.Size(95, 37);
            this.btnProductosActivos.TabIndex = 4;
            this.btnProductosActivos.Text = "&Activos";
            this.btnProductosActivos.UseVisualStyleBackColor = false;
            this.btnProductosActivos.Click += new System.EventHandler(this.btnProductosActivos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProveedor);
            this.groupBox1.Controls.Add(this.rbCodigoBarra);
            this.groupBox1.Controls.Add(this.rbNombreProducto);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Location = new System.Drawing.Point(750, 19);
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Size = new System.Drawing.Size(107, 22);
            this.rbProveedor.TabIndex = 3;
            this.rbProveedor.TabStop = true;
            this.rbProveedor.Text = "Proveedor";
            this.rbProveedor.UseVisualStyleBackColor = true;
            this.rbProveedor.CheckedChanged += new System.EventHandler(this.rbProveedor_CheckedChanged);
            // 
            // rbCodigoBarra
            // 
            this.rbCodigoBarra.AutoSize = true;
            this.rbCodigoBarra.Location = new System.Drawing.Point(597, 19);
            this.rbCodigoBarra.Name = "rbCodigoBarra";
            this.rbCodigoBarra.Size = new System.Drawing.Size(131, 22);
            this.rbCodigoBarra.TabIndex = 2;
            this.rbCodigoBarra.TabStop = true;
            this.rbCodigoBarra.Text = "Codigo Barra";
            this.rbCodigoBarra.UseVisualStyleBackColor = true;
            this.rbCodigoBarra.CheckedChanged += new System.EventHandler(this.rbCodigoBarra_CheckedChanged);
            // 
            // rbNombreProducto
            // 
            this.rbNombreProducto.AutoSize = true;
            this.rbNombreProducto.Location = new System.Drawing.Point(471, 19);
            this.rbNombreProducto.Name = "rbNombreProducto";
            this.rbNombreProducto.Size = new System.Drawing.Size(89, 22);
            this.rbNombreProducto.TabIndex = 1;
            this.rbNombreProducto.TabStop = true;
            this.rbNombreProducto.Text = "Nombre";
            this.rbNombreProducto.UseVisualStyleBackColor = true;
            this.rbNombreProducto.CheckedChanged += new System.EventHandler(this.rbNombreProducto_CheckedChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtbuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtbuscar.Location = new System.Drawing.Point(78, 21);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(357, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // gvProductos
            // 
            this.gvProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvProductos.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvProductos.Location = new System.Drawing.Point(16, 103);
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.ReadOnly = true;
            this.gvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProductos.Size = new System.Drawing.Size(887, 225);
            this.gvProductos.TabIndex = 0;
            // 
            // btnProductosInactivos
            // 
            this.btnProductosInactivos.BackColor = System.Drawing.Color.White;
            this.btnProductosInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductosInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosInactivos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosInactivos.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnProductosInactivos.Location = new System.Drawing.Point(117, 352);
            this.btnProductosInactivos.Name = "btnProductosInactivos";
            this.btnProductosInactivos.Size = new System.Drawing.Size(95, 37);
            this.btnProductosInactivos.TabIndex = 1;
            this.btnProductosInactivos.Text = "&Inactivos";
            this.btnProductosInactivos.UseVisualStyleBackColor = false;
            this.btnProductosInactivos.Click += new System.EventHandler(this.btnProductosInactivos_Click);
            // 
            // btnReorden
            // 
            this.btnReorden.BackColor = System.Drawing.Color.White;
            this.btnReorden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReorden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorden.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnReorden.Location = new System.Drawing.Point(319, 352);
            this.btnReorden.Name = "btnReorden";
            this.btnReorden.Size = new System.Drawing.Size(95, 37);
            this.btnReorden.TabIndex = 0;
            this.btnReorden.Text = "&Reorden";
            this.btnReorden.UseVisualStyleBackColor = false;
            this.btnReorden.Click += new System.EventHandler(this.btnReorden_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnsalir.Location = new System.Drawing.Point(789, 352);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(114, 37);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "&Cerrar";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmConsutarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblTituloAgregarProducto);
            this.Controls.Add(this.gbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsutarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsutarProducto";
            this.Load += new System.EventHandler(this.frmConsutarProducto_Load);
            this.gbInventario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTituloAgregarProducto;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.Button btnTodosProductos;
        private System.Windows.Forms.Button btnProductosActivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProveedor;
        private System.Windows.Forms.RadioButton rbCodigoBarra;
        private System.Windows.Forms.RadioButton rbNombreProducto;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.Button btnProductosInactivos;
        private System.Windows.Forms.Button btnReorden;
        private System.Windows.Forms.Button btnsalir;
    }
}