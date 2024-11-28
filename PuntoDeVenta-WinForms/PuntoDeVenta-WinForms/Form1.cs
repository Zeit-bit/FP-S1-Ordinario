using System.Text.Json;
using PuntoDeVenta_WinForms.classes;
using PuntoDeVenta_WinForms.forms;

namespace PuntoDeVenta_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // Asgina valores de id y clave
            string id = textBox_id.Text;
            string clave = textBox_clave.Text;

            // Crea un objeto gerente con los atributos y valores de "gerente.json"
            Gerente gerente = JsonSerializer.Deserialize<Gerente>(File.ReadAllText("data/gerente.json"));

            // Crea una lista de objetos empleado con los atributos y valores de "empleados.json"
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));

            // Valida credenciales
            if (id == gerente.id &&  clave == gerente.clave)
            {
                WinformUtils.openForm(this, new frmPanelGerente());
            } else
            {
                for (int i = 0; i < empleados.Count; i++)
                {
                    if (id == empleados[i].id && clave == empleados[i].clave)
                    {
                        MessageBox.Show("Eres empleado");
                        // LLevar a dashboard de empleado
                        return;
                    }
                }

                MessageBox.Show("Credenciales invalidas, intenta nuevamente");
            }
        }
    }
}
