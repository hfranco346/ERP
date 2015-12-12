namespace ERP.UserInterface.Ventas
{
    partial class frmDevolucionVenta
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
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.gvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnularFactura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFactura.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdFactura.Location = new System.Drawing.Point(4, 75);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(167, 18);
            this.lblIdFactura.TabIndex = 56;
            this.lblIdFactura.Text = "Número de factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNumeroFactura.Location = new System.Drawing.Point(177, 73);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(203, 24);
            this.txtNumeroFactura.TabIndex = 53;
            this.txtNumeroFactura.Leave += new System.EventHandler(this.txtNumeroFactura_Leave);
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-5, 41);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(514, 15);
            this.lblLinea.TabIndex = 55;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDevolucion.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDevolucion.Location = new System.Drawing.Point(202, 9);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(103, 18);
            this.lblDevolucion.TabIndex = 54;
            this.lblDevolucion.Text = "Devolución";
            // 
            // gvDetalleVenta
            // 
            this.gvDetalleVenta.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDetalleVenta.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDetalleVenta.Location = new System.Drawing.Point(18, 197);
            this.gvDetalleVenta.Name = "gvDetalleVenta";
            this.gvDetalleVenta.ReadOnly = true;
            this.gvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetalleVenta.Size = new System.Drawing.Size(471, 296);
            this.gvDetalleVenta.TabIndex = 57;
            this.gvDetalleVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetalleVenta_CellDoubleClick);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetalle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDetalle.Location = new System.Drawing.Point(171, 176);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(165, 18);
            this.lblDetalle.TabIndex = 58;
            this.lblDetalle.Text = "Detalle de factura";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(18, 506);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 37);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnularFactura
            // 
            this.btnAnularFactura.BackColor = System.Drawing.Color.White;
            this.btnAnularFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularFactura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularFactura.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAnularFactura.Location = new System.Drawing.Point(141, 506);
            this.btnAnularFactura.Name = "btnAnularFactura";
            this.btnAnularFactura.Size = new System.Drawing.Size(173, 37);
            this.btnAnularFactura.TabIndex = 60;
            this.btnAnularFactura.Text = "&Anular factura";
            this.btnAnularFactura.UseVisualStyleBackColor = false;
            this.btnAnularFactura.Click += new System.EventHandler(this.btnAnularFactura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(375, 506);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 37);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorTotal.Location = new System.Drawing.Point(92, 112);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(18, 18);
            this.lblValorTotal.TabIndex = 64;
            this.lblValorTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(4, 112);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 18);
            this.lblTotal.TabIndex = 63;
            this.lblTotal.Text = "TOTAL: L.";
            // 
            // frmDevolucionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 553);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnularFactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.gvDetalleVenta);
            this.Controls.Add(this.lblIdFactura);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblDevolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevolucionVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDevolucionVenta";
            this.Load += new System.EventHandler(this.frmDevolucionVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.DataGridView gvDetalleVenta;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAnularFactura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}