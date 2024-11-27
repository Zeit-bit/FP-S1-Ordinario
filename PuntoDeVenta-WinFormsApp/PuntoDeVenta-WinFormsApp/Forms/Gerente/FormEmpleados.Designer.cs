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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button_empleados = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button_compras = new Button();
            button_productos = new Button();
            label_selected = new Label();
            dataGridView_empleados = new DataGridView();
            panel2 = new Panel();
            textBox_nombre = new TextBox();
            label2 = new Label();
            textBox_clave = new TextBox();
            button_crearEmpleado = new Button();
            textBox_id = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            button_eliminarEmpleado = new Button();
            textBox_idAeliminar = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_empleados).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            pictureBox1.Location = new Point(75, 581);
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
            label_selected.Location = new Point(304, 18);
            label_selected.Name = "label_selected";
            label_selected.Size = new Size(191, 35);
            label_selected.TabIndex = 4;
            label_selected.Text = "Empleados";
            // 
            // dataGridView_empleados
            // 
            dataGridView_empleados.AllowUserToAddRows = false;
            dataGridView_empleados.AllowUserToDeleteRows = false;
            dataGridView_empleados.AllowUserToResizeColumns = false;
            dataGridView_empleados.AllowUserToResizeRows = false;
            dataGridView_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_empleados.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView_empleados.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_empleados.Location = new Point(304, 117);
            dataGridView_empleados.Name = "dataGridView_empleados";
            dataGridView_empleados.ReadOnly = true;
            dataGridView_empleados.RowHeadersVisible = false;
            dataGridView_empleados.Size = new Size(381, 471);
            dataGridView_empleados.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 247);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox_nombre);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_clave);
            panel2.Controls.Add(button_crearEmpleado);
            panel2.Controls.Add(textBox_id);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(896, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 383);
            panel2.TabIndex = 12;
            // 
            // textBox_nombre
            // 
            textBox_nombre.BackColor = Color.FromArgb(234, 234, 234);
            textBox_nombre.BorderStyle = BorderStyle.FixedSingle;
            textBox_nombre.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_nombre.Location = new Point(36, 201);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(296, 37);
            textBox_nombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F);
            label2.Location = new Point(36, 175);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // textBox_clave
            // 
            textBox_clave.BackColor = Color.FromArgb(234, 234, 234);
            textBox_clave.BorderStyle = BorderStyle.FixedSingle;
            textBox_clave.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_clave.Location = new Point(36, 123);
            textBox_clave.Name = "textBox_clave";
            textBox_clave.Size = new Size(296, 37);
            textBox_clave.TabIndex = 0;
            // 
            // button_crearEmpleado
            // 
            button_crearEmpleado.BackColor = Color.FromArgb(205, 51, 51);
            button_crearEmpleado.FlatAppearance.BorderColor = Color.Black;
            button_crearEmpleado.FlatStyle = FlatStyle.Flat;
            button_crearEmpleado.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_crearEmpleado.ForeColor = Color.White;
            button_crearEmpleado.Location = new Point(89, 273);
            button_crearEmpleado.Name = "button_crearEmpleado";
            button_crearEmpleado.Size = new Size(196, 70);
            button_crearEmpleado.TabIndex = 8;
            button_crearEmpleado.Text = "Crear Empleado";
            button_crearEmpleado.UseVisualStyleBackColor = false;
            button_crearEmpleado.Click += button_crearEmpleado_Click;
            // 
            // textBox_id
            // 
            textBox_id.BackColor = Color.FromArgb(234, 234, 234);
            textBox_id.BorderStyle = BorderStyle.FixedSingle;
            textBox_id.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id.Location = new Point(36, 48);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(296, 37);
            textBox_id.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F);
            label3.Location = new Point(36, 97);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 6;
            label3.Text = "Clave:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F);
            label4.Location = new Point(36, 22);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 5;
            label4.Text = "ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 247, 247);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button_eliminarEmpleado);
            panel3.Controls.Add(textBox_idAeliminar);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(896, 474);
            panel3.Name = "panel3";
            panel3.Size = new Size(374, 202);
            panel3.TabIndex = 13;
            // 
            // button_eliminarEmpleado
            // 
            button_eliminarEmpleado.BackColor = Color.FromArgb(205, 51, 51);
            button_eliminarEmpleado.FlatAppearance.BorderColor = Color.Black;
            button_eliminarEmpleado.FlatStyle = FlatStyle.Flat;
            button_eliminarEmpleado.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_eliminarEmpleado.ForeColor = Color.White;
            button_eliminarEmpleado.Location = new Point(89, 108);
            button_eliminarEmpleado.Name = "button_eliminarEmpleado";
            button_eliminarEmpleado.Size = new Size(196, 70);
            button_eliminarEmpleado.TabIndex = 8;
            button_eliminarEmpleado.Text = "Eliminar Empleado";
            button_eliminarEmpleado.UseVisualStyleBackColor = false;
            button_eliminarEmpleado.Click += button_eliminarEmpleado_Click;
            // 
            // textBox_idAeliminar
            // 
            textBox_idAeliminar.BackColor = Color.FromArgb(234, 234, 234);
            textBox_idAeliminar.BorderStyle = BorderStyle.FixedSingle;
            textBox_idAeliminar.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_idAeliminar.Location = new Point(36, 48);
            textBox_idAeliminar.Name = "textBox_idAeliminar";
            textBox_idAeliminar.Size = new Size(296, 37);
            textBox_idAeliminar.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F);
            label7.Location = new Point(36, 22);
            label7.Name = "label7";
            label7.Size = new Size(42, 23);
            label7.TabIndex = 5;
            label7.Text = "ID:";
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 717);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridView_empleados);
            Controls.Add(label_selected);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormEmpleados";
            Text = "FormControlGerente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_empleados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private DataGridView dataGridView_empleados;
        private Panel panel2;
        private Label label2;
        private TextBox textBox_nombre;
        private Button button_crearEmpleado;
        private Label label3;
        private Label label4;
        private TextBox textBox_clave;
        private TextBox textBox_id;
        private Panel panel3;
        private Button button_eliminarEmpleado;
        private TextBox textBox_idAeliminar;
        private Label label7;
    }
}