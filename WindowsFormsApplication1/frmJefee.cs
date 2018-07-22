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
    public partial class frmJefee : Form
    {
        Form padre;
        clsEmpleado user = new clsEmpleado();
        clsConexion conectar = new clsConexion();
        DataTable dTable;
        TimeSpan inicio_sesion;
        string filtro_tabla;
        string filtro_fecha;
        string campo_fecha;

        public frmJefee(Form logueo, int dni) // Guardo los datos q vienen del form Logeo
        {
            InitializeComponent();
            padre = logueo;
            user.Dni = dni;
            inicio_sesion = DateTime.Now.TimeOfDay;
        }

        #region Funciones

        private void queryFiltrado()
        {
            DataView dv = new DataView(dTable);
            string query = string.Empty;
            if (tbNombre.Enabled || tbCliente.Enabled || tbCampaña.Enabled)
            {
                if (tbNombre.Enabled && !string.IsNullOrWhiteSpace(tbNombre.Text))
                    query += "Empleado LIKE '%" + tbNombre.Text + "%'";
                if (tbCliente.Enabled && !string.IsNullOrWhiteSpace(tbCliente.Text))
                {
                    if (!string.IsNullOrEmpty(query))
                        query += " AND ";
                    query += "Cliente LIKE '%" + tbCliente.Text + "%'";
                }
                if (tbCampaña.Enabled && !string.IsNullOrWhiteSpace(tbCampaña.Text))
                {
                    if (!string.IsNullOrEmpty(query))
                        query += " AND ";
                    query += "Campaña LIKE '%" + tbCampaña.Text + "%'";
                }
            }
            if (pnlFiltroFecha.Enabled && (cbFecha.Checked || cbMes.Checked || cbAño.Checked))
            {
                if (!string.IsNullOrEmpty(query))
                    query += " AND ";
                switch (filtro_fecha)
                {
                    case "fecha":
                        string fecha = dtpFecha.Value.ToString("yyyy/M/dd");
                        query += campo_fecha + " = #" + fecha + "#";
                        break;

                    case "mes":
                        fecha = dtpFecha.Value.ToString("M/");
                        query += "Convert(" + campo_fecha + ", 'System.String') LIKE '%/" + fecha + "%'";
                        break;

                    case "año":
                        fecha = dtpFecha.Value.ToString("yyyy");
                        query += "Convert(" + campo_fecha + ", 'System.String') LIKE '%" + fecha + "%'";
                        break;

                    case "mesaño":
                        fecha = dtpFecha.Value.ToString("M/yyyy");
                        query += "Convert(" + campo_fecha + ", 'System.String') LIKE '%" + fecha + "%'";
                        break;
                }
            }
            dv.RowFilter = query;
            dgvTabla.DataSource = dv.ToTable();
            /* Tira el error al no matchar con nada
                        DataRow[] dtRows = dTable.Select(query);
                        dgvTabla.DataSource = dtRows.CopyToDataTable();*/
        }

        public void cerrarForm()
        {
            if (Application.OpenForms.Count > 2)
            {
                foreach (Form f in Application.OpenForms.Cast<Form>().Where(x => x.Name != padre.Name && x.Name != this.Name))
                {
                    f.Close();
                }
            }
            padre.Show();
            this.Hide();
        }

        public void agregarColumnaEliminar()
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "";
            dgvTabla.Columns.Add(dgvCmb);
        }

        #endregion

        private void frmJefee_Load(object sender, EventArgs e)
        {
            user = conectar.datos_empleado(user.Dni);//obtengo datos del jefe

            ucDatosUsuario1.NombreCompleto = user.Apellido.ToUpper() + ", " + user.Nombre;
            ucDatosUsuario1.Dni = user.Dni;
            ucDatosUsuario1.EsJefe = true;
            ucDatosUsuario1.InicioSesion = inicio_sesion;
            //ucDatosUsuario1.D1 = "Campañas asignadas:";
            //ucDatosUsuario1.D2 = "Empleados a cargo:";
            pnlFiltros.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            padre.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (dgvTabla.Columns.Count > 0)
                dgvTabla.Columns.Clear();
            pnlFiltros.Enabled = true;
            pnlAB.Enabled = true;
            dgvTabla.Height = 509;
            dgvTabla.Location = new Point(22, 172);
            filtro_tabla = (sender as Button).Tag.ToString();
            switch (filtro_tabla)
            {
                case "empleados":
                    dTable = conectar.listarEmpleados();
                    dgvTabla.Height = 445;
                    dgvTabla.Location = new Point(22,236);
                    agregarColumnaEliminar();
                    tbNombre.Enabled = true;
                    tbCliente.Enabled = false;
                    tbCampaña.Enabled = false; // se puede poner el nombre de la campaña asignada actualmente
                    pnlFiltroFecha.Enabled = false;
                    pnlLista.BackColor = Color.DarkBlue;
                    break;

                case "clientes":
                    dTable = conectar.listarClientes();
                    dgvTabla.Height = 445;
                    dgvTabla.Location = new Point(22,236);
                    agregarColumnaEliminar();
                    tbNombre.Enabled = false; // podriamos aca preguntar por el nombre de contacto
                    tbCliente.Enabled = true;
                    tbCampaña.Enabled = false;
                    pnlFiltroFecha.Enabled = false;
                    pnlLista.BackColor = Color.DarkGreen;
                    break;

                case "campañas":
                    dTable = conectar.listarCampañas();
                    dgvTabla.Height = 445;
                    dgvTabla.Location = new Point(22,236);
                    agregarColumnaEliminar();
                    campo_fecha = "Inicia";
                    tbNombre.Enabled = false; // podriamos aca preguntar por el nombre de contacto
                    tbCliente.Enabled = true;
                    tbCampaña.Enabled = true;
                    pnlFiltroFecha.Enabled = true;
                    pnlLista.BackColor = Color.DarkMagenta;
                    break;

                case "ventas":
                    dTable = conectar.listarVentas();
                    campo_fecha = "[Fecha Venta]";
                    tbNombre.Enabled = true;
                    tbCliente.Enabled = true;
                    tbCampaña.Enabled = true;
                    pnlFiltroFecha.Enabled = true;
                    pnlLista.BackColor = Color.DarkRed;
                    break;

                case "llamados":
                    dTable = conectar.listarLlamadas();
                    campo_fecha = "Fecha";
                    tbNombre.Enabled = true;
                    tbCliente.Enabled = true;
                    tbCampaña.Enabled = true;
                    pnlFiltroFecha.Enabled = true;
                    pnlLista.BackColor = Color.DarkKhaki;
                    break;
            }
            dgvTabla.DataSource = dTable;
            foreach (DataGridViewColumn dgvC in dgvTabla.Columns)
            {
                if (!(dgvC.CellTemplate is DataGridViewCheckBoxCell))
                    dgvC.ReadOnly = true;
            }
        }

        private void btnNewEmpleado_Click(object sender, EventArgs e)
        {
            frmNuevo frmNuevo = new frmNuevo("Campaña");
            frmNuevo.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevo frmNuevo = new frmNuevo(filtro_tabla);
            frmNuevo.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<int> lista_eliminar = new List<int>();
            foreach (DataGridViewRow dr in dgvTabla.Rows)
            {
                if (Convert.ToBoolean(dr.Cells["Chk"].Value))   // as DataGridViewCheckBoxColumn
                {
                    lista_eliminar.Add((int)dr.Cells[1].Value);
                }
            }

            int cant_eliminar = lista_eliminar.Count;
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de eliminar " + cant_eliminar + " registros de forma permanente? En caso de requerirse, la información debe ingresarse nuevamente.", "Atención: confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                switch (filtro_tabla)
                {
                    case "empleados":
                        break;

                    case "clientes":
                        break;

                    case "campañas":
                        break;
                }
            }
        }

        private void tbNombre_KeyUp(object sender, KeyEventArgs e)
        {
            // ' y [ tiran error
            if (!string.IsNullOrEmpty(tbNombre.Text) || !string.IsNullOrEmpty(tbCliente.Text) || !string.IsNullOrEmpty(tbCampaña.Text) || !cbFecha.Checked || !cbMes.Checked || !cbAño.Checked)
                queryFiltrado();
            else
                dgvTabla.DataSource = dTable;
        }

        private void dtpFecha_CloseUp(object sender, EventArgs e)
        {
            queryFiltrado();
        }

        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbFecha.Checked && !cbMes.Checked && !cbAño.Checked)
            {
                dtpFecha.Enabled = false;
                if (tbNombre.Enabled || tbCliente.Enabled || tbCampaña.Enabled)
                    queryFiltrado();
                else
                    dgvTabla.DataSource = dTable;
            }
            else
            {
                dtpFecha.Enabled = true;
                CheckBox s = (sender as CheckBox);
                if (s.Checked)
                {
                    filtro_fecha = s.Tag.ToString();
                    if (s.Tag.ToString() == "mes" || s.Tag.ToString() == "año")
                        cbFecha.Checked = false;
                    else
                    {
                        cbMes.Checked = false;
                        cbAño.Checked = false;
                    }
                    if (cbMes.Checked && cbAño.Checked)
                        filtro_fecha = "mesaño";
                }
            }
        }

        private void frmJefee_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrarForm();
        }
        
        private void dgvTabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmDetalle frmDetalle;
                frmDatos frmDato;
                switch (dgvTabla.Columns[1].Name)//la tabla cambia,esto es para controlar q tabla esta visible al momento del click en la celda
                {
                    case "id_empleado":
                        /*frmDato = new frmDatos(this, Convert.ToInt32(dgvTabla.Rows[e.RowIndex].Cells["DNI"].Value.ToString()), "Datos Empleado");
                        frmDato.Show();*/
                        frmDetalle = new frmDetalle("empleado", Convert.ToInt32(dgvTabla.Rows[e.RowIndex].Cells["DNI"].Value.ToString()));
                        frmDetalle.Show();
                        break;

                    case "id_cliente":
                        frmDetalle = new frmDetalle("cliente", Convert.ToInt32(dgvTabla.Rows[e.RowIndex].Cells["id_cliente"].Value.ToString()));
                        frmDetalle.Show();
                        break;

                    case "id_campaña":
                        frmDetalle = new frmDetalle("campaña", Convert.ToInt32(dgvTabla.Rows[e.RowIndex].Cells["id_campaña"].Value.ToString()));
                        frmDetalle.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbEliminados_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}