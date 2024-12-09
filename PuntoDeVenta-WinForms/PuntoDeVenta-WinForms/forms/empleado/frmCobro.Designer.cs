namespace PuntoDeVenta_WinForms.forms.empleado
{
    partial class frmCobro
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
            button_10p = new Button();
            button_15p = new Button();
            button_20p = new Button();
            checkBox_Propina = new CheckBox();
            label_precioTotal = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            panel3 = new Panel();
            button_terminarPagoEfectivo = new Button();
            panel2 = new Panel();
            label3 = new Label();
            textBox_cambio = new TextBox();
            panel4 = new Panel();
            numUpDown_efectivo = new NumericUpDown();
            label2 = new Label();
            button_procesarEfectivo = new Button();
            comboBox_tipoTarjeta = new ComboBox();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            numericUpDown_nip = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            button_terminarPagoTarjeta = new Button();
            panel9 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_efectivo).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nip).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // button_10p
            // 
            button_10p.BackColor = Color.FromArgb(234, 234, 234);
            button_10p.FlatAppearance.BorderColor = Color.Black;
            button_10p.FlatStyle = FlatStyle.Flat;
            button_10p.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_10p.ForeColor = Color.Black;
            button_10p.Location = new Point(12, 51);
            button_10p.Name = "button_10p";
            button_10p.Size = new Size(97, 48);
            button_10p.TabIndex = 2;
            button_10p.Text = "10%";
            button_10p.UseVisualStyleBackColor = false;
            button_10p.Click += button_10p_Click;
            // 
            // button_15p
            // 
            button_15p.BackColor = Color.FromArgb(234, 234, 234);
            button_15p.FlatAppearance.BorderColor = Color.Black;
            button_15p.FlatStyle = FlatStyle.Flat;
            button_15p.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_15p.ForeColor = Color.Black;
            button_15p.Location = new Point(115, 51);
            button_15p.Name = "button_15p";
            button_15p.Size = new Size(97, 48);
            button_15p.TabIndex = 3;
            button_15p.Text = "15%";
            button_15p.UseVisualStyleBackColor = false;
            button_15p.Click += button_15p_Click;
            // 
            // button_20p
            // 
            button_20p.BackColor = Color.FromArgb(234, 234, 234);
            button_20p.FlatAppearance.BorderColor = Color.Black;
            button_20p.FlatStyle = FlatStyle.Flat;
            button_20p.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_20p.ForeColor = Color.Black;
            button_20p.Location = new Point(218, 51);
            button_20p.Name = "button_20p";
            button_20p.Size = new Size(97, 48);
            button_20p.TabIndex = 4;
            button_20p.Text = "20%";
            button_20p.UseVisualStyleBackColor = false;
            button_20p.Click += button_20p_Click;
            // 
            // checkBox_Propina
            // 
            checkBox_Propina.AutoSize = true;
            checkBox_Propina.FlatAppearance.BorderColor = Color.Black;
            checkBox_Propina.FlatStyle = FlatStyle.Flat;
            checkBox_Propina.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_Propina.ForeColor = Color.White;
            checkBox_Propina.Location = new Point(19, 11);
            checkBox_Propina.Name = "checkBox_Propina";
            checkBox_Propina.Size = new Size(203, 33);
            checkBox_Propina.TabIndex = 5;
            checkBox_Propina.Text = "Añadir propina";
            checkBox_Propina.UseVisualStyleBackColor = true;
            checkBox_Propina.CheckedChanged += checkBox_Propina_CheckedChanged;
            // 
            // label_precioTotal
            // 
            label_precioTotal.AutoSize = true;
            label_precioTotal.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_precioTotal.ForeColor = Color.White;
            label_precioTotal.Location = new Point(357, 9);
            label_precioTotal.Name = "label_precioTotal";
            label_precioTotal.Size = new Size(198, 29);
            label_precioTotal.TabIndex = 6;
            label_precioTotal.Text = "Precio Total: $0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 51, 51);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(checkBox_Propina);
            panel1.Controls.Add(button_10p);
            panel1.Controls.Add(button_15p);
            panel1.Controls.Add(button_20p);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 108);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label_precioTotal);
            panel3.Location = new Point(329, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 48);
            panel3.TabIndex = 0;
            // 
            // button_terminarPagoEfectivo
            // 
            button_terminarPagoEfectivo.BackColor = Color.FromArgb(205, 51, 51);
            button_terminarPagoEfectivo.FlatAppearance.BorderColor = SystemColors.ControlText;
            button_terminarPagoEfectivo.FlatStyle = FlatStyle.Flat;
            button_terminarPagoEfectivo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_terminarPagoEfectivo.ForeColor = Color.White;
            button_terminarPagoEfectivo.Location = new Point(113, 374);
            button_terminarPagoEfectivo.Name = "button_terminarPagoEfectivo";
            button_terminarPagoEfectivo.Size = new Size(204, 79);
            button_terminarPagoEfectivo.TabIndex = 13;
            button_terminarPagoEfectivo.Text = "Terminar Pago";
            button_terminarPagoEfectivo.UseVisualStyleBackColor = false;
            button_terminarPagoEfectivo.Click += button_terminarPagoEfectivo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 247);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_cambio);
            panel2.Location = new Point(22, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 111);
            panel2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(32, 25);
            label3.Name = "label3";
            label3.Size = new Size(76, 18);
            label3.TabIndex = 5;
            label3.Text = "Cambio:";
            // 
            // textBox_cambio
            // 
            textBox_cambio.BackColor = Color.Silver;
            textBox_cambio.BorderStyle = BorderStyle.FixedSingle;
            textBox_cambio.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_cambio.Location = new Point(32, 46);
            textBox_cambio.MaxLength = 20;
            textBox_cambio.Name = "textBox_cambio";
            textBox_cambio.ReadOnly = true;
            textBox_cambio.Size = new Size(323, 37);
            textBox_cambio.TabIndex = 3;
            textBox_cambio.Text = " $0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(247, 247, 247);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(numUpDown_efectivo);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button_procesarEfectivo);
            panel4.Location = new Point(22, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 191);
            panel4.TabIndex = 11;
            // 
            // numUpDown_efectivo
            // 
            numUpDown_efectivo.BackColor = Color.FromArgb(234, 234, 234);
            numUpDown_efectivo.BorderStyle = BorderStyle.FixedSingle;
            numUpDown_efectivo.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUpDown_efectivo.Location = new Point(33, 52);
            numUpDown_efectivo.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numUpDown_efectivo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDown_efectivo.Name = "numUpDown_efectivo";
            numUpDown_efectivo.Size = new Size(323, 37);
            numUpDown_efectivo.TabIndex = 7;
            numUpDown_efectivo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(155, 18);
            label2.TabIndex = 4;
            label2.Text = "Dinero de cliente:";
            // 
            // button_procesarEfectivo
            // 
            button_procesarEfectivo.BackColor = Color.FromArgb(205, 51, 51);
            button_procesarEfectivo.FlatAppearance.BorderColor = SystemColors.ControlText;
            button_procesarEfectivo.FlatStyle = FlatStyle.Flat;
            button_procesarEfectivo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_procesarEfectivo.ForeColor = Color.White;
            button_procesarEfectivo.Location = new Point(103, 109);
            button_procesarEfectivo.Name = "button_procesarEfectivo";
            button_procesarEfectivo.Size = new Size(174, 58);
            button_procesarEfectivo.TabIndex = 4;
            button_procesarEfectivo.Text = "Procesar";
            button_procesarEfectivo.UseVisualStyleBackColor = false;
            button_procesarEfectivo.Click += button_procesarEfectivo_Click;
            // 
            // comboBox_tipoTarjeta
            // 
            comboBox_tipoTarjeta.BackColor = Color.FromArgb(234, 234, 234);
            comboBox_tipoTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tipoTarjeta.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_tipoTarjeta.FormattingEnabled = true;
            comboBox_tipoTarjeta.Items.AddRange(new object[] { "credito", "debito" });
            comboBox_tipoTarjeta.Location = new Point(29, 67);
            comboBox_tipoTarjeta.MaxDropDownItems = 2;
            comboBox_tipoTarjeta.Name = "comboBox_tipoTarjeta";
            comboBox_tipoTarjeta.Size = new Size(329, 37);
            comboBox_tipoTarjeta.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(button_terminarPagoEfectivo);
            panel5.Location = new Point(198, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(442, 475);
            panel5.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(143, 10);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 16;
            label1.Text = "Efectivo";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkRed;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label1);
            panel6.Location = new Point(198, 120);
            panel6.Name = "panel6";
            panel6.Size = new Size(442, 56);
            panel6.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(224, 224, 224);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(button_terminarPagoTarjeta);
            panel7.Location = new Point(688, 182);
            panel7.Name = "panel7";
            panel7.Size = new Size(442, 475);
            panel7.TabIndex = 18;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(247, 247, 247);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(numericUpDown_nip);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(comboBox_tipoTarjeta);
            panel8.Location = new Point(26, 25);
            panel8.Name = "panel8";
            panel8.Size = new Size(389, 243);
            panel8.TabIndex = 11;
            // 
            // numericUpDown_nip
            // 
            numericUpDown_nip.BackColor = Color.FromArgb(234, 234, 234);
            numericUpDown_nip.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown_nip.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_nip.Location = new Point(29, 153);
            numericUpDown_nip.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown_nip.Name = "numericUpDown_nip";
            numericUpDown_nip.Size = new Size(329, 37);
            numericUpDown_nip.TabIndex = 16;
            numericUpDown_nip.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(29, 46);
            label5.Name = "label5";
            label5.Size = new Size(138, 18);
            label5.TabIndex = 15;
            label5.Text = "Tipo de tarjeta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(29, 129);
            label4.Name = "label4";
            label4.Size = new Size(37, 18);
            label4.TabIndex = 4;
            label4.Text = "NIP";
            // 
            // button_terminarPagoTarjeta
            // 
            button_terminarPagoTarjeta.BackColor = Color.FromArgb(205, 51, 51);
            button_terminarPagoTarjeta.FlatAppearance.BorderColor = SystemColors.ControlText;
            button_terminarPagoTarjeta.FlatStyle = FlatStyle.Flat;
            button_terminarPagoTarjeta.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_terminarPagoTarjeta.ForeColor = Color.White;
            button_terminarPagoTarjeta.Location = new Point(123, 374);
            button_terminarPagoTarjeta.Name = "button_terminarPagoTarjeta";
            button_terminarPagoTarjeta.Size = new Size(204, 79);
            button_terminarPagoTarjeta.TabIndex = 13;
            button_terminarPagoTarjeta.Text = "Terminar Pago";
            button_terminarPagoTarjeta.UseVisualStyleBackColor = false;
            button_terminarPagoTarjeta.Click += button_terminarPagoTarjeta_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkRed;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label6);
            panel9.Location = new Point(688, 120);
            panel9.Name = "panel9";
            panel9.Size = new Size(442, 56);
            panel9.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(157, 10);
            label6.Name = "label6";
            label6.Size = new Size(131, 35);
            label6.TabIndex = 16;
            label6.Text = "Tarjeta";
            // 
            // frmCobro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 717);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmCobro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmCobro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown_efectivo).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nip).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_10p;
        private Button button_15p;
        private Button button_20p;
        private CheckBox checkBox_Propina;
        private Label label_precioTotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Panel panel3;
        private Button button_terminarPagoEfectivo;
        private Panel panel2;
        private Label label3;
        private TextBox textBox_cambio;
        private Panel panel4;
        private NumericUpDown numUpDown_efectivo;
        private Label label2;
        private Button button_procesarEfectivo;
        private ComboBox comboBox_tipoTarjeta;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label4;
        private Button button_terminarPagoTarjeta;
        private NumericUpDown numericUpDown_nip;
        private Label label5;
        private Panel panel9;
        private Label label6;
    }
}