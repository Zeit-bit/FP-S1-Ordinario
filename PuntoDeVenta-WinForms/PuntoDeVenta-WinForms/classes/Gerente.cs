using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinForms.classes
{
    // Clase para poder crear un objeto gerente al deserializar "gerente.json"
    class Gerente
    {
        public string id { get; set; }
        public string clave { get; set; }
    }
}
