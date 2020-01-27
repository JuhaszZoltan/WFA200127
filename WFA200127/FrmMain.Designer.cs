namespace WFA200127
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOsszesito = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFenymasolasraOsszesen = new System.Windows.Forms.TextBox();
            this.cbDiakok = new System.Windows.Forms.ComboBox();
            this.rtbDiakTranzakcioi = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUjTetel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzamlaKimut = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsszesito)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOsszesito
            // 
            this.dgvOsszesito.AllowUserToAddRows = false;
            this.dgvOsszesito.AllowUserToDeleteRows = false;
            this.dgvOsszesito.AllowUserToResizeColumns = false;
            this.dgvOsszesito.AllowUserToResizeRows = false;
            this.dgvOsszesito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsszesito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsszesito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOsszesito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsszesito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOsszesito.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOsszesito.Location = new System.Drawing.Point(12, 12);
            this.dgvOsszesito.Name = "dgvOsszesito";
            this.dgvOsszesito.RowHeadersVisible = false;
            this.dgvOsszesito.Size = new System.Drawing.Size(272, 335);
            this.dgvOsszesito.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Név";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Befizetés";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(290, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "fénymásolásra:";
            // 
            // tbFenymasolasraOsszesen
            // 
            this.tbFenymasolasraOsszesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFenymasolasraOsszesen.Location = new System.Drawing.Point(431, 21);
            this.tbFenymasolasraOsszesen.Name = "tbFenymasolasraOsszesen";
            this.tbFenymasolasraOsszesen.Size = new System.Drawing.Size(162, 29);
            this.tbFenymasolasraOsszesen.TabIndex = 2;
            // 
            // cbDiakok
            // 
            this.cbDiakok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDiakok.FormattingEnabled = true;
            this.cbDiakok.Location = new System.Drawing.Point(294, 74);
            this.cbDiakok.Name = "cbDiakok";
            this.cbDiakok.Size = new System.Drawing.Size(299, 32);
            this.cbDiakok.TabIndex = 3;
            this.cbDiakok.SelectedIndexChanged += new System.EventHandler(this.cbDiakok_SelectedIndexChanged);
            // 
            // rtbDiakTranzakcioi
            // 
            this.rtbDiakTranzakcioi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbDiakTranzakcioi.Location = new System.Drawing.Point(294, 130);
            this.rtbDiakTranzakcioi.Name = "rtbDiakTranzakcioi";
            this.rtbDiakTranzakcioi.Size = new System.Drawing.Size(299, 217);
            this.rtbDiakTranzakcioi.TabIndex = 4;
            this.rtbDiakTranzakcioi.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUjTetel,
            this.tsmiSzamlaKimut});
            this.menuStrip1.Location = new System.Drawing.Point(608, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(121, 359);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUjTetel
            // 
            this.tsmiUjTetel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsmiUjTetel.Name = "tsmiUjTetel";
            this.tsmiUjTetel.Size = new System.Drawing.Size(108, 41);
            this.tsmiUjTetel.Text = "Új tétel";
            // 
            // tsmiSzamlaKimut
            // 
            this.tsmiSzamlaKimut.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tsmiSzamlaKimut.Name = "tsmiSzamlaKimut";
            this.tsmiSzamlaKimut.Size = new System.Drawing.Size(108, 41);
            this.tsmiSzamlaKimut.Text = "Számla";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 359);
            this.Controls.Add(this.rtbDiakTranzakcioi);
            this.Controls.Add(this.cbDiakok);
            this.Controls.Add(this.tbFenymasolasraOsszesen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOsszesito);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Osztálypénztár Összesítő";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsszesito)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOsszesito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFenymasolasraOsszesen;
        private System.Windows.Forms.ComboBox cbDiakok;
        private System.Windows.Forms.RichTextBox rtbDiakTranzakcioi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem tsmiUjTetel;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzamlaKimut;
    }
}

