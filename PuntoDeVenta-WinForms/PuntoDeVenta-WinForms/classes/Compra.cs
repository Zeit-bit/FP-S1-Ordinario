using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinForms.classes
{
    class Compra
    {
        public string encargado { get; set; }
        public string id { get; set; }
        public string clave { get; set; }
        public string costo {  get; set; }

        public Compra(string encargado, string id, string clave, string costo)
        {
            this.encargado = encargado;
            this.id = id;
            this.clave = clave;
            this.costo = costo;
        }
    }
}
