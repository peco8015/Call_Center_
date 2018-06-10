using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    class clsLllamada
    {
        int id_llamada;
        int id_contacto;
        int id_campaña;
        int id_empleado;
        string duracion;
        string resultado; 
        public DateTime fecha;
        string observaciones;
       
      

        public int Id_llamada
        {
            get
            {
                return id_llamada;
            }

            set
            {
                id_llamada = value;
            }
        }

        public int Id_contacto
        {
            get
            {
                return id_contacto;
            }

            set
            {
                id_contacto = value;
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

        public string Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
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

        public string Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }

        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
