﻿namespace WindowsFormsApplication1
{
    partial class frmEmpleadoCampaña
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEmp = new System.Windows.Forms.Label();
            this.cTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcamp2 = new System.Windows.Forms.Label();
            this.lbcamp = new System.Windows.Forms.Label();
            this.cPorcentajeVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb01 = new System.Windows.Forms.GroupBox();
            this.lblInfo04 = new System.Windows.Forms.Label();
            this.lblInfo03 = new System.Windows.Forms.Label();
            this.lblInfo02 = new System.Windows.Forms.Label();
            this.lblInfo01 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTiempos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPorcentajeVentas)).BeginInit();
            this.gb01.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbEmp);
            this.panel1.Controls.Add(this.cTiempos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(535, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 729);
            this.panel1.TabIndex = 0;
            // 
            // lbEmp
            // 
            this.lbEmp.AutoSize = true;
            this.lbEmp.Font = new System.Drawing.Font("Microsoft YaHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp.Location = new System.Drawing.Point(20, 35);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(137, 35);
            this.lbEmp.TabIndex = 26;
            this.lbEmp.Text = "empleado";
            this.lbEmp.Click += new System.EventHandler(this.lbEmp_Click);
            // 
            // cTiempos
            // 
            this.cTiempos.BorderlineColor = System.Drawing.Color.Black;
            this.cTiempos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.cTiempos.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            this.cTiempos.Legends.Add(legend1);
            this.cTiempos.Location = new System.Drawing.Point(98, 144);
            this.cTiempos.Name = "cTiempos";
            this.cTiempos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            series1.Legend = "Legend1";
            series1.Name = "tiempos";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.cTiempos.Series.Add(series1);
            this.cTiempos.Size = new System.Drawing.Size(601, 562);
            this.cTiempos.TabIndex = 1;
            this.cTiempos.Text = "Detalle de Tiempos";
            title1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Tiempos";
            title1.Text = "Detalle de Tiempos";
            this.cTiempos.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbcamp2);
            this.panel2.Controls.Add(this.lbcamp);
            this.panel2.Controls.Add(this.cPorcentajeVentas);
            this.panel2.Controls.Add(this.gb01);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 729);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(107, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 39);
            this.panel3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultados de Llamadas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbcamp2
            // 
            this.lbcamp2.AutoSize = true;
            this.lbcamp2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcamp2.Location = new System.Drawing.Point(71, 66);
            this.lbcamp2.Name = "lbcamp2";
            this.lbcamp2.Size = new System.Drawing.Size(58, 21);
            this.lbcamp2.TabIndex = 26;
            this.lbcamp2.Text = "cliente";
            // 
            // lbcamp
            // 
            this.lbcamp.AutoSize = true;
            this.lbcamp.Font = new System.Drawing.Font("Microsoft YaHei Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcamp.Location = new System.Drawing.Point(71, 35);
            this.lbcamp.Name = "lbcamp";
            this.lbcamp.Size = new System.Drawing.Size(126, 35);
            this.lbcamp.TabIndex = 25;
            this.lbcamp.Text = "campaña";
            // 
            // cPorcentajeVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.cPorcentajeVentas.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            this.cPorcentajeVentas.Legends.Add(legend2);
            this.cPorcentajeVentas.Location = new System.Drawing.Point(75, 371);
            this.cPorcentajeVentas.Name = "cPorcentajeVentas";
            this.cPorcentajeVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            this.cPorcentajeVentas.Series.Add(series2);
            this.cPorcentajeVentas.Size = new System.Drawing.Size(395, 335);
            this.cPorcentajeVentas.TabIndex = 24;
            this.cPorcentajeVentas.Text = "Porcentaje de Ventas";
            title2.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title01";
            title2.Text = "% Ventas";
            this.cPorcentajeVentas.Titles.Add(title2);
            // 
            // gb01
            // 
            this.gb01.BackColor = System.Drawing.Color.Transparent;
            this.gb01.Controls.Add(this.lblInfo04);
            this.gb01.Controls.Add(this.lblInfo03);
            this.gb01.Controls.Add(this.lblInfo02);
            this.gb01.Controls.Add(this.lblInfo01);
            this.gb01.Controls.Add(this.label21);
            this.gb01.Controls.Add(this.label19);
            this.gb01.Controls.Add(this.label18);
            this.gb01.Controls.Add(this.label17);
            this.gb01.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb01.Location = new System.Drawing.Point(75, 144);
            this.gb01.Name = "gb01";
            this.gb01.Size = new System.Drawing.Size(440, 219);
            this.gb01.TabIndex = 23;
            this.gb01.TabStop = false;
            this.gb01.Text = "Números";
            // 
            // lblInfo04
            // 
            this.lblInfo04.AutoSize = true;
            this.lblInfo04.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo04.Location = new System.Drawing.Point(222, 104);
            this.lblInfo04.Name = "lblInfo04";
            this.lblInfo04.Size = new System.Drawing.Size(14, 20);
            this.lblInfo04.TabIndex = 11;
            this.lblInfo04.Text = "1";
            // 
            // lblInfo03
            // 
            this.lblInfo03.AutoSize = true;
            this.lblInfo03.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo03.Location = new System.Drawing.Point(222, 74);
            this.lblInfo03.Name = "lblInfo03";
            this.lblInfo03.Size = new System.Drawing.Size(14, 20);
            this.lblInfo03.TabIndex = 10;
            this.lblInfo03.Text = "1";
            // 
            // lblInfo02
            // 
            this.lblInfo02.AutoSize = true;
            this.lblInfo02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo02.Location = new System.Drawing.Point(223, 138);
            this.lblInfo02.Name = "lblInfo02";
            this.lblInfo02.Size = new System.Drawing.Size(14, 20);
            this.lblInfo02.TabIndex = 9;
            this.lblInfo02.Text = "1";
            // 
            // lblInfo01
            // 
            this.lblInfo01.AutoSize = true;
            this.lblInfo01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo01.Location = new System.Drawing.Point(222, 41);
            this.lblInfo01.Name = "lblInfo01";
            this.lblInfo01.Size = new System.Drawing.Size(14, 20);
            this.lblInfo01.TabIndex = 8;
            this.lblInfo01.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(59, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 20);
            this.label21.TabIndex = 7;
            this.label21.Text = "Tiempo productivo:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(40, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Cant Ventas realizadas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(40, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Tiempo Improductivo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(90, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cant Llamadas:";
            // 
            // frmEpleadoCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEpleadoCampaña";
            this.Text = "frmEpleadoCampaña";
            this.Load += new System.EventHandler(this.frmEpleadoCampaña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTiempos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPorcentajeVentas)).EndInit();
            this.gb01.ResumeLayout(false);
            this.gb01.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cTiempos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gb01;
        private System.Windows.Forms.Label lblInfo04;
        private System.Windows.Forms.Label lblInfo03;
        private System.Windows.Forms.Label lblInfo02;
        private System.Windows.Forms.Label lblInfo01;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart cPorcentajeVentas;
        private System.Windows.Forms.Label lbcamp;
        private System.Windows.Forms.Label lbcamp2;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}