namespace PuntoDeVenta_WinFormsApp
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label_loginTitle = new Label();
            panel1 = new Panel();
            button_login = new Button();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            textBox_clave = new TextBox();
            panel3 = new Panel();
            textBox_id = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(205, 51, 51);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label_loginTitle);
            panel2.Location = new Point(460, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 100);
            panel2.TabIndex = 6;
            // 
            // label_loginTitle
            // 
            label_loginTitle.AutoSize = true;
            label_loginTitle.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_loginTitle.ForeColor = SystemColors.ButtonFace;
            label_loginTitle.Location = new Point(36, 27);
            label_loginTitle.Name = "label_loginTitle";
            label_loginTitle.Size = new Size(332, 42);
            label_loginTitle.TabIndex = 2;
            label_loginTitle.Text = "Inicio de Sesión";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 247, 247);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(460, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 392);
            panel1.TabIndex = 5;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(205, 51, 51);
            button_login.FlatAppearance.BorderColor = Color.Black;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(99, 291);
            button_login.Name = "button_login";
            button_login.Size = new Size(196, 70);
            button_login.TabIndex = 8;
            button_login.Text = "Iniciar Sesión";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F);
            label3.Location = new Point(36, 162);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 6;
            label3.Text = "Clave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F);
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(234, 234, 234);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox_clave);
            panel4.Location = new Point(36, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 76);
            panel4.TabIndex = 7;
            // 
            // textBox_clave
            // 
            textBox_clave.BackColor = Color.FromArgb(234, 234, 234);
            textBox_clave.BorderStyle = BorderStyle.None;
            textBox_clave.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_clave.Location = new Point(18, 22);
            textBox_clave.Name = "textBox_clave";
            textBox_clave.PasswordChar = '*';
            textBox_clave.Size = new Size(296, 30);
            textBox_clave.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(234, 234, 234);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox_id);
            panel3.Location = new Point(36, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 76);
            panel3.TabIndex = 5;
            // 
            // textBox_id
            // 
            textBox_id.BackColor = Color.FromArgb(234, 234, 234);
            textBox_id.BorderStyle = BorderStyle.None;
            textBox_id.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id.Location = new Point(18, 22);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(296, 30);
            textBox_id.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 717);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label_loginTitle;
        private Panel panel1;
        private Button button_login;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private TextBox textBox_clave;
        private Panel panel3;
        private TextBox textBox_id;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
