namespace de3
{
    partial class Form2
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
            btnLoc = new Button();
            label1 = new Label();
            txtSearchMasv = new TextBox();
            txtSearchNoiSinh = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            dgvSinhVien = new DataGridView();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(143, 188);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(75, 23);
            btnLoc.TabIndex = 0;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã Sinh Viên";
            // 
            // txtSearchMasv
            // 
            txtSearchMasv.Location = new Point(156, 33);
            txtSearchMasv.Name = "txtSearchMasv";
            txtSearchMasv.Size = new Size(100, 23);
            txtSearchMasv.TabIndex = 2;
            // 
            // txtSearchNoiSinh
            // 
            txtSearchNoiSinh.Location = new Point(156, 83);
            txtSearchNoiSinh.Name = "txtSearchNoiSinh";
            txtSearchNoiSinh.Size = new Size(100, 23);
            txtSearchNoiSinh.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 91);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nơi sinh";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSinhVien);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(280, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 450);
            panel1.TabIndex = 7;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.Location = new Point(0, 0);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(520, 450);
            dgvSinhVien.TabIndex = 1;
            // 
            // rdoNu
            // 
            rdoNu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(215, 138);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 14;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(143, 138);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 13;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 142);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 12;
            label5.Text = "Giới tính";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(txtSearchNoiSinh);
            Controls.Add(label2);
            Controls.Add(txtSearchMasv);
            Controls.Add(label1);
            Controls.Add(btnLoc);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoc;
        private Label label1;
        private TextBox txtSearchMasv;
        private TextBox txtSearchNoiSinh;
        private Label label2;
        private Panel panel1;
        private DataGridView dgvSinhVien;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label5;
    }
}