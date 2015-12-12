namespace ERP.UserInterface.Usuarios
{
    partial class frmAgregarCargo
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
            this.gbCargos = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbCargos2 = new System.Windows.Forms.GroupBox();
            this.lstCargosExistentes = new System.Windows.Forms.ListBox();
            this.lblDiseño = new System.Windows.Forms.Label();
            this.lblCargosExistentes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbCargos.SuspendLayout();
            this.gbCargos2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCargos
            // 
            this.gbCargos.Controls.Add(this.btnGuardar);
            this.gbCargos.Controls.Add(this.btnCerrar);
            this.gbCargos.Controls.Add(this.gbCargos2);
            this.gbCargos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargos.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbCargos.Location = new System.Drawing.Point(6, -2);
            this.gbCargos.Name = "gbCargos";
            this.gbCargos.Size = new System.Drawing.Size(427, 341);
            this.gbCargos.TabIndex = 36;
            this.gbCargos.TabStop = false;
            this.gbCargos.Text = "Cargos";
            this.gbCargos.Enter += new System.EventHandler(this.gbCargos_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(176, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 37);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(296, 295);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbCargos2
            // 
            this.gbCargos2.Controls.Add(this.lstCargosExistentes);
            this.gbCargos2.Controls.Add(this.lblDiseño);
            this.gbCargos2.Controls.Add(this.lblCargosExistentes);
            this.gbCargos2.Controls.Add(this.txtNombre);
            this.gbCargos2.Controls.Add(this.lblNombre);
            this.gbCargos2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargos2.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbCargos2.Location = new System.Drawing.Point(29, 26);
            this.gbCargos2.Name = "gbCargos2";
            this.gbCargos2.Size = new System.Drawing.Size(382, 249);
            this.gbCargos2.TabIndex = 0;
            this.gbCargos2.TabStop = false;
            // 
            // lstCargosExistentes
            // 
            this.lstCargosExistentes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCargosExistentes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstCargosExistentes.FormattingEnabled = true;
            this.lstCargosExistentes.ItemHeight = 18;
            this.lstCargosExistentes.Location = new System.Drawing.Point(32, 131);
            this.lstCargosExistentes.Name = "lstCargosExistentes";
            this.lstCargosExistentes.Size = new System.Drawing.Size(324, 112);
            this.lstCargosExistentes.TabIndex = 50;
            this.lstCargosExistentes.SelectedIndexChanged += new System.EventHandler(this.lstCargosExistentes_SelectedIndexChanged);
            // 
            // lblDiseño
            // 
            this.lblDiseño.AutoSize = true;
            this.lblDiseño.BackColor = System.Drawing.Color.Transparent;
            this.lblDiseño.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseño.ForeColor = System.Drawing.Color.Silver;
            this.lblDiseño.Location = new System.Drawing.Point(-3, 82);
            this.lblDiseño.Name = "lblDiseño";
            this.lblDiseño.Size = new System.Drawing.Size(388, 18);
            this.lblDiseño.TabIndex = 49;
            this.lblDiseño.Text = "______________________________________";
            // 
            // lblCargosExistentes
            // 
            this.lblCargosExistentes.AutoSize = true;
            this.lblCargosExistentes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargosExistentes.Location = new System.Drawing.Point(113, 110);
            this.lblCargosExistentes.Name = "lblCargosExistentes";
            this.lblCargosExistentes.Size = new System.Drawing.Size(166, 18);
            this.lblCargosExistentes.TabIndex = 34;
            this.lblCargosExistentes.Text = "Cargos existentes";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombre.Location = new System.Drawing.Point(90, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(152, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 18);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmAgregarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 350);
            this.Controls.Add(this.gbCargos);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmAgregarCargo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCargo";
            this.Load += new System.EventHandler(this.frmAgregarCargo_Load);
            this.gbCargos.ResumeLayout(false);
            this.gbCargos2.ResumeLayout(false);
            this.gbCargos2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbCargos2;
        private System.Windows.Forms.Label lblDiseño;
        private System.Windows.Forms.Label lblCargosExistentes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lstCargosExistentes;
    }
}