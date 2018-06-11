using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    public class clsJornada
    {
        private int id_empleado;
        private DateTime fecha { get; set; }
        private int cantLlamadas;
        private int cantVentas;
        private TimeSpan t_atendiendo { get; set; }
        private TimeSpan t_descanso { get; set; }
        private TimeSpan t_reunion { get; set; }
        private TimeSpan t_llenadoFormularios { get; set; }
        private TimeSpan t_sinContactos { get; set; }
        private TimeSpan t_sinCampaña { get; set; }
        private TimeSpan t_inactivo { get; set; }
        private TimeSpan t_baño { get; set; }
        private TimeSpan t_almuerzo { get; set; }
        private TimeSpan t_capacitacion { get; set; }
        private TimeSpan inicio_sesion { get; set; }
        private TimeSpan cierre_sesion { get; set; }

        public clsJornada()
        {        }

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int CantLlamadas { get => cantLlamadas; set => cantLlamadas = value; }
        public int CantVentas { get => cantVentas; set => cantVentas = value; }
        public TimeSpan T_atendiendo { get => t_atendiendo; set => t_atendiendo = value; }
        public TimeSpan T_reunion { get => t_reunion; set => t_reunion = value; }
        public TimeSpan T_llenadoFormularios { get => t_llenadoFormularios; set => t_llenadoFormularios = value; }
        public TimeSpan T_sinContactos { get => t_sinContactos; set => t_sinContactos = value; }
        public TimeSpan T_sinCampaña { get => t_sinCampaña; set => t_sinCampaña = value; }
        public TimeSpan T_inactivo { get => t_inactivo; set => t_inactivo = value; }
        public TimeSpan T_descanso { get => t_descanso; set => t_descanso = value; }
        public TimeSpan T_baño { get => t_baño; set => t_baño = value; }
        public TimeSpan T_almuerzo { get => t_almuerzo; set => t_almuerzo = value; }
        public TimeSpan T_capacitacion { get => t_capacitacion; set => t_capacitacion = value; }
        public TimeSpan Inicio_sesion { get => inicio_sesion; set => inicio_sesion = value; }
        public TimeSpan Cierre_sesion { get => cierre_sesion; set => cierre_sesion = value; }
    }
}
