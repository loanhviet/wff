using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de3
{
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=BTonTap;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlconnection;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }
        void loadlist()
        {
            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string query = "select * from SinhVien";
            adapter = new SqlDataAdapter(query, sqlconnection);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSinhVien.DataSource = dt;
            sqlconnection.Close();
            dgvSinhVien.Columns["MaSv"].HeaderText = "Mã Sinh Viên";
            dgvSinhVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["NoiSinh"].HeaderText = "Nơi Sinh";
            dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SinhVien WHERE 1=1";

            if (!string.IsNullOrEmpty(txtSearchMasv.Text))
                sql += " AND MaSV LIKE '%" + txtSearchMasv.Text + "%'";

            if (!string.IsNullOrEmpty(txtSearchNoiSinh.Text))
                sql += " AND NoiSinh LIKE N'%" + txtSearchNoiSinh.Text + "%'";

            if (rdoNam.Checked) sql += " AND GioiTinh = N'Nam'";
            if (rdoNu.Checked) sql += " AND GioiTinh = N'Nữ'";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSinhVien.DataSource = dt;

        }
    }
}
