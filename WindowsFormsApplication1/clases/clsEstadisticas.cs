using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    class clsEstadisticas
    {
        clsConexion conectar = new clsConexion();
        clsEmpleado empleado;
        clsCliente cliente;
        clsCampaña campaña;
        string tipo;
        string clave;
        float valor;

        public clsEstadisticas()
        { }

        public clsEstadisticas(string clase, int id)
        {
            tipo = clase;
            switch (tipo)
            {
                case "empleado":
                    empleado = conectar.datos_empleado(id); // DNI para empleado
                    break;

                case "cliente":
                    cliente = conectar.datos_cliente(id);
                    break;

                case "campaña":
                    campaña = conectar.datos_campaña(id);
                    cliente = conectar.datos_cliente(campaña.Id_cliente);
                    break;
            }
        }

        public string Clave { get => clave; set => clave = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}
