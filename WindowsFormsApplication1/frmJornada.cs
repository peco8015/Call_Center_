using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApplication1.clases;

namespace WindowsFormsApplication1
{
    public partial class frmJornada : Form
    {
        clsConexion conexion = new clsConexion();
        Stopwatch sw_inactivo;
        int idEmpleado;

        public frmJornada(int id, Stopwatch sw)
        {
            InitializeComponent();
            sw_inactivo = sw;
            idEmpleado = id;
        }

        private void frmJornada_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
            clsJornada j = conexion.buscar_jornada(idEmpleado, DateTime.Now);
            lblAtendiendo.Text = j.T_atendiendo.ToString("hh':'mm':'ss'.'fff");
            lblEnEspera.Text = conexion.calcular_tiempo_espera_total(idEmpleado, DateTime.Now).ToString("hh':'mm':'ss'.'fff");
            lblCapacitacion.Text = j.T_capacitacion.ToString("hh':'mm':'ss'.'fff");
            lblReunion.Text = j.T_reunion.ToString("hh':'mm':'ss'.'fff");
            lblFormularios.Text = j.T_llenadoFormularios.ToString("hh':'mm':'ss'.'fff");
            lblDescanso.Text = j.T_descanso.ToString("hh':'mm':'ss'.'fff");
            lblSinContactos.Text = j.T_sinContactos.ToString("hh':'mm':'ss'.'fff");
            lblSinCampaña.Text = j.T_sinCampaña.ToString("hh':'mm':'ss'.'fff");
            lblInactivo.Text = sw_inactivo.Elapsed.ToString("hh':'mm':'ss'.'fff");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInactivo.Text = sw_inactivo.Elapsed.ToString("hh':'mm':'ss'.'fff");
            //String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }
    }
}
