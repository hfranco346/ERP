namespace ERP.UserInterface.Inventario
{
    partial class frmAgregarImpuesto
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
            this.gbAgregarProducto = new System.Windows.Forms.GroupBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtValorImpuesto = new System.Windows.Forms.TextBox();
            this.lblValorImpuesto = new System.Windows.Forms.Label();
            this.epValidarTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-5, 0);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(489, 15);
            this.lblLinea.TabIndex = 31;
            // 
            // gbAgregarProducto
            // 
            this.gbAgregarProducto.Controls.Add(this.cbProducto);
            this.gbAgregarProducto.Controls.Add(this.lblProducto);
            this.gbAgregarProducto.Controls.Add(this.txtDescripcion);
            this.gbAgregarProducto.Controls.Add(this.lblDescripcionProducto);
            this.gbAgregarProducto.Controls.Add(this.btnAgregar);
            this.gbAgregarProducto.Controls.Add(this.btnSalir);
            this.gbAgregarProducto.Controls.Add(this.txtValorImpuesto);
            this.gbAgregarProducto.Controls.Add(this.lblValorImpuesto);
            this.gbAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbAgregarProducto.Location = new System.Drawing.Point(12, 46);
            this.gbAgregarProducto.Name = "gbAgregarProducto";
            this.gbAgregarProducto.Size = new System.Drawing.Size(440, 267);
            this.gbAgregarProducto.TabIndex = 29;
            this.gbAgregarProducto.TabStop = false;
            this.gbAgregarProducto.Text = "AGREGAR IMPUESTO A PRODUCTO";
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(190, 46);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(213, 26);
            this.cbProducto.TabIndex = 0;
            this.cbProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProducto_KeyPress);
            this.cbProducto.Leave += new System.EventHandler(this.cbProducto_Leave);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(41, 49);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(86, 18);
            this.lblProducto.TabIndex = 28;
            this.lblProducto.Text = "Producto:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcion.Location = new System.Drawing.Point(191, 131);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(212, 24);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(41, 133);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(108, 18);
            this.lblDescripcionProducto.TabIndex = 27;
            this.lblDescripcionProducto.Text = "Descripción:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Location = new System.Drawing.Point(159, 194);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAgregar_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(289, 194);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSalir_KeyPress);
            // 
            // txtValorImpuesto
            // 
            this.txtValorImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorImpuesto.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtValorImpuesto.Location = new System.Drawing.Point(191, 90);
            this.txtValorImpuesto.Name = "txtValorImpuesto";
            this.txtValorImpuesto.Size = new System.Drawing.Size(212, 24);
            this.txtValorImpuesto.TabIndex = 1;
            this.txtValorImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorImpuesto_KeyPress);
            this.txtValorImpuesto.Leave += new System.EventHandler(this.txtValorImpuesto_Leave);
            // 
            // lblValorImpuesto
            // 
            this.lblValorImpuesto.AutoSize = true;
            this.lblValorImpuesto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorImpuesto.Location = new System.Drawing.Point(41, 92);
            this.lblValorImpuesto.Name = "lblValorImpuesto";
            this.lblValorImpuesto.Size = new System.Drawing.Size(56, 18);
            this.lblValorImpuesto.TabIndex = 2;
            this.lblValorImpuesto.Text = "Valor:";
            // 
            // epValidarTextos
            // 
            this.epValidarTextos.ContainerControl = this;
            // 
            // frmAgregarImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 325);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarImpuesto";
            this.Load += new System.EventHandler(this.frmAgregarImpuesto_Load);
            this.gbAgregarProducto.ResumeLayout(false);
            this.gbAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidarTextos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox gbAgregarProducto;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtValorImpuesto;
        private System.Windows.Forms.Label lblValorImpuesto;
        private System.Windows.Forms.ErrorProvider epValidarTextos;
    }
}