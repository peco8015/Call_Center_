namespace WindowsFormsApplication1
{
    partial class frmEstado
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbl01 = new System.Windows.Forms.Label();
            this.rb01 = new System.Windows.Forms.RadioButton();
            this.rb02 = new System.Windows.Forms.RadioButton();
            this.rb03 = new System.Windows.Forms.RadioButton();
            this.rb04 = new System.Windows.Forms.RadioButton();
            this.lbl02 = new System.Windows.Forms.Label();
            this.rb05 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(264, 311);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 49);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbl01
            // 
            this.lbl01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(19, 24);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(432, 63);
            this.lbl01.TabIndex = 1;
            this.lbl01.Text = "Seleccione la opción de \'estado\' para bloquear temporalmente la llegada de llamad" +
    "as. Al regresar deberá oprimir el botón para continuar realizando llamadas.";
            // 
            // rb01
            // 
            this.rb01.AutoSize = true;
            this.rb01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb01.Location = new System.Drawing.Point(187, 125);
            this.rb01.Name = "rb01";
            this.rb01.Size = new System.Drawing.Size(88, 24);
            this.rb01.TabIndex = 2;
            this.rb01.TabStop = true;
            this.rb01.Tag = "Descanso";
            this.rb01.Text = "Descanso";
            this.rb01.UseVisualStyleBackColor = true;
            this.rb01.CheckedChanged += new System.EventHandler(this.rb01_CheckedChanged);
            // 
            // rb02
            // 
            this.rb02.AutoSize = true;
            this.rb02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb02.Location = new System.Drawing.Point(187, 159);
            this.rb02.Name = "rb02";
            this.rb02.Size = new System.Drawing.Size(79, 24);
            this.rb02.TabIndex = 3;
            this.rb02.TabStop = true;
            this.rb02.Tag = "Reunion";
            this.rb02.Text = "Reunión";
            this.rb02.UseVisualStyleBackColor = true;
            this.rb02.CheckedChanged += new System.EventHandler(this.rb01_CheckedChanged);
            // 
            // rb03
            // 
            this.rb03.AutoSize = true;
            this.rb03.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb03.Location = new System.Drawing.Point(187, 193);
            this.rb03.Name = "rb03";
            this.rb03.Size = new System.Drawing.Size(59, 24);
            this.rb03.TabIndex = 4;
            this.rb03.TabStop = true;
            this.rb03.Tag = "Baño";
            this.rb03.Text = "Baño";
            this.rb03.UseVisualStyleBackColor = true;
            this.rb03.CheckedChanged += new System.EventHandler(this.rb01_CheckedChanged);
            // 
            // rb04
            // 
            this.rb04.AutoSize = true;
            this.rb04.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb04.Location = new System.Drawing.Point(187, 227);
            this.rb04.Name = "rb04";
            this.rb04.Size = new System.Drawing.Size(106, 24);
            this.rb04.TabIndex = 5;
            this.rb04.TabStop = true;
            this.rb04.Tag = "Capacitacion";
            this.rb04.Text = "Capacitacion";
            this.rb04.UseVisualStyleBackColor = true;
            this.rb04.CheckedChanged += new System.EventHandler(this.rb01_CheckedChanged);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.Location = new System.Drawing.Point(19, 87);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(422, 16);
            this.lbl02.TabIndex = 6;
            this.lbl02.Text = "Atención: debe clickear \'Aceptar\' antes de retirarse para justificar el tiempo au" +
    "sente.";
            // 
            // rb05
            // 
            this.rb05.AutoSize = true;
            this.rb05.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb05.Location = new System.Drawing.Point(187, 261);
            this.rb05.Name = "rb05";
            this.rb05.Size = new System.Drawing.Size(89, 24);
            this.rb05.TabIndex = 7;
            this.rb05.TabStop = true;
            this.rb05.Tag = "Almuerzo";
            this.rb05.Text = "Almuerzo";
            this.rb05.UseVisualStyleBackColor = true;
            // 
            // frmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.rb05);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.rb04);
            this.Controls.Add(this.rb03);
            this.Controls.Add(this.rb02);
            this.Controls.Add(this.rb01);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de estado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.RadioButton rb01;
        private System.Windows.Forms.RadioButton rb02;
        private System.Windows.Forms.RadioButton rb03;
        private System.Windows.Forms.RadioButton rb04;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.RadioButton rb05;
    }
}