namespace PuntoDeVenta_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            textBox_id = new TextBox();
            panel2 = new Panel();
            button_login = new Button();
            label3 = new Label();
            panel4 = new Panel();
            textBox_clave = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 51, 51);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(448, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(332, 42);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            // 
            // textBox_id
            // 
            textBox_id.BackColor = Color.FromArgb(234, 234, 234);
            textBox_id.BorderStyle = BorderStyle.None;
            textBox_id.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id.Location = new Point(17, 21);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(296, 30);
            textBox_id.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 247);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button_login);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(448, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 374);
            panel2.TabIndex = 3;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(205, 51, 51);
            button_login.FlatAppearance.BorderColor = SystemColors.ControlText;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(89, 264);
            button_login.Name = "button_login";
            button_login.Size = new Size(203, 86);
            button_login.TabIndex = 4;
            button_login.Text = "Iniciar Sesión";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 139);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 5;
            label3.Text = "Clave:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(234, 234, 234);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox_clave);
            panel4.Location = new Point(24, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 76);
            panel4.TabIndex = 6;
            // 
            // textBox_clave
            // 
            textBox_clave.BackColor = Color.FromArgb(234, 234, 234);
            textBox_clave.BorderStyle = BorderStyle.None;
            textBox_clave.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_clave.Location = new Point(17, 24);
            textBox_clave.Name = "textBox_clave";
            textBox_clave.PasswordChar = '*';
            textBox_clave.Size = new Size(296, 30);
            textBox_clave.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 23);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(234, 234, 234);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox_id);
            panel3.Location = new Point(24, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 76);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(1318, 717);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox_id;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private Button button_login;
        private TextBox textBox_clave;
        private PictureBox pictureBox1;
    }
}
