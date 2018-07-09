using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    class clsContacto
    {
        int _id;
        int dni;
        string nombre;
        string apellido;
        DateTime fecha_nacimiento;
        string ocupacion;
        string est_civil;
        string nacionalidad;
        string provincia;
        string domicilio;
        double telefono;
       

        public double Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }
 

        public string Ocupacion
        {
            get
            {
                return ocupacion;
            }

            set
            {
                ocupacion = value;
            }
        }

        public string Est_civil
        {
            get
            {
                return est_civil;
            }

            set
            {
                est_civil = value;
            }
        }

        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }

            set
            {
                domicilio = value;
            }
        }

        public DateTime Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }

            set
            {
                fecha_nacimiento = value;
            }
        }

      
    }
}
