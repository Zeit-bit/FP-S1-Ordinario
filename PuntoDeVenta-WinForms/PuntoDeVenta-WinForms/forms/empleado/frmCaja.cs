using System.Text.Json;
using PuntoDeVenta_WinForms.classes;

namespace PuntoDeVenta_WinForms.forms.empleado
{
    public partial class frmCaja : Form
    {
        public static List<ProductoEnCarrito> carrito = new List<ProductoEnCarrito>();
        private List<Producto> productos = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText("data/productos.json"));
        public static int precioTotal;
        public frmCaja()
        {
            InitializeComponent();

            // Muestra en el form, el nombre del empleado loggeado
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
            label1.Text = $"Empleado: {empleados[Form1.indiceEmpleado].nombre}";

            // Asigna el precio correspondiente a cada label de cada producto
            Label[] precios = { label_paracetamol, label_vitaminaC, label_bloqueadorSolar, label_vendas, label_termometro, label_vaporub, label_eletrolitoUva, label1_ibuprofeno, label_clorfenamina, label_treda, label_aspirina, label_cubrebocas };
            for (int i = 0; i < precios.Length; i++)
            {
                precios[i].Text = $"Precio: ${productos[i].precio}";
            }
        }

        private void button_paracetamol_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 0);
        }

        private void button_vitaminaC_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 1);
        }

        private void button_bloqueadorSolar_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 2);
        }

        private void button_vendas_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 3);
        }

        private void button_termometro_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 4);
        }

        private void button_vaporub_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 5);
        }

        private void button_electrolitoUva_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 6);
        }

        private void button_ibuprofeno_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 7);
        }

        private void button_clorfenamina_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 8);
        }

        private void button_treda_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 9);
        }

        private void button_aspirina_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 10);
        }

        private void button_cubrebocas_Click(object sender, EventArgs e)
        {
            agregarProducto(carrito, 11);
        }

        private void linkLabel_cerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            carrito.Clear();
            WinformUtils.openForm(this, new Form1());
        }

        private void agregarProducto(List<ProductoEnCarrito> carrito, int indiceProducto)
        {
            bool productoYaAgregado = false;
            precioTotal = 0;

            for (int i = 0; i < carrito.Count; i++)
            {
                if (productos[indiceProducto].nombre == carrito[i].nombre)
                {
                    productoYaAgregado = true;
                    if (carrito[i].qty < 64)
                    {
                        carrito[i].qty++;
                        carrito[i].precio = carrito[i].qty * productos[indiceProducto].precio;
                    }
                    else
                    {
                        MessageBox.Show("No puedes agregar mas de un stack de un mismo producto");
                    }
                }
                precioTotal += carrito[i].precio;
            }

            if (!productoYaAgregado)
            {
                carrito.Add(new ProductoEnCarrito(productos[indiceProducto].nombre, productos[indiceProducto].precio, 1));
                precioTotal += productos[indiceProducto].precio;
            }
            label_precioTotal.Text = $"Precio Total: ${precioTotal}";
            dataGridView_carrito.DataSource = null;
            dataGridView_carrito.DataSource = carrito;
            dataGridView_carrito.Columns[0].Width = 50;
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            string nombre = textBox_nombreProducto.Text;
            int cantidad = (int)numUpDown_cantidad.Value;

            bool productoEstaEnCarrito = false;
            int indiceCarrito = 0;
            for (int i = 0; i < carrito.Count; i++)
            {
                if (nombre == carrito[i].nombre)
                {
                    productoEstaEnCarrito = true;
                    indiceCarrito = i;
                }
            }

            if (productoEstaEnCarrito)
            {
                if (carrito[indiceCarrito].qty - cantidad >= 0)
                {
                    int precioUnitario = carrito[indiceCarrito].precio / carrito[indiceCarrito].qty;
                    precioTotal -= precioUnitario * cantidad;
                    carrito[indiceCarrito].qty -= cantidad;
                    carrito[indiceCarrito].precio -= precioUnitario * cantidad;
                    label_precioTotal.Text = $"Precio Total: ${precioTotal}";
                }
                else
                {
                    MessageBox.Show($"Cantidad ingresada es mayor que la cantidad de {carrito[indiceCarrito].nombre}");
                }

                if (carrito[indiceCarrito].qty == 0)
                {
                    carrito.Remove(carrito[indiceCarrito]);

                }
                dataGridView_carrito.DataSource = null;
                dataGridView_carrito.DataSource = carrito;
                dataGridView_carrito.Columns[0].Width = 50;
            }
            else
            {
                MessageBox.Show("El producto ingresado no existe");
            }
        }

        private void button_pagar_Click(object sender, EventArgs e)
        {
            if (carrito.Count > 0)
            {
                WinformUtils.openForm(this, new frmCobro());
            } else
            {
                MessageBox.Show("Primero agrega algun producto, antes de continuar con el pago");
            }
        }
    }
}
