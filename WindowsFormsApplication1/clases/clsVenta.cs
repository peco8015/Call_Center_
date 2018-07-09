using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    public class clsVenta
    {
        private int id_venta;
        private DateTime fecha_venta;
        private int id_llamada;

        public clsVenta()
        {
        }

        public int Id_venta { get => id_venta; set => id_venta = value; }
        public DateTime Fecha_venta { get => fecha_venta; set => fecha_venta = value; }
        public int Id_llamada { get => id_llamada; set => id_llamada = value; }
    }
}
