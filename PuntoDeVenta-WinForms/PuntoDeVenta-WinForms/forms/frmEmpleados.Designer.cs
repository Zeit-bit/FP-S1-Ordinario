namespace PuntoDeVenta_WinForms.forms
{
    partial class frmEmpleados
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
            dataGridView_empleados = new DataGridView();
            panel2 = new Panel();
            textBox_nombreCrear = new TextBox();
            label1 = new Label();
            textBox_claveCrear = new TextBox();
            textBox_idCrear = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button_crear = new Button();
            panel1 = new Panel();
            button_eliminar = new Button();
            textBox_idEliminar = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_empleados).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_empleados
            // 
            dataGridView_empleados.AllowUserToAddRows = false;
            dataGridView_empleados.AllowUserToDeleteRows = false;
            dataGridView_empleados.AllowUserToResizeColumns = false;
            dataGridView_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_empleados.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_empleados.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_empleados.Location = new Point(49, 42);
            dataGridView_empleados.MultiSelect = false;
            dataGridView_empleados.Name = "dataGridView_empleados";
            dataGridView_empleados.ReadOnly = true;
            dataGridView_empleados.RowHeadersVisible = false;
            dataGridView_empleados.Size = new Size(548, 543);
            dataGridView_empleados.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 247);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox_nombreCrear);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox_claveCrear);
            panel2.Controls.Add(textBox_idCrear);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button_crear);
            panel2.Location = new Point(632, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 359);
            panel2.TabIndex = 4;
            // 
            // textBox_nombreCrear
            // 
            textBox_nombreCrear.BackColor = Color.FromArgb(234, 234, 234);
            textBox_nombreCrear.BorderStyle = BorderStyle.FixedSingle;
            textBox_nombreCrear.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_nombreCrear.Location = new Point(33, 214);
            textBox_nombreCrear.MaxLength = 15;
            textBox_nombreCrear.Name = "textBox_nombreCrear";
            textBox_nombreCrear.Size = new Size(323, 37);
            textBox_nombreCrear.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F);
            label1.Location = new Point(32, 193);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // textBox_claveCrear
            // 
            textBox_claveCrear.BackColor = Color.FromArgb(234, 234, 234);
            textBox_claveCrear.BorderStyle = BorderStyle.FixedSingle;
            textBox_claveCrear.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_claveCrear.Location = new Point(33, 135);
            textBox_claveCrear.MaxLength = 15;
            textBox_claveCrear.Name = "textBox_claveCrear";
            textBox_claveCrear.Size = new Size(323, 37);
            textBox_claveCrear.TabIndex = 3;
            // 
            // textBox_idCrear
            // 
            textBox_idCrear.BackColor = Color.FromArgb(234, 234, 234);
            textBox_idCrear.BorderStyle = BorderStyle.FixedSingle;
            textBox_idCrear.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_idCrear.Location = new Point(33, 52);
            textBox_idCrear.MaxLength = 15;
            textBox_idCrear.Name = "textBox_idCrear";
            textBox_idCrear.Size = new Size(323, 37);
            textBox_idCrear.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(32, 114);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 5;
            label3.Text = "Clave:";
            // 
            // button_crear
            // 
            button_crear.BackColor = Color.FromArgb(205, 51, 51);
            button_crear.FlatAppearance.BorderColor = SystemColors.ControlText;
            button_crear.FlatStyle = FlatStyle.Flat;
            button_crear.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_crear.ForeColor = Color.White;
            button_crear.Location = new Point(105, 279);
            button_crear.Name = "button_crear";
            button_crear.Size = new Size(174, 58);
            button_crear.TabIndex = 4;
            button_crear.Text = "Crear Empleado";
            button_crear.UseVisualStyleBackColor = false;
            button_crear.Click += button_crear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 247, 247);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_eliminar);
            panel1.Controls.Add(textBox_idEliminar);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(632, 434);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 151);
            panel1.TabIndex = 7;
            // 
            // button_eliminar
            // 
            button_eliminar.BackColor = Color.FromArgb(205, 51, 51);
            button_eliminar.FlatAppearance.BorderColor = SystemColors.ControlText;
            button_eliminar.FlatStyle = FlatStyle.Flat;
            button_eliminar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_eliminar.ForeColor = Color.White;
            button_eliminar.Location = new Point(105, 81);
            button_eliminar.Name = "button_eliminar";
            button_eliminar.Size = new Size(174, 58);
            button_eliminar.TabIndex = 8;
            button_eliminar.Text = "Eliminar Empleado";
            button_eliminar.UseVisualStyleBackColor = false;
            button_eliminar.Click += button_eliminar_Click;
            // 
            // textBox_idEliminar
            // 
            textBox_idEliminar.BackColor = Color.FromArgb(234, 234, 234);
            textBox_idEliminar.BorderStyle = BorderStyle.FixedSingle;
            textBox_idEliminar.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_idEliminar.Location = new Point(33, 33);
            textBox_idEliminar.MaxLength = 15;
            textBox_idEliminar.Name = "textBox_idEliminar";
            textBox_idEliminar.Size = new Size(323, 37);
            textBox_idEliminar.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(32, 12);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 9;
            label4.Text = "ID:";
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1069, 630);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView_empleados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)dataGridView_empleados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_empleados;
        private Panel panel2;
        private Button button_crear;
        private Label label3;
        private TextBox textBox_claveCrear;
        private Label label2;
        private TextBox textBox_idCrear;
        private Panel panel1;
        private TextBox textBox_nombreCrear;
        private Label label1;
        private Button button_eliminar;
        private TextBox textBox_idEliminar;
        private Label label4;
    }
}