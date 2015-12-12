namespace ERP.UserInterface.Usuarios
{
    partial class frmBuscarEmpleadosSinUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMostrarEmpleados = new System.Windows.Forms.Label();
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblDiseño = new System.Windows.Forms.Label();
            this.gvDatosEmpleado = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLinea = new System.Windows.Forms.Label();
            this.gbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMostrarEmpleados
            // 
            this.lblMostrarEmpleados.AutoSize = true;
            this.lblMostrarEmpleados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblMostrarEmpleados.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMostrarEmpleados.Location = new System.Drawing.Point(296, 9);
            this.lblMostrarEmpleados.Name = "lblMostrarEmpleados";
            this.lblMostrarEmpleados.Size = new System.Drawing.Size(289, 18);
            this.lblMostrarEmpleados.TabIndex = 37;
            this.lblMostrarEmpleados.Text = "Mostrar Empleados Sin Usuarios";
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.btnBuscar);
            this.gbDatosEmpleado.Controls.Add(this.btnCerrar);
            this.gbDatosEmpleado.Controls.Add(this.lblNombreUsuario);
            this.gbDatosEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.gbDatosEmpleado.Controls.Add(this.lblDiseño);
            this.gbDatosEmpleado.Controls.Add(this.gvDatosEmpleado);
            this.gbDatosEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEmpleado.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDatosEmpleado.Location = new System.Drawing.Point(12, 59);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(857, 421);
            this.gbDatosEmpleado.TabIndex = 36;
            this.gbDatosEmpleado.TabStop = false;
            this.gbDatosEmpleado.Text = "DATOS DEL EMPLEADO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Location = new System.Drawing.Point(292, 375);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 37);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(451, 375);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(6, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(78, 18);
            this.lblNombreUsuario.TabIndex = 53;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(90, 30);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(203, 24);
            this.txtNombreEmpleado.TabIndex = 52;
            this.txtNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiseño
            // 
            this.lblDiseño.AutoSize = true;
            this.lblDiseño.BackColor = System.Drawing.Color.Transparent;
            this.lblDiseño.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseño.ForeColor = System.Drawing.Color.Silver;
            this.lblDiseño.Location = new System.Drawing.Point(-65, 45);
            this.lblDiseño.Name = "lblDiseño";
            this.lblDiseño.Size = new System.Drawing.Size(998, 18);
            this.lblDiseño.TabIndex = 51;
            this.lblDiseño.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // gvDatosEmpleado
            // 
            this.gvDatosEmpleado.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvDatosEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvDatosEmpleado.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvDatosEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDatosEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvDatosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvDatosEmpleado.Location = new System.Drawing.Point(26, 84);
            this.gvDatosEmpleado.Name = "gvDatosEmpleado";
            this.gvDatosEmpleado.RowHeadersVisible = false;
            this.gvDatosEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatosEmpleado.Size = new System.Drawing.Size(805, 286);
            this.gvDatosEmpleado.TabIndex = 3;
            this.gvDatosEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatosEmpleado_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Identidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombres";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellidos";
            this.Column4.Name = "Column4";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cargo";
            this.Column9.Name = "Column9";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dirección";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Género";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Estado civil";
            this.Column7.Name = "Column7";
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-53, 41);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(1028, 15);
            this.lblLinea.TabIndex = 35;
            // 
            // frmBuscarEmpleadosSinUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 483);
            this.Controls.Add(this.lblMostrarEmpleados);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.lblLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarEmpleadosSinUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarEmpleadosSinUsuario";
            this.Load += new System.EventHandler(this.frmBuscarEmpleadosSinUsuario_Load);
            this.gbDatosEmpleado.ResumeLayout(false);
            this.gbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrarEmpleados;
        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblDiseño;
        private System.Windows.Forms.DataGridView gvDatosEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;

    }
}