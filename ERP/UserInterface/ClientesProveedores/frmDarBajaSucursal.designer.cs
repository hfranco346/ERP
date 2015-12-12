namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmDarBajaSucursal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTituloAgregarProducto = new System.Windows.Forms.Label();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObservacionesTitulo = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lEstado = new System.Windows.Forms.Label();
            this.lstSucursal = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-16, 70);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 32;
            // 
            // lblTituloAgregarProducto
            // 
            this.lblTituloAgregarProducto.AutoSize = true;
            this.lblTituloAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloAgregarProducto.Location = new System.Drawing.Point(332, 40);
            this.lblTituloAgregarProducto.Name = "lblTituloAgregarProducto";
            this.lblTituloAgregarProducto.Size = new System.Drawing.Size(191, 18);
            this.lblTituloAgregarProducto.TabIndex = 31;
            this.lblTituloAgregarProducto.Text = "Dar de Baja Sucursal";
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.lbnombre);
            this.gbInventario.Controls.Add(this.label2);
            this.gbInventario.Controls.Add(this.lblObservacionesTitulo);
            this.gbInventario.Controls.Add(this.txtObservaciones);
            this.gbInventario.Controls.Add(this.btnCambiarEstado);
            this.gbInventario.Controls.Add(this.lblEstado);
            this.gbInventario.Controls.Add(this.lEstado);
            this.gbInventario.Controls.Add(this.lstSucursal);
            this.gbInventario.Controls.Add(this.btnSalir);
            this.gbInventario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInventario.Location = new System.Drawing.Point(12, 100);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(857, 457);
            this.gbInventario.TabIndex = 30;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Sucursal";
            this.gbInventario.Enter += new System.EventHandler(this.gbInventario_Enter);
            // 
            // lbnombre
            // 
            this.lbnombre.BackColor = System.Drawing.Color.SteelBlue;
            this.lbnombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.White;
            this.lbnombre.Location = new System.Drawing.Point(563, 55);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(250, 25);
            this.lbnombre.TabIndex = 26;
            this.lbnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(452, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombres:";
            // 
            // lblObservacionesTitulo
            // 
            this.lblObservacionesTitulo.AutoSize = true;
            this.lblObservacionesTitulo.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblObservacionesTitulo.Location = new System.Drawing.Point(452, 196);
            this.lblObservacionesTitulo.Name = "lblObservacionesTitulo";
            this.lblObservacionesTitulo.Size = new System.Drawing.Size(134, 18);
            this.lblObservacionesTitulo.TabIndex = 20;
            this.lblObservacionesTitulo.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(455, 217);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservaciones.Size = new System.Drawing.Size(358, 81);
            this.txtObservaciones.TabIndex = 19;
            this.txtObservaciones.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarEstado.Location = new System.Drawing.Point(246, 402);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(155, 37);
            this.btnCambiarEstado.TabIndex = 18;
            this.btnCambiarEstado.Text = "&Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(563, 96);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(250, 25);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstado.Click += new System.EventHandler(this.label5_Click);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Verdana", 12F);
            this.lEstado.Location = new System.Drawing.Point(452, 99);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(71, 18);
            this.lEstado.TabIndex = 13;
            this.lEstado.Text = "Estado:";
            this.lEstado.Click += new System.EventHandler(this.label2_Click);
            // 
            // lstSucursal
            // 
            this.lstSucursal.BackColor = System.Drawing.Color.SteelBlue;
            this.lstSucursal.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSucursal.ForeColor = System.Drawing.Color.White;
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.ItemHeight = 21;
            this.lstSucursal.Location = new System.Drawing.Point(35, 55);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.ScrollAlwaysVisible = true;
            this.lstSucursal.Size = new System.Drawing.Size(366, 319);
            this.lstSucursal.TabIndex = 11;
            this.lstSucursal.SelectedIndexChanged += new System.EventHandler(this.lstSucursal_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(455, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 37);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // epValidarTextos
            // 
            this.epValidarTextos.ContainerControl = this;
            // 
            // frmDarBajaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 584);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblTituloAgregarProducto);
            this.Controls.Add(this.gbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDarBajaSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDarBajaClienteProveedor_Load);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTituloAgregarProducto;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.ListBox lstSucursal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblObservacionesTitulo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label label2;
    }
}

