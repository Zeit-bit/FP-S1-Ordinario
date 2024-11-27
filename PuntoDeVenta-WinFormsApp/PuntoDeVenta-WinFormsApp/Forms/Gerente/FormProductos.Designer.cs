namespace PuntoDeVenta_WinFormsApp.Forms.Gerente
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label_selected = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button_compras = new Button();
            button_productos = new Button();
            button_empleados = new Button();
            dataGridView_Productos = new DataGridView();
            panel2 = new Panel();
            textBox_producto = new TextBox();
            numericUpDown_precio = new NumericUpDown();
            button_confirmarPrecio = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Productos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_precio).BeginInit();
            SuspendLayout();
            // 
            // label_selected
            // 
            label_selected.AutoSize = true;
            label_selected.BackColor = Color.Transparent;
            label_selected.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_selected.Location = new Point(367, 38);
            label_selected.Name = "label_selected";
            label_selected.Size = new Size(178, 35);
            label_selected.TabIndex = 9;
            label_selected.Text = "Productos";
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
            panel1.Location = new Point(12, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 729);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 135);
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
            // dataGridView_Productos
            // 
            dataGridView_Productos.AllowUserToAddRows = false;
            dataGridView_Productos.AllowUserToDeleteRows = false;
            dataGridView_Productos.AllowUserToResizeColumns = false;
            dataGridView_Productos.AllowUserToResizeRows = false;
            dataGridView_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Productos.BackgroundColor = SystemColors.Control;
            dataGridView_Productos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView_Productos.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_Productos.Location = new Point(367, 126);
            dataGridView_Productos.Name = "dataGridView_Productos";
            dataGridView_Productos.ReadOnly = true;
            dataGridView_Productos.RowHeadersVisible = false;
            dataGridView_Productos.Size = new Size(371, 568);
            dataGridView_Productos.TabIndex = 10;
            dataGridView_Productos.CellContentClick += dataGridView_Productos_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 247);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox_producto);
            panel2.Controls.Add(numericUpDown_precio);
            panel2.Controls.Add(button_confirmarPrecio);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(793, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 360);
            panel2.TabIndex = 11;
            // 
            // textBox_producto
            // 
            textBox_producto.BackColor = Color.FromArgb(234, 234, 234);
            textBox_producto.BorderStyle = BorderStyle.FixedSingle;
            textBox_producto.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_producto.Location = new Point(36, 52);
            textBox_producto.Name = "textBox_producto";
            textBox_producto.Size = new Size(296, 37);
            textBox_producto.TabIndex = 0;
            // 
            // numericUpDown_precio
            // 
            numericUpDown_precio.BackColor = Color.FromArgb(234, 234, 234);
            numericUpDown_precio.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_precio.Location = new Point(36, 168);
            numericUpDown_precio.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown_precio.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_precio.Name = "numericUpDown_precio";
            numericUpDown_precio.Size = new Size(120, 37);
            numericUpDown_precio.TabIndex = 12;
            numericUpDown_precio.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // button_confirmarPrecio
            // 
            button_confirmarPrecio.BackColor = Color.FromArgb(205, 51, 51);
            button_confirmarPrecio.FlatAppearance.BorderColor = Color.Black;
            button_confirmarPrecio.FlatStyle = FlatStyle.Flat;
            button_confirmarPrecio.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_confirmarPrecio.ForeColor = Color.White;
            button_confirmarPrecio.Location = new Point(102, 259);
            button_confirmarPrecio.Name = "button_confirmarPrecio";
            button_confirmarPrecio.Size = new Size(196, 70);
            button_confirmarPrecio.TabIndex = 8;
            button_confirmarPrecio.Text = "Confirmar";
            button_confirmarPrecio.UseVisualStyleBackColor = false;
            button_confirmarPrecio.Click += button_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F);
            label3.Location = new Point(36, 134);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 6;
            label3.Text = "Nuevo precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F);
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(216, 23);
            label2.TabIndex = 5;
            label2.Text = "Nombre de producto:";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 717);
            Controls.Add(panel2);
            Controls.Add(dataGridView_Productos);
            Controls.Add(label_selected);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormProductos";
            Text = "FormProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Productos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_precio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_selected;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button_compras;
        private Button button_productos;
        private Button button_empleados;
        private DataGridView dataGridView_Productos;
        private Panel panel2;
        private TextBox textBox_producto;
        private NumericUpDown numericUpDown_precio;
        private Button button_confirmarPrecio;
        private Label label3;
        private Label label2;
    }
}