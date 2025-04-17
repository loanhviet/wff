namespace WinFormsApp2
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
            txtTen = new TextBox();
            txtSearch = new TextBox();
            label2 = new Label();
            txtSoPhongThue = new TextBox();
            label3 = new Label();
            label4 = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            label5 = new Label();
            cbbLoaiPhong = new ComboBox();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dtgvQlKhachHang = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvQlKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTen.Location = new Point(122, 35);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(178, 23);
            txtTen.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(592, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(178, 23);
            txtSearch.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(520, 48);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // txtSoPhongThue
            // 
            txtSoPhongThue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSoPhongThue.Location = new Point(122, 160);
            txtSoPhongThue.Name = "txtSoPhongThue";
            txtSoPhongThue.Size = new Size(178, 23);
            txtSoPhongThue.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(25, 163);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Số phòng thuê";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(25, 90);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Giới tính";
            // 
            // rdoNam
            // 
            rdoNam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(127, 92);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 1;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(227, 92);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 2;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(25, 134);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 9;
            label5.Text = "Loại phòng";
            // 
            // cbbLoaiPhong
            // 
            cbbLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbLoaiPhong.FormattingEnabled = true;
            cbbLoaiPhong.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi", "Phòng vip" });
            cbbLoaiPhong.Location = new Point(127, 131);
            cbbLoaiPhong.Name = "cbbLoaiPhong";
            cbbLoaiPhong.Size = new Size(111, 23);
            cbbLoaiPhong.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(495, 90);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(82, 21);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(495, 157);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 21);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(609, 157);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 21);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(724, 157);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 21);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dtgvQlKhachHang
            // 
            dtgvQlKhachHang.AllowUserToAddRows = false;
            dtgvQlKhachHang.AllowUserToDeleteRows = false;
            dtgvQlKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvQlKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvQlKhachHang.Dock = DockStyle.Bottom;
            dtgvQlKhachHang.Location = new Point(0, 218);
            dtgvQlKhachHang.Name = "dtgvQlKhachHang";
            dtgvQlKhachHang.ReadOnly = true;
            dtgvQlKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvQlKhachHang.Size = new Size(862, 279);
            dtgvQlKhachHang.TabIndex = 15;
            dtgvQlKhachHang.CellClick += dtgvQlKhachHang_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(713, 112);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(862, 497);
            Controls.Add(button1);
            Controls.Add(dtgvQlKhachHang);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbLoaiPhong);
            Controls.Add(label5);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(label4);
            Controls.Add(txtSoPhongThue);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QL khách hàng trong khách sạn(lỗ anh việt - 2351260695)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvQlKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private TextBox txtSearch;
        private Label label2;
        private TextBox txtSoPhongThue;
        private Label label3;
        private Label label4;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label label5;
        private ComboBox cbbLoaiPhong;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dtgvQlKhachHang;
        private Button button1;
    }
}
