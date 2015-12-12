namespace ERP.UserInterface.Usuarios
{
    partial class frmTelefonos
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
            this.gbNumeroTelefonos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.mskMovil = new System.Windows.Forms.MaskedTextBox();
            this.lblDiseño = new System.Windows.Forms.Label();
            this.lstMovil = new System.Windows.Forms.ListBox();
            this.lblMovil = new System.Windows.Forms.Label();
            this.lblFijo = new System.Windows.Forms.Label();
            this.mskFijo = new System.Windows.Forms.MaskedTextBox();
            this.lstFijos = new System.Windows.Forms.ListBox();
            this.lblDiseño2 = new System.Windows.Forms.Label();
            this.gbNumeroTelefonos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNumeroTelefonos
            // 
            this.gbNumeroTelefonos.BackColor = System.Drawing.Color.Transparent;
            this.gbNumeroTelefonos.Controls.Add(this.btnAgregar);
            this.gbNumeroTelefonos.Controls.Add(this.btnCerrar);
            this.gbNumeroTelefonos.Controls.Add(this.mskMovil);
            this.gbNumeroTelefonos.Controls.Add(this.lblDiseño);
            this.gbNumeroTelefonos.Controls.Add(this.lstMovil);
            this.gbNumeroTelefonos.Controls.Add(this.lblMovil);
            this.gbNumeroTelefonos.Controls.Add(this.lblFijo);
            this.gbNumeroTelefonos.Controls.Add(this.mskFijo);
            this.gbNumeroTelefonos.Controls.Add(this.lstFijos);
            this.gbNumeroTelefonos.Controls.Add(this.lblDiseño2);
            this.gbNumeroTelefonos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumeroTelefonos.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbNumeroTelefonos.Location = new System.Drawing.Point(10, 10);
            this.gbNumeroTelefonos.Name = "gbNumeroTelefonos";
            this.gbNumeroTelefonos.Size = new System.Drawing.Size(304, 288);
            this.gbNumeroTelefonos.TabIndex = 42;
            this.gbNumeroTelefonos.TabStop = false;
            this.gbNumeroTelefonos.Text = "Números de Teléfono";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Location = new System.Drawing.Point(66, 246);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 28);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(157, 246);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(82, 28);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // mskMovil
            // 
            this.mskMovil.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskMovil.Location = new System.Drawing.Point(94, 71);
            this.mskMovil.Mask = "0000-0000";
            this.mskMovil.Name = "mskMovil";
            this.mskMovil.Size = new System.Drawing.Size(197, 27);
            this.mskMovil.TabIndex = 1;
            this.mskMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiseño
            // 
            this.lblDiseño.AutoSize = true;
            this.lblDiseño.BackColor = System.Drawing.Color.Transparent;
            this.lblDiseño.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseño.ForeColor = System.Drawing.Color.Silver;
            this.lblDiseño.Location = new System.Drawing.Point(-30, 93);
            this.lblDiseño.Name = "lblDiseño";
            this.lblDiseño.Size = new System.Drawing.Size(358, 18);
            this.lblDiseño.TabIndex = 48;
            this.lblDiseño.Text = "___________________________________";
            // 
            // lstMovil
            // 
            this.lstMovil.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstMovil.FormattingEnabled = true;
            this.lstMovil.ItemHeight = 18;
            this.lstMovil.Location = new System.Drawing.Point(157, 128);
            this.lstMovil.Name = "lstMovil";
            this.lstMovil.Size = new System.Drawing.Size(134, 94);
            this.lstMovil.TabIndex = 5;
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.Location = new System.Drawing.Point(16, 74);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(57, 18);
            this.lblMovil.TabIndex = 28;
            this.lblMovil.Text = "Móvil:";
            // 
            // lblFijo
            // 
            this.lblFijo.AutoSize = true;
            this.lblFijo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFijo.Location = new System.Drawing.Point(16, 38);
            this.lblFijo.Name = "lblFijo";
            this.lblFijo.Size = new System.Drawing.Size(45, 18);
            this.lblFijo.TabIndex = 26;
            this.lblFijo.Text = "Fijo:";
            // 
            // mskFijo
            // 
            this.mskFijo.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskFijo.Location = new System.Drawing.Point(94, 33);
            this.mskFijo.Mask = "0000-0000";
            this.mskFijo.Name = "mskFijo";
            this.mskFijo.Size = new System.Drawing.Size(197, 27);
            this.mskFijo.TabIndex = 0;
            this.mskFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstFijos
            // 
            this.lstFijos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstFijos.FormattingEnabled = true;
            this.lstFijos.ItemHeight = 18;
            this.lstFijos.Location = new System.Drawing.Point(19, 128);
            this.lstFijos.Name = "lstFijos";
            this.lstFijos.Size = new System.Drawing.Size(129, 94);
            this.lstFijos.TabIndex = 4;
            // 
            // lblDiseño2
            // 
            this.lblDiseño2.AutoSize = true;
            this.lblDiseño2.BackColor = System.Drawing.Color.Transparent;
            this.lblDiseño2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseño2.ForeColor = System.Drawing.Color.Silver;
            this.lblDiseño2.Location = new System.Drawing.Point(-13, 218);
            this.lblDiseño2.Name = "lblDiseño2";
            this.lblDiseño2.Size = new System.Drawing.Size(358, 18);
            this.lblDiseño2.TabIndex = 54;
            this.lblDiseño2.Text = "___________________________________";
            // 
            // frmTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 308);
            this.ControlBox = false;
            this.Controls.Add(this.gbNumeroTelefonos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelefonos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTelefonos_Load_1);
            this.gbNumeroTelefonos.ResumeLayout(false);
            this.gbNumeroTelefonos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNumeroTelefonos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MaskedTextBox mskMovil;
        private System.Windows.Forms.Label lblDiseño;
        private System.Windows.Forms.ListBox lstMovil;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.Label lblFijo;
        private System.Windows.Forms.MaskedTextBox mskFijo;
        private System.Windows.Forms.ListBox lstFijos;
        private System.Windows.Forms.Label lblDiseño2;

    }
}

