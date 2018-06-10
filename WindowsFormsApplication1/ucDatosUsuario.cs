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
    public partial class ucDatosUsuario : UserControl
    {
        TimeSpan inicioSesion;
        string nombreCompleto;
        bool esJefe;
        int d1, d2, dni;

        public bool EsJefe
        {
            get { return esJefe; }
            set
            {
                esJefe = value;
                if (esJefe)
                {
                    pbFoto.Image = Properties.Resources.jefe;
                    lblDato1.Text = "Campañas asignadas:";
                    lblDato2.Text = "Empleados a cargo:";
                }
                else
                {
                    lblDato1.Text = "Total Llamadas:";
                    lblDato2.Text = "Total Ventas:";
                }
            }
        }
        
        public int D1
        {
            get { return d1; }
            set
            {
                d1 = value;
                lblD1.Text = d1.ToString();
            }
        }

        public int D2
        {
            get { return d2; }
            set
            {
                d2 = value;
                lblD2.Text = d2.ToString();
            }
        }

        public int Dni
        {
            get { return dni; }
            set
            {
                dni = value;
                lblDNI.Text = "DNI: "+dni.ToString();
            }
        }

        public TimeSpan InicioSesion
        {
            get { return inicioSesion; }
            set
            {
                inicioSesion = value;
                lblIS.Text = inicioSesion.ToString(@"hh\:mm") + " hs";
            }
        }
        

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set
            {
                nombreCompleto = value;
                lblNombre.Text = nombreCompleto;
            }
        }

        public ucDatosUsuario()
        {
            InitializeComponent();
            lblF.Text = DateTime.Today.ToString("d MMM yyyy");
        }
        
    }
}
