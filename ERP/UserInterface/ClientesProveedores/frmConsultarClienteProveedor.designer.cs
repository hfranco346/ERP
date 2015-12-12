namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmConsultarClienteProveedor
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
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTituloClienteProveedores = new System.Windows.Forms.Label();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.lblRTN = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.gvClienteProveedor = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClienteProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-7, 75);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 38;
            // 
            // lblTituloClienteProveedores
            // 
            this.lblTituloClienteProveedores.AutoSize = true;
            this.lblTituloClienteProveedores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloClienteProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloClienteProveedores.Location = new System.Drawing.Point(342, 43);
            this.lblTituloClienteProveedores.Name = "lblTituloClienteProveedores";
            this.lblTituloClienteProveedores.Size = new System.Drawing.Size(198, 18);
            this.lblTituloClienteProveedores.TabIndex = 37;
            this.lblTituloClienteProveedores.Text = "Clientes-Proveedores";
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.lblRTN);
            this.gbInventario.Controls.Add(this.txtRTN);
            this.gbInventario.Controls.Add(this.btnProveedores);
            this.gbInventario.Controls.Add(this.btnClientes);
            this.gbInventario.Controls.Add(this.gvClienteProveedor);
            this.gbInventario.Controls.Add(this.btnCerrar);
            this.gbInventario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInventario.Location = new System.Drawing.Point(14, 124);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(855, 433);
            this.gbInventario.TabIndex = 36;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "TODOS LOS CLIENTES-PROVEEDORES";
            // 
            // lblRTN
            // 
            this.lblRTN.AutoSize = true;
            this.lblRTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTN.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRTN.Location = new System.Drawing.Point(13, 43);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(48, 18);
            this.lblRTN.TabIndex = 38;
            this.lblRTN.Text = "RTN:";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(83, 40);
            this.txtRTN.MaxLength = 14;
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(443, 27);
            this.txtRTN.TabIndex = 17;
            this.txtRTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRTN.TextChanged += new System.EventHandler(this.txtRTN_TextChanged);
            this.txtRTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRTN_KeyPress);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.White;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnProveedores.Location = new System.Drawing.Point(339, 376);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(131, 37);
            this.btnProveedores.TabIndex = 16;
            this.btnProveedores.Text = "&Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClientes.Location = new System.Drawing.Point(219, 376);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(114, 37);
            this.btnClientes.TabIndex = 15;
            this.btnClientes.Text = "&Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // gvClienteProveedor
            // 
            this.gvClienteProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gvClienteProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvClienteProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvClienteProveedor.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvClienteProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvClienteProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvClienteProveedor.ColumnHeadersHeight = 40;
            this.gvClienteProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvClienteProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvClienteProveedor.Location = new System.Drawing.Point(16, 88);
            this.gvClienteProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.gvClienteProveedor.Name = "gvClienteProveedor";
            this.gvClienteProveedor.RowTemplate.Height = 24;
            this.gvClienteProveedor.Size = new System.Drawing.Size(819, 264);
            this.gvClienteProveedor.TabIndex = 14;
            this.gvClienteProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvClienteProveedor_CellContentClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(521, 376);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmConsultarClienteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 569);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblTituloClienteProveedores);
            this.Controls.Add(this.gbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarClienteProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente-Proveedor";
            this.Load += new System.EventHandler(this.frmClienteProveedor_Load);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClienteProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTituloClienteProveedores;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.DataGridView gvClienteProveedor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblRTN;
        private System.Windows.Forms.TextBox txtRTN;

    }
}

