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
            SqlCommand cmd = new SqlCommand("Select SOBAN from QLCAFE", SqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbBanThanhToan.Items.Add(reader["SOBAN"].ToString());
            }
            SqlConnection.Close();
        }

        private void cbbBanThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            string query = "SELECT SOBAN, DOUONG, SOLUONG, GIA FROM QLCAFE WHERE SOBAN = @soban";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@soban", cbbBanThanhToan.SelectedItem.ToString());

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvThanhToan.DataSource = dt;
            conn.Close();

            int tongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                int soLuong = Convert.ToInt32(row["SOLUONG"]);
                int gia = Convert.ToInt32(row["GIA"]);
                tongTien += soLuong * gia;
            }

            txtThanhTien.Text = tongTien.ToString();

        }
    }
}
