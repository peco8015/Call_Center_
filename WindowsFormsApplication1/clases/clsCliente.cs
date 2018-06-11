using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.clases
{
    public class clsCliente
    {
        int _id;
        int cuil;
        string nombre; // empresa
        string contacto;
        string domicilio;
        string mail;
        int telefono; // STRING O INT?!

        public clsCliente()
        { }

        public int Id { get => _id; set => _id = value; }
        public int Cuil { get => cuil; set => cuil = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}