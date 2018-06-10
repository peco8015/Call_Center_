namespace WindowsFormsApplication1
{
    partial class ucPantallaAusente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegreso = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegreso
            // 
            this.btnRegreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegreso.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRegreso.FlatAppearance.BorderSize = 2;
            this.btnRegreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegreso.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreso.Location = new System.Drawing.Point(450, 224);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(110, 54);
            this.btnRegreso.TabIndex = 0;
            this.btnRegreso.Text = "Regresar";
            this.btnRegreso.UseVisualStyleBackColor = false;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTexto.Location = new System.Drawing.Point(330, 129);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(345, 38);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Para continuar con las tareas, clickee el botón \'Regresar\'.\r\nAA";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucPantallaAusente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnRegreso);
            this.Name = "ucPantallaAusente";
            this.Size = new System.Drawing.Size(1010, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegreso;
        private System.Windows.Forms.Label lblTexto;
    }
}
