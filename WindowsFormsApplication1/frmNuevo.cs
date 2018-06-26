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
    public partial class frmNuevo : Form
    {
        clsEmpleado user = new clsEmpleado();
        clsConexion conectar = new clsConexion();
        clsCampaña camp;
        DataTable dTable;

        public frmNuevo()
        {
            InitializeComponent();
        }

        private void frmNuevo_Load(object sender, EventArgs e)
        {
            pnlRegistro.Enabled = false;
            rbEmpleado.Checked = true;
            btnAddEmpleados.Visible = false;
        }

        private void cbTipoRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLista.SelectionMode = SelectionMode.One;
            pnlRegistro.Enabled = true;
            switch(cbTipoRegistro.SelectedItem)
            {
                case "Empleado":
                    btnAdd.Enabled = true;
                    label1.Text = "Nombre";
                    label2.Text = "Apellido";
                    label3.Text = "DNI";
                    label4.Text = "Teléfono";
                    label5.Text = "Mail";
                    label6.Text = "Domicilio";
                    label7.Text = "Nacimiento";
                    label8.Text = "Contraseña";
                    tb03.Size = new Size(191, 25);
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    tb04.Visible = true;
                    tb05.Visible = true;
                    tb06.Visible = true;
                    tb07.Visible = true;
                    dtp01.Visible = true;
                    dtp02.Visible = false;
                    rbEmpleado.Visible = true;
                    rbJefe.Visible = true;

                    pnlRelacion.Enabled = true;
                    lblLista.Text = "Asignar campaña al empleado";
                    lbLista.Items.Clear();
                    dTable = conectar.obtenerCampañas(); //ACTIVAS
                    foreach (DataRow fila in dTable.Rows)
                    {
                        clsCampaña aux = new clsCampaña();
                        aux.IdCampaña = Convert.ToInt32(fila["id_campaña"]);
                        aux.Nombre = Convert.ToString(fila["nombre"]);
                        lbLista.Items.Add(aux); //Convert.ToString(fila[0]) + "-" + Convert.ToString(fila[0])
                    }
                    lbLista.DisplayMember = "nombre";
                    break;

                case "Cliente":
                    btnAdd.Enabled = true;
                    pnlRelacion.Enabled = false;
                    lbLista.Items.Clear();
                    label1.Text = "Nombre";
                    label2.Text = "CUIL";
                    label3.Text = "Domicilio";
                    label4.Text = "Nombre contacto";
                    label5.Text = "Mail contacto";
                    label6.Text = "Telefono contacto";
                    tb03.Size = new Size(191, 25);
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    tb07.Visible = false;
                    dtp01.Visible = false;
                    dtp02.Visible = false;
                    rbEmpleado.Visible = false;
                    rbJefe.Visible = false;
                    break;

                case "Campaña":
                    btnAdd.Enabled = false;
                    label1.Text = "Campaña";
                    label2.Text = "Precio";
                    label3.Text = "Descripción";
                    label7.Text = "Fecha de inicio";
                    label8.Text = "Fecha de fin";
                    tb03.Size = new Size(191, 139);
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = false;
                    tb04.Visible = false;
                    tb05.Visible = false;
                    tb06.Visible = false;
                    tb07.Visible = false;
                    dtp01.Visible = true;
                    dtp02.Visible = true;
                    rbEmpleado.Visible = false;
                    rbJefe.Visible = false;

                    pnlRelacion.Enabled = true;
                    lblLista.Text = "Seleccione el cliente propietario";
                    lbLista.Items.Clear();
                    dTable = conectar.listarClientes();
                    foreach (DataRow fila in dTable.Rows)
                    {
                        clsCliente aux = new clsCliente();
                        aux.Id = Convert.ToInt32(fila["id_cliente"]);
                        aux.Nombre = Convert.ToString(fila["Cliente"]);
                        lbLista.Items.Add(aux);
                    }
                    lbLista.DisplayMember = "nombre";
                    break;
            }
        }

        private void lbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ListBox).SelectedItem != null)
            {
                btnAdd.Enabled = true;
                if (lbLider.SelectedItem !=null)
                {
                    btnAddEmpleados.Enabled = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb01.Text) && !string.IsNullOrWhiteSpace(tb02.Text) && !string.IsNullOrWhiteSpace(tb03.Text))
            {
                switch (cbTipoRegistro.SelectedItem)
                {
                    case "Empleado":
                        clsEmpleado emp = new clsEmpleado();
                        if ( Int32.TryParse(tb03.Text, out int aux_dni) && !string.IsNullOrWhiteSpace(tb04.Text) && !string.IsNullOrWhiteSpace(tb05.Text)
                            && !string.IsNullOrWhiteSpace(tb06.Text) && !string.IsNullOrWhiteSpace(tb07.Text) && dtp01.Value < DateTime.Now )
                        {
                            emp.Nombre = tb01.Text;
                            emp.Apellido = tb02.Text;
                            emp.Dni = aux_dni;
                            emp.Telefono = tb04.Text; // guardar como int? checkear eso?
                            emp.Mail = tb05.Text;
                            emp.Domicilio = tb06.Text;
                            emp.FechaNaciemiento = dtp01.Value;
                            emp.FechaInicio = DateTime.Now;
                            emp.Jefe = (rbJefe.Checked) ? 0 : 1;
                            emp.Password = tb07.Text;
                            emp.Id_campaña = (lbLista.SelectedItem as clsCampaña).IdCampaña;    //CAMPAÑA
                            SeGuardo(conectar.insertar_empleado(emp));
                        }
                        else
                            msjError("Falta completar campos");
                        break;

                    case "Cliente":
                        if ( !string.IsNullOrWhiteSpace(tb04.Text) && !string.IsNullOrWhiteSpace(tb05.Text) && Int32.TryParse(tb06.Text, out int aux_tel) )
                        {
                            clsCliente cli = new clsCliente();
                            cli.Nombre = tb01.Text;
                            cli.Cuil = Convert.ToInt32(tb02.Text);
                            cli.Domicilio = tb03.Text;
                            cli.Contacto = tb04.Text;
                            cli.Mail = tb05.Text;
                            cli.Telefono = aux_tel;
                            SeGuardo(conectar.insertar_cliente(cli));
                        }
                        else
                            msjError("Falta completar campos");
                        break;

                    case "Campaña":
                        if ( Int32.TryParse(tb02.Text, out int aux_precio) && dtp01.Value < dtp02.Value )
                        {
                            camp = new clsCampaña();
                            camp.Nombre = tb01.Text;
                            camp.Precio = aux_precio;
                            camp.Descripcion = tb03.Text;
                            camp.Fecha_inicio = dtp01.Value;
                            camp.Fecha_fin = dtp02.Value;
                            // especificaciones
                            camp.IdCliente = (lbLista.SelectedItem as clsCliente).Id;   // CLIENTE
                            SeGuardo(conectar.insertar_campaña(camp));
                        }
                        else
                            msjError("Falta completar campos");
                        break;
                }
            }
            else
                msjError("Falta completar campos");
        }

        private void btnAddEmpleados_Click(object sender, EventArgs e)
        {
            // ACTUALIZAR JEFE CAMPAÑA.
            camp.IdCampaña = ((clsEmpleado)lbLider.SelectedItem).Id_empleado;
            List<int> empleados = new List<int>();
            foreach (clsEmpleado aux in lbLista.SelectedItems)
            {
                empleados.Add(aux.Id_empleado);
            }
            if (conectar.actualizar_campaña_empleados(camp.IdCampaña, empleados) && conectar.actualizar_campaña(camp))
                this.Close();
            else
                noInserto();
        }


        public void limpiarControles()
        {
            MessageBox.Show("Se guardó correctamente el registro.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cbTipoRegistro.SelectedItem.ToString() == "Campaña")
            {
                if(DialogResult.Yes == MessageBox.Show("¿Desea asignar empleados a esta campaña?", "Completar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    lbLista.SelectionMode = SelectionMode.MultiExtended;
                    lblLista.Text = "Seleccione empleados";
                    lbLista.Items.Clear();
                    dTable = conectar.listarEmpleados();
                    foreach (DataRow fila in dTable.Rows)
                    {
                        clsEmpleado aux = new clsEmpleado();
                        aux.Id_empleado = Convert.ToInt32(fila["id_empleado"]);
                        aux.Nombre = Convert.ToString(fila["Empleado"]);
                        lbLista.Items.Add(aux);
                    }
                    lbLista.DisplayMember = "nombre";
                    dTable = conectar.listarJefes();
                    foreach (DataRow fila in dTable.Rows)
                    {
                        clsEmpleado aux = new clsEmpleado();
                        aux.Id_empleado = Convert.ToInt32(fila["id_empleado"]);
                        aux.Nombre = Convert.ToString(fila["Empleado"]);
                        lbLista.Items.Add(aux);
                    }
                    lbLista.DisplayMember = "nombre";

                    pnlInformacion.Visible = false;
                    pnlLider.Visible = true;
                    btnAdd.Visible = false;
                    btnAddEmpleados.Visible = true;
                    btnAddEmpleados.Enabled = false;
                }
            }
            else
                this.Close();
        }

        public void noInserto()
        {
            MessageBox.Show("Se produjo un error al guardar los registros en la base de datos. Intente nuevamente.","No se guardo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void msjError(string msj)
        {
            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SeGuardo(bool se_guardo)
        {
            if (se_guardo)
                limpiarControles();
            else
                noInserto();
        }
    }
}