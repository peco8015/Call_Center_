﻿namespace WindowsFormsApplication1
{
    partial class frmNuevo
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
            this.label11 = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.check01 = new System.Windows.Forms.CheckBox();
            this.cb02 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.check02 = new System.Windows.Forms.CheckBox();
            this.cb01 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb07 = new System.Windows.Forms.TextBox();
            this.dtp02 = new System.Windows.Forms.DateTimePicker();
            this.dtp01 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb06 = new System.Windows.Forms.TextBox();
            this.tb05 = new System.Windows.Forms.TextBox();
            this.tb03 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb04 = new System.Windows.Forms.TextBox();
            this.tb02 = new System.Windows.Forms.TextBox();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(52, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Información";
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.nudPrecio);
            this.pnlInformacion.Controls.Add(this.check01);
            this.pnlInformacion.Controls.Add(this.cb02);
            this.pnlInformacion.Controls.Add(this.btnAdd);
            this.pnlInformacion.Controls.Add(this.check02);
            this.pnlInformacion.Controls.Add(this.cb01);
            this.pnlInformacion.Controls.Add(this.label9);
            this.pnlInformacion.Controls.Add(this.tb07);
            this.pnlInformacion.Controls.Add(this.dtp02);
            this.pnlInformacion.Controls.Add(this.dtp01);
            this.pnlInformacion.Controls.Add(this.label7);
            this.pnlInformacion.Controls.Add(this.label8);
            this.pnlInformacion.Controls.Add(this.tb06);
            this.pnlInformacion.Controls.Add(this.tb05);
            this.pnlInformacion.Controls.Add(this.tb03);
            this.pnlInformacion.Controls.Add(this.label6);
            this.pnlInformacion.Controls.Add(this.label5);
            this.pnlInformacion.Controls.Add(this.label4);
            this.pnlInformacion.Controls.Add(this.tb04);
            this.pnlInformacion.Controls.Add(this.tb02);
            this.pnlInformacion.Controls.Add(this.tb01);
            this.pnlInformacion.Controls.Add(this.label2);
            this.pnlInformacion.Controls.Add(this.label1);
            this.pnlInformacion.Controls.Add(this.label3);
            this.pnlInformacion.Location = new System.Drawing.Point(38, 58);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(644, 478);
            this.pnlInformacion.TabIndex = 25;
            // 
            // check01
            // 
            this.check01.AutoSize = true;
            this.check01.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.check01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check01.ForeColor = System.Drawing.Color.Maroon;
            this.check01.Location = new System.Drawing.Point(54, 327);
            this.check01.Name = "check01";
            this.check01.Size = new System.Drawing.Size(159, 24);
            this.check01.TabIndex = 24;
            this.check01.Text = "Director de campaña";
            this.check01.UseVisualStyleBackColor = true;
            this.check01.Click += new System.EventHandler(this.check01_CheckedChanged_1);
            // 
            // cb02
            // 
            this.cb02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb02.FormattingEnabled = true;
            this.cb02.Location = new System.Drawing.Point(327, 364);
            this.cb02.Name = "cb02";
            this.cb02.Size = new System.Drawing.Size(261, 27);
            this.cb02.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(504, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 47);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // check02
            // 
            this.check02.AutoSize = true;
            this.check02.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.check02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check02.Location = new System.Drawing.Point(54, 365);
            this.check02.Name = "check02";
            this.check02.Size = new System.Drawing.Size(213, 24);
            this.check02.TabIndex = 22;
            this.check02.Text = "Asignar campaña a empleado";
            this.check02.UseVisualStyleBackColor = true;
            this.check02.Click += new System.EventHandler(this.check02_CheckedChanged);
            // 
            // cb01
            // 
            this.cb01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb01.FormattingEnabled = true;
            this.cb01.Location = new System.Drawing.Point(327, 324);
            this.cb01.Name = "cb01";
            this.cb01.Size = new System.Drawing.Size(261, 27);
            this.cb01.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(73, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cliente";
            // 
            // tb07
            // 
            this.tb07.BackColor = System.Drawing.SystemColors.Window;
            this.tb07.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb07.Location = new System.Drawing.Point(327, 287);
            this.tb07.Name = "tb07";
            this.tb07.Size = new System.Drawing.Size(261, 25);
            this.tb07.TabIndex = 18;
            // 
            // dtp02
            // 
            this.dtp02.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp02.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp02.Location = new System.Drawing.Point(327, 287);
            this.dtp02.Name = "dtp02";
            this.dtp02.Size = new System.Drawing.Size(261, 25);
            this.dtp02.TabIndex = 18;
            // 
            // dtp01
            // 
            this.dtp01.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp01.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp01.Location = new System.Drawing.Point(327, 249);
            this.dtp01.Name = "dtp01";
            this.dtp01.Size = new System.Drawing.Size(261, 25);
            this.dtp01.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(73, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(73, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contraseña";
            // 
            // tb06
            // 
            this.tb06.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb06.Location = new System.Drawing.Point(327, 211);
            this.tb06.Name = "tb06";
            this.tb06.Size = new System.Drawing.Size(261, 25);
            this.tb06.TabIndex = 14;
            // 
            // tb05
            // 
            this.tb05.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb05.Location = new System.Drawing.Point(327, 173);
            this.tb05.Name = "tb05";
            this.tb05.Size = new System.Drawing.Size(261, 25);
            this.tb05.TabIndex = 13;
            // 
            // tb03
            // 
            this.tb03.BackColor = System.Drawing.SystemColors.Window;
            this.tb03.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb03.Location = new System.Drawing.Point(327, 97);
            this.tb03.Multiline = true;
            this.tb03.Name = "tb03";
            this.tb03.Size = new System.Drawing.Size(261, 25);
            this.tb03.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(73, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(73, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(73, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefono";
            // 
            // tb04
            // 
            this.tb04.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb04.Location = new System.Drawing.Point(327, 135);
            this.tb04.Name = "tb04";
            this.tb04.Size = new System.Drawing.Size(261, 25);
            this.tb04.TabIndex = 12;
            // 
            // tb02
            // 
            this.tb02.BackColor = System.Drawing.SystemColors.Window;
            this.tb02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb02.Location = new System.Drawing.Point(327, 59);
            this.tb02.Name = "tb02";
            this.tb02.Size = new System.Drawing.Size(261, 25);
            this.tb02.TabIndex = 8;
            // 
            // tb01
            // 
            this.tb01.BackColor = System.Drawing.SystemColors.Window;
            this.tb01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb01.Location = new System.Drawing.Point(327, 21);
            this.tb01.Name = "tb01";
            this.tb01.Size = new System.Drawing.Size(261, 25);
            this.tb01.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(73, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(73, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(73, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Location = new System.Drawing.Point(327, 59);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(261, 25);
            this.nudPrecio.TabIndex = 27;
            // 
            // frmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(721, 562);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pnlInformacion);
            this.MaximizeBox = false;
            this.Name = "frmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo registro";
            this.Load += new System.EventHandler(this.frmNuevo_Load);
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.CheckBox check01;
        private System.Windows.Forms.ComboBox cb02;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox check02;
        private System.Windows.Forms.ComboBox cb01;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb07;
        private System.Windows.Forms.DateTimePicker dtp02;
        private System.Windows.Forms.DateTimePicker dtp01;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb06;
        private System.Windows.Forms.TextBox tb05;
        private System.Windows.Forms.TextBox tb03;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb04;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrecio;
    }
}