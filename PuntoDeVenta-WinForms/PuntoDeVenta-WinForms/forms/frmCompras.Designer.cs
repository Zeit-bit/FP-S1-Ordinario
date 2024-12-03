namespace PuntoDeVenta_WinForms.forms
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView_compras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_compras).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_compras
            // 
            dataGridView_compras.AllowUserToAddRows = false;
            dataGridView_compras.AllowUserToDeleteRows = false;
            dataGridView_compras.AllowUserToResizeColumns = false;
            dataGridView_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_compras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_compras.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_compras.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_compras.Location = new Point(12, 12);
            dataGridView_compras.MultiSelect = false;
            dataGridView_compras.Name = "dataGridView_compras";
            dataGridView_compras.ReadOnly = true;
            dataGridView_compras.RowHeadersVisible = false;
            dataGridView_compras.Size = new Size(1045, 606);
            dataGridView_compras.TabIndex = 1;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1069, 630);
            Controls.Add(dataGridView_compras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCompras";
            Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView_compras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_compras;
    }
}