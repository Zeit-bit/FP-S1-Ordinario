using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta_WinForms.classes;

namespace PuntoDeVenta_WinForms.forms
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
            dataGridView_compras.DataSource = JsonSerializer.Deserialize<List<Compra>>(File.ReadAllText("data/compras.json"));
        }
    }
}
