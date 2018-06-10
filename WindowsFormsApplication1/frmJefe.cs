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
    public partial class frmJefe : Form
    {
        Form padre;
        clsEmpleado user = new clsEmpleado();
        clsConexion conectar = new clsConexion();

        DataTable dTable;
              
        

        DateTime fechaHoy= DateTime.Now;

        public frmJefe(Form logueo, int dni)
        {
            InitializeComponent();
            
            padre = logueo;
            user.Dni = dni;//guardo los datos q vienen del form Logeo
            
        }

        private void frmJefe_Load(object sender, EventArgs e)
        {
            user = conectar.datos_empleado(user.Dni);//obtengo datos del jefe
            
            ucDatosUser1.Nombre = user.Nombre;
            ucDatosUser1.Apellidos = user.Apellido;
            ucDatosUser1.Dni = user.Dni;
            ucDatosUser1.Hoy = String.Format("{0:dddd,d MMMM, yyyy}", fechaHoy);
            ucDatosUser1.Hora= "Hora Inicio de Hoy  " + fechaHoy.Hour.ToString() + ":" + fechaHoy.Minute.ToString();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            padre.Show();
            this.Hide();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            pnlBuscarEmpleado.Visible = true;

            pnlCantVentas.Visible = false;
          
            pnlVentas.Visible = false;

            pnlBtEMpl.BackColor = Color.DarkOrange;
            pnlBtVentas.BackColor = Color.LightGray;
            

            dTable = new DataTable();
            dTable = conectar.listarEmpleados();             
            
            dgvbTabla.DataSource= dTable;
            



        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            frmAusente fm = new frmAusente();
            fm.Show();

        }

        private void btllamadas_Click(object sender, EventArgs e)
        {
            dTable = conectar.listarLlamadas();

            dgvbTabla.DataSource = dTable;
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            pnlBuscarEmpleado.Visible = false;
            pnlVentas.Visible = true;
            pnlCantVentas.Visible = true;

            pnlBtEMpl.BackColor = Color.LightGray;
            pnlBtVentas.BackColor = Color.OliveDrab;

            dTable = conectar.listarVentas();

            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();

        }

        private void dgvbTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (dgvbTabla.Columns[0].Name)//la tabla cambia,esto es para controlar q tabla esta visible al momento del click en la celda
            {
                case "id_empleado":
                    string dni = dgvbTabla.Rows[e.RowIndex].Cells[3].Value.ToString();//obtengo el dni de la fila seleccionada
                    int dniselect = Convert.ToInt32(dni);


                    string control = "Datos Empleado";//para saber q UserControl usar en el otro form

                    frmDatos formuE = new frmDatos(this, dniselect, control);
                    formuE.Show(); break;//abro el nuevo form

                case "id_venta": break;


            }



        }

        private void tbBusqPersona_KeyUp(object sender, KeyEventArgs e)
        {

            string txt = "%"+tbBusqPersona.Text+"%";


            dTable = new DataTable();
         

            dTable = conectar.filtro_empleados(txt);
            dgvbTabla.DataSource = dTable;
           
        }

 

       /* private void tbCliente_KeyUp(object sender, KeyEventArgs e)
        {

            dTable = new DataTable();

            if (cbChekedFecha.Checked)
            {
                dTable = carga_ventas_filtradas_time();
            }
            else
            {
                dTable = carga_ventas_filtradas_sin_time();
            }

           
            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();
        }
        */

       /* public DataTable  carga_ventas_filtradas_sin_time()
        {
           

            string cliente = "%" + tbCliente.Text + "%";
            string campaña = "%" + tbCampaña.Text + "%";
            string empleado = "%" + tbemplleadoV.Text + "%";
            string nombre = "%" + tbNombreE.Text + "%";
            



           DataTable table = new DataTable();

            if (cbañoo.Checked==false && cbmess.Checked==false)
            {
                table = conectar.filtro_ventas_sin_time(cliente, empleado, campaña, nombre);
            }
            else {

                if(cbañoo.Checked == true && cbmess.Checked == false)
                {
                    table = conectar.filtro_ventas_años_todos(Convert.ToInt32(cbAño.SelectedItem), cliente, empleado, campaña, nombre);
                }
                else if(cbañoo.Checked == false && cbmess.Checked == true)
                {
                    table = conectar.filtro_ventas_mes_todos(cbMes.SelectedItem.ToString(), cliente, empleado, campaña, nombre);

                }
                else if (cbañoo.Checked == true && cbmess.Checked == true)
                {
                    table = conectar.filtro_ventas_mes_año_todos(cbMes.SelectedItem.ToString(), Convert.ToInt32(cbAño.SelectedItem),cliente,empleado,campaña,nombre);
                }



            }

            


            return table;
        }*/

        public DataTable carga_ventas_filtradas_time()
        {
            DateTime f = dtFechaVenta.Value;
            string fecha = f.ToString("yyyy/M/dd");

            string cliente = "%" + tbCliente.Text + "%";
            string campaña = "%" + tbCampaña.Text + "%";
            string empleado = "%" + tbemplleadoV.Text + "%";
            string nombre = "%" + tbNombreE.Text + "%";



            DataTable table = new DataTable();
            table = conectar.filtro_ventas_con_time(fecha, cliente, empleado, campaña,nombre);



            return table;
        }//si esta activado el datimepiker tira esta consulta

        private void dtFechaVenta_CloseUp(object sender, EventArgs e)
        {
            dTable = new DataTable();

            DateTime f = dtFechaVenta.Value;
            string fecha = f.ToString("yyyy/M/dd");

            dTable = conectar.filtro_ventas_time(fecha);

            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();
            //cuando selecciona una fecha buscar directamente todos los datos con la fecha seleccionada
            //ccuando ademas de la fecha filtre por cliente,empledo ETC,llamara a otra funcion de busqueda
            //en los eventos de los textbox q filtran

        }

        private void dtFechaVenta_DropDown(object sender, EventArgs e)
        {
           
            tbemplleadoV.Text = "";
            tbCliente.Text = "";
            tbCampaña.Text = "";
        }

        public string switch_mes(string mes)
        {
            string valor="";
            switch (mes)
            {
                case "Enero":valor="1";break;
                case "Febrero": valor = "2"; break;
                case "Marzo": valor = "3"; break;
                case "Abril": valor = "4"; break;
                case "Mayo": valor = "5"; break;
                case "Junio": valor ="6"; break;
                case "Julio": valor = "7"; break;
                case "Agosto": valor = "8"; break;
                case "Septiembre": valor = "9"; break;
                case "Octubre": valor = "10"; break;
                case "Noviembre": valor = "11"; break;
                case "Dciembre": valor = "12"; break;


            }

            return valor;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbChekedFecha.Checked)
            {
                dtFechaVenta.Visible = true;
                cbmess.Checked = false;
                cbañoo.Checked = false;
                cbMes.Visible = false;
                cbAño.Visible = false;
                tbemplleadoV.Text = "";
                tbCliente.Text = "";
                tbCampaña.Text = "";
                tbNombreE.Text = "";
            }
            else
            {
                dtFechaVenta.Visible = false;
               

            }
        }

        /*private void tbCampaña_KeyUp(object sender, KeyEventArgs e)
        {
            dTable = new DataTable();

            if (cbChekedFecha.Checked)
            {
                dTable = carga_ventas_filtradas_time();
            }
            else
            {
                dTable = carga_ventas_filtradas_sin_time();
            }


            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();
        }
        */
       /* private void tbemplleadoV_KeyUp(object sender, KeyEventArgs e)
        {
            dTable = new DataTable();

            if (cbChekedFecha.Checked)
            {
                dTable = carga_ventas_filtradas_time();
            }
            else
            {
                dTable = carga_ventas_filtradas_sin_time();
            }


            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();
        }
        */
       /* private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

            dTable = new DataTable();


            if (cbañoo.Checked == false)
            {
                dTable = conectar.filtro_ventas_mes(cbMes.SelectedItem.ToString());
            }
            else
            {
                dTable = conectar.filtro_ventas_mes_año(cbMes.SelectedItem.ToString(), Convert.ToInt32(cbAño.SelectedItem));
            }
            
    

            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {

            dTable = new DataTable();


            if (cbmess.Checked == false)
            {
                dTable = conectar.filtro_ventas_año(Convert.ToInt32(cbAño.SelectedItem));
            }
            else
            {

                dTable = conectar.filtro_ventas_mes_año(cbMes.SelectedItem.ToString(), Convert.ToInt32(cbAño.SelectedItem));


            }



            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();

        }

        private void tbNombreE_KeyUp(object sender, KeyEventArgs e)
        {
            dTable = new DataTable();

            if (cbChekedFecha.Checked)
            {
                dTable = carga_ventas_filtradas_time();
            }
            else
            {
                dTable = carga_ventas_filtradas_sin_time();
            }


            dgvbTabla.DataSource = dTable;
            lbTotalVentas.Text = dgvbTabla.RowCount.ToString();
        }

        private void cbmess_CheckedChanged(object sender, EventArgs e)
        {
          

            if (cbmess.Checked)
            {
                cbMes.Visible = true;
                cbChekedFecha.Checked = false;
                tbemplleadoV.Text = "";
                tbCliente.Text = "";
                tbCampaña.Text = "";
                tbNombreE.Text = "";

            }
            else
            {
                cbMes.Visible = false;
            }

        }
        */
        private void cbañoo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbañoo.Checked == true)
            {
                cbChekedFecha.Checked = false;
                cbAño.Visible = true;
                tbemplleadoV.Text = "";
                tbCliente.Text = "";
                tbCampaña.Text = "";
                tbNombreE.Text = "";
            }
            else
            {
                cbAño.Visible = false;
            }
        }

    }
}
