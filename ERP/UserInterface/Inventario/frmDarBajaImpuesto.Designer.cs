namespace ERP.UserInterface.Inventario
{
    partial class frmDarBajaImpuesto
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
            this.lblTituloDarBajaImpuesto = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.gbDarBajaImpuesto = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorTitle = new System.Windows.Forms.Label();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.lblEstadoImpuesto = new System.Windows.Forms.Label();
            this.lblNombreImpuesto = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombreImpuestoTitle = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lstImpuestos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDarBajaImpuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDarBajaImpuesto
            // 
            this.lblTituloDarBajaImpuesto.AutoSize = true;
            this.lblTituloDarBajaImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloDarBajaImpuesto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloDarBajaImpuesto.Location = new System.Drawing.Point(346, 21);
            this.lblTituloDarBajaImpuesto.Name = "lblTituloDarBajaImpuesto";
            this.lblTituloDarBajaImpuesto.Size = new System.Drawing.Size(201, 18);
            this.lblTituloDarBajaImpuesto.TabIndex = 36;
            this.lblTituloDarBajaImpuesto.Text = "Dar de Baja Impuesto\r\n";
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-12, 54);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 35;
            // 
            // gbDarBajaImpuesto
            // 
            this.gbDarBajaImpuesto.Controls.Add(this.lblNombre);
            this.gbDarBajaImpuesto.Controls.Add(this.lblCantidadProducto);
            this.gbDarBajaImpuesto.Controls.Add(this.lblCantidad);
            this.gbDarBajaImpuesto.Controls.Add(this.txtObservaciones);
            this.gbDarBajaImpuesto.Controls.Add(this.lblObservaciones);
            this.gbDarBajaImpuesto.Controls.Add(this.lblValor);
            this.gbDarBajaImpuesto.Controls.Add(this.lblValorTitle);
            this.gbDarBajaImpuesto.Controls.Add(this.btnCambiarEstado);
            this.gbDarBajaImpuesto.Controls.Add(this.lblEstadoImpuesto);
            this.gbDarBajaImpuesto.Controls.Add(this.lblNombreImpuesto);
            this.gbDarBajaImpuesto.Controls.Add(this.lblCodigoBarra);
            this.gbDarBajaImpuesto.Controls.Add(this.lblEstado);
            this.gbDarBajaImpuesto.Controls.Add(this.lblNombreImpuestoTitle);
            this.gbDarBajaImpuesto.Controls.Add(this.lblCodigoProducto);
            this.gbDarBajaImpuesto.Controls.Add(this.lstImpuestos);
            this.gbDarBajaImpuesto.Controls.Add(this.btnSalir);
            this.gbDarBajaImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDarBajaImpuesto.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDarBajaImpuesto.Location = new System.Drawing.Point(12, 90);
            this.gbDarBajaImpuesto.Name = "gbDarBajaImpuesto";
            this.gbDarBajaImpuesto.Size = new System.Drawing.Size(857, 441);
            this.gbDarBajaImpuesto.TabIndex = 34;
            this.gbDarBajaImpuesto.TabStop = false;
            this.gbDarBajaImpuesto.Text = "TODOS LOS IMPUESTOS";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtObservaciones.Location = new System.Drawing.Point(396, 268);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(434, 75);
            this.txtObservaciones.TabIndex = 22;
            this.txtObservaciones.Tag = "";
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblObservaciones.Location = new System.Drawing.Point(393, 237);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 18);
            this.lblObservaciones.TabIndex = 21;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(566, 112);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(264, 25);
            this.lblValor.TabIndex = 20;
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorTitle
            // 
            this.lblValorTitle.AutoSize = true;
            this.lblValorTitle.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblValorTitle.Location = new System.Drawing.Point(393, 112);
            this.lblValorTitle.Name = "lblValorTitle";
            this.lblValorTitle.Size = new System.Drawing.Size(56, 18);
            this.lblValorTitle.TabIndex = 19;
            this.lblValorTitle.Text = "Valor:";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarEstado.Location = new System.Drawing.Point(255, 382);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(147, 37);
            this.btnCambiarEstado.TabIndex = 18;
            this.btnCambiarEstado.Text = "&Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // lblEstadoImpuesto
            // 
            this.lblEstadoImpuesto.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEstadoImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoImpuesto.ForeColor = System.Drawing.Color.White;
            this.lblEstadoImpuesto.Location = new System.Drawing.Point(566, 73);
            this.lblEstadoImpuesto.Name = "lblEstadoImpuesto";
            this.lblEstadoImpuesto.Size = new System.Drawing.Size(264, 25);
            this.lblEstadoImpuesto.TabIndex = 17;
            this.lblEstadoImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreImpuesto
            // 
            this.lblNombreImpuesto.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombreImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreImpuesto.ForeColor = System.Drawing.Color.White;
            this.lblNombreImpuesto.Location = new System.Drawing.Point(566, 36);
            this.lblNombreImpuesto.Name = "lblNombreImpuesto";
            this.lblNombreImpuesto.Size = new System.Drawing.Size(264, 25);
            this.lblNombreImpuesto.TabIndex = 16;
            this.lblNombreImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarra.ForeColor = System.Drawing.Color.White;
            this.lblCodigoBarra.Location = new System.Drawing.Point(566, 151);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(133, 25);
            this.lblCodigoBarra.TabIndex = 15;
            this.lblCodigoBarra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblEstado.Location = new System.Drawing.Point(393, 73);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 18);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombreImpuestoTitle
            // 
            this.lblNombreImpuestoTitle.AutoSize = true;
            this.lblNombreImpuestoTitle.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblNombreImpuestoTitle.Location = new System.Drawing.Point(393, 36);
            this.lblNombreImpuestoTitle.Name = "lblNombreImpuestoTitle";
            this.lblNombreImpuestoTitle.Size = new System.Drawing.Size(162, 18);
            this.lblNombreImpuestoTitle.TabIndex = 13;
            this.lblNombreImpuestoTitle.Text = "Nombre Impuesto:";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblCodigoProducto.Location = new System.Drawing.Point(393, 151);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(86, 18);
            this.lblCodigoProducto.TabIndex = 12;
            this.lblCodigoProducto.Text = "Producto:";
            // 
            // lstImpuestos
            // 
            this.lstImpuestos.BackColor = System.Drawing.Color.SteelBlue;
            this.lstImpuestos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstImpuestos.ForeColor = System.Drawing.Color.White;
            this.lstImpuestos.FormattingEnabled = true;
            this.lstImpuestos.ItemHeight = 18;
            this.lstImpuestos.Location = new System.Drawing.Point(32, 36);
            this.lstImpuestos.Name = "lstImpuestos";
            this.lstImpuestos.Size = new System.Drawing.Size(323, 310);
            this.lstImpuestos.TabIndex = 0;
            this.lstImpuestos.SelectedIndexChanged += new System.EventHandler(this.lstProducto_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(454, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 37);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // epValidarTextos
            // 
            this.epValidarTextos.ContainerControl = this;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.ForeColor = System.Drawing.Color.White;
            this.lblCantidadProducto.Location = new System.Drawing.Point(566, 190);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(264, 25);
            this.lblCantidadProducto.TabIndex = 24;
            this.lblCantidadProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(393, 193);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(165, 18);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad Producto:";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(705, 151);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 25);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDarBajaImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 543);
            this.Controls.Add(this.lblTituloDarBajaImpuesto);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbDarBajaImpuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDarBajaImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDarBajaImpuesto";
            this.Load += new System.EventHandler(this.frmDarBajaImpuesto_Load);
            this.gbDarBajaImpuesto.ResumeLayout(false);
            this.gbDarBajaImpuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDarBajaImpuesto;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox gbDarBajaImpuesto;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorTitle;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Label lblEstadoImpuesto;
        private System.Windows.Forms.Label lblNombreImpuesto;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombreImpuestoTitle;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.ListBox lstImpuestos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
    }
}