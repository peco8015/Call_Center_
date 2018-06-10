namespace WindowsFormsApplication1
{
    partial class frmEmple
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
            this.btnEstado = new System.Windows.Forms.Button();
            this.pnlCampaña = new System.Windows.Forms.Panel();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFI = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCamp = new System.Windows.Forms.Label();
            this.pnlContacto = new System.Windows.Forms.Panel();
            this.ucPantallaAusente1 = new WindowsFormsApplication1.ucPantallaAusente();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDurLlamada = new System.Windows.Forms.Label();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.pnlProgramada = new System.Windows.Forms.Panel();
            this.dtpHorarioProg = new System.Windows.Forms.DateTimePicker();
            this.rtbObsProg = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlRespuesta = new System.Windows.Forms.Panel();
            this.pnlVolverLlam = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbVObs = new System.Windows.Forms.RichTextBox();
            this.dtpVHora = new System.Windows.Forms.DateTimePicker();
            this.dtpVFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.rbVolver = new System.Windows.Forms.RadioButton();
            this.rbNoAtendio = new System.Windows.Forms.RadioButton();
            this.rbNoVendido = new System.Windows.Forms.RadioButton();
            this.rbVendido = new System.Windows.Forms.RadioButton();
            this.lblNacCon = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblECCon = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblProvCon = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOcupCon = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblFNCon = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNombreCon = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDniCon = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblApellidoCon = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblNTel = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ucDatosUsuario1 = new WindowsFormsApplication1.ucDatosUsuario();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.pnlCampaña.SuspendLayout();
            this.pnlContacto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlProgramada.SuspendLayout();
            this.pnlRespuesta.SuspendLayout();
            this.pnlVolverLlam.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstado.Location = new System.Drawing.Point(24, 25);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(172, 57);
            this.btnEstado.TabIndex = 1;
            this.btnEstado.Text = "ESTADO";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // pnlCampaña
            // 
            this.pnlCampaña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCampaña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCampaña.Controls.Add(this.rtbDesc);
            this.pnlCampaña.Controls.Add(this.label11);
            this.pnlCampaña.Controls.Add(this.lblFF);
            this.pnlCampaña.Controls.Add(this.label9);
            this.pnlCampaña.Controls.Add(this.lblFI);
            this.pnlCampaña.Controls.Add(this.label7);
            this.pnlCampaña.Controls.Add(this.lblPrecio);
            this.pnlCampaña.Controls.Add(this.label5);
            this.pnlCampaña.Controls.Add(this.lblNombreCli);
            this.pnlCampaña.Controls.Add(this.label2);
            this.pnlCampaña.Controls.Add(this.lblNombreCamp);
            this.pnlCampaña.Location = new System.Drawing.Point(241, 27);
            this.pnlCampaña.Name = "pnlCampaña";
            this.pnlCampaña.Size = new System.Drawing.Size(989, 211);
            this.pnlCampaña.TabIndex = 2;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.Location = new System.Drawing.Point(592, 69);
            this.rtbDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(357, 120);
            this.rtbDesc.TabIndex = 11;
            this.rtbDesc.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(590, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Descripción:";
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.Location = new System.Drawing.Point(375, 106);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(48, 20);
            this.lblFF.TabIndex = 8;
            this.lblFF.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fecha Fin:";
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFI.Location = new System.Drawing.Point(375, 78);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(48, 20);
            this.lblFI.TabIndex = 6;
            this.lblFI.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha Inicio:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(104, 106);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Precio:   $";
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCli.Location = new System.Drawing.Point(104, 78);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(48, 20);
            this.lblNombreCli.TabIndex = 2;
            this.lblNombreCli.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // lblNombreCamp
            // 
            this.lblNombreCamp.AutoSize = true;
            this.lblNombreCamp.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCamp.Location = new System.Drawing.Point(28, 26);
            this.lblNombreCamp.Name = "lblNombreCamp";
            this.lblNombreCamp.Size = new System.Drawing.Size(273, 30);
            this.lblNombreCamp.TabIndex = 0;
            this.lblNombreCamp.Text = "CAMPAÑA \"[ nombre ]\"";
            // 
            // pnlContacto
            // 
            this.pnlContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContacto.BackColor = System.Drawing.Color.LightBlue;
            this.pnlContacto.Controls.Add(this.ucPantallaAusente1);
            this.pnlContacto.Controls.Add(this.panel1);
            this.pnlContacto.Controls.Add(this.pnlProgramada);
            this.pnlContacto.Controls.Add(this.pnlRespuesta);
            this.pnlContacto.Controls.Add(this.lblNacCon);
            this.pnlContacto.Controls.Add(this.label13);
            this.pnlContacto.Controls.Add(this.lblECCon);
            this.pnlContacto.Controls.Add(this.label24);
            this.pnlContacto.Controls.Add(this.lblProvCon);
            this.pnlContacto.Controls.Add(this.label26);
            this.pnlContacto.Controls.Add(this.lblOcupCon);
            this.pnlContacto.Controls.Add(this.label28);
            this.pnlContacto.Controls.Add(this.lblFNCon);
            this.pnlContacto.Controls.Add(this.label15);
            this.pnlContacto.Controls.Add(this.lblNombreCon);
            this.pnlContacto.Controls.Add(this.label17);
            this.pnlContacto.Controls.Add(this.lblDniCon);
            this.pnlContacto.Controls.Add(this.label19);
            this.pnlContacto.Controls.Add(this.lblApellidoCon);
            this.pnlContacto.Controls.Add(this.label21);
            this.pnlContacto.Controls.Add(this.lblNTel);
            this.pnlContacto.Location = new System.Drawing.Point(241, 258);
            this.pnlContacto.Name = "pnlContacto";
            this.pnlContacto.Size = new System.Drawing.Size(989, 416);
            this.pnlContacto.TabIndex = 3;
            // 
            // ucPantallaAusente1
            // 
            this.ucPantallaAusente1.BackColor = System.Drawing.SystemColors.ControlText;
            this.ucPantallaAusente1.Estado = null;
            this.ucPantallaAusente1.Location = new System.Drawing.Point(-241, -255);
            this.ucPantallaAusente1.Name = "ucPantallaAusente1";
            this.ucPantallaAusente1.Opacity = 80;
            this.ucPantallaAusente1.Size = new System.Drawing.Size(1254, 689);
            this.ucPantallaAusente1.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDurLlamada);
            this.panel1.Controls.Add(this.btnCortar);
            this.panel1.Controls.Add(this.btnLlamar);
            this.panel1.Location = new System.Drawing.Point(52, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 177);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Duración de llamada";
            // 
            // lblDurLlamada
            // 
            this.lblDurLlamada.AutoSize = true;
            this.lblDurLlamada.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurLlamada.Location = new System.Drawing.Point(163, 42);
            this.lblDurLlamada.Name = "lblDurLlamada";
            this.lblDurLlamada.Size = new System.Drawing.Size(121, 24);
            this.lblDurLlamada.TabIndex = 30;
            this.lblDurLlamada.Text = "00:00:00.000";
            // 
            // btnCortar
            // 
            this.btnCortar.AutoSize = true;
            this.btnCortar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.llamar_cortar;
            this.btnCortar.Location = new System.Drawing.Point(329, 81);
            this.btnCortar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(82, 74);
            this.btnCortar.TabIndex = 29;
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.AutoSize = true;
            this.btnLlamar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.llamar_llamar;
            this.btnLlamar.Location = new System.Drawing.Point(31, 81);
            this.btnLlamar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(82, 74);
            this.btnLlamar.TabIndex = 28;
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // pnlProgramada
            // 
            this.pnlProgramada.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgramada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgramada.Controls.Add(this.dtpHorarioProg);
            this.pnlProgramada.Controls.Add(this.rtbObsProg);
            this.pnlProgramada.Controls.Add(this.label6);
            this.pnlProgramada.Location = new System.Drawing.Point(576, 28);
            this.pnlProgramada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlProgramada.Name = "pnlProgramada";
            this.pnlProgramada.Size = new System.Drawing.Size(388, 364);
            this.pnlProgramada.TabIndex = 32;
            this.pnlProgramada.Visible = false;
            // 
            // dtpHorarioProg
            // 
            this.dtpHorarioProg.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioProg.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioProg.Location = new System.Drawing.Point(120, 90);
            this.dtpHorarioProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHorarioProg.Name = "dtpHorarioProg";
            this.dtpHorarioProg.ShowUpDown = true;
            this.dtpHorarioProg.Size = new System.Drawing.Size(146, 23);
            this.dtpHorarioProg.TabIndex = 10;
            // 
            // rtbObsProg
            // 
            this.rtbObsProg.BackColor = System.Drawing.Color.White;
            this.rtbObsProg.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbObsProg.Location = new System.Drawing.Point(33, 149);
            this.rtbObsProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbObsProg.Name = "rtbObsProg";
            this.rtbObsProg.ReadOnly = true;
            this.rtbObsProg.Size = new System.Drawing.Size(320, 191);
            this.rtbObsProg.TabIndex = 11;
            this.rtbObsProg.Text = "[ Observaciones ]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(81, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "LLAMADA PROGRAMADA";
            // 
            // pnlRespuesta
            // 
            this.pnlRespuesta.BackColor = System.Drawing.Color.Transparent;
            this.pnlRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRespuesta.Controls.Add(this.pnlVolverLlam);
            this.pnlRespuesta.Controls.Add(this.btnRegistrar);
            this.pnlRespuesta.Controls.Add(this.label30);
            this.pnlRespuesta.Controls.Add(this.rbVolver);
            this.pnlRespuesta.Controls.Add(this.rbNoAtendio);
            this.pnlRespuesta.Controls.Add(this.rbNoVendido);
            this.pnlRespuesta.Controls.Add(this.rbVendido);
            this.pnlRespuesta.Location = new System.Drawing.Point(576, 28);
            this.pnlRespuesta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRespuesta.Name = "pnlRespuesta";
            this.pnlRespuesta.Size = new System.Drawing.Size(388, 364);
            this.pnlRespuesta.TabIndex = 31;
            // 
            // pnlVolverLlam
            // 
            this.pnlVolverLlam.Controls.Add(this.label1);
            this.pnlVolverLlam.Controls.Add(this.rtbVObs);
            this.pnlVolverLlam.Controls.Add(this.dtpVHora);
            this.pnlVolverLlam.Controls.Add(this.dtpVFecha);
            this.pnlVolverLlam.Enabled = false;
            this.pnlVolverLlam.Location = new System.Drawing.Point(184, 13);
            this.pnlVolverLlam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlVolverLlam.Name = "pnlVolverLlam";
            this.pnlVolverLlam.Size = new System.Drawing.Size(188, 282);
            this.pnlVolverLlam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha, hora, nota";
            // 
            // rtbVObs
            // 
            this.rtbVObs.BackColor = System.Drawing.Color.White;
            this.rtbVObs.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVObs.Location = new System.Drawing.Point(20, 134);
            this.rtbVObs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbVObs.Name = "rtbVObs";
            this.rtbVObs.Size = new System.Drawing.Size(152, 130);
            this.rtbVObs.TabIndex = 11;
            this.rtbVObs.Text = "";
            // 
            // dtpVHora
            // 
            this.dtpVHora.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVHora.Location = new System.Drawing.Point(22, 95);
            this.dtpVHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpVHora.Name = "dtpVHora";
            this.dtpVHora.ShowUpDown = true;
            this.dtpVHora.Size = new System.Drawing.Size(146, 23);
            this.dtpVHora.TabIndex = 10;
            // 
            // dtpVFecha
            // 
            this.dtpVFecha.CustomFormat = "dddd dd, MMM";
            this.dtpVFecha.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVFecha.Location = new System.Drawing.Point(22, 54);
            this.dtpVFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpVFecha.Name = "dtpVFecha";
            this.dtpVFecha.Size = new System.Drawing.Size(146, 23);
            this.dtpVFecha.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(140, 306);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 43);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Llamada";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(32, 34);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(81, 20);
            this.label30.TabIndex = 4;
            this.label30.Text = "Respuesta:";
            // 
            // rbVolver
            // 
            this.rbVolver.AutoSize = true;
            this.rbVolver.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVolver.Location = new System.Drawing.Point(60, 201);
            this.rbVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVolver.Name = "rbVolver";
            this.rbVolver.Size = new System.Drawing.Size(125, 24);
            this.rbVolver.TabIndex = 3;
            this.rbVolver.TabStop = true;
            this.rbVolver.Tag = "VL";
            this.rbVolver.Text = "Volver a llamar";
            this.rbVolver.UseVisualStyleBackColor = true;
            this.rbVolver.CheckedChanged += new System.EventHandler(this.rbVendido_CheckedChanged);
            // 
            // rbNoAtendio
            // 
            this.rbNoAtendio.AutoSize = true;
            this.rbNoAtendio.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoAtendio.Location = new System.Drawing.Point(60, 158);
            this.rbNoAtendio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNoAtendio.Name = "rbNoAtendio";
            this.rbNoAtendio.Size = new System.Drawing.Size(102, 24);
            this.rbNoAtendio.TabIndex = 2;
            this.rbNoAtendio.TabStop = true;
            this.rbNoAtendio.Tag = "NA";
            this.rbNoAtendio.Text = "No atendió";
            this.rbNoAtendio.UseVisualStyleBackColor = true;
            this.rbNoAtendio.CheckedChanged += new System.EventHandler(this.rbVendido_CheckedChanged);
            // 
            // rbNoVendido
            // 
            this.rbNoVendido.AutoSize = true;
            this.rbNoVendido.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoVendido.Location = new System.Drawing.Point(60, 117);
            this.rbNoVendido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNoVendido.Name = "rbNoVendido";
            this.rbNoVendido.Size = new System.Drawing.Size(105, 24);
            this.rbNoVendido.TabIndex = 1;
            this.rbNoVendido.TabStop = true;
            this.rbNoVendido.Tag = "NV";
            this.rbNoVendido.Text = "No vendido";
            this.rbNoVendido.UseVisualStyleBackColor = true;
            this.rbNoVendido.CheckedChanged += new System.EventHandler(this.rbVendido_CheckedChanged);
            // 
            // rbVendido
            // 
            this.rbVendido.AutoSize = true;
            this.rbVendido.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVendido.Location = new System.Drawing.Point(60, 78);
            this.rbVendido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVendido.Name = "rbVendido";
            this.rbVendido.Size = new System.Drawing.Size(84, 24);
            this.rbVendido.TabIndex = 0;
            this.rbVendido.TabStop = true;
            this.rbVendido.Tag = "V";
            this.rbVendido.Text = "Vendido";
            this.rbVendido.UseVisualStyleBackColor = true;
            this.rbVendido.CheckedChanged += new System.EventHandler(this.rbVendido_CheckedChanged);
            // 
            // lblNacCon
            // 
            this.lblNacCon.AutoSize = true;
            this.lblNacCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacCon.Location = new System.Drawing.Point(442, 176);
            this.lblNacCon.Name = "lblNacCon";
            this.lblNacCon.Size = new System.Drawing.Size(54, 20);
            this.lblNacCon.TabIndex = 27;
            this.lblNacCon.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(344, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Nacionalidad:";
            // 
            // lblECCon
            // 
            this.lblECCon.AutoSize = true;
            this.lblECCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECCon.Location = new System.Drawing.Point(442, 150);
            this.lblECCon.Name = "lblECCon";
            this.lblECCon.Size = new System.Drawing.Size(56, 20);
            this.lblECCon.TabIndex = 25;
            this.lblECCon.Text = "label23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(344, 150);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 20);
            this.label24.TabIndex = 24;
            this.label24.Text = "E. Civil:";
            // 
            // lblProvCon
            // 
            this.lblProvCon.AutoSize = true;
            this.lblProvCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvCon.Location = new System.Drawing.Point(130, 176);
            this.lblProvCon.Name = "lblProvCon";
            this.lblProvCon.Size = new System.Drawing.Size(56, 20);
            this.lblProvCon.TabIndex = 23;
            this.lblProvCon.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(48, 176);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 20);
            this.label26.TabIndex = 22;
            this.label26.Text = "Provincia:";
            // 
            // lblOcupCon
            // 
            this.lblOcupCon.AutoSize = true;
            this.lblOcupCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupCon.Location = new System.Drawing.Point(130, 150);
            this.lblOcupCon.Name = "lblOcupCon";
            this.lblOcupCon.Size = new System.Drawing.Size(56, 20);
            this.lblOcupCon.TabIndex = 21;
            this.lblOcupCon.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(48, 150);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 20);
            this.label28.TabIndex = 20;
            this.label28.Text = "Ocupación:";
            // 
            // lblFNCon
            // 
            this.lblFNCon.AutoSize = true;
            this.lblFNCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNCon.Location = new System.Drawing.Point(442, 119);
            this.lblFNCon.Name = "lblFNCon";
            this.lblFNCon.Size = new System.Drawing.Size(55, 20);
            this.lblFNCon.TabIndex = 19;
            this.lblFNCon.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(344, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Fecha Nac.:";
            // 
            // lblNombreCon
            // 
            this.lblNombreCon.AutoSize = true;
            this.lblNombreCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCon.Location = new System.Drawing.Point(442, 91);
            this.lblNombreCon.Name = "lblNombreCon";
            this.lblNombreCon.Size = new System.Drawing.Size(54, 20);
            this.lblNombreCon.TabIndex = 17;
            this.lblNombreCon.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(344, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Nombre:";
            // 
            // lblDniCon
            // 
            this.lblDniCon.AutoSize = true;
            this.lblDniCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCon.Location = new System.Drawing.Point(130, 119);
            this.lblDniCon.Name = "lblDniCon";
            this.lblDniCon.Size = new System.Drawing.Size(54, 20);
            this.lblDniCon.TabIndex = 15;
            this.lblDniCon.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(48, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "DNI:";
            // 
            // lblApellidoCon
            // 
            this.lblApellidoCon.AutoSize = true;
            this.lblApellidoCon.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCon.Location = new System.Drawing.Point(130, 91);
            this.lblApellidoCon.Name = "lblApellidoCon";
            this.lblApellidoCon.Size = new System.Drawing.Size(56, 20);
            this.lblApellidoCon.TabIndex = 13;
            this.lblApellidoCon.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(48, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "Apellido:";
            // 
            // lblNTel
            // 
            this.lblNTel.AutoSize = true;
            this.lblNTel.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTel.Location = new System.Drawing.Point(28, 28);
            this.lblNTel.Name = "lblNTel";
            this.lblNTel.Size = new System.Drawing.Size(250, 30);
            this.lblNTel.TabIndex = 11;
            this.lblNTel.Text = "Telefono [ N° telefono ]";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Teal;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(24, 90);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 63);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // ucDatosUsuario1
            // 
            this.ucDatosUsuario1.BackColor = System.Drawing.Color.White;
            this.ucDatosUsuario1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDatosUsuario1.D1 = 0;
            this.ucDatosUsuario1.D2 = 0;
            this.ucDatosUsuario1.Dni = 0;
            this.ucDatosUsuario1.EsJefe = false;
            this.ucDatosUsuario1.InicioSesion = System.TimeSpan.Parse("00:00:00");
            this.ucDatosUsuario1.Location = new System.Drawing.Point(21, 1);
            this.ucDatosUsuario1.Name = "ucDatosUsuario1";
            this.ucDatosUsuario1.NombreCompleto = null;
            this.ucDatosUsuario1.Size = new System.Drawing.Size(198, 498);
            this.ucDatosUsuario1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnEstado);
            this.gbOpciones.Controls.Add(this.btnSalir);
            this.gbOpciones.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOpciones.Location = new System.Drawing.Point(10, 510);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(220, 169);
            this.gbOpciones.TabIndex = 11;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // frmEmple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1254, 691);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.ucDatosUsuario1);
            this.Controls.Add(this.pnlContacto);
            this.Controls.Add(this.pnlCampaña);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.pnlCampaña.ResumeLayout(false);
            this.pnlCampaña.PerformLayout();
            this.pnlContacto.ResumeLayout(false);
            this.pnlContacto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlProgramada.ResumeLayout(false);
            this.pnlProgramada.PerformLayout();
            this.pnlRespuesta.ResumeLayout(false);
            this.pnlRespuesta.PerformLayout();
            this.pnlVolverLlam.ResumeLayout(false);
            this.pnlVolverLlam.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Panel pnlCampaña;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCamp;
        private System.Windows.Forms.Panel pnlContacto;
        private System.Windows.Forms.Label lblNacCon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblECCon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblProvCon;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblOcupCon;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblFNCon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNombreCon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDniCon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblApellidoCon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblNTel;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblDurLlamada;
        private System.Windows.Forms.Panel pnlRespuesta;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RadioButton rbVolver;
        private System.Windows.Forms.RadioButton rbNoAtendio;
        private System.Windows.Forms.RadioButton rbNoVendido;
        private System.Windows.Forms.RadioButton rbVendido;
        private System.Windows.Forms.Panel pnlVolverLlam;
        private System.Windows.Forms.RichTextBox rtbVObs;
        private System.Windows.Forms.DateTimePicker dtpVHora;
        private System.Windows.Forms.DateTimePicker dtpVFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ucDatosUsuario ucDatosUsuario1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlProgramada;
        private System.Windows.Forms.DateTimePicker dtpHorarioProg;
        private System.Windows.Forms.RichTextBox rtbObsProg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbOpciones;
        private ucPantallaAusente ucPantallaAusente1;
        private System.Windows.Forms.Panel panel1;
    }
}