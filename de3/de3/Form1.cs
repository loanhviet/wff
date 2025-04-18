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
            SqlCommand cmd = new SqlCommand("Select * from SinhVien", sqlconnection);
            sqlconnection.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvSinhVien.DataSource = dt;
            sqlconnection.Close();
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
            Form2 f = new Form2();
            f.Show();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(connectionString);
            string query = "Insert into SinhVien values (@MaSV,@HoTen,@NgaySinh,@NoiSinh,@GioiTinh)";
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpkNgaySinh.Value);
            cmd.Parameters.AddWithValue("@NoiSinh", cbbNoiSinh.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "Nam" : "Nữ");
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            loadlist();
            clear();

        }
        void clear()
        {
            txtHoTen.Clear();
            txtMa.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            cbbNoiSinh.SelectedIndex = -1;
            dtpkNgaySinh.Value = DateTime.Now;
            txtMa.Focus();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtMa.Text = row.Cells["MaSV"].Value.ToString();
                cbbNoiSinh.SelectedItem = row.Cells["NoiSinh"].Value.ToString();
                string gt = Convert.ToString(row.Cells["GioiTinh"].Value);
                if (gt == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;

                }
                dtpkNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(connectionString);
            string query = "delete SinhVien where MaSV = @MaSV";
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            loadlist();
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(connectionString);
            string query = "update SinhVien set MaSV= @MaSV,HoTen=@HoTen,NgaySinh=@NgaySinh,NoiSinh=@NoiSinh,GioiTinh=@GioiTinh where MaSV =@MaSV";
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpkNgaySinh.Value);
            cmd.Parameters.AddWithValue("@NoiSinh", cbbNoiSinh.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "Nam" : "Nữ");
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            loadlist();
            clear();
        }
    }
}
