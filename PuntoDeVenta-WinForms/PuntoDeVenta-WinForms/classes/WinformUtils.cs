using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta_WinForms.classes
{
    // Clase con metodos estaticos para algunas utilidades que utilizamos en nuestra WinFormApp
    static class WinformUtils
    {
        // Metodo para abrir un form nuevo
        public static void openForm(Form FormActual, Form NuevoForm)
        {
            FormActual.Hide();
            Form form = NuevoForm as Form;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = FormActual.Location;
            form.ShowDialog();
            FormActual.Close();
        }

        // Metodo para cargar un form en un panel
        public static void loadForm(Panel formLoader, Form FormAcargar)
        {
            if (formLoader.Controls.Count > 0)
            {
                formLoader.Controls.RemoveAt(0);
            }

            Form form = FormAcargar as Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            formLoader.Controls.Add(form);
            form.Show();
        }

        // Metodo para highlightear el boton activo y restablecer los colores de los demas
        public static void btnActive(Button[] btns)
        {
            btns[0].BackColor = Color.Maroon;
            btns[0].FlatAppearance.BorderColor = Color.White;
            btns[0].ForeColor = Color.White;

            for (int i = 1; i < btns.Length; i++)
            {
                btns[i].BackColor = Color.FromArgb(234, 234, 234);
                btns[i].FlatAppearance.BorderColor = Color.Black;
                btns[i].ForeColor = Color.Black;
            }
        }

        // Metodo para restablecer los colores de todos los botones
        public static void deselectAllBtns(Button[] btns)
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].BackColor = Color.FromArgb(234, 234, 234);
                btns[i].FlatAppearance.BorderColor = Color.Black;
                btns[i].ForeColor = Color.Black;
            }
        }
    }
}
