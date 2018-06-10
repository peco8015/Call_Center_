using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    public class clsLLamadaDeNuevo
    {
        int _idLlamada;
        int _idEmpleado;
        int _idContacto;
        int _idNuevallamada;
        DateTime fecha;
        int hora;
        int minutos;
        string observaciones;

        public int IdLlamada
        {
            get
            {
                return _idLlamada;
            }

            set
            {
                _idLlamada = value;
            }
        }

        public int IdEmpleado
        {
            get
            {
                return _idEmpleado;
            }

            set
            {
                _idEmpleado = value;
            }
        }

        public int IdContacto
        {
            get
            {
                return _idContacto;
            }

            set
            {
                _idContacto = value;
            }
        }

        public int IdNuevallamada
        {
            get
            {
                return _idNuevallamada;
            }

            set
            {
                _idNuevallamada = value;
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
