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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            dataGridView_productos.DataSource = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText("data/productos.json"));
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            // Asigna valores para el nombre del producto y nuevo precio 
            string nombreProducto = textBox_nombreProducto.Text;
            int nuevoPrecio = (int)numUpDown_nuevoPrecio.Value;

            // Valida si existe el producto, en caso de existir, se actualiza el valor del indice al valor del producto correspondiente
            bool productoExiste = false;
            int iProducto = 0;
            List<Producto> productos = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText("data/productos.json"));
            for (int i = 0; i < productos.Count; i++) 
            {
                if (nombreProducto == productos[i].nombre)
                {
                    productoExiste = true;
                    iProducto = i;
                    break;
                }
            }

            // Actualiza el precio del producto en caso de existir, de lo contrario retorna mensaje correspondiente
            if (productoExiste)
            {
                productos[iProducto].precio = nuevoPrecio;
                File.WriteAllText("data/productos.json", JsonSerializer.Serialize<List<Producto>>(productos));
                dataGridView_productos.DataSource = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText("data/productos.json"));
            } else
            {
                MessageBox.Show("El producto ingresado no existe");
            }
        }
    }
}
