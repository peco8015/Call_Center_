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
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.rbJefe = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
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
            this.pnlRelacion = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoRegistro = new System.Windows.Forms.ComboBox();
            this.btnAddEmpleados = new System.Windows.Forms.Button();
            this.pnlLider = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbLider = new System.Windows.Forms.ListBox();
            this.pnlInformacion.SuspendLayout();
            this.pnlRelacion.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.pnlLider.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInformacion.BackColor = System.Drawing.Color.LightBlue;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.rbJefe);
            this.pnlInformacion.Controls.Add(this.rbEmpleado);
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
            this.pnlInformacion.Location = new System.Drawing.Point(38, 47);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(386, 377);
            this.pnlInformacion.TabIndex = 7;
            // 
            // rbJefe
            // 
            this.rbJefe.AutoSize = true;
            this.rbJefe.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJefe.Location = new System.Drawing.Point(274, 325);
            this.rbJefe.Name = "rbJefe";
            this.rbJefe.Size = new System.Drawing.Size(38, 24);
            this.rbJefe.TabIndex = 20;
            this.rbJefe.Text = "Si";
            this.rbJefe.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Checked = true;
            this.rbEmpleado.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleado.Location = new System.Drawing.Point(183, 325);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(47, 24);
            this.rbEmpleado.TabIndex = 19;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "No";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Director de campaña";
            // 
            // tb07
            // 
            this.tb07.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb07.Location = new System.Drawing.Point(170, 287);
            this.tb07.Name = "tb07";
            this.tb07.Size = new System.Drawing.Size(191, 25);
            this.tb07.TabIndex = 18;
            // 
            // dtp02
            // 
            this.dtp02.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp02.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp02.Location = new System.Drawing.Point(170, 287);
            this.dtp02.Name = "dtp02";
            this.dtp02.Size = new System.Drawing.Size(191, 25);
            this.dtp02.TabIndex = 18;
            // 
            // dtp01
            // 
            this.dtp01.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp01.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp01.Location = new System.Drawing.Point(170, 249);
            this.dtp01.Name = "dtp01";
            this.dtp01.Size = new System.Drawing.Size(191, 25);
            this.dtp01.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Trabajando desde";
            // 
            // tb06
            // 
            this.tb06.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb06.Location = new System.Drawing.Point(170, 211);
            this.tb06.Name = "tb06";
            this.tb06.Size = new System.Drawing.Size(191, 25);
            this.tb06.TabIndex = 14;
            // 
            // tb05
            // 
            this.tb05.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb05.Location = new System.Drawing.Point(170, 173);
            this.tb05.Name = "tb05";
            this.tb05.Size = new System.Drawing.Size(191, 25);
            this.tb05.TabIndex = 13;
            // 
            // tb03
            // 
            this.tb03.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb03.Location = new System.Drawing.Point(170, 97);
            this.tb03.Multiline = true;
            this.tb03.Name = "tb03";
            this.tb03.Size = new System.Drawing.Size(191, 25);
            this.tb03.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefono";
            // 
            // tb04
            // 
            this.tb04.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb04.Location = new System.Drawing.Point(170, 135);
            this.tb04.Name = "tb04";
            this.tb04.Size = new System.Drawing.Size(191, 25);
            this.tb04.TabIndex = 12;
            // 
            // tb02
            // 
            this.tb02.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb02.Location = new System.Drawing.Point(170, 59);
            this.tb02.Name = "tb02";
            this.tb02.Size = new System.Drawing.Size(191, 25);
            this.tb02.TabIndex = 8;
            // 
            // tb01
            // 
            this.tb01.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb01.Location = new System.Drawing.Point(170, 21);
            this.tb01.Name = "tb01";
            this.tb01.Size = new System.Drawing.Size(191, 25);
            this.tb01.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // pnlRelacion
            // 
            this.pnlRelacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRelacion.Controls.Add(this.lblLista);
            this.pnlRelacion.Controls.Add(this.lbLista);
            this.pnlRelacion.Location = new System.Drawing.Point(489, 47);
            this.pnlRelacion.Name = "pnlRelacion";
            this.pnlRelacion.Size = new System.Drawing.Size(312, 377);
            this.pnlRelacion.TabIndex = 23;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.Transparent;
            this.lblLista.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(24, 16);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(197, 20);
            this.lblLista.TabIndex = 20;
            this.lblLista.Text = "Asignar campaña al empleado";
            // 
            // lbLista
            // 
            this.lbLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLista.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 19;
            this.lbLista.Location = new System.Drawing.Point(28, 48);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(256, 308);
            this.lbLista.TabIndex = 21;
            this.lbLista.SelectedIndexChanged += new System.EventHandler(this.lbLista_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(313, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 47);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.Teal;
            this.pnlRegistro.Controls.Add(this.pnlLider);
            this.pnlRegistro.Controls.Add(this.btnAddEmpleados);
            this.pnlRegistro.Controls.Add(this.label11);
            this.pnlRegistro.Controls.Add(this.pnlRelacion);
            this.pnlRegistro.Controls.Add(this.pnlInformacion);
            this.pnlRegistro.Controls.Add(this.btnAdd);
            this.pnlRegistro.Location = new System.Drawing.Point(19, 59);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(830, 493);
            this.pnlRegistro.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Información";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlText;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(55, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Agregar nuevo registro de";
            // 
            // cbTipoRegistro
            // 
            this.cbTipoRegistro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbTipoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRegistro.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRegistro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbTipoRegistro.FormattingEnabled = true;
            this.cbTipoRegistro.ItemHeight = 21;
            this.cbTipoRegistro.Items.AddRange(new object[] {
            "Empleado",
            "Cliente",
            "Campaña"});
            this.cbTipoRegistro.Location = new System.Drawing.Point(294, 19);
            this.cbTipoRegistro.Name = "cbTipoRegistro";
            this.cbTipoRegistro.Size = new System.Drawing.Size(197, 29);
            this.cbTipoRegistro.TabIndex = 1;
            this.cbTipoRegistro.SelectedIndexChanged += new System.EventHandler(this.cbTipoRegistro_SelectedIndexChanged);
            // 
            // btnAddEmpleados
            // 
            this.btnAddEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddEmpleados.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpleados.Location = new System.Drawing.Point(518, 433);
            this.btnAddEmpleados.Name = "btnAddEmpleados";
            this.btnAddEmpleados.Size = new System.Drawing.Size(159, 47);
            this.btnAddEmpleados.TabIndex = 25;
            this.btnAddEmpleados.Text = "Asignar CAMPAÑA";
            this.btnAddEmpleados.UseVisualStyleBackColor = true;
            this.btnAddEmpleados.Click += new System.EventHandler(this.btnAddEmpleados_Click);
            // 
            // pnlLider
            // 
            this.pnlLider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLider.Controls.Add(this.label12);
            this.pnlLider.Controls.Add(this.lbLider);
            this.pnlLider.Location = new System.Drawing.Point(116, 47);
            this.pnlLider.Name = "pnlLider";
            this.pnlLider.Size = new System.Drawing.Size(312, 377);
            this.pnlLider.TabIndex = 24;
            this.pnlLider.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Asignar líder/jefe a campaña";
            // 
            // lbLider
            // 
            this.lbLider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLider.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLider.FormattingEnabled = true;
            this.lbLider.ItemHeight = 19;
            this.lbLider.Location = new System.Drawing.Point(28, 48);
            this.lbLider.Name = "lbLider";
            this.lbLider.Size = new System.Drawing.Size(256, 308);
            this.lbLider.TabIndex = 21;
            this.lbLider.SelectedIndexChanged += new System.EventHandler(this.lbLista_SelectedIndexChanged);
            // 
            // frmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(869, 573);
            this.Controls.Add(this.cbTipoRegistro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlRegistro);
            this.MaximizeBox = false;
            this.Name = "frmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo registro";
            this.Load += new System.EventHandler(this.frmNuevo_Load);
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.pnlRelacion.ResumeLayout(false);
            this.pnlRelacion.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlLider.ResumeLayout(false);
            this.pnlLider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnAdd;
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
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Panel pnlRelacion;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipoRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp02;
        private System.Windows.Forms.DateTimePicker dtp01;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb07;
        private System.Windows.Forms.RadioButton rbJefe;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddEmpleados;
        private System.Windows.Forms.Panel pnlLider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbLider;
    }
}