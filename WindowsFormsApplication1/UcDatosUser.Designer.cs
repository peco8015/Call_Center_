namespace WindowsFormsApplication1
{
    partial class UcDatosUser
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHoraIni = new System.Windows.Forms.Label();
            this.lbFechaHoy = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbApe = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbHoraIni);
            this.panel1.Controls.Add(this.lbFechaHoy);
            this.panel1.Controls.Add(this.lbDni);
            this.panel1.Controls.Add(this.lbApe);
            this.panel1.Controls.Add(this.lbNom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 107);
            this.panel1.TabIndex = 1;
            // 
            // lbHoraIni
            // 
            this.lbHoraIni.AutoSize = true;
            this.lbHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraIni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbHoraIni.Location = new System.Drawing.Point(346, 51);
            this.lbHoraIni.Name = "lbHoraIni";
            this.lbHoraIni.Size = new System.Drawing.Size(51, 16);
            this.lbHoraIni.TabIndex = 6;
            this.lbHoraIni.Text = "label1";
            // 
            // lbFechaHoy
            // 
            this.lbFechaHoy.AutoSize = true;
            this.lbFechaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaHoy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFechaHoy.Location = new System.Drawing.Point(345, 18);
            this.lbFechaHoy.Name = "lbFechaHoy";
            this.lbFechaHoy.Size = new System.Drawing.Size(66, 24);
            this.lbFechaHoy.TabIndex = 5;
            this.lbFechaHoy.Text = "label1";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDni.Location = new System.Drawing.Point(16, 67);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(57, 20);
            this.lbDni.TabIndex = 3;
            this.lbDni.Text = "label1";
            // 
            // lbApe
            // 
            this.lbApe.AutoSize = true;
            this.lbApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbApe.Location = new System.Drawing.Point(15, 18);
            this.lbApe.Name = "lbApe";
            this.lbApe.Size = new System.Drawing.Size(76, 25);
            this.lbApe.TabIndex = 2;
            this.lbApe.Text = "label2";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNom.Location = new System.Drawing.Point(16, 47);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(57, 20);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "label1";
            // 
            // UcDatosUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcDatosUser";
            this.Size = new System.Drawing.Size(600, 103);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHoraIni;
        private System.Windows.Forms.Label lbFechaHoy;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbApe;
        private System.Windows.Forms.Label lbNom;
    }
}
