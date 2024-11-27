using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta_WinFormsApp.Forms.Gerente
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void button_empleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.ShowDialog();
        }

        private void button_compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCompras formCompras = new FormCompras();
            formCompras.ShowDialog();
        }
    }
}
