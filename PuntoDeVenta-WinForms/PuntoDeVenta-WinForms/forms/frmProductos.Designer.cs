namespace PuntoDeVenta_WinForms.forms
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            panel2 = new Panel();
            numUpDown_nuevoPrecio = new NumericUpDown();
            textBox_nombreProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button_confirmar = new Button();
            dataGridView_productos = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_nuevoPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 247);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(numUpDown_nuevoPrecio);
            panel2.Controls.Add(textBox_nombreProducto);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button_confirmar);
            panel2.Location = new Point(89, 377);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 210);
            panel2.TabIndex = 9;
            // 
            // numUpDown_nuevoPrecio
            // 
            numUpDown_nuevoPrecio.BackColor = Color.FromArgb(234, 234, 234);
            numUpDown_nuevoPrecio.BorderStyle = BorderStyle.FixedSingle;
            numUpDown_nuevoPrecio.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUpDown_nuevoPrecio.Location = new Point(33, 135);
            numUpDown_nuevoPrecio.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numUpDown_nuevoPrecio.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numUpDown_nuevoPrecio.Name = "numUpDown_nuevoPrecio";
            numUpDown_nuevoPrecio.Size = new Size(120, 37);
            numUpDown_nuevoPrecio.TabIndex = 6;
            numUpDown_nuevoPrecio.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // textBox_nombreProducto
            // 
            textBox_nombreProducto.BackColor = Color.FromArgb(234, 234, 234);
            textBox_nombreProducto.BorderStyle = BorderStyle.FixedSingle;
            textBox_nombreProducto.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_nombreProducto.Location = new Point(34, 53);
            textBox_nombreProducto.MaxLength = 18;
            textBox_nombreProducto.Name = "textBox_nombreProducto";
            textBox_nombreProducto.Size = new Size(323, 37);
            textBox_nombreProducto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(181, 18);
            label2.TabIndex = 4;
            label2.Text = "Nombre de producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(32, 114);
            label3.Name = "label3";
            label3.Size = new Size(121, 18);
            label3.TabIndex = 5;
            label3.Text = "Nuevo precio:";
            // 
            // button_confirmar
            // 
            button_confirmar.BackColor = Color.FromArgb(205, 51, 51);
            button_confirmar.FlatAppearance.BorderColor = SystemColors.ControlText;
            button_confirmar.FlatStyle = FlatStyle.Flat;
            button_confirmar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_confirmar.ForeColor = Color.White;
            button_confirmar.Location = new Point(183, 114);
            button_confirmar.Name = "button_confirmar";
            button_confirmar.Size = new Size(174, 58);
            button_confirmar.TabIndex = 4;
            button_confirmar.Text = "Confirmar";
            button_confirmar.UseVisualStyleBackColor = false;
            button_confirmar.Click += button_confirmar_Click;
            // 
            // dataGridView_productos
            // 
            dataGridView_productos.AllowUserToAddRows = false;
            dataGridView_productos.AllowUserToDeleteRows = false;
            dataGridView_productos.AllowUserToResizeColumns = false;
            dataGridView_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_productos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_productos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_productos.Location = new Point(48, 44);
            dataGridView_productos.MultiSelect = false;
            dataGridView_productos.Name = "dataGridView_productos";
            dataGridView_productos.ReadOnly = true;
            dataGridView_productos.RowHeadersVisible = false;
            dataGridView_productos.Size = new Size(474, 297);
            dataGridView_productos.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(635, 289);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(709, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1069, 630);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(dataGridView_productos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            Text = "frmProductos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_nuevoPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private NumericUpDown numUpDown_nuevoPrecio;
        private TextBox textBox_nombreProducto;
        private Label label2;
        private Label label3;
        private Button button_confirmar;
        private DataGridView dataGridView_productos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}