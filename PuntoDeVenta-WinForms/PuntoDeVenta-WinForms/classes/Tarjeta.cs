using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinForms.classes
{
    class Tarjeta
    {
        public string tipo { get; set; }
        public int nip { get; set; }
        public int saldo {  get; set; }

        public Tarjeta(string tipo, int nip, int saldo)
        {
            this.tipo = tipo;
            this.nip = nip;
            this.saldo = saldo;
        }
    }
}
