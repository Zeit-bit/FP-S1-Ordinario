using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta_WinFormsApp.Classes;

namespace PuntoDeVenta_WinFormsApp.Forms.Gerente
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            List<Producto> productos = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText("data/productos.json"));
            dataGridView_Productos.DataSource = productos;
        }

        private void button_empleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.StartPosition = FormStartPosition.Manual;
            formEmpleados.Location = this.Location;
            formEmpleados.ShowDialog();
            this.Close();
        }

        private void button_compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCompras formCompras = new FormCompras();
            formCompras.StartPosition = FormStartPosition.Manual;
            formCompras.Location = this.Location;
            formCompras.ShowDialog();
            this.Close();
        }

        private void dataGridView_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Productos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_confirmarPrecio_Click(object sender, EventArgs e)
        {
            List<Producto> productos = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText("data/productos.json"));
            string productoAmodificar = textBox_producto.Text;
            int nuevoPrecio = (int)numericUpDown_precio.Value;

            bool productoExiste = false;
            for (int i = 0; i < productos.Count; i++)
            {
                if (productoAmodificar == productos[i].nombre)
                {
                    productoExiste = true;
                    productos[i].precio = nuevoPrecio;
                    dataGridView_Productos.DataSource = productos;
                    File.WriteAllText("data/productos.json", JsonSerializer.Serialize(productos));
                }
            }

            if (!productoExiste) 
            {
                MessageBox.Show("El producto ingresado no existe");
            }
        }
    }
}
