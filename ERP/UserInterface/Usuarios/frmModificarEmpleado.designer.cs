namespace ERP.UserInterface.Usuarios
{
    partial class frmModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarEmpleado));
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.gbDatosEmpleado1 = new System.Windows.Forms.GroupBox();
            this.mskIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarTelefonos = new System.Windows.Forms.Button();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.gbDiseño = new System.Windows.Forms.GroupBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chkSi = new System.Windows.Forms.CheckBox();
            this.lblDeseaActualizarUsuarioAEmpleado = new System.Windows.Forms.Label();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.cbEstadocivil = new System.Windows.Forms.ComboBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNumerosTelefono = new System.Windows.Forms.Label();
            this.lblDiseño2 = new System.Windows.Forms.Label();
            this.lblDiseño = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblActualizarEmpleado = new System.Windows.Forms.Label();
            this.gbDatosEmpleado.SuspendLayout();
            this.gbDatosEmpleado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.gbDatosEmpleado1);
            this.gbDatosEmpleado.Controls.Add(this.btnActualizar);
            this.gbDatosEmpleado.Controls.Add(this.btnCerrar);
            this.gbDatosEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEmpleado.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDatosEmpleado.Location = new System.Drawing.Point(12, 62);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(977, 441);
            this.gbDatosEmpleado.TabIndex = 34;
            this.gbDatosEmpleado.TabStop = false;
            this.gbDatosEmpleado.Text = "DATOS DEL EMPLEADO";
            // 
            // gbDatosEmpleado1
            // 
            this.gbDatosEmpleado1.Controls.Add(this.mskIdentidad);
            this.gbDatosEmpleado1.Controls.Add(this.btnAgregarTelefonos);
            this.gbDatosEmpleado1.Controls.Add(this.cbCargo);
            this.gbDatosEmpleado1.Controls.Add(this.lblCargo);
            this.gbDatosEmpleado1.Controls.Add(this.gbDiseño);
            this.gbDatosEmpleado1.Controls.Add(this.chkNo);
            this.gbDatosEmpleado1.Controls.Add(this.chkSi);
            this.gbDatosEmpleado1.Controls.Add(this.lblDeseaActualizarUsuarioAEmpleado);
            this.gbDatosEmpleado1.Controls.Add(this.lblIdentidad);
            this.gbDatosEmpleado1.Controls.Add(this.cbEstadocivil);
            this.gbDatosEmpleado1.Controls.Add(this.lblNombres);
            this.gbDatosEmpleado1.Controls.Add(this.lblEstadoCivil);
            this.gbDatosEmpleado1.Controls.Add(this.txtNombre);
            this.gbDatosEmpleado1.Controls.Add(this.cbGenero);
            this.gbDatosEmpleado1.Controls.Add(this.lblApellidos);
            this.gbDatosEmpleado1.Controls.Add(this.txtApellido);
            this.gbDatosEmpleado1.Controls.Add(this.lblDireccion);
            this.gbDatosEmpleado1.Controls.Add(this.lblGenero);
            this.gbDatosEmpleado1.Controls.Add(this.txtDireccion);
            this.gbDatosEmpleado1.Controls.Add(this.lblNumerosTelefono);
            this.gbDatosEmpleado1.Controls.Add(this.lblDiseño2);
            this.gbDatosEmpleado1.Controls.Add(this.lblDiseño);
            this.gbDatosEmpleado1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEmpleado1.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDatosEmpleado1.Location = new System.Drawing.Point(35, 40);
            this.gbDatosEmpleado1.Name = "gbDatosEmpleado1";
            this.gbDatosEmpleado1.Size = new System.Drawing.Size(907, 321);
            this.gbDatosEmpleado1.TabIndex = 0;
            this.gbDatosEmpleado1.TabStop = false;
            // 
            // mskIdentidad
            // 
            this.mskIdentidad.Enabled = false;
            this.mskIdentidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskIdentidad.Location = new System.Drawing.Point(214, 24);
            this.mskIdentidad.Mask = "0000-0000-00000";
            this.mskIdentidad.Name = "mskIdentidad";
            this.mskIdentidad.Size = new System.Drawing.Size(203, 27);
            this.mskIdentidad.TabIndex = 0;
            this.mskIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarTelefonos
            // 
            this.btnAgregarTelefonos.AutoSize = true;
            this.btnAgregarTelefonos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarTelefonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTelefonos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefonos.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregarTelefonos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTelefonos.Image")));
            this.btnAgregarTelefonos.Location = new System.Drawing.Point(671, 160);
            this.btnAgregarTelefonos.Name = "btnAgregarTelefonos";
            this.btnAgregarTelefonos.Size = new System.Drawing.Size(30, 25);
            this.btnAgregarTelefonos.TabIndex = 8;
            this.btnAgregarTelefonos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarTelefonos.UseVisualStyleBackColor = false;
            this.btnAgregarTelefonos.Click += new System.EventHandler(this.btnAgregarTelefonos_Click);
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCargo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(671, 69);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(203, 26);
            this.cbCargo.TabIndex = 5;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(478, 72);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(62, 18);
            this.lblCargo.TabIndex = 48;
            this.lblCargo.Text = "Cargo:";
            // 
            // gbDiseño
            // 
            this.gbDiseño.BackColor = System.Drawing.Color.Transparent;
            this.gbDiseño.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiseño.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDiseño.Location = new System.Drawing.Point(442, 0);
            this.gbDiseño.Name = "gbDiseño";
            this.gbDiseño.Size = new System.Drawing.Size(11, 321);
            this.gbDiseño.TabIndex = 40;
            this.gbDiseño.TabStop = false;
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNo.Location = new System.Drawing.Point(732, 284);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(48, 22);
            this.chkNo.TabIndex = 10;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.Click += new System.EventHandler(this.chkNo_Click);
            // 
            // chkSi
            // 
            this.chkSi.AutoSize = true;
            this.chkSi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSi.Location = new System.Drawing.Point(565, 284);
            this.chkSi.Name = "chkSi";
            this.chkSi.Size = new System.Drawing.Size(40, 22);
            this.chkSi.TabIndex = 9;
            this.chkSi.Text = "Si";
            this.chkSi.UseVisualStyleBackColor = true;
            this.chkSi.Click += new System.EventHandler(this.chkSi_Click);
            // 
            // lblDeseaActualizarUsuarioAEmpleado
            // 
            this.lblDeseaActualizarUsuarioAEmpleado.AutoSize = true;
            this.lblDeseaActualizarUsuarioAEmpleado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeseaActualizarUsuarioAEmpleado.Location = new System.Drawing.Point(526, 241);
            this.lblDeseaActualizarUsuarioAEmpleado.Name = "lblDeseaActualizarUsuarioAEmpleado";
            this.lblDeseaActualizarUsuarioAEmpleado.Size = new System.Drawing.Size(317, 18);
            this.lblDeseaActualizarUsuarioAEmpleado.TabIndex = 43;
            this.lblDeseaActualizarUsuarioAEmpleado.Text = "¿Desea actualizar el usuario al empleado?";
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidad.Location = new System.Drawing.Point(24, 28);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(94, 18);
            this.lblIdentidad.TabIndex = 25;
            this.lblIdentidad.Text = "Identidad:";
            // 
            // cbEstadocivil
            // 
            this.cbEstadocivil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadocivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstadocivil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadocivil.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbEstadocivil.FormattingEnabled = true;
            this.cbEstadocivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Soltero(a)"});
            this.cbEstadocivil.Location = new System.Drawing.Point(671, 113);
            this.cbEstadocivil.Name = "cbEstadocivil";
            this.cbEstadocivil.Size = new System.Drawing.Size(203, 26);
            this.cbEstadocivil.TabIndex = 6;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(24, 76);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(87, 18);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(478, 116);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(109, 18);
            this.lblEstadoCivil.TabIndex = 37;
            this.lblEstadoCivil.Text = "Estado civil:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombre.Location = new System.Drawing.Point(214, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGenero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbGenero.Location = new System.Drawing.Point(671, 25);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(203, 26);
            this.cbGenero.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(24, 116);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(90, 18);
            this.lblApellidos.TabIndex = 27;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtApellido.Location = new System.Drawing.Point(214, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(203, 24);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(25, 160);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 18);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(478, 28);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(73, 18);
            this.lblGenero.TabIndex = 29;
            this.lblGenero.Text = "Género:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDireccion.Location = new System.Drawing.Point(214, 160);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(205, 55);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumerosTelefono
            // 
            this.lblNumerosTelefono.AutoSize = true;
            this.lblNumerosTelefono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerosTelefono.Location = new System.Drawing.Point(478, 162);
            this.lblNumerosTelefono.Name = "lblNumerosTelefono";
            this.lblNumerosTelefono.Size = new System.Drawing.Size(196, 18);
            this.lblNumerosTelefono.TabIndex = 31;
            this.lblNumerosTelefono.Text = "Números de teléfonos:";
            // 
            // lblDiseño2
            // 
            this.lblDiseño2.AutoSize = true;
            this.lblDiseño2.BackColor = System.Drawing.Color.Transparent;
            this.lblDiseño2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseño2.ForeColor = System.Drawing.Color.Silver;
            this.lblDiseño2.Location = new System.Drawing.Point(448, 223);
            this.lblDiseño2.Name = "lblDiseño2";
            this.lblDiseño2.Size = new System.Drawing.Size(468, 18);
            this.lblDiseño2.TabIndex = 47;
            this.lblDiseño2.Text = "______________________________________________";
            // 
            // lblDiseño
            // 
            this.lblDiseño.AutoSize = true;
            this.lblDiseño.BackColor = System.Drawing.Color.Transparent;
            this.lblDiseño.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseño.ForeColor = System.Drawing.Color.Silver;
            this.lblDiseño.Location = new System.Drawing.Point(-6, 223);
            this.lblDiseño.Name = "lblDiseño";
            this.lblDiseño.Size = new System.Drawing.Size(458, 18);
            this.lblDiseño.TabIndex = 53;
            this.lblDiseño.Text = "_____________________________________________";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.Location = new System.Drawing.Point(332, 379);
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
            this.btnCerrar.Location = new System.Drawing.Point(530, 379);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-5, 44);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(1028, 15);
            this.lblLinea.TabIndex = 33;
            // 
            // lblActualizarEmpleado
            // 
            this.lblActualizarEmpleado.AutoSize = true;
            this.lblActualizarEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblActualizarEmpleado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblActualizarEmpleado.Location = new System.Drawing.Point(362, 9);
            this.lblActualizarEmpleado.Name = "lblActualizarEmpleado";
            this.lblActualizarEmpleado.Size = new System.Drawing.Size(267, 18);
            this.lblActualizarEmpleado.TabIndex = 35;
            this.lblActualizarEmpleado.Text = "Actualizar datos de empleado";
            this.lblActualizarEmpleado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 537);
            this.Controls.Add(this.lblActualizarEmpleado);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.lblLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarEmpleado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarEmpleado";
            this.Load += new System.EventHandler(this.frmModificarEmpleado_Load);
            this.gbDatosEmpleado.ResumeLayout(false);
            this.gbDatosEmpleado1.ResumeLayout(false);
            this.gbDatosEmpleado1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.GroupBox gbDatosEmpleado1;
        private System.Windows.Forms.Button btnAgregarTelefonos;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.GroupBox gbDiseño;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.CheckBox chkSi;
        private System.Windows.Forms.Label lblDeseaActualizarUsuarioAEmpleado;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.ComboBox cbEstadocivil;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNumerosTelefono;
        private System.Windows.Forms.Label lblDiseño2;
        private System.Windows.Forms.Label lblDiseño;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblActualizarEmpleado;
        private System.Windows.Forms.MaskedTextBox mskIdentidad;
    }
}