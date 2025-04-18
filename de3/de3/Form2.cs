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
            SqlCommand cmd = new SqlCommand("Select * from SinhVien", sqlconnection);
            sqlconnection.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvSinhVien.DataSource = dt;
            sqlconnection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string sql = "Select * from SinhVien where 1=1";
            sql += "AND MaSV LIKE '%" + txtSearchMasv.Text + "%'";
            sql += "AND NoiSinh LIKE '%" + txtSearchNoiSinh.Text + "%'";
            if (rdoNam.Checked) sql += " AND GioiTinh = N'Nam'";
            if (rdoNu.Checked) sql += " AND GioiTinh = N'Nữ'";
            sqlconnection = new SqlConnection(connectionString);
            sqlconnection.Open();
            adapter = new SqlDataAdapter(sql, sqlconnection);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSinhVien.DataSource = dt;
            sqlconnection.Close() ;

        }
    }
}
