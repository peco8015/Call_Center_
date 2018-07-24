using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.clases;

namespace WindowsFormsApplication1
{
    public partial class frmEmple : Form
    {
        #region Variables Globales
        Form padre;

        clsEmpleado user = new clsEmpleado();
        clsConexion conectar = new clsConexion();
        clsContacto contacto = new clsContacto();
        clsCampaña campaña = new clsCampaña();
        clsJornada jornada;
        clsLlamada llamada;
        clsLLamadaDeNuevo llamadaProgramada;
        DateTime fechaHoy = DateTime.Now;
        TimeSpan t_atendiendo, inicio_sesion;
        string est;
        /* Medidores de tiempo */
        Stopwatch sw_llamada = new Stopwatch();
        Stopwatch sw_enEspera = new Stopwatch();
        Stopwatch sw_llenandoFormularios = new Stopwatch();
        Stopwatch sw_inactivo = new Stopwatch();
        Stopwatch sw_almuerzo = new Stopwatch();
        Stopwatch sw_baño = new Stopwatch();
        Stopwatch sw_reunion = new Stopwatch();
        Stopwatch sw_capacitacion = new Stopwatch();
        Stopwatch sw_descanso = new Stopwatch();
        Stopwatch sw_sinCampaña = new Stopwatch();
        Stopwatch sw_sinContactos = new Stopwatch();


        // HARDCODEADO
        int control_id_cliente = 1; // JOA pq no tiene contactos con id 0
                                    //int control_id_cliente = 0; // Peco
        #endregion


        public frmEmple(Form logueo, int dni)
        {
            InitializeComponent();
            padre = logueo;
            user.Dni = dni;
            ucPantallaAusente1.regresar += Volver;
            inicio_sesion = DateTime.Now.TimeOfDay;
        }

        /* Carga datos del empleado, checkea existencia de jornada previa
         * Llama función para llenar datos de campaña y del primer cliente/contacto.   */
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            ucPantallaAusente1.Visible = false;
            cbEspera.Visible = false;
            pnlRespuesta.Visible = false;
            pnlProgramada.Visible = false;
            btnCortar.Enabled = false;
            user = conectar.datos_empleado(user.Dni);//obtengo datos del empleado
            try
            {
                jornada = conectar.buscar_jornada(user.Id_empleado, user.Id_campaña, fechaHoy); // User.IdCampaña NULL?
                if (jornada == null)
                    guardarJornada();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Datos del empleado
            ucDatosUsuario1.NombreCompleto = user.Apellido.ToUpper()+", "+user.Nombre;
            ucDatosUsuario1.Dni = user.Dni;
            ucDatosUsuario1.EsJefe = false;
            ucDatosUsuario1.InicioSesion = inicio_sesion;
            ucDatosUsuario1.D1 = jornada.CantLlamadas;
            ucDatosUsuario1.D2 = jornada.CantVentas;

            //Datos de la campaña
            cargarCampaña();
            sw_inactivo.Start();

            //Lógica de llamadaProgramada | CargarContacto
            programacionDeLlamada(control_id_cliente);
        }

        #region Guardo jornada: tiempos (timespand .ToString), fecha e id_empleado
        private void btSalir_Click(object sender, EventArgs e)
        {
            cerrarFormEmpleado();
        }

        private void frmEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(sw_llamada.IsRunning || pnlRespuesta.Visible))
                cerrarFormEmpleado();
            else
                e.Cancel = true;
        }
        #endregion



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sw_llamada.IsRunning)
            {
                TimeSpan ts = sw_llamada.Elapsed;
                lblDurLlamada.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }

        /* Muestra opciones de estado y activa/desactiva medidores de tiempo. Guarda datos en BD */
        private void btnEstado_Click(object sender, EventArgs e)
        {
            frmEstado estado = new frmEstado();
            estado.ShowDialog();
            est = estado.est;
            if (estado.DialogResult == DialogResult.Yes)
            {
                sw_inactivo.Stop();
                switch (est)
                {
                    case "Descanso":
                        sw_descanso.Start();
                        break;
                    case "Reunion":
                        sw_reunion.Start();
                        break;
                    case "Baño":
                        sw_baño.Start();
                        break;
                    case "Capacitacion":
                        sw_capacitacion.Start();
                        break;
                    case "Almuerzo":
                        sw_almuerzo.Start();
                        break;
                }
                ucPantallaAusente1.Size = new Size(ActiveForm.Width, ActiveForm.Height);
                ucPantallaAusente1.Estado = "Estado: " + est.ToUpper(); //Agregar el tick?
                //ActiveForm.Controls.SetChildIndex(ucPantallaAusente1, 0);
                ucPantallaAusente1.Visible = true;
                guardarJornada();
            }
        }


        /* Muestra boton para HACER PROX llamada y 
           - oculta pnl para DEVOLVER llamada | muestra pnl para DEVOLVER llamada */
        private void rbVendido_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Tag.ToString() == "VL")
                pnlVolverLlam.Enabled = true;
            else
                pnlVolverLlam.Enabled = false;

            btnRegistrar.Enabled = true;
        }

        /* Inicia StopWatch, habilita btnCortar (llamada), deshabilita btnEstado y btnSalir (programa). */
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            sw_inactivo.Stop();
            sw_llamada.Start();
            btnLlamar.Enabled = false;
            btnEstado.Enabled = false;
            btnRendimiento.Enabled = false;
            btnSalir.Enabled = false;
            btnCortar.Enabled = true;
            cbEspera.Visible = true;
        }

        /* Corta llamada en curso. Resetea stopWatch y muestra panel para guardar resultado de llamada.*/
        private void btnCortar_Click(object sender, EventArgs e)
        {
            sw_llamada.Stop();
            sw_enEspera.Stop(); // No debería estar corriendo
            t_atendiendo = t_atendiendo.Add(sw_llamada.Elapsed);
            sw_llenandoFormularios.Start();
            btnCortar.Enabled = false;
            pnlRespuesta.Visible = true;
            cbEspera.Visible = false;
            pnlVolverLlam.Enabled = false;
            if (pnlProgramada.Visible)
                pnlProgramada.Visible = false;
        }


        /* Crea llamada (realizada) y nuevaLlamada (controla si hay llamadas programadas antes de pedir nuevo contacto)
         * - Volver (a llamar)/No vendido/No atendio: guarda en BD llamada.
         * - Vendido: guarda en BD llamada + venta.
            Carga nuevo contacto / llamada programada. */
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // StopWatch para y asigna valor al TimeSpand correspondiente.
            sw_llenandoFormularios.Stop();
            sw_inactivo.Start();

            if (llamadaProgramada.Id_nueva_llamada != -1)
                conectar.eliminarLlamadaDeNuevo(llamadaProgramada.Id_nueva_llamada);
            
            llamada = new clsLlamada();
            //llamada.Id_llamada = conectar.obtener_id_llamada();
            llamada.Id_campaña = campaña.Id_campaña;
            llamada.Id_empleado = user.Id_empleado;
            llamada.Id_contacto = contacto.Id;
            llamada.Duracion_total = sw_llamada.Elapsed;
            llamada.T_espera = sw_enEspera.Elapsed;
            llamada.Fecha = fechaHoy;
            llamada.Observaciones = rtbVObs.Text;
            if (rbVendido.Checked == true) llamada.Resultado = "Vendido";
            if (rbNoVendido.Checked == true) llamada.Resultado = "No Vendido";
            if (rbVolver.Checked == true) llamada.Resultado = "LLamarDeNuevo";
            if (rbNoAtendio.Checked == true) llamada.Resultado = "No Atendido ";

            // Inserta en BD 
            llamada.Id_llamada = conectar.insertar_llamada(llamada); // Llamada realizada
            if (llamada.Resultado == "Vendido") // VENTA
            {
                clsVenta venta = new clsVenta();
                venta.Id_venta = conectar.obtener_id_venta();
                venta.Id_llamada = llamada.Id_llamada;
                venta.Fecha_venta = llamada.Fecha;

                conectar.insertar_venta(venta);
                ucDatosUsuario1.D2 = ++jornada.CantVentas;
            }
            if (llamada.Resultado == "LLamarDeNuevo")
            {
                clsLLamadaDeNuevo nuevaLlamada = new clsLLamadaDeNuevo();
                nuevaLlamada.Id_contacto = contacto.Id;
                nuevaLlamada.Id_empleado = user.Id_empleado;
                nuevaLlamada.Id_llamada = llamada.Id_llamada;
                nuevaLlamada.Id_nueva_llamada = conectar.obtener_id_llamadaDeNuevo();
                nuevaLlamada.Fecha = dtpVFecha.Value.Date;
                nuevaLlamada.Hora = dtpVHora.Value.Hour;
                nuevaLlamada.Minutos = dtpVHora.Value.Minute;

                conectar.insertar_llamadaDeNuevi(nuevaLlamada);//inserto en la base el nuevo registro
            }

            setearPnlLlamada(); // Limpia controles y oculta paneles
            ucDatosUsuario1.D1 = ++jornada.CantLlamadas;
            guardarJornada();
            sw_enEspera.Reset(); // Reseteo el stopwatch para el tiempo de espera de la llamada
            sw_llamada.Reset();

            if (!conectar.check_campaña(user.Id_empleado, user.Id_campaña))
            {
                user = conectar.datos_empleado(user.Dni);
                cargarCampaña();
                programacionDeLlamada(++control_id_cliente);
            }
            else
            {
                programacionDeLlamada(++control_id_cliente);
            }
        }


        private void cbEspera_Click(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                sw_enEspera.Start();
            else
                sw_enEspera.Stop();
        }

        private void btnRendimiento_Click(object sender, EventArgs e)
        {
            frmJornada frmJ = new frmJornada(user.Id_empleado, sw_inactivo);
            frmJ.Show();
        }

        #region FUNCIONES
        public void programacionDeLlamada(int control_id_cliente)
        {
            //Datos del cliente a llamar
            llamadaProgramada = conectar.hayLLamadaEnEstaHora(fechaHoy, user.Id_campaña); //controlo antes de pedir nuevo contacto  para llamar si hay algunn
            if (llamadaProgramada.Id_nueva_llamada != -1)
                cargarLlamProgramada(llamadaProgramada);
            else
                cargarContacto(control_id_cliente);// Obtener ids que cumplan especificaciones de campaña
        }

        /* Carga llamada programada y llama funciones */
        public void cargarLlamProgramada(clsLLamadaDeNuevo llamadaProgramada)
        {
            cargarContacto(llamadaProgramada.Id_contacto);// traigo al cliente programado para esta hora
            dtpHorarioProg.Value = new DateTime(llamadaProgramada.Fecha.Year, llamadaProgramada.Fecha.Month, llamadaProgramada.Fecha.Day, llamadaProgramada.Hora, llamadaProgramada.Minutos, 00);
            rtbObsProg.Text = llamadaProgramada.Observaciones;
            pnlProgramada.Visible = true;
        }
        
        /* Busca la campaña asignada y llena datos */
        public void cargarCampaña()
        {
            campaña = conectar.datos_campaña_empleado(user.Id_empleado);
            lblNombreCamp.Text = "CAMPAÑA '"+campaña.Nombre+"'";
            lblNombreCli.Text = campaña.NombreCliente;
            lblPrecio.Text = campaña.Precio.ToString();
            lblFI.Text = campaña.Fecha_inicio.ToLongDateString();
            lblFF.Text = campaña.Fecha_fin.ToLongDateString();
            rtbDesc.Text = campaña.Descripcion;
        }

        /* Llena datos del CONTACTO a llamar. */
        public void cargarContacto(int idllamado)
        {
            contacto = conectar.nuevo_contacto(idllamado);//id 0 para el primer llamado
            if (contacto != null)
            {
                lblNTel.Text = "Telefono "+contacto.Telefono.ToString();
                lblNombreCon.Text = contacto.Nombre;
                lblApellidoCon.Text = contacto.Apellido;
                lblDniCon.Text = contacto.Dni.ToString();
                lblECCon.Text = contacto.Est_civil;
                lblFNCon.Text = String.Format("{0:M/d/yyyy}", contacto.Fecha_nacimiento);
                lblOcupCon.Text = contacto.Ocupacion;
                lblNacCon.Text = contacto.Nacionalidad;
                lblProvCon.Text = contacto.Provincia;
                //lblDomCon.Text = contacto.Domicilio;
            }
        }

        public void setearPnlLlamada()
        {
            lblDurLlamada.Text = "00:00:00.00";
            dtpVHora.Value = fechaHoy;
            dtpVFecha.Value = fechaHoy;
            rtbVObs.Text = string.Empty;
            btnLlamar.Enabled = true;
            btnEstado.Enabled = true;
            btnRendimiento.Enabled = true;
            btnSalir.Enabled = true;
            pnlRespuesta.Visible = false;
            cbEspera.Visible = false;
            foreach(RadioButton rbAux in pnlRespuesta.Controls.OfType<RadioButton>())
            {
                if (rbAux.Checked)
                    rbAux.Checked = false;
            }
            btnRegistrar.Enabled = false;
            //LightBlue
            if (pnlContacto.BackColor == Color.LightBlue) pnlContacto.BackColor = Color.Olive;
            else if (pnlContacto.BackColor == Color.Olive) pnlContacto.BackColor = Color.MediumSpringGreen;
        }

        public void guardarJornada()
        {
            if (jornada == null)
            {
                jornada = new clsJornada();
                jornada.Id_empleado = user.Id_empleado;
                jornada.Id_campaña = user.Id_campaña;
                jornada.Fecha = fechaHoy;
                jornada.Inicio_sesion = inicio_sesion;
                checkStopWatchs();
                conectar.insertar_jornada(jornada);
            }
            else
            {
                checkStopWatchs();
                conectar.actualizar_jornada(jornada);
            }
        }
        
        public void Volver()
        {
            switch (est)
            {
                case "Descanso":
                    sw_descanso.Stop();
                    break;
                case "Reunion":
                    sw_reunion.Stop();
                    break;
                case "Baño":
                    sw_baño.Stop();
                    break;
                case "Capacitacion":
                    sw_capacitacion.Stop();
                    break;
                case "Almuerzo":
                    sw_almuerzo.Stop();
                    break;
            }
            sw_inactivo.Start();
            ucPantallaAusente1.Visible = false;
            guardarJornada();
        }

        private void checkStopWatchs()
        {
            jornada.T_atendiendo = jornada.T_atendiendo.Add(t_atendiendo);
            t_atendiendo = TimeSpan.Zero;

            if (!sw_descanso.IsRunning)
            {
                jornada.T_descanso = jornada.T_descanso.Add(sw_descanso.Elapsed);
                sw_descanso.Reset();
            }
            if (!sw_inactivo.IsRunning)
            {
                jornada.T_inactivo = jornada.T_inactivo.Add(sw_inactivo.Elapsed);
                sw_inactivo.Reset();
            }
            if (!sw_llenandoFormularios.IsRunning)
            {
                jornada.T_llenadoFormularios = jornada.T_llenadoFormularios.Add(sw_llenandoFormularios.Elapsed);
                sw_llenandoFormularios.Reset();
            }
            if (!sw_reunion.IsRunning)
            {
                jornada.T_reunion = jornada.T_reunion.Add(sw_reunion.Elapsed);
                sw_reunion.Reset();
            }
            if (!sw_sinCampaña.IsRunning)
            {
                jornada.T_sinCampaña = jornada.T_sinCampaña.Add(sw_sinCampaña.Elapsed);
                sw_sinCampaña.Reset();
            }
            if (!sw_sinContactos.IsRunning)
            {
                jornada.T_sinContactos = jornada.T_sinContactos.Add(sw_sinContactos.Elapsed);
                sw_sinContactos.Reset();
            }
            if (!sw_baño.IsRunning)
            {
                jornada.T_baño = jornada.T_baño.Add(sw_baño.Elapsed);
                sw_baño.Reset();
            }
            if (!sw_almuerzo.IsRunning)
            {
                jornada.T_almuerzo = jornada.T_almuerzo.Add(sw_almuerzo.Elapsed);
                sw_almuerzo.Reset();
            }
            if (!sw_capacitacion.IsRunning)
            {
                jornada.T_capacitacion = jornada.T_capacitacion.Add(sw_capacitacion.Elapsed);
                sw_capacitacion.Reset();
            }
        }

        public void pararStopWatchs()
        {
            sw_almuerzo.Stop();
            sw_baño.Stop();
            sw_capacitacion.Stop();
            sw_descanso.Stop();
            sw_inactivo.Stop();
            sw_llenandoFormularios.Stop();
            sw_reunion.Stop();
            sw_sinCampaña.Stop();
            sw_sinContactos.Stop();
        }
        
        public void cerrarFormEmpleado()
        {
            pararStopWatchs();
            jornada.Cierre_sesion = DateTime.Now.TimeOfDay;
            guardarJornada();
            if(Application.OpenForms.Count > 1)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != padre.Name && Application.OpenForms[i].Name != this.Name)
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
            padre.Show();
            this.Hide();
        }

        #endregion
    }
}