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
        string tipo;
        clsEmpleado user = new clsEmpleado();
        clsConexion conectar = new clsConexion();
        clsCampaña camp;
        DataTable dTable;

        public frmNuevo()
        {
            InitializeComponent();
        }

        public frmNuevo(string entidad)
        {
            InitializeComponent();
            if (entidad == "empleados")
                tipo = "Empleado";
            if (entidad == "campañas")
                tipo = "Campaña";
            if (entidad == "clientes")
                tipo = "Cliente";
        }

        #region FUNCIONES

        public void setForm()
        {
            switch (tipo)
            {
                case "Empleado":
                    label1.Text = "Nombre";
                    label2.Text = "Apellido";
                    label3.Text = "DNI";
                    label4.Text = "Teléfono";
                    label5.Text = "Mail";
                    label6.Text = "Domicilio";
                    label7.Text = "Nacimiento";
                    label8.Text = "Contraseña";
                    label9.Visible = false;
                    nudPrecio.Visible = false;
                    dtp02.Visible = false;
                    cb01.Visible = false;

                    dTable = conectar.obtenerCampañas(); //ACTIVAS
                    cb02.DataSource = dTable;
                    cb02.DisplayMember = "nombre";
                    cb02.ValueMember = "id_campaña";
                    break;

                case "Cliente":
                    label1.Text = "Nombre";
                    label2.Text = "CUIL";
                    label3.Text = "Domicilio";
                    label4.Text = "Nombre contacto";
                    label5.Text = "Mail contacto";
                    label6.Text = "Telefono contacto";
                    label4.ForeColor = Color.Maroon;
                    label5.ForeColor = Color.Maroon;
                    label6.ForeColor = Color.Maroon;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    nudPrecio.Visible = false;
                    check01.Visible = false;
                    check02.Visible = false;
                    tb07.Visible = false;
                    dtp01.Visible = false;
                    dtp02.Visible = false;
                    cb01.Visible = false;
                    cb02.Visible = false;
                    break;

                case "Campaña":
                    label1.Text = "Campaña";
                    label2.Text = "Precio";
                    label3.Text = "Descripción";
                    label7.Text = "Fecha de inicio";
                    label8.Text = "Fecha de fin";
                    label9.Text = "Cliente";
                    check02.Text = "Lider de campaña";
                    tb03.Size = new Size(261, 139);
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    tb02.Visible = false;
                    tb04.Visible = false;
                    tb05.Visible = false;
                    tb06.Visible = false;
                    tb07.Visible = false;
                    cb02.Visible = false;
                    check01.Visible = false;

                    dTable = conectar.listarClientes(); //ACTIVAS
                    cb01.DataSource = dTable;
                    cb01.DisplayMember = "Cliente";
                    cb01.ValueMember = "id_cliente";
                    break;
            }
        }

        public void limpiarControles()
        {
            string msj = "Se guardó correctamente el registro.";
            if (tipo == "Campaña")
            {
                msj += "\nEn caso de asociar empleados a esta campaña, debe ingresar a la vista detalle del mismo.";
            }
            MessageBox.Show(msj, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
                MessageBox.Show("Se produjo un error al guardar los registros en la base de datos. Intente nuevamente.", "No se guardo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion


        private void frmNuevo_Load(object sender, EventArgs e)
        {
            setForm();
        }

        private void check02_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case "Empleado":
                    if (check02.Checked)
                        cb02.Visible = true;
                    else
                        cb02.Visible = false;
                    break;

                case "Campaña":
                    if (check02.Checked)
                    {
                        dTable = conectar.listarJefes();
                        cb02.DataSource = dTable;
                        cb02.DisplayMember = "Empleado";
                        cb02.ValueMember = "id_empleado";
                        cb02.Visible = true;
                    }
                    else
                        cb02.Visible = false;
                    break;
            }
        }

        private void check01_CheckedChanged_1(object sender, EventArgs e)
        {
            if (check01.Checked)
            {
                cb02.Visible = false;
                check02.Visible = false;
            }
            else
            {
                cb02.Visible = true;
                check02.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb01.Text) && !string.IsNullOrWhiteSpace(tb02.Text) && !string.IsNullOrWhiteSpace(tb03.Text))
            {
                switch (tipo)
                {
                    case "Empleado":
                        clsEmpleado emp = new clsEmpleado();
                        if ( Int32.TryParse(tb03.Text, out int aux_dni) && !string.IsNullOrWhiteSpace(tb07.Text) && dtp01.Value < DateTime.Now )
                        {
                            emp.Nombre = tb01.Text;
                            emp.Apellido = tb02.Text;
                            emp.Dni = aux_dni;
                            emp.Telefono = (!string.IsNullOrWhiteSpace(tb04.Text)) ? tb04.Text : string.Empty; // checkear eso?
                            emp.Mail = (!string.IsNullOrWhiteSpace(tb05.Text)) ? tb05.Text : string.Empty;
                            emp.Domicilio = (!string.IsNullOrWhiteSpace(tb06.Text))? tb06.Text : string.Empty;
                            emp.Fecha_naciemiento = dtp01.Value;
                            emp.Fecha_inicio = DateTime.Now;
                            emp.Jefe = (check01.Checked) ? 0 : 1;
                            emp.Password = tb07.Text;
                            emp.Id_campaña = (check02.Checked && !check01.Checked) ? (int)cb02.SelectedValue : -1;    //CAMPAÑA
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
                        if ( dtp01.Value < dtp02.Value )
                        {
                            camp = new clsCampaña();
                            camp.Nombre = tb01.Text;
                            camp.Precio = (float)nudPrecio.Value;
                            camp.Descripcion = tb03.Text;
                            camp.Fecha_inicio = dtp01.Value;
                            camp.Fecha_fin = dtp02.Value;
                            // especificaciones
                            camp.Id_cliente = (int)cb01.SelectedValue;   // CLIENTE
                            SeGuardo(conectar.insertar_campaña(camp));
                        }
                        else
                            msjError("La fecha de finalización de una campaña debe no puede ser anterior ni la misma que la fecha de inicio.");
                        break;
                }
            }
            else
                msjError("Falta completar campos");
        }

        private void tb02_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}