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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            dataGridView_empleados.DataSource = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            // Asigna valores de id, clave y nombre
            string id = textBox_idCrear.Text;
            string clave = textBox_claveCrear.Text;
            string nombre = textBox_nombreCrear.Text;

            // Valida si exiten campos vacios y retorna mensaje correspondiente
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No puedes dejar campos vacios");
                return;
            }

            // Valida si ya existe el id en "empleados.json" para retornar mensaje correspondiene en dado caso que si
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
            for (int i = 0; i < empleados.Count; i++)
            {
                if (id == empleados[i].id)
                {
                    MessageBox.Show("El id ingresado ya exite, ingrese uno diferente");
                    return;
                }
            }

            // Añade el nuevo empleado a "empleados.json"
            empleados.Add(new Empleado(id, clave, nombre));
            File.WriteAllText("data/empleados.json", JsonSerializer.Serialize(empleados));
            dataGridView_empleados.DataSource = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Asigna valores de id
            string id = textBox_idEliminar.Text;

            // Valida si el id existe para eliminar el empleado correspondiente
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
            for (int i = 0; i < empleados.Count; i++)
            {
                if (id == empleados[i].id)
                {
                    empleados.Remove(empleados[i]);
                    File.WriteAllText("data/empleados.json", JsonSerializer.Serialize<List<Empleado>>(empleados));
                    dataGridView_empleados.DataSource = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
                    return;
                }
            }

            // Si no existe el id, retorna mensaje correspondiente
            MessageBox.Show("No existe el id, ingrese otro");
        }
    }
}
