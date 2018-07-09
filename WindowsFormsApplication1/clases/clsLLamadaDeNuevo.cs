using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    public class clsLLamadaDeNuevo
    {
        int _id_llamada;
        int _id_empleado;
        int _id_contacto;
        int _id_nueva_llamada;
        DateTime fecha;
        int hora;
        int minutos;
        string observaciones;

        public int Id_llamada
        {
            get
            {
                return _id_llamada;
            }

            set
            {
                _id_llamada = value;
            }
        }

        public int Id_empleado
        {
            get
            {
                return _id_empleado;
            }

            set
            {
                _id_empleado = value;
            }
        }

        public int Id_contacto
        {
            get
            {
                return _id_contacto;
            }

            set
            {
                _id_contacto = value;
            }
        }

        public int Id_nueva_llamada
        {
            get
            {
                return _id_nueva_llamada;
            }

            set
            {
                _id_nueva_llamada = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public int Minutos
        {
            get
            {
                return minutos;
            }

            set
            {
                minutos = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }

            set
            {
                observaciones = value;
            }
        }
    }
}
