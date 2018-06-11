namespace WindowsFormsApplication1
{
    partial class frmDetalles
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtp02 = new System.Windows.Forms.DateTimePicker();
            this.tb07 = new System.Windows.Forms.TextBox();
            this.tb06 = new System.Windows.Forms.TextBox();
            this.tb05 = new System.Windows.Forms.TextBox();
            this.tb04 = new System.Windows.Forms.TextBox();
            this.tb03 = new System.Windows.Forms.TextBox();
            this.tb02 = new System.Windows.Forms.TextBox();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.dtp01 = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.pnlEstadisticas = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tcFechas = new System.Windows.Forms.TabControl();
            this.tpHoy = new System.Windows.Forms.TabPage();
            this.cVentasCampaña = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cPorcentajeVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpSemana = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInformacion.SuspendLayout();
            this.pnlEstadisticas.SuspendLayout();
            this.tcFechas.SuspendLayout();
            this.tpHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cVentasCampaña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPorcentajeVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "# [ID] - [Nombre]";
            // 
            // gbInformacion
            // 
            this.gbInformacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbInformacion.Controls.Add(this.label5);
            this.gbInformacion.Controls.Add(this.btnEliminar);
            this.gbInformacion.Controls.Add(this.dtp02);
            this.gbInformacion.Controls.Add(this.tb07);
            this.gbInformacion.Controls.Add(this.tb06);
            this.gbInformacion.Controls.Add(this.tb05);
            this.gbInformacion.Controls.Add(this.tb04);
            this.gbInformacion.Controls.Add(this.tb03);
            this.gbInformacion.Controls.Add(this.tb02);
            this.gbInformacion.Controls.Add(this.tb01);
            this.gbInformacion.Controls.Add(this.dtp01);
            this.gbInformacion.Controls.Add(this.btnEditar);
            this.gbInformacion.Controls.Add(this.label11);
            this.gbInformacion.Controls.Add(this.label10);
            this.gbInformacion.Controls.Add(this.label8);
            this.gbInformacion.Controls.Add(this.label7);
            this.gbInformacion.Controls.Add(this.label6);
            this.gbInformacion.Controls.Add(this.label9);
            this.gbInformacion.Controls.Add(this.label4);
            this.gbInformacion.Controls.Add(this.label3);
            this.gbInformacion.Controls.Add(this.gbContacto);
            this.gbInformacion.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacion.Location = new System.Drawing.Point(21, 62);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(356, 545);
            this.gbInformacion.TabIndex = 2;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Información";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "DNI";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(225, 477);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 47);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtp02
            // 
            this.dtp02.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp02.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp02.Location = new System.Drawing.Point(149, 332);
            this.dtp02.Name = "dtp02";
            this.dtp02.Size = new System.Drawing.Size(196, 27);
            this.dtp02.TabIndex = 18;
            // 
            // tb07
            // 
            this.tb07.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb07.Location = new System.Drawing.Point(149, 374);
            this.tb07.Multiline = true;
            this.tb07.Name = "tb07";
            this.tb07.Size = new System.Drawing.Size(196, 91);
            this.tb07.TabIndex = 17;
            // 
            // tb06
            // 
            this.tb06.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb06.Location = new System.Drawing.Point(123, 248);
            this.tb06.Name = "tb06";
            this.tb06.Size = new System.Drawing.Size(219, 27);
            this.tb06.TabIndex = 16;
            // 
            // tb05
            // 
            this.tb05.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb05.Location = new System.Drawing.Point(123, 205);
            this.tb05.Name = "tb05";
            this.tb05.Size = new System.Drawing.Size(219, 27);
            this.tb05.TabIndex = 15;
            // 
            // tb04
            // 
            this.tb04.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb04.Location = new System.Drawing.Point(123, 162);
            this.tb04.Name = "tb04";
            this.tb04.Size = new System.Drawing.Size(219, 27);
            this.tb04.TabIndex = 14;
            // 
            // tb03
            // 
            this.tb03.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb03.Location = new System.Drawing.Point(123, 119);
            this.tb03.Name = "tb03";
            this.tb03.Size = new System.Drawing.Size(219, 27);
            this.tb03.TabIndex = 13;
            // 
            // tb02
            // 
            this.tb02.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb02.Location = new System.Drawing.Point(123, 76);
            this.tb02.Name = "tb02";
            this.tb02.Size = new System.Drawing.Size(219, 27);
            this.tb02.TabIndex = 12;
            // 
            // tb01
            // 
            this.tb01.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb01.Location = new System.Drawing.Point(123, 33);
            this.tb01.Name = "tb01";
            this.tb01.Size = new System.Drawing.Size(219, 27);
            this.tb01.TabIndex = 11;
            // 
            // dtp01
            // 
            this.dtp01.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp01.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp01.Location = new System.Drawing.Point(149, 290);
            this.dtp01.Name = "dtp01";
            this.dtp01.Size = new System.Drawing.Size(193, 27);
            this.dtp01.TabIndex = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(36, 477);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 47);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Campaña actual";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fecha de ingreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // gbContacto
            // 
            this.gbContacto.BackColor = System.Drawing.Color.Transparent;
            this.gbContacto.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContacto.Location = new System.Drawing.Point(6, 145);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(344, 139);
            this.gbContacto.TabIndex = 20;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // pnlEstadisticas
            // 
            this.pnlEstadisticas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEstadisticas.Controls.Add(this.tcFechas);
            this.pnlEstadisticas.Controls.Add(this.label2);
            this.pnlEstadisticas.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstadisticas.Location = new System.Drawing.Point(397, 62);
            this.pnlEstadisticas.Name = "pnlEstadisticas";
            this.pnlEstadisticas.Size = new System.Drawing.Size(777, 545);
            this.pnlEstadisticas.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hoy",
            "Semana",
            "Mes"});
            this.comboBox1.Location = new System.Drawing.Point(508, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 25);
            this.comboBox1.TabIndex = 2;
            // 
            // tcFechas
            // 
            this.tcFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcFechas.Controls.Add(this.tpHoy);
            this.tcFechas.Controls.Add(this.tpSemana);
            this.tcFechas.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcFechas.Location = new System.Drawing.Point(23, 41);
            this.tcFechas.Name = "tcFechas";
            this.tcFechas.SelectedIndex = 0;
            this.tcFechas.Size = new System.Drawing.Size(733, 494);
            this.tcFechas.TabIndex = 1;
            this.tcFechas.SelectedIndexChanged += new System.EventHandler(this.tcFechas_SelectedIndexChanged);
            // 
            // tpHoy
            // 
            this.tpHoy.Controls.Add(this.comboBox1);
            this.tpHoy.Controls.Add(this.cVentasCampaña);
            this.tpHoy.Controls.Add(this.cPorcentajeVentas);
            this.tpHoy.Controls.Add(this.cTiempos);
            this.tpHoy.Location = new System.Drawing.Point(4, 28);
            this.tpHoy.Name = "tpHoy";
            this.tpHoy.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoy.Size = new System.Drawing.Size(725, 462);
            this.tpHoy.TabIndex = 0;
            this.tpHoy.Text = "Hoy";
            this.tpHoy.UseVisualStyleBackColor = true;
            // 
            // cVentasCampaña
            // 
            chartArea1.Name = "ChartArea1";
            this.cVentasCampaña.ChartAreas.Add(chartArea1);
            this.cVentasCampaña.Location = new System.Drawing.Point(13, 9);
            this.cVentasCampaña.Name = "cVentasCampaña";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            series1.Legend = "Legend1";
            series1.Name = "Campañas";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.cVentasCampaña.Series.Add(series1);
            this.cVentasCampaña.Size = new System.Drawing.Size(391, 201);
            this.cVentasCampaña.TabIndex = 2;
            this.cVentasCampaña.Text = "Ventas por Campaña";
            title1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Ventas por Campaña";
            this.cVentasCampaña.Titles.Add(title1);
            // 
            // cPorcentajeVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.cPorcentajeVentas.ChartAreas.Add(chartArea2);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            this.cPorcentajeVentas.Legends.Add(legend1);
            this.cPorcentajeVentas.Location = new System.Drawing.Point(410, 216);
            this.cPorcentajeVentas.Name = "cPorcentajeVentas";
            this.cPorcentajeVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            this.cPorcentajeVentas.Series.Add(series2);
            this.cPorcentajeVentas.Size = new System.Drawing.Size(307, 236);
            this.cPorcentajeVentas.TabIndex = 1;
            this.cPorcentajeVentas.Text = "Porcentaje de Ventas";
            title2.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title01";
            title2.Text = "% Ventas";
            this.cPorcentajeVentas.Titles.Add(title2);
            // 
            // cTiempos
            // 
            this.cTiempos.BorderlineColor = System.Drawing.Color.Black;
            this.cTiempos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "ChartArea1";
            this.cTiempos.ChartAreas.Add(chartArea3);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            this.cTiempos.Legends.Add(legend2);
            this.cTiempos.Location = new System.Drawing.Point(13, 216);
            this.cTiempos.Name = "cTiempos";
            this.cTiempos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            series3.Legend = "Legend1";
            series3.Name = "Productivo";
            series3.Points.Add(dataPoint3);
            series3.Points.Add(dataPoint4);
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Improductivo";
            this.cTiempos.Series.Add(series3);
            this.cTiempos.Series.Add(series4);
            this.cTiempos.Size = new System.Drawing.Size(391, 236);
            this.cTiempos.TabIndex = 0;
            this.cTiempos.Text = "Detalle de Tiempos";
            title3.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title01";
            title3.Text = "Detalle de Tiempos";
            this.cTiempos.Titles.Add(title3);
            // 
            // tpSemana
            // 
            this.tpSemana.Location = new System.Drawing.Point(4, 28);
            this.tpSemana.Name = "tpSemana";
            this.tpSemana.Padding = new System.Windows.Forms.Padding(3);
            this.tpSemana.Size = new System.Drawing.Size(725, 462);
            this.tpSemana.TabIndex = 1;
            this.tpSemana.Text = "Semana";
            this.tpSemana.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estadísticas y números";
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1194, 627);
            this.Controls.Add(this.pnlEstadisticas);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.label1);
            this.Name = "frmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles [tipo]";
            this.Load += new System.EventHandler(this.frmDetalles_Load);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.pnlEstadisticas.ResumeLayout(false);
            this.pnlEstadisticas.PerformLayout();
            this.tcFechas.ResumeLayout(false);
            this.tpHoy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cVentasCampaña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPorcentajeVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Panel pnlEstadisticas;
        private System.Windows.Forms.TabControl tcFechas;
        private System.Windows.Forms.TabPage tpHoy;
        private System.Windows.Forms.TabPage tpSemana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cTiempos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataVisualization.Charting.Chart cPorcentajeVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart cVentasCampaña;
        private System.Windows.Forms.DateTimePicker dtp02;
        private System.Windows.Forms.TextBox tb07;
        private System.Windows.Forms.TextBox tb06;
        private System.Windows.Forms.TextBox tb05;
        private System.Windows.Forms.TextBox tb04;
        private System.Windows.Forms.TextBox tb03;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.DateTimePicker dtp01;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbContacto;
    }
}