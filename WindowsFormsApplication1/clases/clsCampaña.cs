using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    class clsCampaña
    {
        int id_campaña;
        string nombre;
        string descripion;
        int  precio; // double???
        DateTime fecha_inicio;
        DateTime fecha_fin; // Null o 0 lógico en DateTime es el MinValue
        int id_cliente;
        string nombre_cliente;
        int lider;

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
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripion; set => descripion = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public int Lider { get => lider; set => lider = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string NombreCliente { get => nombre_cliente; set => nombre_cliente = value; }
        public int Precio { get => precio; set => precio = value; }
        

        public string Cliente { get; internal set; }
    }
}