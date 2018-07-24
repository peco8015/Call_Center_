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
        int id_user;

        public frmDetalle(string t, int id, int id_user)
        {
            InitializeComponent();
            clase = t;
            identificador = id;
            this.id_user = id_user;
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
        }

        public void agregarColumnaEliminar()
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "";
            dgvEmpleados.Columns.Add(dgvCmb);
            DataGridViewCheckBoxColumn dgvCmb2 = new DataGridViewCheckBoxColumn();
            dgvCmb2.ValueType = typeof(bool);
            dgvCmb2.Name = "Chk";
            dgvCmb2.HeaderText = "";
            dgvEnCampaña.Columns.Add(dgvCmb2);
        }

        private void mostrarNumeros(DateTime fecha, DateTime hasta)
        {
            try
            {
                List<clsEstadisticas> estadisticas = new List<clsEstadisticas>();
                List<clsEstadisticas> estadisticasCampañas = new List<clsEstadisticas>();
                List<clsJornada> jornadas = new List<clsJornada>();
                switch (clase)
                {
                    case "empleado":
                        estadisticas = conectar.numeros_empleado(empleado.Id_empleado, fecha, hasta);
                        estadisticasCampañas = conectar.campañas_empleado(empleado.Id_empleado, fecha, hasta);
                        jornadas = conectar.jornadas_empleado(empleado.Id_empleado, fecha, hasta);
                        break;

                    case "cliente":
                        estadisticas = conectar.numeros_cliente(cliente.Id, fecha, hasta);
                        estadisticasCampañas = conectar.campañas_cliente(cliente.Id, fecha, hasta);
                        jornadas = conectar.jornadas_cliente(cliente.Id, fecha, hasta);
                        break;

                    case "campaña":
                        estadisticas = conectar.numeros_campaña(campaña.Id_campaña, fecha, hasta);
                        //estadisticasCampañas = conectar.campañas_campaña(campaña.Id_campaña, fecha, hasta); NO TIENE SENTIDO
                        jornadas = conectar.jornadas_campaña(campaña.Id_campaña, fecha, hasta);
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
                #region Limpio los Points de cada Chart
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
                #endregion

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
                dgvRendimiento.DataSource = rendimientos;

                //float promEfectTotal = float.Parse(dgvRendimiento.Rows[dgvRendimiento.Rows.Count - 1].Cells["PromedioEfect"].Value.ToString());

                float promEfectTotal = Convert.ToInt32(canVentas[1]) * 100 / canLlamadas[0];

                lbPromVentas.Text = promEfectTotal.ToString() + "%";
                lbPromDurLlamVent.Text = Convert.ToString(canVentas[2]) + " min";
                lbPromLlamadas.Text = Convert.ToString(canVentas[1]);
                lbPromDurLlam.Text = canLlamadas[1].ToString("0.00") + " min";
                lbPromTimeProd.Text = conectar.totalTiempoPromedioCampaña(campaña.Id_campaña) + " min";
                lbPromTimeImddProd.Text = conectar.totalTiempoImproPromedioCampaña(campaña.Id_campaña) + " min";

                dgvRendimiento.Columns["PromedioEfect"].Visible = false;
                dgvRendimiento.Columns["Id"].Width = 25;
                dgvRendimiento.Columns["Ventas"].Width = 75;
                dgvRendimiento.Columns["Efectividad"].Width = 80;

                foreach (DataGridViewRow row in dgvRendimiento.Rows)
                {
                    row.Cells["Tiempo Productivo(min)"].Style.ForeColor = ((float.Parse(row.Cells["Tiempo Productivo(min)"].Value.ToString())) > float.Parse(conectar.totalTiempoPromedioCampaña(campaña.Id_campaña))) ? Color.Green : Color.Red;

                    row.Cells["Tiempo Improductivo(min)"].Style.ForeColor = ((float.Parse(row.Cells["Tiempo Improductivo(min)"].Value.ToString())) > float.Parse(conectar.totalTiempoImproPromedioCampaña(campaña.Id_campaña)))? Color.Green : Color.Red;
                    
                    if ((Convert.ToInt32(row.Cells["Efectividad"].Value.ToString())) > promEfectTotal)
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

                    row.Cells["Duracion llamadas(min)"].Style.ForeColor = ((float.Parse(row.Cells["Duracion llamadas(min)"].Value.ToString())) > canLlamadas[1]) ? Color.Red : Color.Green;
                    
                }
            }
            catch (Exception ex)
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

        public void llenarDtEmpleados()
        {
            if (conectar.check_lider(campaña.Id_campaña, id_user))
            {
                agregarColumnaEliminar();
                foreach (DataGridViewColumn dgvC in dgvEmpleados.Columns)
                {
                    if (!(dgvC.CellTemplate is DataGridViewCheckBoxCell))
                        dgvC.ReadOnly = true;
                }
                foreach (DataGridViewColumn dgvC in dgvEnCampaña.Columns)
                {
                    if (!(dgvC.CellTemplate is DataGridViewCheckBoxCell))
                        dgvC.ReadOnly = true;
                }
            } else
            {
                btnEliminarDeCampaña.Visible = false;
                btnAgregarACampaña.Visible = false;
                dgvEmpleados.ReadOnly = true;
                dgvEnCampaña.ReadOnly = true;
            }

            dgvEmpleados.DataSource = conectar.listar_empleados_activos();
            dgvEnCampaña.DataSource = conectar.empleados_actuales_de_campaña(campaña.Id_campaña);
            (dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter = "[# Campaña] IS NULL OR [# Campaña] <> " + campaña.Id_campaña;

            
        }

        public void llenarDtCampañas()
        {
            dgvCampañasCliente.DataSource = conectar.listado_campañas_cliente(cliente.Id);
        }

        private void checkCampos()
        {
            switch (clase)
            {
                case "Empleado":
                    if (Int32.TryParse(tb03.Text, out int aux_dni) && !string.IsNullOrWhiteSpace(tb04.Text) && !string.IsNullOrWhiteSpace(tb05.Text)
                        && !string.IsNullOrWhiteSpace(tb06.Text) && !string.IsNullOrWhiteSpace(tb07.Text) && dtp01.Value < DateTime.Now)
                    {
                        empleado.Nombre = tb01.Text;
                        empleado.Apellido = tb02.Text;
                        empleado.Dni = aux_dni;
                        empleado.Telefono = tb04.Text; // guardar como int? checkear eso?
                        empleado.Mail = tb05.Text;
                        empleado.Domicilio = tb06.Text;
                        empleado.Fecha_naciemiento = dtp01.Value;
                        empleado.Fecha_inicio = dtp02.Value;
                        //emp.Id_campaña = (tb07.Text);    //CAMPAÑA
                        SeGuardo(conectar.actualizar_empleado(empleado));
                    }
                    else
                        msjError("Falta completar campos");
                    break;

                case "Cliente":
                    if (!string.IsNullOrWhiteSpace(tb04.Text) && !string.IsNullOrWhiteSpace(tb05.Text) && Int32.TryParse(tb06.Text, out int aux_tel))
                    {
                        cliente.Nombre = tb01.Text;
                        cliente.Cuil = Convert.ToInt32(tb02.Text);
                        cliente.Domicilio = tb03.Text;
                        cliente.Contacto = tb04.Text;
                        cliente.Mail = tb05.Text;
                        cliente.Telefono = aux_tel;
                        SeGuardo(conectar.actualizar_cliente(cliente));
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



        private void frmDetalles_Load(object sender, EventArgs e)
        {
            List<TabPage> tabPage_col = new List<TabPage>();
            switch (clase)
            {
                case "empleado":
                    empleado = conectar.datos_empleado(identificador); // DNI para empleado
                    foreach (TabPage tp in tcDatos.TabPages)
                    {
                        if (tp.Name == "tpCampañaDeEmpleado" || tp.Name == "tpFechas")
                            tabPage_col.Add(tp);
                    }
                    break;

                case "cliente":
                    cliente = conectar.datos_cliente(identificador);
                    foreach (TabPage tp in tcDatos.TabPages)
                    {
                        if (tp.Name == "tpFechas" || tp.Name == "tpListadoCampañas")
                            tabPage_col.Add(tp);
                    }
                    break;

                case "campaña":
                    campaña = conectar.datos_campaña(identificador);
                    cliente = conectar.datos_cliente(campaña.Id_cliente);
                    foreach (TabPage tp in tcDatos.TabPages)
                    {
                        if (tp.Name == "tpRendimiento" || tp.Name == "tpFechas" || tp.Name == "tpListadoEmpleados")
                            tabPage_col.Add(tp);
                    }
                    break;
            }
            tcDatos.TabPages.Clear();
            tcDatos.TabPages.AddRange(tabPage_col.ToArray());//tcDatos.TabPages.RemoveByKey("tpRendimiento");
            setearForm();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string sender_tag = (sender as Button).Tag.ToString();
            switch (sender_tag)
            {
                case "Editar":
                    foreach (Control c in pnlInformacion.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                            (c as TextBox).ReadOnly = false;
                        if (c.GetType() == typeof(DateTimePicker))
                            (c as DateTimePicker).Enabled = true;
                    }
                    pnlEstadisticas.Enabled = false;
                    btnGuardar.Visible = true;
                    btnEditar.Tag = "Cancelar";
                    btnEditar.Text = "Cancelar";
                    break;

                case "Guardar":
                    checkCampos();
                    setearForm();
                    btnEditar.Tag = "Editar";
                    break;

                case "Cancelar":
                    setearForm();
                    btnEditar.Tag = "Editar";
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
                btnGuardar.Visible = false;
            }
        }

        private void tcDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcDatos.TabPages.Count > 0)
            {
                switch (tcDatos.SelectedTab.Name)
                {
                    case "tpFechas":
                        mostrarNumeros(DateTime.Today, DateTime.MinValue);
                        break;

                    case "tpRendimiento":
                        llenarDtRendimiento();
                        break;

                    case "tpCampañaDeEmpleado":
                        rendimientoDeEmpleado();
                        break;

                    case "tpListadoEmpleados":
                        llenarDtEmpleados();
                        break;

                    case "tpListadoCampañas":
                        llenarDtCampañas();
                        break;
                }
            }
        }

        private void dgvRendimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmEmpleadoCampaña frmDetalleCliente = new frmEmpleadoCampaña(campaña.Id_campaña, Convert.ToInt32(dgvRendimiento.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                frmDetalleCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarDeCampaña_Click(object sender, EventArgs e)
        {
            List<int> lista_eliminar = new List<int>();
            foreach (DataGridViewRow dr in dgvEnCampaña.Rows)
            {
                if (Convert.ToBoolean(dr.Cells["Chk"].Value))
                {
                    lista_eliminar.Add((int)dr.Cells[1].Value);
                }
            }
            
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de eliminar " + lista_eliminar.Count + " empleados de la campaña " + campaña.Nombre.ToUpper() + "? En caso de requerirse, la información debe ingresarse nuevamente.", "Atención: confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                //ACTUALIZAR CAMPAÑA EMPL = NULL
                if (conectar.actualizar_campaña_empleados(-1, lista_eliminar))
                    MessageBox.Show("Se actualizó correctamente la información ingresada.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            llenarDtEmpleados();
        }

        private void btnAgregarACampaña_Click(object sender, EventArgs e)
        {
            List<int> lista_agregar = new List<int>();
            foreach (DataGridViewRow dr in dgvEmpleados.Rows)
            {
                if (Convert.ToBoolean(dr.Cells["Chk"].Value))
                {
                    lista_agregar.Add((int)dr.Cells[1].Value);
                }
            }
            
            if (DialogResult.Yes == MessageBox.Show("Agregará " + lista_agregar.Count + " empleados a la campaña " + campaña.Nombre.ToUpper() + "\n. Se necesita confirmar la acción para proceder.", "Atención: confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                //ACTUALIZAR CAMPAÑA EMPL = ID_CAMPAÑA
                if (conectar.actualizar_campaña_empleados(campaña.Id_campaña, lista_agregar))
                    MessageBox.Show("Se actualizó correctamente la información ingresada.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            llenarDtEmpleados();
        }

        private void cbHasta_CheckedChanged(object sender, EventArgs e)
        {
            dtpFiltroHasta.Enabled = (sender as CheckBox).Checked;
            if(!dtpFiltroHasta.Enabled)
                mostrarNumeros(dtpFiltroFecha.Value, DateTime.MinValue);
            else
                mostrarNumeros(dtpFiltroFecha.Value, dtpFiltroHasta.Value);
        }

        private void dtpFiltroFecha_DragDrop(object sender, DragEventArgs e)
        {
            DateTime fechaDesde = dtpFiltroFecha.Value;
            if ((sender as DateTimePicker).Tag.ToString() != "fecha" && fechaDesde < (sender as DateTimePicker).Value)
            {
                DateTime fechaHasta = DateTime.MinValue;
                if (dtpFiltroHasta.Enabled)
                    fechaHasta = dtpFiltroHasta.Value;
                mostrarNumeros(fechaDesde, fechaHasta);
            }
            else
            {
                msjError("La fecha ingresada en el campo 'Hasta' debe ser mayor que la primer fecha ingresada");
                /* fechaAUX = DateTime.Today;
                 * //fechaAUX = Convert.ToDateTime("2018-04-17");
                 * fechaAUX = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);*/
            }
        }

        private void dtpFiltroFecha_ValueChanged(object sender, EventArgs e)
        {
            /*if ((sender as DateTimePicker).Tag.ToString() == "fecha")
            {
                DateTime fechaAux = (sender as DateTimePicker).Value;
                mostrarNumeros(fechaAux, DateTime.MinValue);
            }
            else
            {
                if (dtpFiltroHasta.Enabled && dtpFiltroHasta.Value.Date > dtpFiltroFecha.Value.Date)
                {
                    DateTime fechaDesde = dtpFiltroFecha.Value;
                    DateTime fechaHasta = dtpFiltroHasta.Value;
                    mostrarNumeros(fechaDesde, fechaHasta);
                }
                /* fechaAUX = DateTime.Today;
                 * //fechaAUX = Convert.ToDateTime("2018-04-17");
                 * fechaAUX = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            }*/
            DateTime fechaDesde = dtpFiltroFecha.Value;
            if ((sender as DateTimePicker).Tag.ToString() != "fecha" && fechaDesde < (sender as DateTimePicker).Value)
            {
                DateTime fechaHasta = DateTime.MinValue;
                if (dtpFiltroHasta.Enabled)
                    fechaHasta = dtpFiltroHasta.Value;
                mostrarNumeros(fechaDesde, fechaHasta);
            }
            else
            {
                msjError("La fecha ingresada en el campo 'Hasta' debe ser mayor que la primer fecha ingresada");
                /* fechaAUX = DateTime.Today;
                 * //fechaAUX = Convert.ToDateTime("2018-04-17");
                 * fechaAUX = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);*/
            }
        }
    }
}