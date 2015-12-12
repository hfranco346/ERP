namespace ERP.UserInterface.Usuarios
{
    partial class frmModificarUsuario
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
            this.lblLinea = new System.Windows.Forms.Label();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.gbDiseño = new System.Windows.Forms.GroupBox();
            this.gbContraseña = new System.Windows.Forms.GroupBox();
            this.txtAcutal2 = new System.Windows.Forms.TextBox();
            this.txtActual1 = new System.Windows.Forms.TextBox();
            this.txtnueva2 = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtconfirmar2 = new System.Windows.Forms.TextBox();
            this.chkMostrarCaracteres = new System.Windows.Forms.CheckBox();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.mskIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.gbRoles = new System.Windows.Forms.GroupBox();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblActualizarUsuario = new System.Windows.Forms.Label();
            this.gbDatosUsuario.SuspendLayout();
            this.gbDiseño.SuspendLayout();
            this.gbContraseña.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.gbRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-29, 37);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(1078, 15);
            this.lblLinea.TabIndex = 35;
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.gbDiseño);
            this.gbDatosUsuario.Controls.Add(this.btnActualizar);
            this.gbDatosUsuario.Controls.Add(this.btnCerrar);
            this.gbDatosUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDatosUsuario.Location = new System.Drawing.Point(13, 55);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(1025, 411);
            this.gbDatosUsuario.TabIndex = 34;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "DATOS DEL USUARIO";
            // 
            // gbDiseño
            // 
            this.gbDiseño.Controls.Add(this.gbContraseña);
            this.gbDiseño.Controls.Add(this.gbUsuario);
            this.gbDiseño.Controls.Add(this.gbRoles);
            this.gbDiseño.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiseño.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDiseño.Location = new System.Drawing.Point(35, 55);
            this.gbDiseño.Name = "gbDiseño";
            this.gbDiseño.Size = new System.Drawing.Size(962, 248);
            this.gbDiseño.TabIndex = 0;
            this.gbDiseño.TabStop = false;
            // 
            // gbContraseña
            // 
            this.gbContraseña.Controls.Add(this.txtAcutal2);
            this.gbContraseña.Controls.Add(this.txtActual1);
            this.gbContraseña.Controls.Add(this.txtnueva2);
            this.gbContraseña.Controls.Add(this.lblNueva);
            this.gbContraseña.Controls.Add(this.txtconfirmar2);
            this.gbContraseña.Controls.Add(this.chkMostrarCaracteres);
            this.gbContraseña.Controls.Add(this.txtconfirmar);
            this.gbContraseña.Controls.Add(this.lblConfirmar);
            this.gbContraseña.Controls.Add(this.lblActual);
            this.gbContraseña.Controls.Add(this.txtNueva);
            this.gbContraseña.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContraseña.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbContraseña.Location = new System.Drawing.Point(368, 36);
            this.gbContraseña.Name = "gbContraseña";
            this.gbContraseña.Size = new System.Drawing.Size(342, 182);
            this.gbContraseña.TabIndex = 2;
            this.gbContraseña.TabStop = false;
            this.gbContraseña.Text = "Contraseña";
            // 
            // txtAcutal2
            // 
            this.txtAcutal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcutal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcutal2.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAcutal2.Location = new System.Drawing.Point(120, 35);
            this.txtAcutal2.Name = "txtAcutal2";
            this.txtAcutal2.Size = new System.Drawing.Size(203, 24);
            this.txtAcutal2.TabIndex = 3;
            this.txtAcutal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcutal2.Visible = false;
            // 
            // txtActual1
            // 
            this.txtActual1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActual1.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtActual1.Location = new System.Drawing.Point(120, 35);
            this.txtActual1.Name = "txtActual1";
            this.txtActual1.PasswordChar = 'X';
            this.txtActual1.Size = new System.Drawing.Size(203, 24);
            this.txtActual1.TabIndex = 0;
            this.txtActual1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActual1.TextChanged += new System.EventHandler(this.txtActual1_TextChanged);
            // 
            // txtnueva2
            // 
            this.txtnueva2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnueva2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnueva2.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtnueva2.Location = new System.Drawing.Point(120, 69);
            this.txtnueva2.Name = "txtnueva2";
            this.txtnueva2.Size = new System.Drawing.Size(203, 24);
            this.txtnueva2.TabIndex = 4;
            this.txtnueva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnueva2.Visible = false;
            this.txtnueva2.TextChanged += new System.EventHandler(this.txtnueva2_TextChanged);
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(14, 75);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(66, 18);
            this.lblNueva.TabIndex = 38;
            this.lblNueva.Text = "Nueva:";
            // 
            // txtconfirmar2
            // 
            this.txtconfirmar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfirmar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmar2.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtconfirmar2.Location = new System.Drawing.Point(120, 104);
            this.txtconfirmar2.Name = "txtconfirmar2";
            this.txtconfirmar2.Size = new System.Drawing.Size(203, 24);
            this.txtconfirmar2.TabIndex = 5;
            this.txtconfirmar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtconfirmar2.Visible = false;
            // 
            // chkMostrarCaracteres
            // 
            this.chkMostrarCaracteres.AutoSize = true;
            this.chkMostrarCaracteres.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarCaracteres.Location = new System.Drawing.Point(120, 145);
            this.chkMostrarCaracteres.Name = "chkMostrarCaracteres";
            this.chkMostrarCaracteres.Size = new System.Drawing.Size(153, 20);
            this.chkMostrarCaracteres.TabIndex = 6;
            this.chkMostrarCaracteres.Text = "Mostrar caracteres";
            this.chkMostrarCaracteres.UseVisualStyleBackColor = true;
            this.chkMostrarCaracteres.CheckedChanged += new System.EventHandler(this.chkMostrarCaracteres_CheckedChanged);
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmar.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtconfirmar.Location = new System.Drawing.Point(120, 104);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.PasswordChar = 'X';
            this.txtconfirmar.Size = new System.Drawing.Size(203, 24);
            this.txtconfirmar.TabIndex = 2;
            this.txtconfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtconfirmar.TextChanged += new System.EventHandler(this.txtconfirmar_TextChanged);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(14, 106);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(100, 18);
            this.lblConfirmar.TabIndex = 35;
            this.lblConfirmar.Text = "Confirmar: ";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.Location = new System.Drawing.Point(13, 41);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(66, 18);
            this.lblActual.TabIndex = 33;
            this.lblActual.Text = "Actual:";
            // 
            // txtNueva
            // 
            this.txtNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueva.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNueva.Location = new System.Drawing.Point(120, 69);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = 'X';
            this.txtNueva.Size = new System.Drawing.Size(203, 24);
            this.txtNueva.TabIndex = 1;
            this.txtNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNueva.TextChanged += new System.EventHandler(this.txtNueva_TextChanged);
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.mskIdentidad);
            this.gbUsuario.Controls.Add(this.lblIdentidad);
            this.gbUsuario.Controls.Add(this.txtAlias);
            this.gbUsuario.Controls.Add(this.lblAlias);
            this.gbUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbUsuario.Location = new System.Drawing.Point(30, 36);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(332, 182);
            this.gbUsuario.TabIndex = 1;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario";
            // 
            // mskIdentidad
            // 
            this.mskIdentidad.Enabled = false;
            this.mskIdentidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskIdentidad.Location = new System.Drawing.Point(106, 40);
            this.mskIdentidad.Mask = "0000-0000-00000";
            this.mskIdentidad.Name = "mskIdentidad";
            this.mskIdentidad.Size = new System.Drawing.Size(203, 27);
            this.mskIdentidad.TabIndex = 0;
            this.mskIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidad.Location = new System.Drawing.Point(6, 44);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(94, 18);
            this.lblIdentidad.TabIndex = 32;
            this.lblIdentidad.Text = "Identidad:";
            // 
            // txtAlias
            // 
            this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAlias.Location = new System.Drawing.Point(106, 104);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(203, 24);
            this.txtAlias.TabIndex = 1;
            this.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlias.TextChanged += new System.EventHandler(this.txtAlias_TextChanged);
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlias.Location = new System.Drawing.Point(6, 106);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(55, 18);
            this.lblAlias.TabIndex = 30;
            this.lblAlias.Text = "Alias:";
            // 
            // gbRoles
            // 
            this.gbRoles.Controls.Add(this.cbRoles);
            this.gbRoles.Controls.Add(this.btnEditarRol);
            this.gbRoles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoles.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbRoles.Location = new System.Drawing.Point(716, 36);
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.Size = new System.Drawing.Size(217, 182);
            this.gbRoles.TabIndex = 3;
            this.gbRoles.TabStop = false;
            this.gbRoles.Text = "Roles";
            // 
            // cbRoles
            // 
            this.cbRoles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRoles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(6, 41);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(205, 26);
            this.cbRoles.TabIndex = 0;
            this.cbRoles.Click += new System.EventHandler(this.cbRoles_Click);
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.BackColor = System.Drawing.Color.White;
            this.btnEditarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRol.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRol.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEditarRol.Location = new System.Drawing.Point(64, 99);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(98, 29);
            this.btnEditarRol.TabIndex = 1;
            this.btnEditarRol.Text = "Editar Rol";
            this.btnEditarRol.UseVisualStyleBackColor = false;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.Location = new System.Drawing.Point(357, 339);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 37);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(526, 339);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblActualizarUsuario
            // 
            this.lblActualizarUsuario.AutoSize = true;
            this.lblActualizarUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblActualizarUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblActualizarUsuario.Location = new System.Drawing.Point(418, 9);
            this.lblActualizarUsuario.Name = "lblActualizarUsuario";
            this.lblActualizarUsuario.Size = new System.Drawing.Size(250, 18);
            this.lblActualizarUsuario.TabIndex = 36;
            this.lblActualizarUsuario.Text = "Actualizar datos del usuario";
            this.lblActualizarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 485);
            this.Controls.Add(this.lblActualizarUsuario);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.gbDatosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarUsuario";
            this.Load += new System.EventHandler(this.frmModificarUsuario_Load);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDiseño.ResumeLayout(false);
            this.gbContraseña.ResumeLayout(false);
            this.gbContraseña.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbRoles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.GroupBox gbDiseño;
        private System.Windows.Forms.GroupBox gbContraseña;
        private System.Windows.Forms.TextBox txtconfirmar2;
        private System.Windows.Forms.TextBox txtnueva2;
        private System.Windows.Forms.CheckBox chkMostrarCaracteres;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.GroupBox gbRoles;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblActualizarUsuario;
        private System.Windows.Forms.TextBox txtActual1;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtAcutal2;
        private System.Windows.Forms.MaskedTextBox mskIdentidad;
    }
}