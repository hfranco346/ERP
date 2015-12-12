namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmConsultarSucursal
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
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.gvClienteProveedor = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTituloClienteProveedores = new System.Windows.Forms.Label();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClienteProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.gvClienteProveedor);
            this.gbInventario.Controls.Add(this.btnCerrar);
            this.gbInventario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInventario.Location = new System.Drawing.Point(12, 89);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(841, 335);
            this.gbInventario.TabIndex = 37;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Sucursales";
            this.gbInventario.Enter += new System.EventHandler(this.gbInventario_Enter);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvClienteProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvClienteProveedor.ColumnHeadersHeight = 40;
            this.gvClienteProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvClienteProveedor.Location = new System.Drawing.Point(5, 25);
            this.gvClienteProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.gvClienteProveedor.Name = "gvClienteProveedor";
            this.gvClienteProveedor.RowTemplate.Height = 24;
            this.gvClienteProveedor.Size = new System.Drawing.Size(822, 252);
            this.gvClienteProveedor.TabIndex = 14;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(713, 292);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-36, 49);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 39;
            // 
            // lblTituloClienteProveedores
            // 
            this.lblTituloClienteProveedores.AutoSize = true;
            this.lblTituloClienteProveedores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloClienteProveedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloClienteProveedores.Location = new System.Drawing.Point(381, 20);
            this.lblTituloClienteProveedores.Name = "lblTituloClienteProveedores";
            this.lblTituloClienteProveedores.Size = new System.Drawing.Size(102, 18);
            this.lblTituloClienteProveedores.TabIndex = 40;
            this.lblTituloClienteProveedores.Text = "Sucursales";
            // 
            // frmConsultarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 442);
            this.Controls.Add(this.lblTituloClienteProveedores);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.frmClienteProveedor_Load_1);
            this.gbInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvClienteProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void gbInventario_Enter(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.DataGridView gvClienteProveedor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTituloClienteProveedores;
    }
}

