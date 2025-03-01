using Microsoft.Data.SqlClient;
using System.Data;

namespace Bai5
{
    public partial class FManageEmployee : Form
    {
        public FManageEmployee()
        {
            InitializeComponent();
        }

        string connstring = "Data Source=.;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
        private void dgvManageEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FManageEmployee_Load(object sender, EventArgs e)
        {
            LoadDgvManageEmployee();
            loadLsbDepartment_CmbIddepartment();
            resetForm();
            //loadcmbIdDepartment();
        }
        private void resetForm()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnAccept.Enabled = false;
            txtIdNV.Text = "";
            txtNameNV.Text = "";
            txtPhone.Text = "";
            cmbIdDepartment.Text = ""; ;
            dtpBirthday.Value = DateTime.Today;
            txtIdNV.ReadOnly = true;
            txtNameNV.ReadOnly = true;
            txtPhone.ReadOnly = true;

        }
        private void LoadDgvManageEmployee()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string query = "select * from nhanvien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dgvManageEmployee.DataSource = tb;
            }
        }

        private void loadLsbDepartment_CmbIddepartment()
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string query = "select * from phongban";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            lsbDepartment.Items.Clear();
            while (reader.Read())
            {
                lsbDepartment.Items.Add(reader["tenphong"].ToString() + " (" + reader["maphong"].ToString() + ")"); //  + " (" + reader["maphong"].ToString() + ")"
                cmbIdDepartment.Items.Add(reader["maphong"].ToString());
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa ràng buộc tất cả điều kiện.\r\n Vui lòng nhập đầy đủ và thông tin chính xác!", "Lưu ý");
            btnAccept.Enabled = true;
            btnEdit.Enabled = false;
            txtIdNV.ReadOnly = false;
            txtNameNV.ReadOnly = false;
            txtPhone.ReadOnly = false;
            cmbIdDepartment.Text = "";
            txtIdNV.Text = "";
            txtNameNV.Text = "";
            txtPhone.Text = "";
            dtpBirthday.Value = DateTime.Today;

        }

        string manvSuaDoi = "";
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa ràng buộc tất cả điều kiện.\r\n Vui lòng nhập đầy đủ và thông tin chính xác!", "Lưu ý");
            if (txtIdNV.Text != "")
            {
                btnAccept.Enabled = true;
                btnAdd.Enabled = false;
                txtIdNV.ReadOnly = false;
                txtNameNV.ReadOnly = false;
                txtPhone.ReadOnly = false;
                manvSuaDoi = txtIdNV.Text;
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == true & txtIdNV.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string query = "insert nhanvien (manv,tennv,ngaysinh,sodt,maphong) " +
                        "values (@manv,@tennv,@ngaysinh,@sodt,@maphong) ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@manv", txtIdNV.Text.ToString());
                    cmd.Parameters.AddWithValue("@tennv", txtNameNV.Text.ToString());
                    cmd.Parameters.AddWithValue("@ngaysinh", dtpBirthday.Text.ToString());
                    cmd.Parameters.AddWithValue("@sodt", txtPhone.Text.ToString());
                    cmd.Parameters.AddWithValue("@maphong", cmbIdDepartment.Text.ToString());
                    cmd.ExecuteNonQuery();
                    resetForm();
                }
            }
            else if (btnEdit.Enabled == true & txtIdNV.Text != "" & manvSuaDoi != "")
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string query = "update nhanvien set " +
                        "manv = @manv, " +
                        "tennv = @tennv, " +
                        "ngaysinh = @ngaysinh,  " +
                        "sodt = @sodt, " +
                        "maphong = @maphong " +
                        "where manv = '" + manvSuaDoi + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@manv", txtIdNV.Text.ToString());
                    cmd.Parameters.AddWithValue("@tennv", txtNameNV.Text.ToString());
                    cmd.Parameters.AddWithValue("@ngaysinh", dtpBirthday.Text.ToString());
                    cmd.Parameters.AddWithValue("@sodt", txtPhone.Text.ToString());
                    cmd.Parameters.AddWithValue("@maphong", cmbIdDepartment.Text.ToString());
                    cmd.ExecuteNonQuery();
                    resetForm();
                }
            }
            LoadDgvManageEmployee();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(txtIdNV.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string query = "delete nhanvien where manv = '"+txtIdNV.Text+"' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    LoadDgvManageEmployee();
                    resetForm();
                }
            }
        }
        private void dgvManageEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView rowView = (DataRowView)dgvManageEmployee.CurrentRow.DataBoundItem;
            DataRow rowCurrent = rowView.Row;
            txtIdNV.Text = rowCurrent["manv"].ToString();
            txtNameNV.Text = rowCurrent["tennv"].ToString();
            txtPhone.Text = rowCurrent["sodt"].ToString();
            dtpBirthday.Text = rowCurrent["ngaysinh"].ToString();
            cmbIdDepartment.Text = rowCurrent["maphong"].ToString();
        }
    }
}
