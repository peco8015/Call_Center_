﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApplication1.clases;

namespace WindowsFormsApplication1
{
    public partial class frmDetalles : Form
    {
        clsConexion conectar = new clsConexion();
        clsEmpleado empleado;
        clsCliente cliente;
        clsCampaña campaña;
        List<clsEstadisticas> estadisticas;
        List<clsJornada> jornadas;
        string clase;
        int identificador;

        public frmDetalles(string t, int id)
        {
            InitializeComponent();
            clase = t;
            identificador = id;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            switch (clase)
            {
                case "empleado":
                    empleado = conectar.datos_empleado(identificador); // DNI para empleado
                    break;

                case "cliente":
                    cliente = conectar.datos_cliente(identificador);
                    break;

                case "campaña":
                    campaña = conectar.datos_campaña(identificador);
                    cliente = conectar.datos_cliente(campaña.IdCliente);
                    break;
            }
            setearForm();
        }
        
        private void tcFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = (sender as TabControl);
            //  Limpio los Points de cada Chart
            foreach (Control c in tc.SelectedTab.Controls)
            {
                if (c.GetType() == typeof(Chart))
                {
                    foreach (Series sc in (c as Chart).Series)
                    {
                        sc.Points.Clear();
                    }
                }
            }
            DateTime fechaAUX = DateTime.Today;
            switch (tc.SelectedTab.Name)
            {
                case "tpHoy":
                        //fechaAUX = DateTime.Today;
                        fechaAUX = Convert.ToDateTime("2018-04-17");
                        break;

                case "tpSemana":
                        fechaAUX = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                        break;

                case "tpMes":
                        fechaAUX = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        //DateTime aux = new DateTime(2018, 5, 12);
                        //fechaAUX = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                        //fechaAUX = aux.AddDays(-(int)aux.DayOfWeek + (int)DayOfWeek.Monday);
                        break;
            }
            llenarCharts(fechaAUX, tc.SelectedTab.Name);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbInformacion.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    (c as TextBox).ReadOnly = false;
                if (c.GetType() == typeof(DateTimePicker))
                    (c as DateTimePicker).Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // funcion de eliminar lo que sea
            switch (clase)
            {
                case "empleado":
                    break;
                case "cliente":
                    break;
                case "campaña":
                    break;
            }
        }


        #region Funciones
        private void setearForm()
        {
            switch (clase)
            {
                case "empleado":
                    this.Text = "Detalles de empleado";
                    label1.Text = "# " + empleado.Id_empleado.ToString() + " - " + empleado.Apellido + ", " + empleado.Nombre;
                    label3.Text = "Nombre";
                    label4.Text = "Apellido";
                    label5.Text = "DNI";
                    label6.Text = "Telefono";
                    label7.Text = "Mail";
                    label8.Text = "Domicilio";
                    label9.Text = "Nacimiento";
                    label10.Text = "Fecha de ingreso";
                    label11.Text = "Campaña actual";
                    gbContacto.Visible = false;

                    // Datos de obj
                    tb01.Text = empleado.Nombre;
                    tb02.Text = empleado.Apellido;
                    tb03.Text = empleado.Dni.ToString();
                    tb04.Text = empleado.Telefono;
                    tb05.Text = empleado.Mail;
                    tb06.Text = empleado.Domicilio;
                    tb07.Text = empleado.Id_campaña.ToString(); // NOOOO tiene que ir el nombre de la campaña
                    dtp01.Value = Convert.ToDateTime(empleado.FechaNaciemiento);
                    dtp02.Value = Convert.ToDateTime(empleado.FechaInicio);
                    break;

                case "cliente":
                    this.Text = "Detalles de cliente";
                    label1.Text = "# " + cliente.Id.ToString() + " - " + cliente.Nombre;
                    label3.Text = "Nombre";
                    label4.Text = "CUIL";
                    label5.Text = "Domicilio";
                    gbContacto.Visible = true;
                    label6.Text = "Nombre";
                    label7.Text = "Mail";
                    label8.Text = "Telefono";
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;

                    // Datos de obj
                    tb01.Text = cliente.Nombre;
                    tb02.Text = cliente.Cuil.ToString();
                    tb03.Text = cliente.Domicilio;
                    tb04.Text = cliente.Contacto;
                    tb05.Text = cliente.Mail;
                    tb06.Text = cliente.Telefono.ToString();
                    tb07.Visible = false;
                    dtp01.Visible = false;
                    dtp02.Visible = false;
                    break;

                case "campaña":
                    this.Text = "Detalles de campaña";
                    label1.Text = "# " + campaña.IdCampaña.ToString() + " - " + campaña.Nombre;
                    label3.Text = "Campaña";
                    label4.Text = "Precio";
                    label5.Text = "Cliente";
                    gbContacto.Visible = true;
                    label6.Text = "Nombre";
                    label7.Text = "Telefono";
                    label8.Text = "Mail";
                    label9.Text = "Fecha de inicio";
                    label10.Text = "Fecha de fin";
                    label11.Text = "Descripción";
                    // especificaciones?

                    // Datos de obj
                    tb01.Text = campaña.Nombre;
                    tb02.Text = campaña.Precio.ToString();
                    tb03.Text = campaña.NombreCliente;
                    tb04.Text = cliente.Contacto;
                    tb05.Text = cliente.Telefono.ToString();
                    tb06.Text = cliente.Mail;
                    tb07.Text = campaña.Descripion;
                    dtp01.Value = Convert.ToDateTime(campaña.Fecha_inicio);
                    dtp02.Value = Convert.ToDateTime(campaña.Fecha_fin);
                    break;
            }
            tb01.ReadOnly = true;
            tb02.ReadOnly = true;
            tb03.ReadOnly = true;
            tb04.ReadOnly = true;
            tb05.ReadOnly = true;
            tb06.ReadOnly = true;
            tb07.ReadOnly = true;
            dtp01.Enabled = false;
            dtp02.Enabled = false;

            llenarCharts(DateTime.Today, tcFechas.SelectedTab.Name);
        }

        private void llenarCharts(DateTime fecha, string filtro)
        {
            TimeSpan t_atendiendo = TimeSpan.Zero;
            TimeSpan t_descanso = TimeSpan.Zero;
            TimeSpan t_reunion = TimeSpan.Zero;
            TimeSpan t_llenadoFormularios = TimeSpan.Zero;
            TimeSpan t_sinContactos = TimeSpan.Zero;
            TimeSpan t_sinCampaña = TimeSpan.Zero;
            TimeSpan t_inactivo = TimeSpan.Zero;
            TimeSpan t_baño = TimeSpan.Zero;
            TimeSpan t_capacitacion = TimeSpan.Zero;
            TimeSpan t_almuerzo = TimeSpan.Zero;
            try
            {
                switch (clase)
                {
                    case "empleado":
                        break;

                    case "cliente":
                        estadisticas = conectar.numeros_cliente(cliente.Id, filtro, fecha);
                        if (estadisticas != null)
                        {
                            float total_ventas = estadisticas.Find(x => x.Clave == "Cant ventas").Valor;
                            float total_llamadas = estadisticas.Find(x => x.Clave == "Cant llamadas").Valor;

                            //cPorcentajeVentas.Series["Ventas"].IsValueShownAsLabel = true;
                            cPorcentajeVentas.Series["Ventas"].Label = "#PERCENT";
                            cPorcentajeVentas.Series["Ventas"].LegendText = "#VALX";
                            cPorcentajeVentas.Series["Ventas"].Points.AddXY("Ventas", total_ventas);
                            cPorcentajeVentas.Series["Ventas"].Points.AddXY("Llamadas", total_llamadas);
                        }
                        else
                            MessageBox.Show("No es posible mostrar el PORCENTAJE DE VENTAS, ya que no se encuentran disponibles.", "Notificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        estadisticas = conectar.campañas_cliente(cliente.Id, filtro, fecha);
                        if (estadisticas != null)
                        {
                            if (estadisticas.Count == 1)
                                cVentasCampaña.Series["Campañas"].ChartType = SeriesChartType.Column;
                            foreach (clsEstadisticas est in estadisticas)
                            {
                                cVentasCampaña.Series["Campañas"].Points.AddXY(est.Clave,est.Valor);
                            }
                        }
                        else
                            MessageBox.Show("No es posible mostrar las VENTAS POR CAMPAÑA, ya que no se encuentran disponibles.", "Notificación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        jornadas = conectar.jornadas_cliente(cliente.Id, filtro, fecha);
                        if (jornadas != null)
                        {
                            foreach (clsJornada j in jornadas)
                            {
                                // Tiempos productivos
                                t_atendiendo = t_atendiendo.Add(j.T_atendiendo);
                                t_capacitacion = t_capacitacion.Add(j.T_capacitacion);
                                t_reunion = t_reunion.Add(j.T_reunion);
                                t_llenadoFormularios = t_llenadoFormularios.Add(j.T_llenadoFormularios);
                                // Tiempos no productivos
                                t_descanso = t_descanso.Add(j.T_descanso);
                                t_sinContactos = t_sinContactos.Add(j.T_sinContactos);
                                t_sinCampaña = t_sinCampaña.Add(j.T_sinCampaña);
                                t_inactivo = t_inactivo.Add(j.T_inactivo);
                                t_baño = t_baño.Add(j.T_baño);
                                t_almuerzo = t_almuerzo.Add(j.T_almuerzo);
                            }
                            cTiempos.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
                            // Serie Productivo
                            cTiempos.Series["Productivo"].Points.AddXY("Atendiendo", t_atendiendo.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Capacitación", t_capacitacion.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Reunión", t_reunion.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Formularios", t_llenadoFormularios.TotalMinutes);
                            // Serie No productiva
                            cTiempos.Series["Productivo"].Points.AddXY("Descanso", t_descanso.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Inactivo", t_inactivo.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Baño", t_baño.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Almuerzo", t_almuerzo.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Sin Contactos", t_sinContactos.TotalMinutes);
                            cTiempos.Series["Productivo"].Points.AddXY("Sin Campaña", t_sinCampaña.TotalMinutes);
                            for (int i = 4; i < cTiempos.Series["Productivo"].Points.Count; i++)
                            {
                                cTiempos.Series["Productivo"].Points[i].Color = Color.LimeGreen; //pale
                            }

                        }
                        break;

                    case "campaña":
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}