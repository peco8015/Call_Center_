using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    class clsCampaña
    {
        int idCampaña;
        string nombre;
        string descripion;
        int  precio; // double???
        DateTime fecha_inicio;
        DateTime fecha_fin;     // Null o 0 lógico en DateTime es el MinValue
        int idCliente;
        string nombreCliente;
        int lider; // ??

        public int IdCampaña
        {
            get
            {
                return idCampaña;
            }

            set
            {
                idCampaña = value;
            }
        }
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripion; set => descripion = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public int Lider { get => lider; set => lider = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int Precio { get => precio; set => precio = value; }
        

        public string Cliente { get; internal set; }
    }
}