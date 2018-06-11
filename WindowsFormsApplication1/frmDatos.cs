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
    public partial class frmDatos : Form
    {

        int dni;
        string control;
        Form padre;
        clsEmpleado empleado = new clsEmpleado();
        clsConexion conectar = new clsConexion();
        clsCampaña campaña = new clsCampaña();

        public frmDatos(Form fjefe, int dni, string control)
        {
            InitializeComponent();

            this.dni = dni;
            this.control = control;
            padre = fjefe;
        }






        private void FormDatos_Load(object sender, EventArgs e)
        {
            empleado = conectar.datos_empleado(dni);
           campaña= conectar.datos_campaña_empleado(empleado.Id_campaña);

            lbId.Text = "Id: " + empleado.Id_empleado.ToString();
            tbApellido.Text = empleado.Apellido;
            tbNombre.Text = empleado.Nombre;
            tbDni.Text = empleado.Dni.ToString();
            tbInicio.Text = empleado.FechaInicio.ToString();
            tbNacimiento.Text = empleado.FechaNaciemiento.ToString();
            tbDomicilio.Text = empleado.Domicilio;
            tbTel.Text = empleado.Telefono;
            tbMail.Text = empleado.Mail;
            lbcampañaAsig.Text = campaña.Nombre;
            rbTiemposHoy.Checked = true;
            rbTiemposSemana.Checked = true;
            rbTiemposMes.Checked = true;
            rbTiemposAño.Checked = true;




            //--------------------load tabcontrol hoy----------------------------
            int hoyProd = conectar.tiempoHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int hoyImprod = conectar.tiempoHoyImproductivo(DateTime.Now);

            int tot = hoyProd + hoyImprod;
            if (tot == 0)
            {
                tot = 1;

            }
            float hours1 = (hoyProd * 100) / tot;
            float hours2 = (hoyImprod * 100) / tot;




            chProdHoy.Series["Tiempos"].Points.AddXY(hours1.ToString() + " %", hoyProd);
            chProdHoy.Series["Tiempos"].Points.AddXY(hours2.ToString() + " %", hoyImprod);

            chProdHoy.Series["Tiempos"].Points[0].LegendText = "";
            chProdHoy.Series["Tiempos"].Points[1].LegendText = "";



            foreach (var series in chDeatailHoy1.Series)
            {
                series.Points.Clear();
            }



            chDeatailHoy1.Series["Tiempos"].LegendText = "(minutos)";

            int t_capacitacion = conectar.tiempoDetalleCapacitacionHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_formu = conectar.tiempoDetalleFormularioHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_atendiendo = conectar.tiempoDetalleAtendiendoHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_reunion = conectar.tiempoDetalleReunionHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_descanso = conectar.tiempoDetalleDescansoHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_sincontact = conectar.tiempoDetalleSinContactoHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_sincamp = conectar.tiempoDetalleSinCampañaHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_inactivo = conectar.tiempoDetalleInactivoHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_baño = conectar.tiempoDetalleBañoHoyProductivo(DateTime.Now, empleado.Id_empleado);
            int t_almuerzo = conectar.tiempoDetalleAlmuerzoHoyProductivo(DateTime.Now, empleado.Id_empleado);

            Dictionary<string, int> dic = new Dictionary<string, int>();

            dic.Add("En Reunión", t_reunion);
            dic.Add("Atendiendo", t_atendiendo);
            dic.Add("Llenando Formularios", t_formu);
            dic.Add("En Capacitación", t_capacitacion);
            dic.Add("Descanso", t_descanso);
            dic.Add("Sin Contactos", t_sincontact);
            dic.Add("Inactivo", t_inactivo);
            dic.Add("Baño", t_baño);
            dic.Add("Almuerzo", t_almuerzo);
            // dic.Add("Sin Campaña", t_sincamp);



            foreach (KeyValuePair<string, int> d in dic)
            {
                chDeatailHoy1.Series["Tiempos"].Points.AddXY(d.Key, d.Value);
            }





        }

        private void Bt_UpdateEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void lbDetail_Click(object sender, EventArgs e)
        {

        }

        private void btDetail_Click(object sender, EventArgs e)
        {




        }

        private void btDetailSem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)//año
        {
            int AñoProd = conectar.tiempoAñoProductivo(empleado.Id_empleado);
            int AñoImprod = conectar.tiempoAñoImproductivo(empleado.Id_empleado);

            int tot4 = AñoProd + AñoImprod;
            float hours4s = (AñoProd * 100) / tot4;
            float hours4ss = (AñoImprod * 100) / tot4;

            chProdAño.Series["Tiempos"].Points.AddXY(hours4s.ToString() + " %", AñoProd);
            chProdAño.Series["Tiempos"].Points.AddXY(hours4ss.ToString() + " %", AñoProd);


            chProdAño.Series["Tiempos"].Points[0].LegendText = "PRODUCTIVO";
            chProdAño.Series["Tiempos"].Points[1].LegendText = "NO  PRODUCTIVO";
        }

        private void tabPage1_Click(object sender, EventArgs e)//hoy
        {
            pnVentaHoy.Visible = false;




        }

        private void tabPage3_Click(object sender, EventArgs e)//mes
        {
            int MesProd = conectar.tiempoMesProductivo(empleado.Id_empleado);
            int MesImprod = conectar.tiempoMesImproductivo(empleado.Id_empleado);

            int tot3 = MesProd + MesImprod;
            float hours3s = (MesProd * 100) / tot3;
            float hours3ss = (MesImprod * 100) / tot3;

            chProdMes.Series["Tiempos"].Points.AddXY(hours3s.ToString() + " %", MesProd);
            chProdMes.Series["Tiempos"].Points.AddXY(hours3ss.ToString() + " %", MesProd);

            chProdMes.Series["Tiempos"].Points[0].LegendText = "PRODUCTIVO";
            chProdMes.Series["Tiempos"].Points[1].LegendText = "NO  PRODUCTIVO";

        }

        private void tabPage5_Click(object sender, EventArgs e)//histry
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)//semana
        {
            pnVentaSemana.Visible = false;




        }


        private void chProdSemana_Click(object sender, EventArgs e)
        {

        }

        private void plDatosEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rbVentasMes.SelectedIndex)
            {
                /*hoy*/
                case 0:
                    foreach (var series in chProdHoy.Series)
                    {
                        series.Points.Clear();
                    }

                 
                    int hoyProd = conectar.tiempoHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int hoyImprod = conectar.tiempoHoyImproductivo(DateTime.Now);

                    int tot = hoyProd + hoyImprod;

                    if (tot == 0)
                    {
                        tot = 1;

                    }
                    float hours1 = (hoyProd * 100) / tot;
                    float hours2 = (hoyImprod * 100) / tot;




                    chProdHoy.Series["Tiempos"].Points.AddXY(hours1.ToString() + " %", hoyProd);
                    chProdHoy.Series["Tiempos"].Points.AddXY(hours2.ToString() + " %", hoyImprod);

                    chProdHoy.Series["Tiempos"].Points[0].LegendText = "";
                    chProdHoy.Series["Tiempos"].Points[1].LegendText = "";



                    foreach (var series in chDeatailHoy1.Series)
                    {
                        series.Points.Clear();
                    }



                    chDeatailHoy1.Series["Tiempos"].LegendText = "(minutos)";

                    int t_capacitacion = conectar.tiempoDetalleCapacitacionHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_formu = conectar.tiempoDetalleFormularioHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_atendiendo = conectar.tiempoDetalleAtendiendoHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_reunion = conectar.tiempoDetalleReunionHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_descanso = conectar.tiempoDetalleDescansoHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_sincontact = conectar.tiempoDetalleSinContactoHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_sincamp = conectar.tiempoDetalleSinCampañaHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_inactivo = conectar.tiempoDetalleInactivoHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_baño = conectar.tiempoDetalleBañoHoyProductivo(DateTime.Now, empleado.Id_empleado);
                    int t_almuerzo = conectar.tiempoDetalleAlmuerzoHoyProductivo(DateTime.Now, empleado.Id_empleado);

                    Dictionary<string, int> dic = new Dictionary<string, int>();
                    dic.Add("En Reunión", t_reunion);
                    dic.Add("Atendiendo", t_atendiendo);
                    dic.Add("Llenando Formularios", t_formu);
                    dic.Add("En Capacitación", t_capacitacion);
                    dic.Add("Descanso", t_descanso);
                    dic.Add("Sin Contactos", t_sincontact);
                    dic.Add("Inactivo", t_inactivo);
                    dic.Add("Baño", t_baño);
                    dic.Add("Almuerzo", t_almuerzo);
                    //dic.Add("Sin Campaña", t_sincamp);





                    foreach (KeyValuePair<string, int> d in dic)
                    {
                        chDeatailHoy1.Series["Tiempos"].Points.AddXY(d.Key, d.Value);
                    }
                    break;


                /*semana*/
                case 1:

                    foreach (var series in chProdSemana.Series)
                    {
                        series.Points.Clear();
                    }

                   


                    int SemanaProd = conectar.tiempoSemanaProductivo(empleado.Id_empleado);
                    int SemanaImprod = conectar.tiempoSemanaImproductivo(empleado.Id_empleado);

                    int tot2 = SemanaProd + SemanaImprod;
                    float hours1s = (SemanaProd * 100) / tot2;
                    float hours2s = (SemanaImprod * 100) / tot2;


                    chProdSemana.Series["Tiempos"].Points.AddXY(hours1s.ToString() + " %", SemanaProd);
                    chProdSemana.Series["Tiempos"].Points.AddXY(hours2s.ToString() + " %", SemanaImprod);

                    chProdSemana.Series["Tiempos"].Points[0].LegendText = "";
                    chProdSemana.Series["Tiempos"].Points[1].LegendText = "";

                    foreach (var series in chDeatailSemana.Series)
                    {
                        series.Points.Clear();
                    }



                    chDeatailSemana.Series["Tiempos"].LegendText = "";

                    int t_capacitacion1 = conectar.tiempoDetalleCapacitacionSemana(empleado.Id_empleado);
                    int t_formu1 = conectar.tiempoDetalleFormularioSemana(empleado.Id_empleado);
                    int t_atendiendo1 = conectar.tiempoDetalleAtendiendoSemana(empleado.Id_empleado);
                    int t_reunion1 = conectar.tiempoDetalleReunionSemana(empleado.Id_empleado);
                    int t_descanso1a = conectar.tiempoDetalleDescansoSemana(empleado.Id_empleado);
                    int t_sincontact1a = conectar.tiempoDetalleSinContactoSemana(empleado.Id_empleado);
                    int t_sincamp1a = conectar.tiempoDetalleSinCampañaSemana(empleado.Id_empleado);
                    int t_inactivo1a = conectar.tiempoDetalleInactivoSemana(empleado.Id_empleado);
                    int t_baño1a = conectar.tiempoDetalleBañoSemana(empleado.Id_empleado);
                    int t_almuerzo1a = conectar.tiempoDetalleAlmuerzoSemana(empleado.Id_empleado);

                    Dictionary<string, int> dic1 = new Dictionary<string, int>();
                    dic1.Add("En Reunión", t_reunion1);
                    dic1.Add("Atendiendo", t_atendiendo1);
                    dic1.Add("Llenando Formularios", t_formu1);
                    dic1.Add("En Capacitación", t_capacitacion1);
                    dic1.Add("Descanso", t_descanso1a);
                    dic1.Add("Sin Contactos", t_sincontact1a);
                    dic1.Add("Sin Campaña", t_sincamp1a);
                    dic1.Add("Inactivo", t_inactivo1a);
                    dic1.Add("Baño", t_baño1a);
                    //dic1.Add("Almuerzo", t_almuerzo1a);


                    foreach (KeyValuePair<string, int> d in dic1)
                    {
                        chDeatailSemana.Series["Tiempos"].Points.AddXY(d.Key, d.Value);
                    }



                    break;

                /*Mes*/
                case 2:
                    foreach (var series in chProdMes.Series)
                    {
                        series.Points.Clear();
                    }

                  


                    int MesProd = conectar.tiempoMesProductivo(empleado.Id_empleado);
                    int MesImprod = conectar.tiempoMesImproductivo(empleado.Id_empleado);

                    int tot3 = MesProd + MesImprod;
                    float hours1m = (MesProd * 100) / tot3;
                    float hours2m = (MesImprod * 100) / tot3;


                    chProdMes.Series["Tiempos"].Points.AddXY(hours1m.ToString() + " %", MesProd);
                    chProdMes.Series["Tiempos"].Points.AddXY(hours2m.ToString() + " %", MesImprod);

                    chProdMes.Series["Tiempos"].Points[0].LegendText = "";
                    chProdMes.Series["Tiempos"].Points[1].LegendText = "";

                    foreach (var series in chDeatailMes.Series)
                    {
                        series.Points.Clear();
                    }



                    chDeatailMes.Series["Tiempos"].LegendText = "";

                    int t_capacitacion2 = conectar.tiempoDetalleCapacitacionMes(empleado.Id_empleado);
                    int t_formu2 = conectar.tiempoDetalleFormularioMes(empleado.Id_empleado);
                    int t_atendiendo2 = conectar.tiempoDetalleAtendiendoMes(empleado.Id_empleado);
                    int t_reunion2 = conectar.tiempoDetalleReunionMes(empleado.Id_empleado);
                    int t_descanso1m = conectar.tiempoDetalleDescansoMes(empleado.Id_empleado);
                    int t_sincontact1m = conectar.tiempoDetalleSinContactoMes(empleado.Id_empleado);
                    int t_sincamp1m = conectar.tiempoDetalleSinCampañaMes(empleado.Id_empleado);
                    int t_inactivo1m = conectar.tiempoDetalleInactivoMes(empleado.Id_empleado);
                    int t_baño1m = conectar.tiempoDetalleBañoMes(empleado.Id_empleado);
                    int t_almuerzo1m = conectar.tiempoDetalleAlmuerzoMes(empleado.Id_empleado);

                    Dictionary<string, int> dicm = new Dictionary<string, int>();
                    dicm.Add("En Reunión", t_reunion2);
                    dicm.Add("Atendiendo", t_atendiendo2);
                    dicm.Add("Llenando Formularios", t_formu2);
                    dicm.Add("En Capacitación", t_capacitacion2);
                    dicm.Add("Descanso", t_descanso1m);
                    dicm.Add("Sin Contactos", t_sincontact1m);
                    dicm.Add("Sin Campaña", t_sincamp1m);
                    dicm.Add("Inactivo", t_inactivo1m);
                    dicm.Add("Baño", t_baño1m);
                    //dicm.Add("Almuerzo", t_almuerzo1m);

                    foreach (KeyValuePair<string, int> d in dicm)
                    {
                        chDeatailMes.Series["Tiempos"].Points.AddXY(d.Key, d.Value);
                    }
                    break;

                /*año*/
                case 3:
                    foreach (var series in chProdAño.Series)
                    {
                        series.Points.Clear();//wqewqeqw
                    }

                  

                    int AñoProd = conectar.tiempoAñoProductivo(empleado.Id_empleado);
                    int AñoImprod = conectar.tiempoAñoImproductivo(empleado.Id_empleado);

                    int tot4 = AñoProd + AñoImprod;
                    float hours1a = (AñoProd * 100) / tot4;
                    float hours2a = (AñoImprod * 100) / tot4;


                    chProdAño.Series["Tiempos"].Points.AddXY(hours1a.ToString() + " %", AñoProd);
                    chProdAño.Series["Tiempos"].Points.AddXY(hours2a.ToString() + " %", AñoImprod);

                    chProdAño.Series["Tiempos"].Points[0].LegendText = "";
                    chProdAño.Series["Tiempos"].Points[1].LegendText = "";

                    foreach (var series in chDeatailAño.Series)
                    {
                        series.Points.Clear();
                    }



                    chDeatailAño.Series["Tiempos"].LegendText = "";

                    int t_capacitacion3 = conectar.tiempoDetalleCapacitacionAño(empleado.Id_empleado);
                    int t_formu3 = conectar.tiempoDetalleFormularioAño(empleado.Id_empleado);
                    int t_atendiendo3 = conectar.tiempoDetalleAtendiendoAño(empleado.Id_empleado);
                    int t_reunion3 = conectar.tiempoDetalleReunionAño(empleado.Id_empleado);
                    int t_descanso3a = conectar.tiempoDetalleDescansoAño(empleado.Id_empleado);
                    int t_sincontact3a = conectar.tiempoDetalleSinContactoAño(empleado.Id_empleado);
                    int t_sincamp3a = conectar.tiempoDetalleSinCampañaAño(empleado.Id_empleado);
                    int t_inactivo3a = conectar.tiempoDetalleInactivoAño(empleado.Id_empleado);
                    int t_baño3a = conectar.tiempoDetalleBañoAño(empleado.Id_empleado);
                    int t_almuerzo3a = conectar.tiempoDetalleAlmuerzoAño(empleado.Id_empleado);

                    Dictionary<string, int> dica = new Dictionary<string, int>();
                    dica.Add("En Reunión", t_reunion3);
                    dica.Add("Atendiendo", t_atendiendo3);
                    dica.Add("Llenando Formularios", t_formu3);
                    dica.Add("En Capacitación", t_capacitacion3);
                    dica.Add("Descanso", t_descanso3a);
                    dica.Add("Sin Contactos", t_sincontact3a);
                    dica.Add("Sin Campaña", t_sincamp3a);
                    dica.Add("Inactivo", t_inactivo3a);
                    dica.Add("Baño", t_baño3a);
                    dica.Add("Almuerzo", t_almuerzo3a);



                    foreach (KeyValuePair<string, int> d in dica)
                    {
                        chDeatailAño.Series["Tiempos"].Points.AddXY(d.Key, d.Value);
                    }
                    break;

                case 4: MessageBox.Show("history"); break;



            }
        }

        private void chDeatailSemana2_Click(object sender, EventArgs e)
        {

        }


        private void rbTiemposHoy_CheckedChanged(object sender, EventArgs e)

        {
            rbVentasHoy.Checked = false;
            pnVentaHoy.Visible = false;





        }
        int[] resVenta = new int[] { 0, 0, 0, 0 };

        private void rbVentasHoy_CheckedChanged(object sender, EventArgs e)// estadisticas ventas hoy
        {
            rbTiemposHoy.Checked = false;
              

            pnVentaHoy.Visible = true;
     

            foreach (var series in chVentasHoy.Series)
            {
                series.Points.Clear();
            }
            foreach (var series2 in chVentasHoy2.Series)
            {
                series2.Points.Clear();
            }

            resVenta = conectar.totalTodasLlamadasHoy(DateTime.Now, empleado.Id_empleado);


            int total = resVenta[0] + resVenta[1] + resVenta[2] + resVenta[3];
            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido
            int porVendido = (resVenta[3] * 100) / total;
            int porNoAtendio = (resVenta[1] * 100) / total;
            int porLlamarDeNuevo = (resVenta[0] * 100) / total;
            int porNoVendido = (resVenta[2] * 100) / total;




            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido
            chVentasHoy2.Series["Tiempos"].Points.AddXY(porNoVendido.ToString() + " %", resVenta[2]);
            chVentasHoy2.Series["Tiempos"].Points.AddXY(porLlamarDeNuevo.ToString() + " %", resVenta[0]);
            chVentasHoy2.Series["Tiempos"].Points.AddXY(porNoAtendio.ToString() + " %", resVenta[1]);
            chVentasHoy2.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", resVenta[3]);

            chVentasHoy2.Series["Tiempos"].Points[0].LegendText = "NoVendido";
            chVentasHoy2.Series["Tiempos"].Points[1].LegendText = "Llamar de Nuevo";
            chVentasHoy2.Series["Tiempos"].Points[2].LegendText = "No Atendio";
            chVentasHoy2.Series["Tiempos"].Points[3].LegendText = "Vendido";





            chVentasHoy.Series["Tiempos"].Points.AddXY((100 - porVendido).ToString() + " %", 100 - porVendido);
            chVentasHoy.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", porVendido);

            chVentasHoy.Series["Tiempos"].Points[0].LegendText = "Total Llamdas";
            chVentasHoy.Series["Tiempos"].Points[1].LegendText = "Ventas Realizadas";
            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido
            lbTotalLlamada.Text = total.ToString();
            lbTotalVentas.Text = resVenta[3].ToString();
            lbVovlverLlamar.Text = resVenta[0].ToString();
            lbNoVendidas.Text = resVenta[2].ToString();
            lbNoAtendidas.Text = resVenta[1].ToString();



        }

        private void rbTiemposSemana_CheckedChanged(object sender, EventArgs e)
        {
            rbVentasSemana.Checked = false;
            pnVentaSemana.Visible = false;
        }

        private void rbVentasSemana_CheckedChanged(object sender, EventArgs e)  /*ventas semana*/
        {
            rbTiemposSemana.Checked = false;
            pnVentaSemana.Visible = true;

            foreach (var series in chVentasSemana2.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chVentasSemana.Series)
            {
                series.Points.Clear();
            }

            resVenta = conectar.totalTodasLlamadasSemana(DateTime.Now, empleado.Id_empleado);


            int total = resVenta[0] + resVenta[1] + resVenta[2] + resVenta[3];
            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido
            int porVendido = (resVenta[3] * 100) / total;
            int porNoAtendio = (resVenta[1] * 100) / total;
            int porLlamarDeNuevo = (resVenta[0] * 100) / total;
            int porNoVendido = (resVenta[2] * 100) / total;





            chVentasSemana.Series["Tiempos"].Points.AddXY(porNoVendido.ToString() + " %", resVenta[2]);
            chVentasSemana.Series["Tiempos"].Points.AddXY(porLlamarDeNuevo.ToString() + " %", resVenta[0]);
            chVentasSemana.Series["Tiempos"].Points.AddXY(porNoAtendio.ToString() + " %", resVenta[1]);
            chVentasSemana.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", resVenta[3]);

            chVentasSemana.Series["Tiempos"].Points[0].LegendText = "NoVendido";
            chVentasSemana.Series["Tiempos"].Points[1].LegendText = "Llamar de Nuevo";
            chVentasSemana.Series["Tiempos"].Points[2].LegendText = "No Atendio";
            chVentasSemana.Series["Tiempos"].Points[3].LegendText = "Vendido";





            chVentasSemana2.Series["Tiempos"].Points.AddXY((100 - porVendido).ToString() + " %", 100 - porVendido);
            chVentasSemana2.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", porVendido);

            chVentasSemana2.Series["Tiempos"].Points[0].LegendText = "Total Llamdas";
            chVentasSemana2.Series["Tiempos"].Points[1].LegendText = "Ventas Realizadas";

            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido

            lbTotalLlamadasSemana.Text = total.ToString();

            lbVentasSemana.Text = resVenta[3].ToString();
            lbVolverSemana.Text = resVenta[0].ToString();
            lbNoVendidasSemana.Text = resVenta[2].ToString();
            lbNoAtendSemana.Text = resVenta[1].ToString();

        }

        private void rbTiemposMes_CheckedChanged(object sender, EventArgs e)
        {
            rbVentasMes_.Checked = false;
            pnVentaMes.Visible = false;
        }

        private void rbVentasMes__CheckedChanged(object sender, EventArgs e) // ventas mes
        {
            rbTiemposMes.Checked = false;
            pnVentaMes.Visible = true;

            foreach (var series in chVentasMes2.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chVentasMes.Series)
            {
                series.Points.Clear();
            }

            resVenta = conectar.totalTodasLlamadasMes(DateTime.Now, empleado.Id_empleado);


            int total = resVenta[0] + resVenta[1] + resVenta[2] + resVenta[3];
            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido
            int porVendido = (resVenta[3] * 100) / total;
            int porNoAtendio = (resVenta[1] * 100) / total;
            int porLlamarDeNuevo = (resVenta[0] * 100) / total;
            int porNoVendido = (resVenta[2] * 100) / total;



            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido

            chVentasMes.Series["Tiempos"].Points.AddXY(porNoVendido.ToString() + " %", resVenta[2]);
            chVentasMes.Series["Tiempos"].Points.AddXY(porLlamarDeNuevo.ToString() + " %", resVenta[0]);
            chVentasMes.Series["Tiempos"].Points.AddXY(porNoAtendio.ToString() + " %", resVenta[1]);
            chVentasMes.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", resVenta[3]);

            chVentasMes.Series["Tiempos"].Points[0].LegendText = "NoVendido";
            chVentasMes.Series["Tiempos"].Points[1].LegendText = "Llamar de Nuevo";
            chVentasMes.Series["Tiempos"].Points[2].LegendText = "No Atendio";
            chVentasMes.Series["Tiempos"].Points[3].LegendText = "Vendido";





            chVentasMes2.Series["Tiempos"].Points.AddXY((100 - porVendido).ToString() + " %", 100 - porVendido);
            chVentasMes2.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", porVendido);

            chVentasMes2.Series["Tiempos"].Points[0].LegendText = "Total Llamdas";
            chVentasMes2.Series["Tiempos"].Points[1].LegendText = "Ventas Realizadas";

            lbTotalLlamadasMes.Text = total.ToString();
            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido

            lbVentasMes.Text = resVenta[3].ToString();
            lbVolverMes.Text = resVenta[0].ToString();
            lbNoVendidasMes.Text = resVenta[2].ToString();
            lbNoAtendMes.Text = resVenta[1].ToString();

        }

        private void chVentasAño_Click(object sender, EventArgs e)
        {

        }

        private void rbTiemposAño_CheckedChanged(object sender, EventArgs e)
        {

            rbVentasAño.Checked = false;
            pnVentaAño.Visible = false;

        }

        private void rbVentasAño_CheckedChanged(object sender, EventArgs e) //ventas año
        {

            rbTiemposAño.Checked = false;
            pnVentaAño.Visible = true;

            foreach (var series in chVentasAño2.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chVentasAño.Series)
            {
                series.Points.Clear();
            }

            resVenta = conectar.totalTodasLlamadasAño(DateTime.Now, empleado.Id_empleado);


            int total = resVenta[0] + resVenta[1] + resVenta[2] + resVenta[3];
            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido
            int porVendido = (resVenta[3] * 100) / total;
            int porNoAtendio = (resVenta[1] * 100) / total;
            int porLlamarDeNuevo = (resVenta[0] * 100) / total;
            int porNoVendido = (resVenta[2] * 100) / total;





            chVentasAño.Series["Tiempos"].Points.AddXY(porNoVendido.ToString() + " %", resVenta[2]);
            chVentasAño.Series["Tiempos"].Points.AddXY(porLlamarDeNuevo.ToString() + " %", resVenta[0]);
            chVentasAño.Series["Tiempos"].Points.AddXY(porNoAtendio.ToString() + " %", resVenta[1]);
            chVentasAño.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", resVenta[3]);

            chVentasAño.Series["Tiempos"].Points[2].LegendText = "NoVendido";
            chVentasAño.Series["Tiempos"].Points[0].LegendText = "Llamar de Nuevo";
            chVentasAño.Series["Tiempos"].Points[1].LegendText = "No Atendio";
            chVentasAño.Series["Tiempos"].Points[3].LegendText = "Vendido";





            chVentasAño2.Series["Tiempos"].Points.AddXY((100 - porVendido).ToString() + " %", 100 - porVendido);
            chVentasAño2.Series["Tiempos"].Points.AddXY(porVendido.ToString() + " %", porVendido);

            chVentasAño2.Series["Tiempos"].Points[0].LegendText = "Total Llamdas";
            chVentasAño2.Series["Tiempos"].Points[1].LegendText = "Ventas Realizadas";

            lbTotalllamadasAño.Text = total.ToString();
            //0-llamar de nuevo ;1 no atendido -;2- no vendido ;3- vendido

            lbVentasAño.Text = resVenta[3].ToString();
            lbVolverLlamarAño.Text = resVenta[0].ToString();
            llbNoVendAño.Text = resVenta[2].ToString();
            lbNoAtendAño.Text = resVenta[1].ToString();
        }

        private void pnVentaSemana_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNewCamp_Click(object sender, EventArgs e)
        {
            panelCampañas.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DataTable dTable = new DataTable();
            dTable = conectar.obtenerCampañas();


            foreach (DataRow fila in dTable.Rows)
            {

                listBox1.Items.Add(Convert.ToString(fila[0]));


            }

            panelCampañas.Visible = false;
        }




        /* chProdHoy.Series["Tiempos"].Points.AddXY("Productivo", 50);
                    chProdHoy.Series["Tiempos"].Points.AddXY("Improducticvo", 50);*/








    }
}
