using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    class clsLlamada
    {
        int id_llamada;
        int id_contacto;
        int id_campaña;
        int id_empleado;
        TimeSpan duracion_total;
        TimeSpan t_espera;
        string resultado; 
        DateTime fecha;
        string observaciones;


        public int Id_llamada { get => id_llamada; set => id_llamada = value; }
        public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        public int Id_campaña { get => id_campaña; set => id_campaña = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public TimeSpan Duracion_total { get => duracion_total; set => duracion_total = value; }
        public TimeSpan T_espera { get => t_espera; set => t_espera = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
