using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.clases;

namespace WindowsFormsApplication1
{
    public partial class Logeo : Form
    {
       
        public Logeo()
        {
            InitializeComponent();
        }
       
        
        private void btnIngresa_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpleado usuario = new clsEmpleado();
                clsConexion conectar = new clases.clsConexion();
                bool logeado = conectar.logear(Convert.ToInt32(tbUser.Text), tbPass.Text);
                if (logeado == true)
                {
                    usuario = conectar.datos_empleado(Convert.ToInt32(tbUser.Text));//obtengo los datos del usuario

                    if (usuario.Jefe == 1)//null es empleado,sino  jefe
                    {
                        //frmJefe formuJ = new frmJefe(this, usuario.Dni);//referencia form logueo(this) por q es el principal,no puedo cerrarlo
                        //logueo qedara oculto,se cerrrara desde el evento de cierre del form nuevo
                        frmJefee formuJ = new frmJefee(this, usuario.Dni);
                        formuJ.Show();//abro el nuevo form
                        this.Hide();//oculto el principal
                    }
                    else
                    {
                        frmEmple formuE = new frmEmple(this, usuario.Dni);//si es empleado-referencia form logueo(this) por q es el principal,no puedo cerrarlo
                                                                                //logueo qedara oculto,se cerrrara desde el evento de cierre del form nuevo
                        formuE.Show();//abro el nuevo form
                        this.Hide();//oculto el principal
                    }
                }
                else
                {
                    msjError("El nombre de usuario y la contraseña ingresada no coinciden.");
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233033)
                {
                    msjError("El formato para el campo de 'Usuario' es incorrecto. Debe escribir el DNI en formato numérico.");
                }
                else
                {
                    msjError(ex.Message);
                }
            }
        }

       public void msjError(string msj)
       {
            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
    }
}
