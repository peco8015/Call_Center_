namespace WindowsFormsApplication1
{
    partial class frmJornada
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
            this.components = new System.ComponentModel.Container();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbTiempos = new System.Windows.Forms.GroupBox();
            this.lblInactivo = new System.Windows.Forms.Label();
            this.lblSinCampaña = new System.Windows.Forms.Label();
            this.lblSinContactos = new System.Windows.Forms.Label();
            this.lblFormularios = new System.Windows.Forms.Label();
            this.lblDescanso = new System.Windows.Forms.Label();
            this.lblReunion = new System.Windows.Forms.Label();
            this.lblCapacitacion = new System.Windows.Forms.Label();
            this.lblEnEspera = new System.Windows.Forms.Label();
            this.lblAtendiendo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gbTiempos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(173, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha: 28 de Mayo, 2018";
            // 
            // gbTiempos
            // 
            this.gbTiempos.Controls.Add(this.label1);
            this.gbTiempos.Controls.Add(this.lblInactivo);
            this.gbTiempos.Controls.Add(this.lblSinCampaña);
            this.gbTiempos.Controls.Add(this.lblSinContactos);
            this.gbTiempos.Controls.Add(this.lblFormularios);
            this.gbTiempos.Controls.Add(this.lblDescanso);
            this.gbTiempos.Controls.Add(this.lblReunion);
            this.gbTiempos.Controls.Add(this.lblCapacitacion);
            this.gbTiempos.Controls.Add(this.lblEnEspera);
            this.gbTiempos.Controls.Add(this.lblAtendiendo);
            this.gbTiempos.Controls.Add(this.label10);
            this.gbTiempos.Controls.Add(this.label9);
            this.gbTiempos.Controls.Add(this.label8);
            this.gbTiempos.Controls.Add(this.label7);
            this.gbTiempos.Controls.Add(this.label6);
            this.gbTiempos.Controls.Add(this.label5);
            this.gbTiempos.Controls.Add(this.label4);
            this.gbTiempos.Controls.Add(this.label3);
            this.gbTiempos.Controls.Add(this.label2);
            this.gbTiempos.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiempos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbTiempos.Location = new System.Drawing.Point(12, 63);
            this.gbTiempos.Name = "gbTiempos";
            this.gbTiempos.Size = new System.Drawing.Size(441, 333);
            this.gbTiempos.TabIndex = 1;
            this.gbTiempos.TabStop = false;
            this.gbTiempos.Text = "Tiempos";
            // 
            // lblInactivo
            // 
            this.lblInactivo.AutoSize = true;
            this.lblInactivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInactivo.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInactivo.Location = new System.Drawing.Point(246, 295);
            this.lblInactivo.Name = "lblInactivo";
            this.lblInactivo.Size = new System.Drawing.Size(90, 20);
            this.lblInactivo.TabIndex = 17;
            this.lblInactivo.Text = "00:00:00.000";
            // 
            // lblSinCampaña
            // 
            this.lblSinCampaña.AutoSize = true;
            this.lblSinCampaña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSinCampaña.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinCampaña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSinCampaña.Location = new System.Drawing.Point(246, 264);
            this.lblSinCampaña.Name = "lblSinCampaña";
            this.lblSinCampaña.Size = new System.Drawing.Size(90, 20);
            this.lblSinCampaña.TabIndex = 16;
            this.lblSinCampaña.Text = "00:00:00.000";
            // 
            // lblSinContactos
            // 
            this.lblSinContactos.AutoSize = true;
            this.lblSinContactos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSinContactos.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinContactos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSinContactos.Location = new System.Drawing.Point(246, 233);
            this.lblSinContactos.Name = "lblSinContactos";
            this.lblSinContactos.Size = new System.Drawing.Size(90, 20);
            this.lblSinContactos.TabIndex = 15;
            this.lblSinContactos.Text = "00:00:00.000";
            // 
            // lblFormularios
            // 
            this.lblFormularios.AutoSize = true;
            this.lblFormularios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormularios.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFormularios.Location = new System.Drawing.Point(246, 171);
            this.lblFormularios.Name = "lblFormularios";
            this.lblFormularios.Size = new System.Drawing.Size(90, 20);
            this.lblFormularios.TabIndex = 14;
            this.lblFormularios.Text = "00:00:00.000";
            // 
            // lblDescanso
            // 
            this.lblDescanso.AutoSize = true;
            this.lblDescanso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescanso.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescanso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescanso.Location = new System.Drawing.Point(246, 202);
            this.lblDescanso.Name = "lblDescanso";
            this.lblDescanso.Size = new System.Drawing.Size(90, 20);
            this.lblDescanso.TabIndex = 13;
            this.lblDescanso.Text = "00:00:00.000";
            // 
            // lblReunion
            // 
            this.lblReunion.AutoSize = true;
            this.lblReunion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReunion.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReunion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReunion.Location = new System.Drawing.Point(246, 140);
            this.lblReunion.Name = "lblReunion";
            this.lblReunion.Size = new System.Drawing.Size(90, 20);
            this.lblReunion.TabIndex = 12;
            this.lblReunion.Text = "00:00:00.000";
            // 
            // lblCapacitacion
            // 
            this.lblCapacitacion.AutoSize = true;
            this.lblCapacitacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCapacitacion.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCapacitacion.Location = new System.Drawing.Point(246, 109);
            this.lblCapacitacion.Name = "lblCapacitacion";
            this.lblCapacitacion.Size = new System.Drawing.Size(90, 20);
            this.lblCapacitacion.TabIndex = 11;
            this.lblCapacitacion.Text = "00:00:00.000";
            // 
            // lblEnEspera
            // 
            this.lblEnEspera.AutoSize = true;
            this.lblEnEspera.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnEspera.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnEspera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnEspera.Location = new System.Drawing.Point(246, 78);
            this.lblEnEspera.Name = "lblEnEspera";
            this.lblEnEspera.Size = new System.Drawing.Size(90, 20);
            this.lblEnEspera.TabIndex = 10;
            this.lblEnEspera.Text = "00:00:00.000";
            // 
            // lblAtendiendo
            // 
            this.lblAtendiendo.AutoSize = true;
            this.lblAtendiendo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAtendiendo.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendiendo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAtendiendo.Location = new System.Drawing.Point(246, 47);
            this.lblAtendiendo.Name = "lblAtendiendo";
            this.lblAtendiendo.Size = new System.Drawing.Size(90, 20);
            this.lblAtendiendo.TabIndex = 9;
            this.lblAtendiendo.Text = "00:00:00.000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "En espera (llamada)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Inactivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sin campaña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sin contactos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descanso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Registro de llamadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Reunión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Capacitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Atendiendo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "HH:MM:SS.ms";
            // 
            // frmJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(467, 408);
            this.Controls.Add(this.gbTiempos);
            this.Controls.Add(this.lblFecha);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmJornada";
            this.Text = "Jornada de hoy";
            this.Load += new System.EventHandler(this.frmJornada_Load);
            this.gbTiempos.ResumeLayout(false);
            this.gbTiempos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbTiempos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblInactivo;
        private System.Windows.Forms.Label lblSinCampaña;
        private System.Windows.Forms.Label lblSinContactos;
        private System.Windows.Forms.Label lblFormularios;
        private System.Windows.Forms.Label lblDescanso;
        private System.Windows.Forms.Label lblReunion;
        private System.Windows.Forms.Label lblCapacitacion;
        private System.Windows.Forms.Label lblEnEspera;
        private System.Windows.Forms.Label lblAtendiendo;
        private System.Windows.Forms.Label label1;
    }
}