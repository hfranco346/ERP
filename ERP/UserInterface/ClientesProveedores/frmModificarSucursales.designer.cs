namespace ERP.UserInterface.ClientesProveedores
{
    partial class frmModificarSucursales
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
            this.lblTituloAgregarProducto = new System.Windows.Forms.Label();
            this.gbAgregarProducto = new System.Windows.Forms.GroupBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.lstSucursal = new System.Windows.Forms.ListBox();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.llblID = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.gbAgregarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloAgregarProducto
            // 
            this.lblTituloAgregarProducto.AutoSize = true;
            this.lblTituloAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTituloAgregarProducto.Location = new System.Drawing.Point(373, 26);
            this.lblTituloAgregarProducto.Name = "lblTituloAgregarProducto";
            this.lblTituloAgregarProducto.Size = new System.Drawing.Size(167, 18);
            this.lblTituloAgregarProducto.TabIndex = 64;
            this.lblTituloAgregarProducto.Text = "Modificar Sucursal";
            // 
            // gbAgregarProducto
            // 
            this.gbAgregarProducto.Controls.Add(this.txtNombreSucursal);
            this.gbAgregarProducto.Controls.Add(this.lblID);
            this.gbAgregarProducto.Controls.Add(this.dtpFechaModificacion);
            this.gbAgregarProducto.Controls.Add(this.lstSucursal);
            this.gbAgregarProducto.Controls.Add(this.lblFechaModificacion);
            this.gbAgregarProducto.Controls.Add(this.txtDire);
            this.gbAgregarProducto.Controls.Add(this.lblNombre);
            this.gbAgregarProducto.Controls.Add(this.llblID);
            this.gbAgregarProducto.Controls.Add(this.btnModificar);
            this.gbAgregarProducto.Controls.Add(this.btnAgregarUsuarios);
            this.gbAgregarProducto.Controls.Add(this.lblNombreSucursal);
            this.gbAgregarProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgregarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbAgregarProducto.Location = new System.Drawing.Point(2, 83);
            this.gbAgregarProducto.Name = "gbAgregarProducto";
            this.gbAgregarProducto.Size = new System.Drawing.Size(884, 453);
            this.gbAgregarProducto.TabIndex = 65;
            this.gbAgregarProducto.TabStop = false;
            this.gbAgregarProducto.Text = "DATOS DE LA SUCURSAL";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSucursal.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombreSucursal.Location = new System.Drawing.Point(643, 124);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(203, 24);
            this.txtNombreSucursal.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.SteelBlue;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(644, 86);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(203, 23);
            this.lblID.TabIndex = 56;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.CalendarFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaModificacion.CalendarForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaModificacion.CalendarTitleForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaModificacion.CalendarTrailingForeColor = System.Drawing.Color.SteelBlue;
            this.dtpFechaModificacion.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.dtpFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaModificacion.Location = new System.Drawing.Point(644, 211);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(203, 26);
            this.dtpFechaModificacion.TabIndex = 3;
            // 
            // lstSucursal
            // 
            this.lstSucursal.BackColor = System.Drawing.Color.SteelBlue;
            this.lstSucursal.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.lstSucursal.ForeColor = System.Drawing.Color.White;
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.ItemHeight = 19;
            this.lstSucursal.Location = new System.Drawing.Point(18, 26);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.ScrollAlwaysVisible = true;
            this.lstSucursal.Size = new System.Drawing.Size(366, 403);
            this.lstSucursal.TabIndex = 0;
            this.lstSucursal.SelectedIndexChanged += new System.EventHandler(this.lstSucursal_SelectedIndexChanged);
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.Location = new System.Drawing.Point(446, 211);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(170, 18);
            this.lblFechaModificacion.TabIndex = 39;
            this.lblFechaModificacion.Text = "Fecha modificacion:";
            // 
            // txtDire
            // 
            this.txtDire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDire.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDire.Location = new System.Drawing.Point(644, 170);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(203, 24);
            this.txtDire.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(446, 172);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 18);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Direccion:";
            // 
            // llblID
            // 
            this.llblID.AutoSize = true;
            this.llblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblID.Location = new System.Drawing.Point(446, 91);
            this.llblID.Name = "llblID";
            this.llblID.Size = new System.Drawing.Size(34, 18);
            this.llblID.TabIndex = 25;
            this.llblID.Text = "ID:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.Location = new System.Drawing.Point(492, 392);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 37);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.BackColor = System.Drawing.Color.White;
            this.btnAgregarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuarios.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(732, 392);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(114, 37);
            this.btnAgregarUsuarios.TabIndex = 6;
            this.btnAgregarUsuarios.Text = "&Cerrar";
            this.btnAgregarUsuarios.UseVisualStyleBackColor = false;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSucursal.Location = new System.Drawing.Point(446, 130);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(151, 18);
            this.lblNombreSucursal.TabIndex = 2;
            this.lblNombreSucursal.Text = "Nombre sucursal:";
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-19, 56);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(940, 15);
            this.lblLinea.TabIndex = 57;
            // 
            // frmModificarSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 548);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbAgregarProducto);
            this.Controls.Add(this.lblTituloAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSucursales";
            this.Load += new System.EventHandler(this.frmModificarSucursales_Load);
            this.gbAgregarProducto.ResumeLayout(false);
            this.gbAgregarProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgregarProducto;
        private System.Windows.Forms.GroupBox gbAgregarProducto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
        private System.Windows.Forms.ListBox lstSucursal;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label llblID;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label lblLinea;
    }
}