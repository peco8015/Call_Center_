﻿using System;
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
        DateTime fechaInicio;
        int jefe;//null es empleado,con valor 1 es jefe
        string password;
        DateTime fechaNaciemiento;
        int id_campaña;
        string domicilio;
        string telefono;
        string mail;

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

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
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

        public DateTime FechaNaciemiento
        {
            get
            {
                return fechaNaciemiento;
            }

            set
            {
                fechaNaciemiento = value;
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
    }
}
