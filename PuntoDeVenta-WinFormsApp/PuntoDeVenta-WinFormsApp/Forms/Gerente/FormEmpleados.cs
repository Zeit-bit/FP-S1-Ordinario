using System.Text.Json;
using PuntoDeVenta_WinFormsApp.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PuntoDeVenta_WinFormsApp.Forms.Gerente
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
            dataGridView_empleados.DataSource = empleados;
        }

        private void button_empleados_Click(object sender, EventArgs e)
        {

        }

        private void button_productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductos formProductos = new FormProductos();
            formProductos.StartPosition = FormStartPosition.Manual;
            formProductos.Location = this.Location;
            formProductos.ShowDialog();
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

        private void button_crearEmpleado_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
            string id = textBox_id.Text;
            string clave = textBox_clave.Text;
            string nombre = textBox_nombre.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("No puedes dejar campos vacios");
                return;
            }

            bool idExists = false;
            for (int i = 0; i < empleados.Count; i++)
            {
                if (id == empleados[i].id)
                {
                    idExists = true;
                }
            }

            if (!idExists)
            {
                Empleado empleado = new Empleado(id, clave, nombre);
                empleados.Add(empleado);
                File.WriteAllText("data/empleados.json", JsonSerializer.Serialize<List<Empleado>>(empleados));
                dataGridView_empleados.DataSource = empleados;
            }
            else
            {
                MessageBox.Show("El id ya existe, ingrese otro");
            }
        }

        private void button_eliminarEmpleado_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
            string id = textBox_idAeliminar.Text;

            if (string.IsNullOrWhiteSpace(id)) 
            {
                MessageBox.Show("No puedes dejar campos vacios");
                return;
            }

            bool idExists = false;
            int indiceAeliminar = 0;
            for (int i = 0; i < empleados.Count; i++)
            {
                if (id == empleados[i].id)
                {
                    idExists = true;
                    indiceAeliminar = i;
                }
            }

            if (idExists)
            {
                empleados.Remove(empleados[indiceAeliminar]);
                File.WriteAllText("data/empleados.json", JsonSerializer.Serialize<List<Empleado>>(empleados));
                dataGridView_empleados.DataSource = empleados;
            }
            else
            {
                MessageBox.Show("El id no existe, ingrese otro");
            }
        }
    }
}
