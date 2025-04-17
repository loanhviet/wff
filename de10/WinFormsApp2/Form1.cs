using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=BTonTap;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlConnection;
        SqlDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();

        }
        void load()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            adapter = new SqlDataAdapter("Select * from khachhang", sqlConnection);
            dt = new DataTable();
            adapter.Fill(dt);
            dtgvQlKhachHang.DataSource = dt;
            sqlConnection.Close();
            dtgvQlKhachHang.Columns["MaKH"].HeaderText = "STT";
            dtgvQlKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            dtgvQlKhachHang.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgvQlKhachHang.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dtgvQlKhachHang.Columns["SoPhongThue"].HeaderText = "số phòng thuê";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "Insert into khachhang values (@HoTen,@GioiTinh,@LoaiPhong,@SoPhongThue)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@HoTen", txtTen.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "1" : "0");
            cmd.Parameters.AddWithValue("@LoaiPhong", cbbLoaiPhong.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@SoPhongThue", txtSoPhongThue.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Thêm thành công khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
            clear();

        }
        void clear()
        {
            txtTen.Clear();
            txtSoPhongThue.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            cbbLoaiPhong.SelectedIndex = -1;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            int MaKH = Convert.ToInt32(dtgvQlKhachHang.CurrentRow.Cells["MaKH"].Value);
            string query = "delete khachhang where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("xoas thành công khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
            clear();
        }

        private void dtgvQlKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvQlKhachHang.Rows[e.RowIndex];
                txtTen.Text = row.Cells["HoTen"].Value.ToString();
                bool gioitinh = Convert.ToBoolean(row.Cells["GioiTinh"].Value);
                if (gioitinh)
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                cbbLoaiPhong.SelectedItem = row.Cells["LoaiPhong"].Value.ToString();
                txtSoPhongThue.Text = row.Cells["SoPhongThue"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "update khachhang set HoTen =@HoTen,GioiTinh=@GioiTinh,LoaiPhong=@LoaiPhong,SoPhongThue=@SoPhongThue where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            int MaKH = Convert.ToInt32(dtgvQlKhachHang.CurrentRow.Cells["MaKH"].Value);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@HoTen", txtTen.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "1" : "0");
            cmd.Parameters.AddWithValue("@LoaiPhong", cbbLoaiPhong.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@SoPhongThue", txtSoPhongThue.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Sua thành công khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
            clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv;
            string search = txtSearch.Text;
            dv = new DataView(dt);
            dv.RowFilter = "HoTen LIKE '%" + search + "%'";
            dtgvQlKhachHang.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
