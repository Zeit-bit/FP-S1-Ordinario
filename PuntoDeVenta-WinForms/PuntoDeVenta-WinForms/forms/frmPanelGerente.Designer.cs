namespace PuntoDeVenta_WinForms.forms
{
    partial class frmPanelGerente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelGerente));
            panel1 = new Panel();
            linkLabel_cerrarSesion = new LinkLabel();
            label1 = new Label();
            button_compras = new Button();
            button_productos = new Button();
            button_empleados = new Button();
            pictureBox1 = new PictureBox();
            label_encabezado = new Label();
            panel2 = new Panel();
            panel_formLoader = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel_formLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 51, 51);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabel_cerrarSesion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_compras);
            panel1.Controls.Add(button_productos);
            panel1.Controls.Add(button_empleados);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 717);
            panel1.TabIndex = 0;
            // 
            // linkLabel_cerrarSesion
            // 
            linkLabel_cerrarSesion.ActiveLinkColor = Color.RosyBrown;
            linkLabel_cerrarSesion.AutoSize = true;
            linkLabel_cerrarSesion.LinkColor = Color.White;
            linkLabel_cerrarSesion.Location = new Point(83, 183);
            linkLabel_cerrarSesion.Name = "linkLabel_cerrarSesion";
            linkLabel_cerrarSesion.Size = new Size(76, 15);
            linkLabel_cerrarSesion.TabIndex = 4;
            linkLabel_cerrarSesion.TabStop = true;
            linkLabel_cerrarSesion.Text = "Cerrar Sesión";
            linkLabel_cerrarSesion.LinkClicked += linkLabel_cerrarSesion_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(187, 18);
            label1.TabIndex = 1;
            label1.Text = "Panel Administrativo";
            // 
            // button_compras
            // 
            button_compras.BackColor = Color.FromArgb(234, 234, 234);
            button_compras.FlatAppearance.BorderColor = Color.Black;
            button_compras.FlatStyle = FlatStyle.Flat;
            button_compras.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_compras.ForeColor = Color.Black;
            button_compras.Location = new Point(11, 619);
            button_compras.Name = "button_compras";
            button_compras.Size = new Size(221, 86);
            button_compras.TabIndex = 3;
            button_compras.Text = "Compras";
            button_compras.UseVisualStyleBackColor = false;
            button_compras.Click += button_compras_Click;
            // 
            // button_productos
            // 
            button_productos.BackColor = Color.FromArgb(234, 234, 234);
            button_productos.FlatAppearance.BorderColor = Color.Black;
            button_productos.FlatStyle = FlatStyle.Flat;
            button_productos.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_productos.ForeColor = Color.Black;
            button_productos.Location = new Point(11, 518);
            button_productos.Name = "button_productos";
            button_productos.Size = new Size(221, 86);
            button_productos.TabIndex = 2;
            button_productos.Text = "Productos";
            button_productos.UseVisualStyleBackColor = false;
            button_productos.Click += button_productos_Click;
            // 
            // button_empleados
            // 
            button_empleados.BackColor = Color.FromArgb(234, 234, 234);
            button_empleados.FlatAppearance.BorderColor = Color.Black;
            button_empleados.FlatStyle = FlatStyle.Flat;
            button_empleados.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_empleados.ForeColor = Color.Black;
            button_empleados.Location = new Point(11, 417);
            button_empleados.Name = "button_empleados";
            button_empleados.Size = new Size(221, 86);
            button_empleados.TabIndex = 1;
            button_empleados.Text = "Empleados";
            button_empleados.UseVisualStyleBackColor = false;
            button_empleados.Click += button_empleados_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label_encabezado
            // 
            label_encabezado.AutoSize = true;
            label_encabezado.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_encabezado.ForeColor = Color.Black;
            label_encabezado.Location = new Point(24, 27);
            label_encabezado.Name = "label_encabezado";
            label_encabezado.Size = new Size(335, 35);
            label_encabezado.TabIndex = 1;
            label_encabezado.Text = "Bienvenido Gerente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(210, 108, 116);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label_encabezado);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(249, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 87);
            panel2.TabIndex = 2;
            // 
            // panel_formLoader
            // 
            panel_formLoader.Controls.Add(pictureBox2);
            panel_formLoader.Dock = DockStyle.Fill;
            panel_formLoader.Location = new Point(249, 87);
            panel_formLoader.Name = "panel_formLoader";
            panel_formLoader.Size = new Size(1069, 630);
            panel_formLoader.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1032, 612);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // frmPanelGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 717);
            Controls.Add(panel_formLoader);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPanelGerente";
            Text = "frmPanelGerente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_formLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button_empleados;
        private Button button_compras;
        private Button button_productos;
        private Label label1;
        private Label label_encabezado;
        private Panel panel2;
        private Panel panel_formLoader;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel_cerrarSesion;
    }
}