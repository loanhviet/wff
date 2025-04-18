using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=BTonTap;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection SqlConnection;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            loadsoban();
        }
        void loadsoban()
        {
            SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();
            string query = "select SOBAN from QLCAFE";
            SqlCommand cmd = new SqlCommand(query, SqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbBanThanhToan.Items.Add(reader["SOBAN"].ToString());
            }
            SqlConnection.Close();

        }

        private void cbbBanThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();
            string query = "select * from QLCAFE where SOBAN = @SOBAN";
            SqlCommand cmd = new SqlCommand(query, SqlConnection);
            cmd.Parameters.AddWithValue("@SOBAN", cbbBanThanhToan.SelectedItem.ToString());
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvThanhToan.DataSource = dt;

            SqlConnection.Close();
            int tongtien = 0;
            foreach (DataRow row in dt.Rows)
            {

                int soluong = Convert.ToInt32(row["SOLUONG"]);
                int gia = Convert.ToInt32(row["GIA"]);
                tongtien += soluong * gia;
            }
            txtThanhTien.Text = tongtien.ToString();

        }
        private void LoadDoUong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DOUONG FROM DATHANG", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbDoUong.Items.Add(reader["DOUONG"].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM DATHANG WHERE 1=1";

                if (chkDoUong.Checked && cbDoUong.SelectedItem != null)
                {
                    query += " AND DOUONG = @douong";
                }

                if (chkNgay.Checked)
                {
                    query += " AND NGAY BETWEEN @tuNgay AND @denNgay";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if (chkDoUong.Checked && cbDoUong.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@douong", cbDoUong.SelectedItem.ToString());
                }

                if (chkNgay.Checked)
                {
                    cmd.Parameters.AddWithValue("@tuNgay", dtpDenNgay.Value.Date);
                    cmd.Parameters.AddWithValue("@denNgay", dtpDenNgay.Value.Date);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKetQua.DataSource = dt;

                // Tính doanh thu
                int doanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int soLuong = Convert.ToInt32(row["SOLUONG"]);
                    int gia = Convert.ToInt32(row["GIA"]);
                    doanhThu += soLuong * gia;
                }

                txtDoanhThu.Text = doanhThu.ToString();
            }
        }
    }
}
