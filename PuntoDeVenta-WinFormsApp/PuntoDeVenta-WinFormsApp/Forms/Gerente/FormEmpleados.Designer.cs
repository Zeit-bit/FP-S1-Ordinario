namespace PuntoDeVenta_WinFormsApp.Forms.Gerente
{
    partial class FormEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            button_empleados = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button_compras = new Button();
            button_productos = new Button();
            label_selected = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_empleados
            // 
            button_empleados.BackColor = Color.FromArgb(205, 51, 51);
            button_empleados.FlatAppearance.BorderColor = Color.Black;
            button_empleados.FlatStyle = FlatStyle.Flat;
            button_empleados.Font = new Font("Verdana", 18F);
            button_empleados.ForeColor = Color.White;
            button_empleados.Location = new Point(0, 298);
            button_empleados.Name = "button_empleados";
            button_empleados.Size = new Size(266, 55);
            button_empleados.TabIndex = 1;
            button_empleados.Text = "Empleados";
            button_empleados.UseVisualStyleBackColor = false;
            button_empleados.Click += button_empleados_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 51, 51);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button_compras);
            panel1.Controls.Add(button_productos);
            panel1.Controls.Add(button_empleados);
            panel1.Location = new Point(-3, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 729);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 135);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 181);
            label1.Name = "label1";
            label1.Size = new Size(207, 23);
            label1.TabIndex = 4;
            label1.Text = "Panel Administrativo";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(75, 600);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 111);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button_compras
            // 
            button_compras.BackColor = Color.FromArgb(205, 51, 51);
            button_compras.FlatAppearance.BorderColor = Color.Black;
            button_compras.FlatStyle = FlatStyle.Flat;
            button_compras.Font = new Font("Verdana", 18F);
            button_compras.ForeColor = Color.White;
            button_compras.Location = new Point(0, 402);
            button_compras.Name = "button_compras";
            button_compras.Size = new Size(266, 55);
            button_compras.TabIndex = 5;
            button_compras.Text = "Compras";
            button_compras.UseVisualStyleBackColor = false;
            button_compras.Click += button_compras_Click;
            // 
            // button_productos
            // 
            button_productos.BackColor = Color.FromArgb(205, 51, 51);
            button_productos.FlatAppearance.BorderColor = Color.Black;
            button_productos.FlatStyle = FlatStyle.Flat;
            button_productos.Font = new Font("Verdana", 18F);
            button_productos.ForeColor = Color.White;
            button_productos.Location = new Point(0, 350);
            button_productos.Name = "button_productos";
            button_productos.Size = new Size(266, 55);
            button_productos.TabIndex = 4;
            button_productos.Text = "Productos";
            button_productos.UseVisualStyleBackColor = false;
            button_productos.Click += button_productos_Click;
            // 
            // label_selected
            // 
            label_selected.AutoSize = true;
            label_selected.BackColor = Color.Transparent;
            label_selected.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_selected.Location = new Point(281, 28);
            label_selected.Name = "label_selected";
            label_selected.Size = new Size(191, 35);
            label_selected.TabIndex = 4;
            label_selected.Text = "Empleados";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(205, 51, 51);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 14.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(789, 606);
            button2.Name = "button2";
            button2.Size = new Size(267, 80);
            button2.TabIndex = 7;
            button2.Text = "Eliminar Empleado";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(205, 51, 51);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 14.25F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(501, 606);
            button1.Name = "button1";
            button1.Size = new Size(267, 80);
            button1.TabIndex = 6;
            button1.Text = "Agregar Empleado";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(281, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1011, 510);
            dataGridView1.TabIndex = 5;
            // 
            // FormControlGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 717);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label_selected);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormControlGerente";
            Text = "FormControlGerente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_empleados;
        private Panel panel1;
        private Button button_compras;
        private Button button_productos;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label_selected;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}