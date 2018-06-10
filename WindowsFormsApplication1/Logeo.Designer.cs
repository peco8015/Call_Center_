namespace WindowsFormsApplication1
{
    partial class Logeo
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogeo = new System.Windows.Forms.Panel();
            this.btnIngresa = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogeo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogeo
            // 
            this.pnlLogeo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlLogeo.Controls.Add(this.btnIngresa);
            this.pnlLogeo.Controls.Add(this.tbPass);
            this.pnlLogeo.Controls.Add(this.tbUser);
            this.pnlLogeo.Controls.Add(this.label2);
            this.pnlLogeo.Controls.Add(this.label1);
            this.pnlLogeo.Location = new System.Drawing.Point(37, 18);
            this.pnlLogeo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlLogeo.Name = "pnlLogeo";
            this.pnlLogeo.Size = new System.Drawing.Size(338, 202);
            this.pnlLogeo.TabIndex = 0;
            // 
            // btnIngresa
            // 
            this.btnIngresa.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresa.Location = new System.Drawing.Point(119, 145);
            this.btnIngresa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(101, 38);
            this.btnIngresa.TabIndex = 4;
            this.btnIngresa.Text = "Ingresar";
            this.btnIngresa.UseVisualStyleBackColor = true;
            this.btnIngresa.Click += new System.EventHandler(this.btnIngresa_Click);
            // 
            // tbPass
            // 
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(147, 91);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(139, 23);
            this.tbPass.TabIndex = 3;
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUser.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(147, 33);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(139, 23);
            this.tbUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(413, 239);
            this.Controls.Add(this.pnlLogeo);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.pnlLogeo.ResumeLayout(false);
            this.pnlLogeo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogeo;
        private System.Windows.Forms.Button btnIngresa;
        public System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

