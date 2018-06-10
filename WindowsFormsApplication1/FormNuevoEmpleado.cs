using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.clases;

namespace WindowsFormsApplication1
{
    public partial class FormNuevoEmpleado : Form
    {
        public FormNuevoEmpleado()
        {
            InitializeComponent();
        }
        clsEmpleado user = new clsEmpleado();
        clsConexion conectar = new clsConexion();
        DataTable dTable;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

           

        }

        private void lbcampañas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDeletteEmpleado.Visible = true;
            Bt_UpdateEmpleado.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            dTable = conectar.obtenerCampañas();


            foreach (DataRow fila in dTable.Rows)
            {

                lbcampañas.Items.Add(Convert.ToString(fila[0]));
               

            }
        }
    }
}
