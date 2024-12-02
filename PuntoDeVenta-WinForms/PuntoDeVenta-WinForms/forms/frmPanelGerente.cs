using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta_WinForms.classes;

namespace PuntoDeVenta_WinForms.forms
{
    public partial class frmPanelGerente : Form
    {
        public frmPanelGerente()
        {
            InitializeComponent();
        }

        private void button_empleados_Click(object sender, EventArgs e)
        {
            WinformUtils.btnActive([button_empleados, button_productos, button_compras]);
            label_encabezado.Text = "Empleados";
            WinformUtils.loadForm(panel_formLoader, new frmEmpleados());
        }

        private void button_productos_Click(object sender, EventArgs e)
        {
            WinformUtils.btnActive([button_productos, button_empleados, button_compras]);
            label_encabezado.Text = "Productos";
            WinformUtils.loadForm(panel_formLoader, new frmProductos());
        }

        private void button_compras_Click(object sender, EventArgs e)
        {
            WinformUtils.btnActive([button_compras, button_empleados, button_productos]);
            label_encabezado.Text = "Historial de Compras";
            WinformUtils.loadForm(panel_formLoader, new frmCompras());
        }

        private void linkLabel_cerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WinformUtils.openForm(this, new Form1());
        }
    }
}
