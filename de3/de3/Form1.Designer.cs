namespace de3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMa = new TextBox();
            panel1 = new Panel();
            btnLoc = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            cbbNoiSinh = new ComboBox();
            dtpkNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            panel2 = new Panel();
            dgvSinhVien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 29);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 73);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 29);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 3;
            label6.Text = "Nơi sinh";
            // 
            // txtMa
            // 
            txtMa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMa.Location = new Point(176, 26);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(141, 23);
            txtMa.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(rdoNu);
            panel1.Controls.Add(rdoNam);
            panel1.Controls.Add(cbbNoiSinh);
            panel1.Controls.Add(dtpkNgaySinh);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 154);
            panel1.TabIndex = 7;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(719, 114);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(75, 23);
            btnLoc.TabIndex = 15;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(626, 114);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(547, 114);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(454, 114);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rdoNu
            // 
            rdoNu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(709, 75);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 11;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(616, 77);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 10;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // cbbNoiSinh
            // 
            cbbNoiSinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbNoiSinh.FormattingEnabled = true;
            cbbNoiSinh.Items.AddRange(new object[] { "Hà Nội", "Lâm Đồng", "Vĩnh Phúc" });
            cbbNoiSinh.Location = new Point(616, 29);
            cbbNoiSinh.Name = "cbbNoiSinh";
            cbbNoiSinh.Size = new Size(121, 23);
            cbbNoiSinh.TabIndex = 9;
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpkNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpkNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpkNgaySinh.Location = new Point(176, 110);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(141, 23);
            dtpkNgaySinh.TabIndex = 8;
            dtpkNgaySinh.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Location = new Point(176, 73);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(141, 23);
            txtHoTen.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvSinhVien);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 302);
            panel2.TabIndex = 8;
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
            dgvSinhVien.Size = new Size(805, 302);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 456);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtMa;
        private Panel panel1;
        private TextBox txtHoTen;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private ComboBox cbbNoiSinh;
        private DateTimePicker dtpkNgaySinh;
        private Button btnLoc;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private DataGridView dgvSinhVien;
    }
}
