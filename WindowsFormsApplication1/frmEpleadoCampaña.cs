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
    public partial class frmEpleadoCampaña : Form
    {
        int id_Campaña;
        int id_Empleado;
        clsEmpleado empleado = new clsEmpleado();
        clsConexion conectar = new clsConexion();
        clsCampaña campaña = new clsCampaña();
      
        DateTime desde = new DateTime();
        DateTime hasta = new DateTime();

        public frmEpleadoCampaña( int idCamp,int idEmp)
        {
            InitializeComponent();
            id_Campaña = idCamp;
            id_Empleado = idEmp;

            

        }

     
        private void frmEpleadoCampaña_Load(object sender, EventArgs e)
        {
            lblInfo01.Text = conectar.totalLlamadaEMpleadoCampaña(id_Campaña,id_Empleado,"");
            lblInfo03.Text= conectar.totalVentasEMpleadoCampaña(id_Campaña, id_Empleado);
            lblInfo04.Text = conectar.totalTiempoProductivoFormat(id_Campaña, id_Empleado);
            lblInfo02.Text = conectar.totalTiempoImproductivoFormat(id_Campaña, id_Empleado);

           
            campaña = conectar.datos_campaña(id_Campaña);
            empleado = conectar.datos_empleado2(id_Empleado);

            lbcamp.Text = campaña.Nombre;
            lbcamp2.Text = campaña.NombreCliente;

            lbEmp.Text = empleado.Apellido + " " + empleado.Nombre;


            llenarEstadisticasEmpleadoEnCampaña();
            llenarEstadisticasLlamadasEmpleadoEnCampaña();

        }

        public void llenarEstadisticasEmpleadoEnCampaña()
        {
            double[] tiempos = new double[10];


         



            tiempos = conectar.tiemposCampañaEmpleado(id_Empleado, id_Campaña, desde, hasta);

            
            cPorcentajeVentas.Series["Ventas"].LegendText = "#VALX";


            foreach (var series in cTiempos.Series)
            {
                series.Points.Clear();
            }

            cTiempos.Series["tiempos"].LegendText = "(minutos)";

            Dictionary<string, int> dic = new Dictionary<string, int>();

            dic.Add("En Reunión", Convert.ToInt32(tiempos[0]));
            dic.Add("Atendiendo", Convert.ToInt32(tiempos[1]));
            dic.Add("Llenando Formularios", Convert.ToInt32(tiempos[2]));
            dic.Add("En Capacitación", Convert.ToInt32(tiempos[3]));
            dic.Add("Descanso", Convert.ToInt32(tiempos[4]));
            dic.Add("Sin Contactos", Convert.ToInt32(tiempos[5]));
            dic.Add("Inactivo", Convert.ToInt32(tiempos[6]));
            dic.Add("Baño", Convert.ToInt32(tiempos[7]));
            dic.Add("Almuerzo", Convert.ToInt32(tiempos[8]));
            dic.Add("Sin Campaña", Convert.ToInt32(tiempos[9]));

            foreach (KeyValuePair<string, int> d in dic)
            {
                cTiempos.Series["tiempos"].Points.AddXY(d.Key, d.Value);
            }

        }

        public void llenarEstadisticasLlamadasEmpleadoEnCampaña()
        {
            int[] tiempos = new int[4];

           

            tiempos = conectar.llamadasCampañaEmpleado(id_Empleado, id_Campaña, desde, hasta);
            cPorcentajeVentas.Series["Ventas"].Label = "#PERCENT";
            cPorcentajeVentas.Series["Ventas"].LegendText = "#VALX";


            foreach (var series in cPorcentajeVentas.Series)
            {
                series.Points.Clear();
            }

            //cPorcentajeVentas.Series["Ventas"].LegendText = "(minutos)";

            Dictionary<string, int> dic = new Dictionary<string, int>();

            dic.Add("LLamarDeNuevo", Convert.ToInt32(tiempos[0]));
            dic.Add("No Atendido ", Convert.ToInt32(tiempos[1]));
            dic.Add("No Vendido", Convert.ToInt32(tiempos[2]));
            dic.Add("Vendidos", Convert.ToInt32(tiempos[3]));


            foreach (KeyValuePair<string, int> d in dic)
            {
                cPorcentajeVentas.Series["Ventas"].Points.AddXY(d.Key, d.Value);
                


            }
           
        }

        private void lbEmp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
