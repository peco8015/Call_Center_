using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApplication1.clases;

namespace WindowsFormsApplication1
{
    public partial class frmDetalle : Form
    {
        clsConexion conectar = new clsConexion();
        clsEmpleado empleado;
        clsCliente cliente;
        clsCampaña campaña;
        string clase;
        int identificador;

        public frmDetalle(string t, int id)
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
                    tcDatos.TabPages.RemoveByKey("tpRendimiento");
                    tcDatos.TabPages.RemoveByKey("tpFechas");
                    break;

                case "cliente":
                    cliente = conectar.datos_cliente(identificador);
                    tcDatos.TabPages.RemoveByKey("tpRendimiento");
                    break;

                case "campaña":
                    campaña = conectar.datos_campaña(identificador);
                    cliente = conectar.datos_cliente(campaña.Id_cliente);
                    tcDatos.TabPages.RemoveByKey("tpCampañaDeEmpleado");
                    break;
            }
            setearForm();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string sender_tag = (sender as Button).Tag.ToString();
            switch (sender_tag)
            {
                case "Eliminar":
                    //aca elimina
                    this.Close();
                    break;

                case "Editar":
                    foreach (Control c in pnlInformacion.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                            (c as TextBox).ReadOnly = false;
                        if (c.GetType() == typeof(DateTimePicker))
                            (c as DateTimePicker).Enabled = true;
                    }
                    pnlEstadisticas.Enabled = false;
                    btnEditar.Tag = "Guardar";
                    btnEliminar.Tag = "Cancelar";
                    break;

                case "Guardar":
                    checkCampos();
                    btnEditar.Tag = "Editar";
                    btnEliminar.Tag = "Eliminar";
                    break;

                case "Cancelar":
                    btnEditar.Tag = "Editar";
                    btnEliminar.Tag = "Eliminar";
                    break;
            }
            if ( sender_tag == "Guardar" || sender_tag == "Cancelar" )
            {
                foreach (Control c in pnlInformacion.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                        (c as TextBox).ReadOnly = true;
                    if (c.GetType() == typeof(DateTimePicker))
                        (c as DateTimePicker).Enabled = false;
                }
                pnlEstadisticas.Enabled = true;
            }
        }

        private void tcDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tcDatos.SelectedTab.Name)
            {
                case "tpFechas":
                    cbFiltroFecha.Items.Clear();
                    string[] opciones = { "Hoy", "Semana", "Mes", "Año" };
                    cbFiltroFecha.Items.AddRange(opciones);
                    cbFiltroFecha.SelectedIndex = 0;
                    break;

                case "tpRendimiento":
                    llenarDtRendimiento();
                    break;

                case "tpCampañaDeEmpleado":
                    rendimientoDeEmpleado();
                    break;
            }
        }

        private void cbFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Limpio los Points de cada Chart
            foreach (Control c in tpFechas.Controls)
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
            switch (cbFiltroFecha.SelectedItem.ToString())
            {
                case "Hoy":
                    fechaAUX = DateTime.Today;
                    //fechaAUX = Convert.ToDateTime("2018-04-17");
                    break;

                case "Semana":
                    fechaAUX = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                    break;

                case "Mes":
                    fechaAUX = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    //DateTime aux = new DateTime(2018, 5, 12);
                    //fechaAUX = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                    //fechaAUX = aux.AddDays(-(int)aux.DayOfWeek + (int)DayOfWeek.Monday);
                    break;

                case "Año":
                    fechaAUX = new DateTime(DateTime.Today.Year, 1, 1);
                    break;
            }
            mostrarNumeros(fechaAUX, cbFiltroFecha.SelectedItem.ToString());
        }


        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               // frmDatos frmDato;
                int dni = conectar.dniEmpleado(Convert.ToInt32(dgvTabla.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                /*frmDato = new frmDatos(this, dni, "Datos Empleado");
                frmDato.Show();*/
                frmDetalle frmDetalleCliente = new frmDetalle("empleado", dni);
                frmDetalleCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dtp01.Value = Convert.ToDateTime(empleado.Fecha_naciemiento);
                    dtp02.Value = Convert.ToDateTime(empleado.Fecha_inicio);
                    break;

                case "cliente":
                    this.Text = "Detalles de cliente";
                    label1.Text = "# " + cliente.Id.ToString() + " - " + cliente.Nombre;
                    label3.Text = "Nombre";
                    label4.Text = "CUIL";
                    label5.Text = "Domicilio";
                    label6.Text = "Nombre";
                    label7.Text = "Mail";
                    label8.Text = "Telefono";
                    gbContacto.Visible = true;
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
                    label1.Text = "# " + campaña.Id_campaña.ToString() + " - " + campaña.Nombre;
                    label3.Text = "Campaña";
                    label4.Text = "Precio";
                    label5.Text = "Cliente";
                    label6.Text = "Nombre";
                    label7.Text = "Telefono";
                    label8.Text = "Mail";
                    label9.Text = "Fecha de inicio";
                    label10.Text = "Fecha de fin";
                    label11.Text = "Descripción";
                    gbContacto.Visible = true;
                    // especificaciones?

                    // Datos de obj
                    tb01.Text = campaña.Nombre;
                    tb02.Text = campaña.Precio.ToString();
                    tb03.Text = campaña.NombreCliente;
                    tb04.Text = cliente.Contacto;
                    tb05.Text = cliente.Telefono.ToString();
                    tb06.Text = cliente.Mail;
                    tb07.Text = campaña.Descripcion;
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

            mostrarNumeros(DateTime.Today, tcDatos.SelectedTab.Name);
            if (tcDatos.TabPages.Count >= 2)     // Si son 2 existe la tpRendimiento
                if (tcDatos.TabPages[1].Text != "Historial Campañas")
                {
                    llenarDtRendimiento();
                }
        }

        private void mostrarNumeros(DateTime fecha, string filtro)
        {
            try
            {
                List<clsEstadisticas> estadisticas = new List<clsEstadisticas>();
                List<clsEstadisticas> estadisticasCampañas = new List<clsEstadisticas>();
                List<clsJornada> jornadas = new List<clsJornada>();
                switch (clase)
                {
                    case "empleado":

                        break;

                    case "cliente":
                        estadisticas = conectar.numeros_cliente(cliente.Id, filtro, fecha);
                        estadisticasCampañas = conectar.campañas_cliente(cliente.Id, filtro, fecha);
                        jornadas = conectar.jornadas_cliente(cliente.Id, filtro, fecha);
                        break;

                    case "campaña":
                        break;
                }
                llenarCharts(estadisticas, estadisticasCampañas, jornadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenarCharts(List<clsEstadisticas> estadisticas, List<clsEstadisticas> est_campañas, List<clsJornada> jornadas)
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
                //else
                    //lblInfo01.Text
                
                if (est_campañas != null)
                {
                    if (est_campañas.Count == 1)
                        cVentasCampaña.Series["Campañas"].ChartType = SeriesChartType.Column;
                    foreach (clsEstadisticas est in est_campañas)
                    {
                        cVentasCampaña.Series["Campañas"].Points.AddXY(est.Clave, est.Valor);
                    }
                }
                //else
                //lblInfo01.Text

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
                //else
                //lblInfo01.Text
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void llenarDtRendimiento()
         {
            try
            {
                string[] canVentas = conectar.promedioVentasCamapaña(campaña.Id_campaña);
                float[] canLlamadas = conectar.promedioLlamadasCamapaña(campaña.Id_campaña);
                DataTable rendimientos = conectar.rendimientoCampaña(campaña.Id_campaña);
                dgvTabla.DataSource = rendimientos;

                //float promEfectTotal = float.Parse(dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells["PromedioEfect"].Value.ToString());

                float promEfectTotal = Convert.ToInt32(canVentas[1]) * 100 / canLlamadas[0];

                lbPromVentas.Text = promEfectTotal.ToString() + "%";
                lbPromDurLlamVent.Text = Convert.ToString(canVentas[2]) + " min";
                lbPromLlamadas.Text = Convert.ToString(canVentas[1]) + " Ventas Totales";
                lbPromDurLlam.Text = canLlamadas[1].ToString("0.00") + " min";
                lbPromTimeProd.Text = conectar.totalTiempoPromedioCampaña(campaña.Id_campaña) + " min";
                lbPromTimeImddProd.Text= conectar.totalTiempoImproPromedioCampaña(campaña.Id_campaña)+ " min";
                lbTimeEspera.Text = conectar.promedioEspera(campaña.Id_campaña) +" min";

                dgvTabla.Columns["PromedioEfect"].Visible = false;
                dgvTabla.Columns["Id"].Width = 25;
                dgvTabla.Columns["Ventas"].Width = 75;
                dgvTabla.Columns["Efectividad"].Width = 80;
                

                foreach (DataGridViewRow row in dgvTabla.Rows)
                {

                    if (float.Parse(row.Cells["Tiempo Productivo(min)"].Value.ToString()) > float.Parse(conectar.totalTiempoPromedioCampaña(campaña.Id_campaña)))
                    {
                        row.Cells["Tiempo Productivo(min)"].Style.ForeColor = Color.Green;
                       
                    }
                    else
                    {
                        row.Cells["Tiempo Productivo(min)"].Style.ForeColor = Color.Red;
                       
                    }


                    if ((float.Parse(row.Cells["Tiempo Improductivo(min)"].Value.ToString())) > float.Parse(conectar.totalTiempoImproPromedioCampaña(campaña.Id_campaña)))
                    {
                        row.Cells["Tiempo Improductivo(min)"].Style.ForeColor = Color.Green;
                      
                    }
                    else
                    {
                        row.Cells["Tiempo Improductivo(min)"].Style.ForeColor = Color.Red;
                    
                    }


                    if ((float.Parse(row.Cells["Efectividad"].Value.ToString())) > promEfectTotal)
                    {
                        row.Cells["Efectividad"].Value = (row.Cells["Efectividad"].Value).ToString() + "%";
                        row.Cells["Efectividad"].Style.ForeColor = Color.Green;
                    }
                    else
                    {
                        row.Cells["Efectividad"].Value = (row.Cells["Efectividad"].Value).ToString() + "%";
                        row.Cells["Efectividad"].Style.ForeColor = Color.Red;
                    }


                    if ((float.Parse(row.Cells["Duracion llamadas Vendidas(min)"].Value.ToString())) > 0)//canVentas[1])
                    {
                        row.Cells["Duracion llamadas Vendidas(min)"].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.Cells["Duracion llamadas Vendidas(min)"].Style.ForeColor = Color.Green;
                    }

                    if ((float.Parse(row.Cells["Duracion llamadas(min)"].Value.ToString())) > canLlamadas[1])
                    {
                        row.Cells["Duracion llamadas(min)"].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.Cells["Duracion llamadas(min)"].Style.ForeColor = Color.Green;
                    }

                    if ((float.Parse(row.Cells["Tiempo de Espera(min)"].Value.ToString())) > float.Parse(conectar.promedioEspera(campaña.Id_campaña)))
                    {
                        row.Cells["Tiempo de Espera(min)"].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.Cells["Tiempo de Espera(min)"].Style.ForeColor = Color.Green;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void rendimientoDeEmpleado()
        {
            DataTable dt = new DataTable();
            dt = conectar.misCampañas(empleado.Id_empleado);
            dgvTableEmpl.DataSource = dt;
        }
        
        private void checkCampos()
        {
            switch (clase)
            {
                case "Empleado":
                    clsEmpleado emp = new clsEmpleado();
                    if (Int32.TryParse(tb03.Text, out int aux_dni) && !string.IsNullOrWhiteSpace(tb04.Text) && !string.IsNullOrWhiteSpace(tb05.Text)
                        && !string.IsNullOrWhiteSpace(tb06.Text) && !string.IsNullOrWhiteSpace(tb07.Text) && dtp01.Value < DateTime.Now)
                    {
                        emp.Nombre = tb01.Text;
                        emp.Apellido = tb02.Text;
                        emp.Dni = aux_dni;
                        emp.Telefono = tb04.Text; // guardar como int? checkear eso?
                        emp.Mail = tb05.Text;
                        emp.Domicilio = tb06.Text;
                        emp.Fecha_naciemiento = dtp01.Value;
                        emp.Fecha_inicio = dtp02.Value;
                        //emp.Id_campaña = (tb07.Text);    //CAMPAÑA
                        SeGuardo(conectar.actualizar_empleado(emp));
                    }
                    else
                        msjError("Falta completar campos");
                    break;

                case "Cliente":
                    if (!string.IsNullOrWhiteSpace(tb04.Text) && !string.IsNullOrWhiteSpace(tb05.Text) && Int32.TryParse(tb06.Text, out int aux_tel))
                    {
                        clsCliente cli = new clsCliente();
                        cli.Nombre = tb01.Text;
                        cli.Cuil = Convert.ToInt32(tb02.Text);
                        cli.Domicilio = tb03.Text;
                        cli.Contacto = tb04.Text;
                        cli.Mail = tb05.Text;
                        cli.Telefono = aux_tel;
                        SeGuardo(conectar.actualizar_cliente(cli));
                    }
                    else
                        msjError("Falta completar campos");
                    break;

                case "Campaña":
                    if (Int32.TryParse(tb02.Text, out int aux_precio) && dtp01.Value < dtp02.Value)
                    {
                        campaña.Nombre = tb01.Text;
                        campaña.Precio = aux_precio;
                        campaña.Descripcion = tb07.Text;
                        campaña.Fecha_inicio = dtp01.Value;
                        campaña.Fecha_fin = dtp02.Value;
                        // especificaciones
                        //camp.IdCliente = (lbLista.SelectedItem as clsCliente).Id;   // CLIENTE
                        // lider
                        SeGuardo(conectar.actualizar_campaña(campaña));
                    }
                    else
                        msjError("Falta completar campos");
                    break;
            }
        }

        public void SeGuardo(bool r)
        {
            if (r)
                MessageBox.Show("Se actualizó correctamente la información ingresada.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void msjError(string msj)
        {
            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabCampañaDeEmpleado_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = conectar.misCampañas(empleado.Id_empleado);
            dgvTableEmpl.DataSource = dt;
        }
        
    }
}