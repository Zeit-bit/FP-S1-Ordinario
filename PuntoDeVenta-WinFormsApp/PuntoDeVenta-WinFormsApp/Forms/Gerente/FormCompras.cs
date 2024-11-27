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
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void button_empleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleados formEmpleadas = new FormEmpleados();
            formEmpleadas.ShowDialog();
        }

        private void button_productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductos formProductos = new FormProductos();
            formProductos.ShowDialog();
        }
    }
}
