namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmDarBajaClienteProveedor
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblObservacionesTitulo = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRTN = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblRTNTitulo = new System.Windows.Forms.Label();
            this.lstClienteProveedor = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-13, 74);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 32;
            // 
            // lblTituloAgregarProducto
            // 
            this.lblTituloAgregarProducto.AutoSize = true;
            this.lblTituloAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloAgregarProducto.Location = new System.Drawing.Point(293, 45);
            this.lblTituloAgregarProducto.Name = "lblTituloAgregarProducto";
            this.lblTituloAgregarProducto.Size = new System.Drawing.Size(288, 18);
            this.lblTituloAgregarProducto.TabIndex = 31;
            this.lblTituloAgregarProducto.Text = "Dar de Baja Cliente - Proveedor";
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.lblTipo);
            this.gbInventario.Controls.Add(this.lblTipoTitulo);
            this.gbInventario.Controls.Add(this.lblEstado);
            this.gbInventario.Controls.Add(this.lblEstadoTitulo);
            this.gbInventario.Controls.Add(this.lblObservacionesTitulo);
            this.gbInventario.Controls.Add(this.txtObservaciones);
            this.gbInventario.Controls.Add(this.btnCambiarEstado);
            this.gbInventario.Controls.Add(this.lblApellido);
            this.gbInventario.Controls.Add(this.lblNombre);
            this.gbInventario.Controls.Add(this.lblRTN);
            this.gbInventario.Controls.Add(this.lblApellidos);
            this.gbInventario.Controls.Add(this.lblNombres);
            this.gbInventario.Controls.Add(this.lblRTNTitulo);
            this.gbInventario.Controls.Add(this.lstClienteProveedor);
            this.gbInventario.Controls.Add(this.btnSalir);
            this.gbInventario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInventario.Location = new System.Drawing.Point(12, 123);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(857, 457);
            this.gbInventario.TabIndex = 30;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "CLIENTES - PROVEEDORES";
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(563, 227);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(250, 25);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoTitulo
            // 
            this.lblTipoTitulo.AutoSize = true;
            this.lblTipoTitulo.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblTipoTitulo.Location = new System.Drawing.Point(452, 230);
            this.lblTipoTitulo.Name = "lblTipoTitulo";
            this.lblTipoTitulo.Size = new System.Drawing.Size(50, 18);
            this.lblTipoTitulo.TabIndex = 23;
            this.lblTipoTitulo.Text = "Tipo:";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(563, 183);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(250, 25);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblEstadoTitulo.Location = new System.Drawing.Point(452, 186);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(71, 18);
            this.lblEstadoTitulo.TabIndex = 21;
            this.lblEstadoTitulo.Text = "Estado:";
            // 
            // lblObservacionesTitulo
            // 
            this.lblObservacionesTitulo.AutoSize = true;
            this.lblObservacionesTitulo.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblObservacionesTitulo.Location = new System.Drawing.Point(452, 272);
            this.lblObservacionesTitulo.Name = "lblObservacionesTitulo";
            this.lblObservacionesTitulo.Size = new System.Drawing.Size(134, 18);
            this.lblObservacionesTitulo.TabIndex = 20;
            this.lblObservacionesTitulo.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(455, 293);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservaciones.Size = new System.Drawing.Size(358, 81);
            this.txtObservaciones.TabIndex = 19;
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
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.SteelBlue;
            this.lblApellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(563, 139);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(250, 25);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(563, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(250, 25);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRTN
            // 
            this.lblRTN.BackColor = System.Drawing.Color.SteelBlue;
            this.lblRTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTN.ForeColor = System.Drawing.Color.White;
            this.lblRTN.Location = new System.Drawing.Point(563, 55);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(250, 25);
            this.lblRTN.TabIndex = 15;
            this.lblRTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblApellidos.Location = new System.Drawing.Point(452, 142);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(90, 18);
            this.lblApellidos.TabIndex = 14;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblNombres.Location = new System.Drawing.Point(452, 99);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(87, 18);
            this.lblNombres.TabIndex = 13;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblRTNTitulo
            // 
            this.lblRTNTitulo.AutoSize = true;
            this.lblRTNTitulo.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblRTNTitulo.Location = new System.Drawing.Point(452, 58);
            this.lblRTNTitulo.Name = "lblRTNTitulo";
            this.lblRTNTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblRTNTitulo.TabIndex = 12;
            this.lblRTNTitulo.Text = "RTN:";
            // 
            // lstClienteProveedor
            // 
            this.lstClienteProveedor.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClienteProveedor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstClienteProveedor.FormattingEnabled = true;
            this.lstClienteProveedor.ItemHeight = 21;
            this.lstClienteProveedor.Location = new System.Drawing.Point(35, 55);
            this.lstClienteProveedor.Name = "lstClienteProveedor";
            this.lstClienteProveedor.ScrollAlwaysVisible = true;
            this.lstClienteProveedor.Size = new System.Drawing.Size(366, 319);
            this.lstClienteProveedor.TabIndex = 11;
            this.lstClienteProveedor.SelectedIndexChanged += new System.EventHandler(this.lstClienteProveedor_SelectedIndexChanged);
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
            // frmDarBajaClienteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 592);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblTituloAgregarProducto);
            this.Controls.Add(this.gbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDarBajaClienteProveedor";
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
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRTN;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblRTNTitulo;
        private System.Windows.Forms.ListBox lstClienteProveedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblObservacionesTitulo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
    }
}

