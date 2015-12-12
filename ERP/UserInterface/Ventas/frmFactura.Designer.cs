namespace ERP.UserInterface.Ventas
{
    partial class frmFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPDataSet = new ERP.ERPDataSet();
            this.encabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblNuevaVenta = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.rpv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.detalleTableAdapter = new ERP.ERPDataSetTableAdapters.DetalleTableAdapter();
            this.encabezadoTableAdapter = new ERP.ERPDataSetTableAdapters.EncabezadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encabezadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataMember = "Detalle";
            this.detalleBindingSource.DataSource = this.eRPDataSet;
            // 
            // eRPDataSet
            // 
            this.eRPDataSet.DataSetName = "ERPDataSet";
            this.eRPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encabezadoBindingSource
            // 
            this.encabezadoBindingSource.DataMember = "Encabezado";
            this.encabezadoBindingSource.DataSource = this.eRPDataSet;
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-2, 55);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(874, 14);
            this.lblLinea.TabIndex = 56;
            // 
            // lblNuevaVenta
            // 
            this.lblNuevaVenta.AutoSize = true;
            this.lblNuevaVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevaVenta.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNuevaVenta.Location = new System.Drawing.Point(372, 24);
            this.lblNuevaVenta.Name = "lblNuevaVenta";
            this.lblNuevaVenta.Size = new System.Drawing.Size(75, 18);
            this.lblNuevaVenta.TabIndex = 57;
            this.lblNuevaVenta.Text = "Factura";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(365, 649);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 58;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rpv
            // 
            reportDataSource1.Name = "Detalle";
            reportDataSource1.Value = this.detalleBindingSource;
            reportDataSource2.Name = "Encabezado";
            reportDataSource2.Value = this.encabezadoBindingSource;
            this.rpv.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv.LocalReport.DataSources.Add(reportDataSource2);
            this.rpv.LocalReport.ReportEmbeddedResource = "ERP.rptImprimirFactura.rdlc";
            this.rpv.Location = new System.Drawing.Point(12, 84);
            this.rpv.Name = "rpv";
            this.rpv.Size = new System.Drawing.Size(848, 559);
            this.rpv.TabIndex = 59;
            // 
            // detalleTableAdapter
            // 
            this.detalleTableAdapter.ClearBeforeFill = true;
            // 
            // encabezadoTableAdapter
            // 
            this.encabezadoTableAdapter.ClearBeforeFill = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 698);
            this.Controls.Add(this.rpv);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNuevaVenta);
            this.Controls.Add(this.lblLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encabezadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblNuevaVenta;
        private System.Windows.Forms.Button btnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer rpv;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private ERPDataSet eRPDataSet;
        private System.Windows.Forms.BindingSource encabezadoBindingSource;
        private ERPDataSetTableAdapters.DetalleTableAdapter detalleTableAdapter;
        private ERPDataSetTableAdapters.EncabezadoTableAdapter encabezadoTableAdapter;
    }
}