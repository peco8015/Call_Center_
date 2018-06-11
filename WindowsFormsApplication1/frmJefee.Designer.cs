namespace WindowsFormsApplication1
{
    partial class frmJefee
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.pnlFiltroFecha = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbAño = new System.Windows.Forms.CheckBox();
            this.cbMes = new System.Windows.Forms.CheckBox();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            this.tbCampaña = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnLlamados = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCampañas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnNewEmpleado = new System.Windows.Forms.Button();
            this.ucDatosUsuario1 = new WindowsFormsApplication1.ucDatosUsuario();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.pnlLista.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlFiltroFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Teal;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(23, 111);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(174, 55);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.pnlFiltros);
            this.pnlLista.Controls.Add(this.dgvTabla);
            this.pnlLista.Controls.Add(this.btnLlamados);
            this.pnlLista.Controls.Add(this.btnVentas);
            this.pnlLista.Controls.Add(this.btnCampañas);
            this.pnlLista.Controls.Add(this.btnClientes);
            this.pnlLista.Controls.Add(this.btnEmpleados);
            this.pnlLista.Location = new System.Drawing.Point(243, 12);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(1099, 692);
            this.pnlLista.TabIndex = 3;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.pnlFiltroFecha);
            this.pnlFiltros.Controls.Add(this.tbCampaña);
            this.pnlFiltros.Controls.Add(this.tbCliente);
            this.pnlFiltros.Controls.Add(this.tbNombre);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Controls.Add(this.label2);
            this.pnlFiltros.Controls.Add(this.label1);
            this.pnlFiltros.Controls.Add(this.pictureBox1);
            this.pnlFiltros.Location = new System.Drawing.Point(22, 91);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1054, 82);
            this.pnlFiltros.TabIndex = 6;
            // 
            // pnlFiltroFecha
            // 
            this.pnlFiltroFecha.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiltroFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltroFecha.Controls.Add(this.dtpFecha);
            this.pnlFiltroFecha.Controls.Add(this.cbAño);
            this.pnlFiltroFecha.Controls.Add(this.cbMes);
            this.pnlFiltroFecha.Controls.Add(this.cbFecha);
            this.pnlFiltroFecha.Location = new System.Drawing.Point(87, 8);
            this.pnlFiltroFecha.Name = "pnlFiltroFecha";
            this.pnlFiltroFecha.Size = new System.Drawing.Size(299, 65);
            this.pnlFiltroFecha.TabIndex = 13;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(28, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 23);
            this.dtpFecha.TabIndex = 12;
            this.dtpFecha.CloseUp += new System.EventHandler(this.dtpFecha_CloseUp);
            // 
            // cbAño
            // 
            this.cbAño.AutoSize = true;
            this.cbAño.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAño.Location = new System.Drawing.Point(218, 6);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(50, 21);
            this.cbAño.TabIndex = 8;
            this.cbAño.Tag = "año";
            this.cbAño.Text = "Año";
            this.cbAño.UseVisualStyleBackColor = true;
            this.cbAño.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // cbMes
            // 
            this.cbMes.AutoSize = true;
            this.cbMes.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.Location = new System.Drawing.Point(149, 6);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(50, 21);
            this.cbMes.TabIndex = 7;
            this.cbMes.Tag = "mes";
            this.cbMes.Text = "Mes";
            this.cbMes.UseVisualStyleBackColor = true;
            this.cbMes.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFecha.Location = new System.Drawing.Point(28, 6);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(102, 21);
            this.cbFecha.TabIndex = 6;
            this.cbFecha.Tag = "fecha";
            this.cbFecha.Text = "Fecha específ";
            this.cbFecha.UseVisualStyleBackColor = true;
            this.cbFecha.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // tbCampaña
            // 
            this.tbCampaña.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCampaña.Location = new System.Drawing.Point(803, 44);
            this.tbCampaña.Name = "tbCampaña";
            this.tbCampaña.Size = new System.Drawing.Size(226, 23);
            this.tbCampaña.TabIndex = 11;
            this.tbCampaña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyUp);
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(803, 14);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(226, 23);
            this.tbCliente.TabIndex = 10;
            this.tbCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyUp);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(440, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(244, 23);
            this.tbNombre.TabIndex = 9;
            this.tbNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Campaña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(22, 176);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(1054, 503);
            this.dgvTabla.TabIndex = 5;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbTabla_CellClick);
            // 
            // btnLlamados
            // 
            this.btnLlamados.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamados.Location = new System.Drawing.Point(807, 17);
            this.btnLlamados.Name = "btnLlamados";
            this.btnLlamados.Size = new System.Drawing.Size(133, 56);
            this.btnLlamados.TabIndex = 4;
            this.btnLlamados.Tag = "llamados";
            this.btnLlamados.Text = "Llamados";
            this.btnLlamados.UseVisualStyleBackColor = true;
            this.btnLlamados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(645, 17);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(133, 56);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Tag = "ventas";
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnCampañas
            // 
            this.btnCampañas.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampañas.Location = new System.Drawing.Point(483, 17);
            this.btnCampañas.Name = "btnCampañas";
            this.btnCampañas.Size = new System.Drawing.Size(133, 56);
            this.btnCampañas.TabIndex = 2;
            this.btnCampañas.Tag = "campañas";
            this.btnCampañas.Text = "Campañas";
            this.btnCampañas.UseVisualStyleBackColor = true;
            this.btnCampañas.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(321, 17);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(133, 56);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Tag = "clientes";
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(159, 17);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(133, 56);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Tag = "empleados";
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnNewEmpleado
            // 
            this.btnNewEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewEmpleado.Location = new System.Drawing.Point(23, 33);
            this.btnNewEmpleado.Name = "btnNewEmpleado";
            this.btnNewEmpleado.Size = new System.Drawing.Size(174, 55);
            this.btnNewEmpleado.TabIndex = 14;
            this.btnNewEmpleado.Text = "Nueva entidad";
            this.btnNewEmpleado.UseVisualStyleBackColor = true;
            this.btnNewEmpleado.Click += new System.EventHandler(this.btnNewEmpleado_Click);
            // 
            // ucDatosUsuario1
            // 
            this.ucDatosUsuario1.BackColor = System.Drawing.Color.White;
            this.ucDatosUsuario1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDatosUsuario1.D1 = 0;
            this.ucDatosUsuario1.D2 = 0;
            this.ucDatosUsuario1.Dni = 0;
            this.ucDatosUsuario1.EsJefe = false;
            this.ucDatosUsuario1.InicioSesion = System.TimeSpan.Parse("00:00:00");
            this.ucDatosUsuario1.Location = new System.Drawing.Point(25, 1);
            this.ucDatosUsuario1.Name = "ucDatosUsuario1";
            this.ucDatosUsuario1.NombreCompleto = null;
            this.ucDatosUsuario1.Size = new System.Drawing.Size(189, 498);
            this.ucDatosUsuario1.TabIndex = 0;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnNewEmpleado);
            this.gbOpciones.Controls.Add(this.btnSalir);
            this.gbOpciones.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOpciones.Location = new System.Drawing.Point(9, 505);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(220, 199);
            this.gbOpciones.TabIndex = 15;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // frmJefee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1354, 716);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.ucDatosUsuario1);
            this.Name = "frmJefee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jefe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJefee_Load);
            this.pnlLista.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlFiltroFecha.ResumeLayout(false);
            this.pnlFiltroFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucDatosUsuario ucDatosUsuario1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnLlamados;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCampañas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbCampaña;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.CheckBox cbAño;
        private System.Windows.Forms.CheckBox cbMes;
        private System.Windows.Forms.CheckBox cbFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFiltroFecha;
        private System.Windows.Forms.Button btnNewEmpleado;
        private System.Windows.Forms.GroupBox gbOpciones;
    }
}