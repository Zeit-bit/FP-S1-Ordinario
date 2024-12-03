using System.Formats.Tar;
using System.Text.Json;
using PuntoDeVenta_WinForms.classes;

namespace PuntoDeVenta_WinForms.forms.empleado
{
    public partial class frmCobro : Form
    {
        int precioSinPropina = frmCaja.precioTotal;
        public frmCobro()
        {
            InitializeComponent();
            label_precioTotal.Text = $"Precio Total: ${frmCaja.precioTotal}";
        }

        public void seleccionarPropina(double porcentaje, Button[] btns)
        {
            if (checkBox_Propina.Checked)
            {
                WinformUtils.btnActive(btns);
                frmCaja.precioTotal = (int)(precioSinPropina * porcentaje);
                label_precioTotal.Text = $"Precio Total: ${frmCaja.precioTotal}";
            }
        }

        private void button_10p_Click(object sender, EventArgs e)
        {
            seleccionarPropina(1.10f, [button_10p, button_15p, button_20p]);
        }

        private void button_15p_Click(object sender, EventArgs e)
        {
            seleccionarPropina(1.15f, [button_15p, button_10p, button_20p]);
        }

        private void button_20p_Click(object sender, EventArgs e)
        {
            seleccionarPropina(1.20f, [button_20p, button_15p, button_10p]);
        }

        private void checkBox_Propina_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Propina.Checked)
            {
                WinformUtils.deselectAllBtns([button_10p, button_15p, button_20p]);
                frmCaja.precioTotal = precioSinPropina;
                label_precioTotal.Text = $"Precio Total: ${frmCaja.precioTotal}";
            }
        }

        private void button_procesarEfectivo_Click(object sender, EventArgs e)
        {
            int efectivo = (int)numUpDown_efectivo.Value;
            if (efectivo < frmCaja.precioTotal)
            {
                MessageBox.Show("Dinero insuficiente, ingrese una mayor cantidad de efectivo");
            }
            else
            {
                textBox_cambio.Text = $" ${efectivo - frmCaja.precioTotal}";
            }
        }

        private void button_terminarPagoEfectivo_Click(object sender, EventArgs e)
        {
            if ((int)numUpDown_efectivo.Value < frmCaja.precioTotal)
            {
                MessageBox.Show("Dinero insuficente, ingrese una mayor cantidad de efectivo");
            }
            else
            {
                List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
                List<Compra> compras = JsonSerializer.Deserialize<List<Compra>>(File.ReadAllText("data/compras.json"));
                compras.Add(new Compra(empleados[Form1.indiceEmpleado].nombre, empleados[Form1.indiceEmpleado].id, empleados[Form1.indiceEmpleado].clave, $"${frmCaja.precioTotal}"));
                File.WriteAllText("data/compras.json", JsonSerializer.Serialize<List<Compra>>(compras));
                resetCompra();
                WinformUtils.openForm(this, new frmCaja());
            }
        }

        public void resetCompra()
        {
            frmCaja.carrito.Clear();
            frmCaja.precioTotal = 0;
        }

        private void button_terminarPagoTarjeta_Click(object sender, EventArgs e)
        {
            string tipoTarjeta = comboBox_tipoTarjeta.Text;
            int nip = (int)numericUpDown_nip.Value;

            List<Tarjeta> tarjetas = JsonSerializer.Deserialize<List<Tarjeta>>(File.ReadAllText("data/tarjetas.json"));

            bool tarjetaExiste = false;
            int indiceTarjeta = 0;
            for (int i = 0; i < tarjetas.Count; i++)
            {
                if (tipoTarjeta == tarjetas[i].tipo && nip == tarjetas[i].nip)
                {
                    tarjetaExiste = true;
                    indiceTarjeta = i;
                } 
            }

            if (tarjetaExiste)
            {
                if (tarjetas[indiceTarjeta].saldo < frmCaja.precioTotal)
                {
                    MessageBox.Show("No hay saldo suficiente en tu tarjeta, intenta con otro metodo");
                }
                else
                {
                    tarjetas[indiceTarjeta].saldo -= frmCaja.precioTotal;
                    File.WriteAllText("data/tarjetas.json", JsonSerializer.Serialize<List<Tarjeta>>(tarjetas));

                    MessageBox.Show($"Operacion exitosa, cliente tenia un saldo de ${tarjetas[indiceTarjeta].saldo+frmCaja.precioTotal} en su cuenta, ahora tiene ${tarjetas[indiceTarjeta].saldo}");
                    List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(File.ReadAllText("data/empleados.json"));
                    List<Compra> compras = JsonSerializer.Deserialize<List<Compra>>(File.ReadAllText("data/compras.json"));
                    compras.Add(new Compra(empleados[Form1.indiceEmpleado].nombre, empleados[Form1.indiceEmpleado].id, empleados[Form1.indiceEmpleado].clave, $"${frmCaja.precioTotal}"));
                    File.WriteAllText("data/compras.json", JsonSerializer.Serialize<List<Compra>>(compras));
                    resetCompra();
                    WinformUtils.openForm(this, new frmCaja());
                }
            }
            else
            {
                MessageBox.Show("Tarjeta no existe, intenta agregarla manualmente en 'data/tarjetas.json'");
            }
        }
    }
}
