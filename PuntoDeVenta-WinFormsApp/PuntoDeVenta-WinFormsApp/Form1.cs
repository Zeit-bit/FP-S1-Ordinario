using System.Text.Json.Nodes;
using System.Text.Json;
using PuntoDeVenta_WinFormsApp.Classes;
using PuntoDeVenta_WinFormsApp.Forms.Gerente;

namespace PuntoDeVenta_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string clave = textBox_clave.Text;

            Gerente gerente = JsonSerializer.Deserialize<Gerente>(File.ReadAllText("data/gerente.json"));

            if (id == gerente.id && clave == gerente.clave)
            {
                this.Hide();
                FormEmpleados formEmpleados = new FormEmpleados();
                formEmpleados.StartPosition = FormStartPosition.Manual;
                formEmpleados.Location = this.Location;
                formEmpleados.ShowDialog();
                this.Close();
            }
        }
    }
}
