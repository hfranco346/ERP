namespace ERP.UserInterface.Usuarios
{
    partial class frmAgregarRol
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
            this.gbRoles1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbRoles2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chklistar = new System.Windows.Forms.CheckBox();
            this.chkDevoluciones = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkselecionar = new System.Windows.Forms.CheckBox();
            this.lstpermisos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chksucursales = new System.Windows.Forms.CheckBox();
            this.chkclientesProveedores = new System.Windows.Forms.CheckBox();
            this.chkcargos = new System.Windows.Forms.CheckBox();
            this.chkusuario = new System.Windows.Forms.CheckBox();
            this.chkempleados = new System.Windows.Forms.CheckBox();
            this.chkroles = new System.Windows.Forms.CheckBox();
            this.chkcompras = new System.Windows.Forms.CheckBox();
            this.chkventas = new System.Windows.Forms.CheckBox();
            this.chkinventario = new System.Windows.Forms.CheckBox();
            this.chkimpuestos = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbRoles1.SuspendLayout();
            this.gbRoles2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRoles1
            // 
            this.gbRoles1.Controls.Add(this.btnGuardar);
            this.gbRoles1.Controls.Add(this.btnCerrar);
            this.gbRoles1.Controls.Add(this.gbRoles2);
            this.gbRoles1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoles1.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbRoles1.Location = new System.Drawing.Point(3, 0);
            this.gbRoles1.Name = "gbRoles1";
            this.gbRoles1.Size = new System.Drawing.Size(438, 350);
            this.gbRoles1.TabIndex = 35;
            this.gbRoles1.TabStop = false;
            this.gbRoles1.Text = "Roles";
            this.gbRoles1.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            this.btnCerrar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbRoles2
            // 
            this.gbRoles2.Controls.Add(this.label8);
            this.gbRoles2.Controls.Add(this.lblDescripcion);
            this.gbRoles2.Controls.Add(this.txtDescripcion);
            this.gbRoles2.Controls.Add(this.txtNombre);
            this.gbRoles2.Controls.Add(this.lblNombre);
            this.gbRoles2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoles2.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbRoles2.Location = new System.Drawing.Point(29, 26);
            this.gbRoles2.Name = "gbRoles2";
            this.gbRoles2.Size = new System.Drawing.Size(382, 249);
            this.gbRoles2.TabIndex = 0;
            this.gbRoles2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(-3, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "______________________________________";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(29, 135);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 18);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcion.Location = new System.Drawing.Point(147, 135);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 85);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombre.Location = new System.Drawing.Point(153, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 18);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chksucursales);
            this.groupBox1.Controls.Add(this.chkroles);
            this.groupBox1.Controls.Add(this.chkempleados);
            this.groupBox1.Controls.Add(this.chkimpuestos);
            this.groupBox1.Controls.Add(this.chklistar);
            this.groupBox1.Controls.Add(this.chkcompras);
            this.groupBox1.Controls.Add(this.chkDevoluciones);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.chkselecionar);
            this.groupBox1.Controls.Add(this.lstpermisos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkclientesProveedores);
            this.groupBox1.Controls.Add(this.chkcargos);
            this.groupBox1.Controls.Add(this.chkusuario);
            this.groupBox1.Controls.Add(this.chkventas);
            this.groupBox1.Controls.Add(this.chkinventario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(447, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 350);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chklistar
            // 
            this.chklistar.AutoSize = true;
            this.chklistar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklistar.Location = new System.Drawing.Point(6, 161);
            this.chklistar.Name = "chklistar";
            this.chklistar.Size = new System.Drawing.Size(120, 20);
            this.chklistar.TabIndex = 60;
            this.chklistar.Text = "Listar ordenes";
            this.chklistar.UseVisualStyleBackColor = true;
            this.chklistar.CheckedChanged += new System.EventHandler(this.chklistar_CheckedChanged);
            // 
            // chkDevoluciones
            // 
            this.chkDevoluciones.AutoSize = true;
            this.chkDevoluciones.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDevoluciones.Location = new System.Drawing.Point(6, 129);
            this.chkDevoluciones.Name = "chkDevoluciones";
            this.chkDevoluciones.Size = new System.Drawing.Size(98, 20);
            this.chkDevoluciones.TabIndex = 59;
            this.chkDevoluciones.Text = "Devolución";
            this.chkDevoluciones.UseVisualStyleBackColor = true;
            this.chkDevoluciones.CheckedChanged += new System.EventHandler(this.chkDevoluciones_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(36, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 22);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar lista";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkselecionar
            // 
            this.chkselecionar.AutoSize = true;
            this.chkselecionar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkselecionar.Location = new System.Drawing.Point(181, 226);
            this.chkselecionar.Name = "chkselecionar";
            this.chkselecionar.Size = new System.Drawing.Size(130, 20);
            this.chkselecionar.TabIndex = 58;
            this.chkselecionar.Text = "Selecionar todo";
            this.chkselecionar.UseVisualStyleBackColor = true;
            this.chkselecionar.CheckedChanged += new System.EventHandler(this.chkselecionar_CheckedChanged);
            // 
            // lstpermisos
            // 
            this.lstpermisos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstpermisos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstpermisos.FormattingEnabled = true;
            this.lstpermisos.ItemHeight = 16;
            this.lstpermisos.Location = new System.Drawing.Point(29, 253);
            this.lstpermisos.Name = "lstpermisos";
            this.lstpermisos.Size = new System.Drawing.Size(281, 84);
            this.lstpermisos.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "tendra, para ello debe de seleccionar las";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "casillas que se muestran a continuacion.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Por favor asigne los permisos que este rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(-27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "______________________________________";
            // 
            // chksucursales
            // 
            this.chksucursales.AutoSize = true;
            this.chksucursales.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksucursales.Location = new System.Drawing.Point(205, 180);
            this.chksucursales.Name = "chksucursales";
            this.chksucursales.Size = new System.Drawing.Size(98, 20);
            this.chksucursales.TabIndex = 15;
            this.chksucursales.Text = "Sucursales";
            this.chksucursales.UseVisualStyleBackColor = true;
            this.chksucursales.CheckedChanged += new System.EventHandler(this.chksucursales_CheckedChanged);
            // 
            // chkclientesProveedores
            // 
            this.chkclientesProveedores.AutoSize = true;
            this.chkclientesProveedores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkclientesProveedores.Location = new System.Drawing.Point(6, 180);
            this.chkclientesProveedores.Name = "chkclientesProveedores";
            this.chkclientesProveedores.Size = new System.Drawing.Size(166, 20);
            this.chkclientesProveedores.TabIndex = 14;
            this.chkclientesProveedores.Text = "Clientes/Proveedores";
            this.chkclientesProveedores.UseVisualStyleBackColor = true;
            this.chkclientesProveedores.CheckedChanged += new System.EventHandler(this.chkclientesProveedores_CheckedChanged);
            // 
            // chkcargos
            // 
            this.chkcargos.AutoSize = true;
            this.chkcargos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcargos.Location = new System.Drawing.Point(205, 129);
            this.chkcargos.Name = "chkcargos";
            this.chkcargos.Size = new System.Drawing.Size(72, 20);
            this.chkcargos.TabIndex = 12;
            this.chkcargos.Text = "Cargos";
            this.chkcargos.UseVisualStyleBackColor = true;
            this.chkcargos.CheckedChanged += new System.EventHandler(this.chkcargos_CheckedChanged);
            // 
            // chkusuario
            // 
            this.chkusuario.AutoSize = true;
            this.chkusuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkusuario.Location = new System.Drawing.Point(205, 96);
            this.chkusuario.Name = "chkusuario";
            this.chkusuario.Size = new System.Drawing.Size(82, 20);
            this.chkusuario.TabIndex = 11;
            this.chkusuario.Text = "Usuarios";
            this.chkusuario.UseVisualStyleBackColor = true;
            this.chkusuario.CheckedChanged += new System.EventHandler(this.chkusuario_CheckedChanged);
            // 
            // chkempleados
            // 
            this.chkempleados.AutoSize = true;
            this.chkempleados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkempleados.Location = new System.Drawing.Point(205, 112);
            this.chkempleados.Name = "chkempleados";
            this.chkempleados.Size = new System.Drawing.Size(96, 20);
            this.chkempleados.TabIndex = 10;
            this.chkempleados.Text = "Empleados";
            this.chkempleados.UseVisualStyleBackColor = true;
            this.chkempleados.CheckedChanged += new System.EventHandler(this.chkempleados_CheckedChanged);
            // 
            // chkroles
            // 
            this.chkroles.AutoSize = true;
            this.chkroles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkroles.Location = new System.Drawing.Point(205, 145);
            this.chkroles.Name = "chkroles";
            this.chkroles.Size = new System.Drawing.Size(61, 20);
            this.chkroles.TabIndex = 9;
            this.chkroles.Text = "Roles";
            this.chkroles.UseVisualStyleBackColor = true;
            this.chkroles.CheckedChanged += new System.EventHandler(this.chkroles_CheckedChanged);
            // 
            // chkcompras
            // 
            this.chkcompras.AutoSize = true;
            this.chkcompras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcompras.Location = new System.Drawing.Point(6, 145);
            this.chkcompras.Name = "chkcompras";
            this.chkcompras.Size = new System.Drawing.Size(121, 20);
            this.chkcompras.TabIndex = 8;
            this.chkcompras.Text = "Nueva compra";
            this.chkcompras.UseVisualStyleBackColor = true;
            this.chkcompras.CheckedChanged += new System.EventHandler(this.chkcompras_CheckedChanged);
            // 
            // chkventas
            // 
            this.chkventas.AutoSize = true;
            this.chkventas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkventas.Location = new System.Drawing.Point(6, 112);
            this.chkventas.Name = "chkventas";
            this.chkventas.Size = new System.Drawing.Size(111, 20);
            this.chkventas.TabIndex = 5;
            this.chkventas.Text = "Nueva venta";
            this.chkventas.UseVisualStyleBackColor = true;
            this.chkventas.CheckedChanged += new System.EventHandler(this.chkventas_CheckedChanged);
            // 
            // chkinventario
            // 
            this.chkinventario.AutoSize = true;
            this.chkinventario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkinventario.Location = new System.Drawing.Point(6, 96);
            this.chkinventario.Name = "chkinventario";
            this.chkinventario.Size = new System.Drawing.Size(94, 20);
            this.chkinventario.TabIndex = 7;
            this.chkinventario.Text = "Inventario";
            this.chkinventario.UseVisualStyleBackColor = true;
            this.chkinventario.CheckedChanged += new System.EventHandler(this.chkinventario_CheckedChanged);
            this.chkinventario.Click += new System.EventHandler(this.chkinventario_Click);
            // 
            // chkimpuestos
            // 
            this.chkimpuestos.AutoSize = true;
            this.chkimpuestos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkimpuestos.Location = new System.Drawing.Point(205, 162);
            this.chkimpuestos.Name = "chkimpuestos";
            this.chkimpuestos.Size = new System.Drawing.Size(95, 20);
            this.chkimpuestos.TabIndex = 13;
            this.chkimpuestos.Text = "Impuestos";
            this.chkimpuestos.UseVisualStyleBackColor = true;
            this.chkimpuestos.CheckedChanged += new System.EventHandler(this.chkimpuestos_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(-27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "______________________________________";
            // 
            // frmAgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 356);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRoles1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarRol";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarRol";
            this.Load += new System.EventHandler(this.frmAgregarRol_Load);
            this.gbRoles1.ResumeLayout(false);
            this.gbRoles2.ResumeLayout(false);
            this.gbRoles2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRoles1;
        private System.Windows.Forms.GroupBox gbRoles2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chksucursales;
        private System.Windows.Forms.CheckBox chkclientesProveedores;
        private System.Windows.Forms.CheckBox chkimpuestos;
        private System.Windows.Forms.CheckBox chkcargos;
        private System.Windows.Forms.CheckBox chkusuario;
        private System.Windows.Forms.CheckBox chkempleados;
        private System.Windows.Forms.CheckBox chkroles;
        private System.Windows.Forms.CheckBox chkcompras;
        private System.Windows.Forms.CheckBox chkventas;
        private System.Windows.Forms.CheckBox chkinventario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstpermisos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkselecionar;
        private System.Windows.Forms.CheckBox chklistar;
        private System.Windows.Forms.CheckBox chkDevoluciones;
    }
}