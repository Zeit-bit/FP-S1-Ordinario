﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinForms.classes
{
    // Clase para poder crear una lista de productos al deserializar "productos.json"
    class Producto
    {
        public string nombre {  get; set; }
        public string precio { get; set; }
    }
}