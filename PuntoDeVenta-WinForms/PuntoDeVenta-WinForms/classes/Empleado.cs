using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinForms.classes
{
    // Clase para poder crear una lista de empleados al deserealizar "empleados.json"
    // Permite sobreescribir el json con nuevos empleados o con empleados eliminados
    class Empleado
    {
        public string id { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }

        public Empleado (string id, string clave, string nombre)
        {
            this.id = id;
            this.clave = clave;
            this.nombre = nombre;
        }
    }
}
