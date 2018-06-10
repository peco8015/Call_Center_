namespace WindowsFormsApplication1
{
    partial class frmJefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJefe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDatosUser1 = new WindowsFormsApplication1.UcDatosUser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCantVentas = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.brReporteVenta = new System.Windows.Forms.Button();
            this.lbTotalVentas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBtVentas = new System.Windows.Forms.Panel();
            this.btVentas = new System.Windows.Forms.Button();
            this.pnlBtEMpl = new System.Windows.Forms.Panel();
            this.btEmpleados = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.btllamadas = new System.Windows.Forms.Button();
            this.btCampaña = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.cbañoo = new System.Windows.Forms.CheckBox();
            this.cbmess = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreE = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.cbChekedFecha = new System.Windows.Forms.CheckBox();
            this.dtFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.tbemplleadoV = new System.Windows.Forms.TextBox();
            this.tbCampaña = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlBuscarEmpleado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbBusqPersona = new System.Windows.Forms.TextBox();
            this.dgvbTabla = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlCantVentas.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlBtVentas.SuspendLayout();
            this.pnlBtEMpl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlBuscarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.btSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ucDatosUser1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 100);
            this.panel1.TabIndex = 1;
            // 
            // btSalir
            // 
            this.btSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalir.BackgroundImage")));
            this.btSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.Red;
            this.btSalir.Location = new System.Drawing.Point(1266, 0);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(88, 100);
            this.btSalir.TabIndex = 5;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ucDatosUser1
            // 
            this.ucDatosUser1.Apellidos = null;
            this.ucDatosUser1.Dni = 0;
            this.ucDatosUser1.Hora = null;
            this.ucDatosUser1.Hoy = null;
            this.ucDatosUser1.Location = new System.Drawing.Point(294, -3);
            this.ucDatosUser1.Name = "ucDatosUser1";
            this.ucDatosUser1.Nombre = null;
            this.ucDatosUser1.Size = new System.Drawing.Size(684, 103);
            this.ucDatosUser1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.pnlCantVentas);
            this.panel2.Controls.Add(this.pnlBtVentas);
            this.panel2.Controls.Add(this.pnlBtEMpl);
            this.panel2.Controls.Add(this.btClientes);
            this.panel2.Controls.Add(this.btllamadas);
            this.panel2.Controls.Add(this.btCampaña);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 617);
            this.panel2.TabIndex = 2;
            // 
            // pnlCantVentas
            // 
            this.pnlCantVentas.BackColor = System.Drawing.Color.Red;
            this.pnlCantVentas.Controls.Add(this.panel4);
            this.pnlCantVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCantVentas.Location = new System.Drawing.Point(0, 464);
            this.pnlCantVentas.Name = "pnlCantVentas";
            this.pnlCantVentas.Size = new System.Drawing.Size(246, 153);
            this.pnlCantVentas.TabIndex = 6;
            this.pnlCantVentas.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel4.Controls.Add(this.brReporteVenta);
            this.panel4.Controls.Add(this.lbTotalVentas);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 147);
            this.panel4.TabIndex = 0;
            // 
            // brReporteVenta
            // 
            this.brReporteVenta.Location = new System.Drawing.Point(42, 103);
            this.brReporteVenta.Name = "brReporteVenta";
            this.brReporteVenta.Size = new System.Drawing.Size(130, 35);
            this.brReporteVenta.TabIndex = 7;
            this.brReporteVenta.Text = "Generar Reporte";
            this.brReporteVenta.UseVisualStyleBackColor = true;
            // 
            // lbTotalVentas
            // 
            this.lbTotalVentas.AutoSize = true;
            this.lbTotalVentas.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalVentas.ForeColor = System.Drawing.Color.Red;
            this.lbTotalVentas.Location = new System.Drawing.Point(100, 70);
            this.lbTotalVentas.Name = "lbTotalVentas";
            this.lbTotalVentas.Size = new System.Drawing.Size(20, 19);
            this.lbTotalVentas.TabIndex = 1;
            this.lbTotalVentas.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Ventas ";
            // 
            // pnlBtVentas
            // 
            this.pnlBtVentas.Controls.Add(this.btVentas);
            this.pnlBtVentas.Location = new System.Drawing.Point(0, 86);
            this.pnlBtVentas.Name = "pnlBtVentas";
            this.pnlBtVentas.Size = new System.Drawing.Size(246, 74);
            this.pnlBtVentas.TabIndex = 5;
            // 
            // btVentas
            // 
            this.btVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btVentas.Location = new System.Drawing.Point(78, 28);
            this.btVentas.Name = "btVentas";
            this.btVentas.Size = new System.Drawing.Size(75, 23);
            this.btVentas.TabIndex = 1;
            this.btVentas.Text = "Ventas";
            this.btVentas.UseVisualStyleBackColor = true;
            this.btVentas.Click += new System.EventHandler(this.btVentas_Click);
            // 
            // pnlBtEMpl
            // 
            this.pnlBtEMpl.Controls.Add(this.btEmpleados);
            this.pnlBtEMpl.Location = new System.Drawing.Point(0, 6);
            this.pnlBtEMpl.Name = "pnlBtEMpl";
            this.pnlBtEMpl.Size = new System.Drawing.Size(243, 74);
            this.pnlBtEMpl.TabIndex = 5;
            // 
            // btEmpleados
            // 
            this.btEmpleados.Location = new System.Drawing.Point(78, 27);
            this.btEmpleados.Name = "btEmpleados";
            this.btEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btEmpleados.TabIndex = 0;
            this.btEmpleados.Text = "empleados";
            this.btEmpleados.UseVisualStyleBackColor = true;
            this.btEmpleados.Click += new System.EventHandler(this.btEmpleados_Click);
            // 
            // btClientes
            // 
            this.btClientes.Location = new System.Drawing.Point(88, 383);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(75, 23);
            this.btClientes.TabIndex = 4;
            this.btClientes.Text = "clientes";
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btllamadas
            // 
            this.btllamadas.Location = new System.Drawing.Point(88, 314);
            this.btllamadas.Name = "btllamadas";
            this.btllamadas.Size = new System.Drawing.Size(75, 23);
            this.btllamadas.TabIndex = 3;
            this.btllamadas.Text = "Llamadas";
            this.btllamadas.UseVisualStyleBackColor = true;
            this.btllamadas.Click += new System.EventHandler(this.btllamadas_Click);
            // 
            // btCampaña
            // 
            this.btCampaña.Location = new System.Drawing.Point(88, 242);
            this.btCampaña.Name = "btCampaña";
            this.btCampaña.Size = new System.Drawing.Size(75, 23);
            this.btCampaña.TabIndex = 2;
            this.btCampaña.Text = "Campañas";
            this.btCampaña.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.pnlVentas);
            this.panel3.Controls.Add(this.pnlBuscarEmpleado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(246, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 80);
            this.panel3.TabIndex = 3;
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlVentas.Controls.Add(this.cbañoo);
            this.pnlVentas.Controls.Add(this.cbmess);
            this.pnlVentas.Controls.Add(this.label2);
            this.pnlVentas.Controls.Add(this.tbNombreE);
            this.pnlVentas.Controls.Add(this.Apellido);
            this.pnlVentas.Controls.Add(this.label1);
            this.pnlVentas.Controls.Add(this.Cliente);
            this.pnlVentas.Controls.Add(this.cbChekedFecha);
            this.pnlVentas.Controls.Add(this.dtFechaVenta);
            this.pnlVentas.Controls.Add(this.tbemplleadoV);
            this.pnlVentas.Controls.Add(this.tbCampaña);
            this.pnlVentas.Controls.Add(this.tbCliente);
            this.pnlVentas.Controls.Add(this.cbAño);
            this.pnlVentas.Controls.Add(this.cbMes);
            this.pnlVentas.Controls.Add(this.pictureBox3);
            this.pnlVentas.Location = new System.Drawing.Point(26, 0);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(1078, 80);
            this.pnlVentas.TabIndex = 2;
            this.pnlVentas.Visible = false;
            // 
            // cbañoo
            // 
            this.cbañoo.AutoSize = true;
            this.cbañoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbañoo.ForeColor = System.Drawing.Color.White;
            this.cbañoo.Location = new System.Drawing.Point(417, 12);
            this.cbañoo.Name = "cbañoo";
            this.cbañoo.Size = new System.Drawing.Size(57, 24);
            this.cbañoo.TabIndex = 18;
            this.cbañoo.Text = "Año";
            this.cbañoo.UseVisualStyleBackColor = true;
            this.cbañoo.CheckedChanged += new System.EventHandler(this.cbañoo_CheckedChanged);
            // 
            // cbmess
            // 
            this.cbmess.AutoSize = true;
            this.cbmess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmess.ForeColor = System.Drawing.Color.White;
            this.cbmess.Location = new System.Drawing.Point(298, 13);
            this.cbmess.Name = "cbmess";
            this.cbmess.Size = new System.Drawing.Size(58, 24);
            this.cbmess.TabIndex = 17;
            this.cbmess.Text = "Mes";
            this.cbmess.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(945, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // tbNombreE
            // 
            this.tbNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreE.ForeColor = System.Drawing.Color.Gray;
            this.tbNombreE.Location = new System.Drawing.Point(949, 39);
            this.tbNombreE.Name = "tbNombreE";
            this.tbNombreE.Size = new System.Drawing.Size(111, 29);
            this.tbNombreE.TabIndex = 15;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.Apellido.Location = new System.Drawing.Point(828, 18);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(65, 20);
            this.Apellido.TabIndex = 14;
            this.Apellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(679, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Campaña";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.SystemColors.Control;
            this.Cliente.Location = new System.Drawing.Point(544, 17);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(58, 20);
            this.Cliente.TabIndex = 12;
            this.Cliente.Text = "Cliente";
            // 
            // cbChekedFecha
            // 
            this.cbChekedFecha.AutoSize = true;
            this.cbChekedFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChekedFecha.ForeColor = System.Drawing.Color.White;
            this.cbChekedFecha.Location = new System.Drawing.Point(127, 12);
            this.cbChekedFecha.Name = "cbChekedFecha";
            this.cbChekedFecha.Size = new System.Drawing.Size(154, 24);
            this.cbChekedFecha.TabIndex = 11;
            this.cbChekedFecha.Text = "Fecha  Específica";
            this.cbChekedFecha.UseVisualStyleBackColor = true;
            this.cbChekedFecha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtFechaVenta
            // 
            this.dtFechaVenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaVenta.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtFechaVenta.CalendarTitleForeColor = System.Drawing.SystemColors.InfoText;
            this.dtFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVenta.Location = new System.Drawing.Point(127, 42);
            this.dtFechaVenta.Name = "dtFechaVenta";
            this.dtFechaVenta.Size = new System.Drawing.Size(154, 26);
            this.dtFechaVenta.TabIndex = 10;
            this.dtFechaVenta.Value = new System.DateTime(2017, 12, 9, 0, 0, 0, 0);
            this.dtFechaVenta.Visible = false;
            this.dtFechaVenta.CloseUp += new System.EventHandler(this.dtFechaVenta_CloseUp);
            this.dtFechaVenta.DropDown += new System.EventHandler(this.dtFechaVenta_DropDown);
            // 
            // tbemplleadoV
            // 
            this.tbemplleadoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemplleadoV.ForeColor = System.Drawing.Color.Gray;
            this.tbemplleadoV.Location = new System.Drawing.Point(832, 39);
            this.tbemplleadoV.Name = "tbemplleadoV";
            this.tbemplleadoV.Size = new System.Drawing.Size(111, 29);
            this.tbemplleadoV.TabIndex = 9;
            // 
            // tbCampaña
            // 
            this.tbCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCampaña.ForeColor = System.Drawing.Color.Gray;
            this.tbCampaña.Location = new System.Drawing.Point(683, 39);
            this.tbCampaña.Name = "tbCampaña";
            this.tbCampaña.Size = new System.Drawing.Size(129, 29);
            this.tbCampaña.TabIndex = 8;
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.ForeColor = System.Drawing.Color.Gray;
            this.tbCliente.Location = new System.Drawing.Point(548, 40);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(129, 29);
            this.tbCliente.TabIndex = 7;
            // 
            // cbAño
            // 
            this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAño.ForeColor = System.Drawing.Color.Gray;
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2015",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbAño.Location = new System.Drawing.Point(417, 40);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(81, 28);
            this.cbAño.TabIndex = 5;
            this.cbAño.Visible = false;
            // 
            // cbMes
            // 
            this.cbMes.DisplayMember = "es|";
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.ForeColor = System.Drawing.Color.Gray;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiempre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(298, 40);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(113, 28);
            this.cbMes.TabIndex = 3;
            this.cbMes.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pnlBuscarEmpleado
            // 
            this.pnlBuscarEmpleado.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlBuscarEmpleado.Controls.Add(this.pictureBox2);
            this.pnlBuscarEmpleado.Controls.Add(this.tbBusqPersona);
            this.pnlBuscarEmpleado.Location = new System.Drawing.Point(26, 6);
            this.pnlBuscarEmpleado.Name = "pnlBuscarEmpleado";
            this.pnlBuscarEmpleado.Size = new System.Drawing.Size(946, 71);
            this.pnlBuscarEmpleado.TabIndex = 0;
            this.pnlBuscarEmpleado.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbBusqPersona
            // 
            this.tbBusqPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqPersona.Location = new System.Drawing.Point(127, 27);
            this.tbBusqPersona.Name = "tbBusqPersona";
            this.tbBusqPersona.Size = new System.Drawing.Size(256, 31);
            this.tbBusqPersona.TabIndex = 0;
            this.tbBusqPersona.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBusqPersona_KeyUp);
            // 
            // dgvbTabla
            // 
            this.dgvbTabla.AllowUserToAddRows = false;
            this.dgvbTabla.AllowUserToDeleteRows = false;
            this.dgvbTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbTabla.Location = new System.Drawing.Point(252, 186);
            this.dgvbTabla.Name = "dgvbTabla";
            this.dgvbTabla.ReadOnly = true;
            this.dgvbTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbTabla.Size = new System.Drawing.Size(1098, 519);
            this.dgvbTabla.TabIndex = 4;
            this.dgvbTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbTabla_CellClick);
            // 
            // frmJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 717);
            this.Controls.Add(this.dgvbTabla);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmJefe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jefe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJefe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlCantVentas.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlBtVentas.ResumeLayout(false);
            this.pnlBtEMpl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlBuscarEmpleado.ResumeLayout(false);
            this.pnlBuscarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcDatosUser ucDatosUser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btllamadas;
        private System.Windows.Forms.Button btCampaña;
        private System.Windows.Forms.Button btVentas;
        private System.Windows.Forms.Button btEmpleados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvbTabla;
        private System.Windows.Forms.Panel pnlBuscarEmpleado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbBusqPersona;
        private System.Windows.Forms.Panel pnlBtEMpl;
        private System.Windows.Forms.Panel pnlBtVentas;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbemplleadoV;
        private System.Windows.Forms.TextBox tbCampaña;
        private System.Windows.Forms.DateTimePicker dtFechaVenta;
        internal System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.CheckBox cbChekedFecha;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreE;
        private System.Windows.Forms.CheckBox cbañoo;
        private System.Windows.Forms.CheckBox cbmess;
        private System.Windows.Forms.Panel pnlCantVentas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button brReporteVenta;
        private System.Windows.Forms.Label lbTotalVentas;
        private System.Windows.Forms.Label label3;
    }
}