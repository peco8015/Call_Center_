using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmEstado : Form
    {
        public string est { get; set; }

        public frmEstado()
        {
            InitializeComponent();
            est = string.Empty;
            btnAceptar.Enabled = false;
        }
        

        private void rb01_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
            est = (sender as RadioButton).Tag.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
