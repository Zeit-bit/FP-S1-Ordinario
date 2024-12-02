using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinForms.classes
{
    public class ProductoEnCarrito : Producto
    {
        public int qty{  get; set; }

        public ProductoEnCarrito(string nombre, int precio, int qty)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.qty = qty;
        }
    }
}
