using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UcDatosUser : UserControl
    {
        public UcDatosUser()
        {
            InitializeComponent();
        }

        string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
                lbNom.Text = nombre;
            }
        }
        string apellidos;
        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
                lbApe.Text = apellidos;
            }
        }


        int dni;
        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
                lbDni.Text = Convert.ToString(dni);
            }
        }

        string hoy;
        public string Hoy
        {
            get
            {
                return hoy;
            }

            set
            {
                hoy = value;
                lbFechaHoy.Text = hoy;
            }
        }

        string hora;
        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
                lbHoraIni.Text = hora;
            }
        }




        private void UserControlDatosUser_Load(object sender, EventArgs e)
        {

        }
    }
}
