using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=CS;Integrated Security=True;TrustServerCertificate=True";
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
            string query = "Select * from KhachHang";
            adapter = new SqlDataAdapter(query, sqlConnection);
            dt = new DataTable();
            adapter.Fill(dt);
            dtgvKhachHang.DataSource = dt;
            sqlConnection.Close();
            dtgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            dtgvKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            dtgvKhachHang.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dtgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvKhachHang.Columns["DichVu"].HeaderText = "Dịch vụ sử dụng";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "Insert into KhachHang values (@MaKH,@HoTen,@NgaySinh,@DiaChi,@DichVu)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@DichVu", rdoCaoVoi.Checked ? "Cạo vôi" : rdoTayTrang.Checked ? "Tẩy trắng" : "Trám răng");
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Them thanh cong khach hang", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
            clearinput();
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                string dv = row.Cells["DichVu"].Value.ToString();
                if (dv == "Cạo vôi")
                {
                    rdoCaoVoi.Checked = true;
                }
                else if (dv == "Tẩy trắng")
                {
                    rdoTayTrang.Checked = true;
                }
                else
                {
                    rdoTramRang.Checked = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "Delete KhachHang where MaKh = @MaKH";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Xoa thanh cong khach hang", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
            clearinput();
        }

        private void Sửa_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "Update KhachHang set HoTen =@HoTen,NgaySinh = @NgaySinh,DiaChi = @DiaChi,DichVu= @DichVu Where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@DichVu", rdoCaoVoi.Checked ? "Cạo vôi" : rdoTayTrang.Checked ? "Tẩy trắng" : "Trám răng");
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Sửa thanh cong khach hang", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
            clearinput();
        }
        void clearinput()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            rdoTramRang.Checked = false;
            rdoTayTrang.Checked = false;
            rdoCaoVoi.Checked = false;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearinput();
            txtMaKH.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string keyword = txtSearch.Text.Trim();

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"MaKH LIKE '%{keyword}%' OR HoTen LIKE '%{keyword}%'";
            dtgvKhachHang.DataSource = dv;
        }
    }
}
