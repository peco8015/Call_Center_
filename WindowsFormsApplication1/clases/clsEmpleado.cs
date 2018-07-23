using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    class clsEmpleado
    {
        int id_empleado;
        string nombre;
        string apellido;
        int dni;
        DateTime fecha_inicio;
        int jefe;//null es empleado,con valor 1 es jefe
        string password;
        DateTime fecha_naciemiento;
        int id_campaña;
        string domicilio;
        string telefono;
        string mail;
        DateTime fecha_eliminado;

        public int Id_empleado
        {
            get
            {
                return id_empleado;
            }

            set
            {
                id_empleado = value;
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

        public DateTime Fecha_inicio
        {
            get
            {
                return fecha_inicio;
            }

            set
            {
                fecha_inicio = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public DateTime Fecha_naciemiento
        {
            get
            {
                return fecha_naciemiento;
            }

            set
            {
                fecha_naciemiento = value;
            }
        }

        public int Jefe
        {
            get
            {
                return jefe;
            }

            set
            {
                jefe = value;
            }
        }

        public int Id_campaña
        {
            get
            {
                return id_campaña;
            }

            set
            {
                id_campaña = value;
            }
        }

        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public DateTime Fecha_eliminado { get => fecha_eliminado; set => fecha_eliminado = value; }
    }
}
