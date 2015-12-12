namespace ERP.UserInterface.Inventario
{
    partial class frmModificarImpuesto
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
            this.gbDatosImpuesto = new System.Windows.Forms.GroupBox();
            this.txtIdInventario = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lstImpuesto = new System.Windows.Forms.ListBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.lblCodigoBarraProducto = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblTituloModificarImpuesto = new System.Windows.Forms.Label();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblProducto = new System.Windows.Forms.Label();
            this.gbDatosImpuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-10, 70);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 34;
            // 
            // gbDatosImpuesto
            // 
            this.gbDatosImpuesto.Controls.Add(this.lblProducto);
            this.gbDatosImpuesto.Controls.Add(this.txtIdInventario);
            this.gbDatosImpuesto.Controls.Add(this.txtObservaciones);
            this.gbDatosImpuesto.Controls.Add(this.lblObservaciones);
            this.gbDatosImpuesto.Controls.Add(this.lstImpuesto);
            this.gbDatosImpuesto.Controls.Add(this.txtValor);
            this.gbDatosImpuesto.Controls.Add(this.lblDescripcionProducto);
            this.gbDatosImpuesto.Controls.Add(this.lblCodigoBarraProducto);
            this.gbDatosImpuesto.Controls.Add(this.btnModificar);
            this.gbDatosImpuesto.Controls.Add(this.btnCerrar);
            this.gbDatosImpuesto.Controls.Add(this.txtDescripcion);
            this.gbDatosImpuesto.Controls.Add(this.lblImpuesto);
            this.gbDatosImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosImpuesto.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDatosImpuesto.Location = new System.Drawing.Point(12, 114);
            this.gbDatosImpuesto.Name = "gbDatosImpuesto";
            this.gbDatosImpuesto.Size = new System.Drawing.Size(857, 460);
            this.gbDatosImpuesto.TabIndex = 33;
            this.gbDatosImpuesto.TabStop = false;
            this.gbDatosImpuesto.Text = "DATOS DEL IMPUESTO";
            // 
            // txtIdInventario
            // 
            this.txtIdInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdInventario.Enabled = false;
            this.txtIdInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtIdInventario.Location = new System.Drawing.Point(587, 62);
            this.txtIdInventario.Name = "txtIdInventario";
            this.txtIdInventario.Size = new System.Drawing.Size(43, 24);
            this.txtIdInventario.TabIndex = 54;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtObservaciones.Location = new System.Drawing.Point(443, 253);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(368, 82);
            this.txtObservaciones.TabIndex = 4;
            this.txtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservaciones_KeyPress);
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(440, 222);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 18);
            this.lblObservaciones.TabIndex = 52;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lstImpuesto
            // 
            this.lstImpuesto.BackColor = System.Drawing.Color.SteelBlue;
            this.lstImpuesto.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.lstImpuesto.ForeColor = System.Drawing.Color.White;
            this.lstImpuesto.FormattingEnabled = true;
            this.lstImpuesto.ItemHeight = 19;
            this.lstImpuesto.Location = new System.Drawing.Point(37, 46);
            this.lstImpuesto.Name = "lstImpuesto";
            this.lstImpuesto.ScrollAlwaysVisible = true;
            this.lstImpuesto.Size = new System.Drawing.Size(364, 289);
            this.lstImpuesto.TabIndex = 0;
            this.lstImpuesto.SelectedIndexChanged += new System.EventHandler(this.lstImpuesto_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtValor.Location = new System.Drawing.Point(587, 166);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(224, 24);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(440, 168);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(140, 18);
            this.lblDescripcionProducto.TabIndex = 27;
            this.lblDescripcionProducto.Text = "Valor Impuesto:";
            // 
            // lblCodigoBarraProducto
            // 
            this.lblCodigoBarraProducto.AutoSize = true;
            this.lblCodigoBarraProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarraProducto.Location = new System.Drawing.Point(440, 64);
            this.lblCodigoBarraProducto.Name = "lblCodigoBarraProducto";
            this.lblCodigoBarraProducto.Size = new System.Drawing.Size(86, 18);
            this.lblCodigoBarraProducto.TabIndex = 25;
            this.lblCodigoBarraProducto.Text = "Producto:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.Location = new System.Drawing.Point(287, 395);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 37);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnModificar_KeyPress);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(443, 395);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCerrar_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcion.Location = new System.Drawing.Point(587, 114);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(224, 24);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(440, 116);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(93, 18);
            this.lblImpuesto.TabIndex = 2;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblTituloModificarImpuesto
            // 
            this.lblTituloModificarImpuesto.AutoSize = true;
            this.lblTituloModificarImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloModificarImpuesto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloModificarImpuesto.Location = new System.Drawing.Point(352, 41);
            this.lblTituloModificarImpuesto.Name = "lblTituloModificarImpuesto";
            this.lblTituloModificarImpuesto.Size = new System.Drawing.Size(177, 18);
            this.lblTituloModificarImpuesto.TabIndex = 35;
            this.lblTituloModificarImpuesto.Text = "Modificar Impuesto";
            // 
            // epValidarTextos
            // 
            this.epValidarTextos.ContainerControl = this;
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(636, 64);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(175, 22);
            this.lblProducto.TabIndex = 55;
            // 
            // frmModificarImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 586);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbDatosImpuesto);
            this.Controls.Add(this.lblTituloModificarImpuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarImpuesto";
            this.Load += new System.EventHandler(this.frmModificarImpuesto_Load);
            this.gbDatosImpuesto.ResumeLayout(false);
            this.gbDatosImpuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox gbDatosImpuesto;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.ListBox lstImpuesto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Label lblCodigoBarraProducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblTituloModificarImpuesto;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
        private System.Windows.Forms.TextBox txtIdInventario;
        private System.Windows.Forms.Label lblProducto;
    }
}