namespace PuntoDeVenta_WinFormsApp.Forms.Gerente
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void button_empleados_Click(object sender, EventArgs e)
        {

        }

        private void button_productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductos formProductos = new FormProductos();
            formProductos.ShowDialog();
            this.Close();
        }

        private void button_compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCompras formCompras = new FormCompras();
            formCompras.ShowDialog();
            this.Close();
        }
    }
}
