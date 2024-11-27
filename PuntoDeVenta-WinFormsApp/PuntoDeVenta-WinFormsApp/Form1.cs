using System.Text.Json.Nodes;
using System.Text.Json;
using PuntoDeVenta_WinFormsApp.Classes;

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
                //Ir a nuevo form para gerentes
            }
        }
    }
}
