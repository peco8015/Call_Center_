namespace WindowsFormsApplication1
{
    partial class frmEpleadoCampaña
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gb01 = new System.Windows.Forms.GroupBox();
            this.lblInfo04 = new System.Windows.Forms.Label();
            this.lblInfo03 = new System.Windows.Forms.Label();
            this.lblInfo02 = new System.Windows.Forms.Label();
            this.lblInfo01 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cPorcentajeVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTiempos)).BeginInit();
            this.panel2.SuspendLayout();
            this.gb01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPorcentajeVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cTiempos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(549, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 729);
            this.panel1.TabIndex = 0;
            // 
            // cTiempos
            // 
            this.cTiempos.BorderlineColor = System.Drawing.Color.Black;
            this.cTiempos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "ChartArea1";
            this.cTiempos.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            this.cTiempos.Legends.Add(legend3);
            this.cTiempos.Location = new System.Drawing.Point(98, 35);
            this.cTiempos.Name = "cTiempos";
            this.cTiempos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            series4.Legend = "Legend1";
            series4.Name = "tiempos";
            series4.Points.Add(dataPoint3);
            series4.Points.Add(dataPoint4);
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.Name = "Improductivo";
            this.cTiempos.Series.Add(series4);
            this.cTiempos.Series.Add(series5);
            this.cTiempos.Size = new System.Drawing.Size(601, 671);
            this.cTiempos.TabIndex = 1;
            this.cTiempos.Text = "Detalle de Tiempos";
            title3.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            title3.Name = "Tiempos";
            title3.Text = "Detalle de Tiempos";
            this.cTiempos.Titles.Add(title3);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cPorcentajeVentas);
            this.panel2.Controls.Add(this.gb01);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 729);
            this.panel2.TabIndex = 1;
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
            this.gb01.Size = new System.Drawing.Size(305, 219);
            this.gb01.TabIndex = 23;
            this.gb01.TabStop = false;
            this.gb01.Text = "Números";
            // 
            // lblInfo04
            // 
            this.lblInfo04.AutoSize = true;
            this.lblInfo04.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo04.Location = new System.Drawing.Point(222, 158);
            this.lblInfo04.Name = "lblInfo04";
            this.lblInfo04.Size = new System.Drawing.Size(14, 20);
            this.lblInfo04.TabIndex = 11;
            this.lblInfo04.Text = "1";
            // 
            // lblInfo03
            // 
            this.lblInfo03.AutoSize = true;
            this.lblInfo03.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo03.Location = new System.Drawing.Point(222, 119);
            this.lblInfo03.Name = "lblInfo03";
            this.lblInfo03.Size = new System.Drawing.Size(14, 20);
            this.lblInfo03.TabIndex = 10;
            this.lblInfo03.Text = "1";
            // 
            // lblInfo02
            // 
            this.lblInfo02.AutoSize = true;
            this.lblInfo02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo02.Location = new System.Drawing.Point(222, 80);
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
            this.label21.Location = new System.Drawing.Point(59, 158);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 20);
            this.label21.TabIndex = 7;
            this.label21.Text = "Tiempo productivo:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(40, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Cant Ventas realizadas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(186, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Cant de Contactos llamados:";
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
            // cPorcentajeVentas
            // 
            chartArea4.Name = "ChartArea1";
            this.cPorcentajeVentas.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.TitleFont = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            this.cPorcentajeVentas.Legends.Add(legend4);
            this.cPorcentajeVentas.Location = new System.Drawing.Point(75, 391);
            this.cPorcentajeVentas.Name = "cPorcentajeVentas";
            this.cPorcentajeVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.BorderColor = System.Drawing.Color.Black;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            series6.Legend = "Legend1";
            series6.Name = "Ventas";
            this.cPorcentajeVentas.Series.Add(series6);
            this.cPorcentajeVentas.Size = new System.Drawing.Size(395, 335);
            this.cPorcentajeVentas.TabIndex = 24;
            this.cPorcentajeVentas.Text = "Porcentaje de Ventas";
            title4.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title01";
            title4.Text = "% Ventas";
            this.cPorcentajeVentas.Titles.Add(title4);
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
            ((System.ComponentModel.ISupportInitialize)(this.cTiempos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gb01.ResumeLayout(false);
            this.gb01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPorcentajeVentas)).EndInit();
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
    }
}