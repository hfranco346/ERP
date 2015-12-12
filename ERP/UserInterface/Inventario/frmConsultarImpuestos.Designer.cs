namespace ERP.UserInterface.Inventario
{
    partial class frmConsultarImpuestos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTituloAgregarProducto = new System.Windows.Forms.Label();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIdInventario = new System.Windows.Forms.RadioButton();
            this.rbNombreProducto = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.gvImpuestos = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.gbInventario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvImpuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-5, 53);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(945, 15);
            this.lblLinea.TabIndex = 33;
            // 
            // lblTituloAgregarProducto
            // 
            this.lblTituloAgregarProducto.AutoSize = true;
            this.lblTituloAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloAgregarProducto.Location = new System.Drawing.Point(420, 26);
            this.lblTituloAgregarProducto.Name = "lblTituloAgregarProducto";
            this.lblTituloAgregarProducto.Size = new System.Drawing.Size(101, 18);
            this.lblTituloAgregarProducto.TabIndex = 32;
            this.lblTituloAgregarProducto.Text = "Impuestos";
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.groupBox1);
            this.gbInventario.Controls.Add(this.gvImpuestos);
            this.gbInventario.Controls.Add(this.btnsalir);
            this.gbInventario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInventario.Location = new System.Drawing.Point(12, 90);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(914, 428);
            this.gbInventario.TabIndex = 31;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "TODOS LOS IMPUESTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIdInventario);
            this.groupBox1.Controls.Add(this.rbNombreProducto);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 48);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // rbIdInventario
            // 
            this.rbIdInventario.AutoSize = true;
            this.rbIdInventario.Location = new System.Drawing.Point(715, 20);
            this.rbIdInventario.Name = "rbIdInventario";
            this.rbIdInventario.Size = new System.Drawing.Size(127, 22);
            this.rbIdInventario.TabIndex = 2;
            this.rbIdInventario.TabStop = true;
            this.rbIdInventario.Text = "IdInventario";
            this.rbIdInventario.UseVisualStyleBackColor = true;
            this.rbIdInventario.CheckedChanged += new System.EventHandler(this.rbIdInventario_CheckedChanged);
            // 
            // rbNombreProducto
            // 
            this.rbNombreProducto.AutoSize = true;
            this.rbNombreProducto.Location = new System.Drawing.Point(554, 20);
            this.rbNombreProducto.Name = "rbNombreProducto";
            this.rbNombreProducto.Size = new System.Drawing.Size(89, 22);
            this.rbNombreProducto.TabIndex = 1;
            this.rbNombreProducto.TabStop = true;
            this.rbNombreProducto.Text = "Nombre";
            this.rbNombreProducto.UseVisualStyleBackColor = true;
            this.rbNombreProducto.CheckedChanged += new System.EventHandler(this.rbNombreProducto_CheckedChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtbuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtbuscar.Location = new System.Drawing.Point(78, 21);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(385, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // gvImpuestos
            // 
            this.gvImpuestos.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvImpuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gvImpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvImpuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvImpuestos.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvImpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvImpuestos.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvImpuestos.Location = new System.Drawing.Point(16, 116);
            this.gvImpuestos.Name = "gvImpuestos";
            this.gvImpuestos.ReadOnly = true;
            this.gvImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvImpuestos.Size = new System.Drawing.Size(887, 239);
            this.gvImpuestos.TabIndex = 31;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnsalir.Location = new System.Drawing.Point(789, 371);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(114, 37);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "&Cerrar";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmConsultarImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 530);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblTituloAgregarProducto);
            this.Controls.Add(this.gbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarImpuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarImpuestos";
            this.Load += new System.EventHandler(this.frmConsultarImpuestos_Load);
            this.gbInventario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvImpuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTituloAgregarProducto;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIdInventario;
        private System.Windows.Forms.RadioButton rbNombreProducto;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView gvImpuestos;
        private System.Windows.Forms.Button btnsalir;
    }
}