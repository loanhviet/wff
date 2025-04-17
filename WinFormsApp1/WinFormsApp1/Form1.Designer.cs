namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaKH = new TextBox();
            groupBox2 = new GroupBox();
            rdoTramRang = new RadioButton();
            rdoTayTrang = new RadioButton();
            rdoCaoVoi = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThem = new Button();
            label1 = new Label();
            btnReset = new Button();
            btnXoa = new Button();
            Sửa = new Button();
            dtgvKhachHang = new DataGridView();
            txtSearch = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(77, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(88, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(392, 27);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(147, 23);
            txtDiaChi.TabIndex = 14;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(88, 74);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(147, 23);
            txtHoTen.TabIndex = 13;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(88, 27);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(147, 23);
            txtMaKH.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoTramRang);
            groupBox2.Controls.Add(rdoTayTrang);
            groupBox2.Controls.Add(rdoCaoVoi);
            groupBox2.Location = new Point(322, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 71);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dịch vụ sử dụng";
            // 
            // rdoTramRang
            // 
            rdoTramRang.AutoSize = true;
            rdoTramRang.Location = new Point(138, 40);
            rdoTramRang.Name = "rdoTramRang";
            rdoTramRang.Size = new Size(79, 19);
            rdoTramRang.TabIndex = 2;
            rdoTramRang.TabStop = true;
            rdoTramRang.Text = "Trám răng";
            rdoTramRang.UseVisualStyleBackColor = true;
            // 
            // rdoTayTrang
            // 
            rdoTayTrang.AutoSize = true;
            rdoTayTrang.Location = new Point(138, 15);
            rdoTayTrang.Name = "rdoTayTrang";
            rdoTayTrang.Size = new Size(75, 19);
            rdoTayTrang.TabIndex = 1;
            rdoTayTrang.TabStop = true;
            rdoTayTrang.Text = "Tẩy trắng";
            rdoTayTrang.UseVisualStyleBackColor = true;
            // 
            // rdoCaoVoi
            // 
            rdoCaoVoi.AutoSize = true;
            rdoCaoVoi.Location = new Point(24, 31);
            rdoCaoVoi.Name = "rdoCaoVoi";
            rdoCaoVoi.Size = new Size(65, 19);
            rdoCaoVoi.TabIndex = 0;
            rdoCaoVoi.TabStop = true;
            rdoCaoVoi.Text = "Cạo vôi";
            rdoCaoVoi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 30);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 116);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 78);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 30);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Mã KH";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThem.Location = new Point(188, 419);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(61, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 1;
            label1.Text = "Dịch vụ nha khoa";
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReset.Location = new Point(289, 419);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(61, 29);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnXoa.Location = new Point(524, 419);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(61, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Sửa
            // 
            Sửa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Sửa.Location = new Point(423, 419);
            Sửa.Name = "Sửa";
            Sửa.Size = new Size(61, 29);
            Sửa.TabIndex = 4;
            Sửa.Text = "Sửa";
            Sửa.UseVisualStyleBackColor = true;
            Sửa.Click += Sửa_Click;
            // 
            // dtgvKhachHang
            // 
            dtgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKhachHang.Location = new Point(77, 217);
            dtgvKhachHang.Name = "dtgvKhachHang";
            dtgvKhachHang.ReadOnly = true;
            dtgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvKhachHang.Size = new Size(616, 196);
            dtgvKhachHang.TabIndex = 6;
            dtgvKhachHang.CellClick += dtgvKhachHang_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(370, 189);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(147, 22);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 191);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 13;
            label6.Text = "Tìm khách hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 460);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(dtgvKhachHang);
            Controls.Add(btnXoa);
            Controls.Add(Sửa);
            Controls.Add(btnReset);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnThem;
        private Button btnReset;
        private Button btnXoa;
        private Button Sửa;
        private DataGridView dtgvKhachHang;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rdoTramRang;
        private RadioButton rdoTayTrang;
        private RadioButton rdoCaoVoi;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaKH;
        private TextBox txtSearch;
        private Label label6;
    }
}
