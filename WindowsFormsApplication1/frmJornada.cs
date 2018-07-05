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
            TimeSpan t_atendiendo = TimeSpan.Zero;
            TimeSpan t_capacitacion = TimeSpan.Zero;
            TimeSpan t_reunion = TimeSpan.Zero;
            TimeSpan t_formularios = TimeSpan.Zero;
            TimeSpan t_descanso = TimeSpan.Zero;
            TimeSpan t_sinContactos = TimeSpan.Zero;
            TimeSpan t_sinCampaña = TimeSpan.Zero;
            TimeSpan t_inactivo= TimeSpan.Zero;

            List<clsJornada> jornadas = conexion.buscar_jornada(idEmpleado, DateTime.Now);
            foreach(clsJornada j in jornadas)
            {
                t_atendiendo = t_atendiendo.Add(j.T_atendiendo);
                t_capacitacion = t_capacitacion.Add(j.T_capacitacion);
                t_reunion = t_reunion.Add(j.T_reunion);
                t_formularios = t_formularios.Add(j.T_llenadoFormularios);
                t_descanso = t_descanso.Add(j.T_descanso);
                t_sinContactos = t_sinContactos.Add(j.T_sinContactos);
                t_sinCampaña = t_sinCampaña.Add(j.T_sinCampaña);
                t_inactivo = t_inactivo.Add(j.T_inactivo);
            }
            lblEnEspera.Text = conexion.calcular_tiempo_espera_total(idEmpleado, DateTime.Now).ToString("hh':'mm':'ss'.'fff");
            lblInactivo.Text = sw_inactivo.Elapsed.Add(t_inactivo).ToString("hh':'mm':'ss'.'fff"); // Sumo tiempos inactivos de jornadas

            lblAtendiendo.Text = t_atendiendo.ToString("hh':'mm':'ss'.'fff");
            lblCapacitacion.Text = t_capacitacion.ToString("hh':'mm':'ss'.'fff");
            lblReunion.Text = t_reunion.ToString("hh':'mm':'ss'.'fff");
            lblFormularios.Text = t_formularios.ToString("hh':'mm':'ss'.'fff");
            lblDescanso.Text = t_descanso.ToString("hh':'mm':'ss'.'fff");
            lblSinContactos.Text = t_sinContactos.ToString("hh':'mm':'ss'.'fff");
            lblSinCampaña.Text = t_sinCampaña.ToString("hh':'mm':'ss'.'fff");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInactivo.Text = sw_inactivo.Elapsed.ToString("hh':'mm':'ss'.'fff");
            //String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }
    }
}
