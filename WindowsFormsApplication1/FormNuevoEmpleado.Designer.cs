namespace WindowsFormsApplication1
{
    partial class FormNuevoEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lbcampañas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btDeletteEmpleado = new System.Windows.Forms.Button();
            this.Bt_UpdateEmpleado = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbInicio = new System.Windows.Forms.TextBox();
            this.tbNacimiento = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.tbTel);
            this.panel1.Controls.Add(this.tbDni);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbDomicilio);
            this.panel1.Controls.Add(this.tbInicio);
            this.panel1.Controls.Add(this.tbNacimiento);
            this.panel1.Controls.Add(this.tbApellido);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Apellido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 449);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lbcampañas);
            this.panel2.Location = new System.Drawing.Point(67, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 290);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Campaña :";
            // 
            // lbcampañas
            // 
            this.lbcampañas.FormattingEnabled = true;
            this.lbcampañas.Location = new System.Drawing.Point(93, 22);
            this.lbcampañas.Name = "lbcampañas";
            this.lbcampañas.Size = new System.Drawing.Size(191, 264);
            this.lbcampañas.TabIndex = 22;
            this.lbcampañas.SelectedIndexChanged += new System.EventHandler(this.lbcampañas_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1233, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 76);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Campaña";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btDeletteEmpleado
            // 
            this.btDeletteEmpleado.Location = new System.Drawing.Point(257, 363);
            this.btDeletteEmpleado.Name = "btDeletteEmpleado";
            this.btDeletteEmpleado.Size = new System.Drawing.Size(94, 23);
            this.btDeletteEmpleado.TabIndex = 19;
            this.btDeletteEmpleado.Text = "Eliminar";
            this.btDeletteEmpleado.UseVisualStyleBackColor = true;
            this.btDeletteEmpleado.Visible = false;
            // 
            // Bt_UpdateEmpleado
            // 
            this.Bt_UpdateEmpleado.Location = new System.Drawing.Point(160, 363);
            this.Bt_UpdateEmpleado.Name = "Bt_UpdateEmpleado";
            this.Bt_UpdateEmpleado.Size = new System.Drawing.Size(95, 23);
            this.Bt_UpdateEmpleado.TabIndex = 18;
            this.Bt_UpdateEmpleado.Text = "Guardar Cambios";
            this.Bt_UpdateEmpleado.UseVisualStyleBackColor = true;
            this.Bt_UpdateEmpleado.Visible = false;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(162, 338);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(191, 20);
            this.tbMail.TabIndex = 17;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(162, 305);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(191, 20);
            this.tbTel.TabIndex = 16;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(162, 166);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(191, 20);
            this.tbDni.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Domicilo:";
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Location = new System.Drawing.Point(162, 244);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(191, 20);
            this.tbDomicilio.TabIndex = 11;
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(162, 206);
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(191, 20);
            this.tbInicio.TabIndex = 10;
            // 
            // tbNacimiento
            // 
            this.tbNacimiento.Location = new System.Drawing.Point(162, 136);
            this.tbNacimiento.Name = "tbNacimiento";
            this.tbNacimiento.Size = new System.Drawing.Size(191, 20);
            this.tbNacimiento.TabIndex = 9;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(162, 102);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(191, 20);
            this.tbApellido.TabIndex = 8;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(162, 67);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(191, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trabajando desde :";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(12, 139);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(136, 16);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Fecha de Nacimiento";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btDeletteEmpleado);
            this.panel3.Controls.Add(this.Bt_UpdateEmpleado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(385, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 449);
            this.panel3.TabIndex = 8;
            // 
            // FormNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 449);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormNuevoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNuevoEmpleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btDeletteEmpleado;
        private System.Windows.Forms.Button Bt_UpdateEmpleado;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbInicio;
        private System.Windows.Forms.TextBox tbNacimiento;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.ListBox lbcampañas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}