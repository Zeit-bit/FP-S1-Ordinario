using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinFormsApp.Classes
{
    class Empleado
    {
        public string id { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }

        public Empleado(string id, string clave, string nombre)
        {
            this.id = id;
            this.clave = clave;
            this.nombre = nombre;
        }
    }
}
