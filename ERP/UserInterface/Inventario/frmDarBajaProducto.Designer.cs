namespace ERP.UserInterface.Inventario
{
    partial class frmDarBajaProducto
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
            this.lblTituloAgregarProducto = new System.Windows.Forms.Label();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.lblEstadoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-10, 46);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(905, 15);
            this.lblLinea.TabIndex = 32;
            // 
            // lblTituloAgregarProducto
            // 
            this.lblTituloAgregarProducto.AutoSize = true;
            this.lblTituloAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloAgregarProducto.Location = new System.Drawing.Point(342, 17);
            this.lblTituloAgregarProducto.Name = "lblTituloAgregarProducto";
            this.lblTituloAgregarProducto.Size = new System.Drawing.Size(197, 18);
            this.lblTituloAgregarProducto.TabIndex = 31;
            this.lblTituloAgregarProducto.Text = "Dar de Baja Producto";
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.txtObservaciones);
            this.gbInventario.Controls.Add(this.lblObservaciones);
            this.gbInventario.Controls.Add(this.lblCantidad);
            this.gbInventario.Controls.Add(this.lblCantidadProducto);
            this.gbInventario.Controls.Add(this.btnCambiarEstado);
            this.gbInventario.Controls.Add(this.lblEstadoProducto);
            this.gbInventario.Controls.Add(this.lblNombreProducto);
            this.gbInventario.Controls.Add(this.lblCodigoBarra);
            this.gbInventario.Controls.Add(this.label3);
            this.gbInventario.Controls.Add(this.label2);
            this.gbInventario.Controls.Add(this.label1);
            this.gbInventario.Controls.Add(this.lstProducto);
            this.gbInventario.Controls.Add(this.btnSalir);
            this.gbInventario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInventario.Location = new System.Drawing.Point(12, 90);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(857, 441);
            this.gbInventario.TabIndex = 30;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "TODOS LOS PRODUCTOS";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtObservaciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtObservaciones.Location = new System.Drawing.Point(448, 274);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(356, 75);
            this.txtObservaciones.TabIndex = 22;
            this.txtObservaciones.Tag = "";
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblObservaciones.Location = new System.Drawing.Point(445, 240);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 18);
            this.lblObservaciones.TabIndex = 21;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(554, 193);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(250, 25);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblCantidadProducto.Location = new System.Drawing.Point(445, 196);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(88, 18);
            this.lblCantidadProducto.TabIndex = 19;
            this.lblCantidadProducto.Text = "Cantidad:";
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
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click_1);
            // 
            // lblEstadoProducto
            // 
            this.lblEstadoProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEstadoProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoProducto.ForeColor = System.Drawing.Color.White;
            this.lblEstadoProducto.Location = new System.Drawing.Point(554, 146);
            this.lblEstadoProducto.Name = "lblEstadoProducto";
            this.lblEstadoProducto.Size = new System.Drawing.Size(250, 25);
            this.lblEstadoProducto.TabIndex = 17;
            this.lblEstadoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombreProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.lblNombreProducto.Location = new System.Drawing.Point(554, 95);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(250, 25);
            this.lblNombreProducto.TabIndex = 16;
            this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarra.ForeColor = System.Drawing.Color.White;
            this.lblCodigoBarra.Location = new System.Drawing.Point(554, 45);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(250, 25);
            this.lblCodigoBarra.TabIndex = 15;
            this.lblCodigoBarra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(445, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(445, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(445, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código:";
            // 
            // lstProducto
            // 
            this.lstProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.lstProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducto.ForeColor = System.Drawing.Color.White;
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.ItemHeight = 18;
            this.lstProducto.Location = new System.Drawing.Point(73, 45);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(323, 292);
            this.lstProducto.TabIndex = 0;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.lstProducto_SelectedIndexChanged);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // epValidarTextos
            // 
            this.epValidarTextos.ContainerControl = this;
            // 
            // frmDarBajaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 543);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblTituloAgregarProducto);
            this.Controls.Add(this.gbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDarBajaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDarBajaProducto";
            this.Load += new System.EventHandler(this.frmDarBajaProducto_Load);
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
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Label lblEstadoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
    }
}