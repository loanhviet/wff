using System.Data;
using System.Data.SqlClient;
namespace de3
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=BTonTap;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlconnection;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            //MaSV nvarchar(30),
            //HoTen nvarchar(30),
            // NgaySinh date,
            //NoiSinh nvarchar(30),
            //GioiTinh nvarchar(5)

            Form2 form2 = new Form2();

            form2.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string query = "Insert into SinhVien values (@MaSV,@HoTen,@NgaySinh,@NoiSinh,@GioiTinh)";
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpkNgaySinh.Value);
            cmd.Parameters.AddWithValue("@NoiSinh", cbbNoiSinh.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "Nam" : "Nữ");
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Thêm thành công sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadlist();
            clear();

        }
        void clear()
        {
            txtHoTen.Clear();
            txtMa.Clear();
            dtpkNgaySinh.Value = DateTime.Now;
            cbbNoiSinh.SelectedIndex = -1;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMa.Text = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpkNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cbbNoiSinh.SelectedItem = row.Cells["NoiSinh"].Value.ToString();
                string gioitinh = Convert.ToString(row.Cells["GioiTinh"].Value);
                if (gioitinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string query = "delete SinhVien where MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Xoa thành công sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadlist();
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            string query = "update SinhVien set  MaSV=@MaSV,HoTen=@HoTen,NgaySinh=@NgaySinh,NoiSinh=@NoiSinh,GioiTinh=@GioiTinh where MaSV =@MaSV";
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpkNgaySinh.Value);
            cmd.Parameters.AddWithValue("@NoiSinh", cbbNoiSinh.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "Nam" : "Nữ");
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Sua thành công sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadlist();
            clear();
        }
    }
}
