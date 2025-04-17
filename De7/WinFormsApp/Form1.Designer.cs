namespace WinFormsApp
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            panel4 = new Panel();
            panel6 = new Panel();
            dgvThanhToan = new DataGridView();
            panel5 = new Panel();
            cbbBanThanhToan = new ComboBox();
            panel3 = new Panel();
            txtThanhTien = new TextBox();
            label2 = new Label();
            tabPage5 = new TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 33);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 5);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Thanh Toán";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 456);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(822, 456);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(814, 428);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(814, 428);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(814, 428);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(814, 428);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Thanh Toán";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(808, 422);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvThanhToan);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(159, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(649, 394);
            panel6.TabIndex = 2;
            // 
            // dgvThanhToan
            // 
            dgvThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhToan.Dock = DockStyle.Fill;
            dgvThanhToan.Location = new Point(0, 0);
            dgvThanhToan.Name = "dgvThanhToan";
            dgvThanhToan.Size = new Size(649, 394);
            dgvThanhToan.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbbBanThanhToan);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(159, 394);
            panel5.TabIndex = 1;
            // 
            // cbbBanThanhToan
            // 
            cbbBanThanhToan.FormattingEnabled = true;
            cbbBanThanhToan.Location = new Point(3, 3);
            cbbBanThanhToan.Name = "cbbBanThanhToan";
            cbbBanThanhToan.Size = new Size(147, 23);
            cbbBanThanhToan.TabIndex = 0;
            cbbBanThanhToan.SelectedIndexChanged += cbbBanThanhToan_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtThanhTien);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 394);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 28);
            panel3.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThanhTien.Location = new Point(598, 2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(100, 23);
            txtThanhTien.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(525, 6);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Thành tiền";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(814, 428);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 489);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel4;
        private TabPage tabPage5;
        private Panel panel6;
        private DataGridView dgvThanhToan;
        private Panel panel5;
        private ComboBox cbbBanThanhToan;
        private Panel panel3;
        private TextBox txtThanhTien;
        private Label label2;
    }
}
