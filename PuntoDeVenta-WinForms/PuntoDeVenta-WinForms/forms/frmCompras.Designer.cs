﻿namespace PuntoDeVenta_WinForms.forms
{
    partial class frmCompras
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 294);
            label1.Name = "label1";
            label1.Size = new Size(189, 42);
            label1.TabIndex = 2;
            label1.Text = "Compras";
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1069, 630);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCompras";
            Text = "frmCompras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}