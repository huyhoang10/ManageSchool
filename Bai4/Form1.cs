using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using System.Data;
using System.Web;

namespace Bai4
{
    public partial class FManageFaculty : Form
    {
        public FManageFaculty()
        {
            InitializeComponent();
        }

        string connstring = "Data Source=.;Initial Catalog=QuanLyTruongHoc;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            txtIdFaculty.ReadOnly = false;
            txtNameFaculty.ReadOnly = false;
            txtIdFaculty.Text = "";
            txtNameFaculty.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
            btnSave.Enabled = false;
            txtIdFaculty.ReadOnly = true;
            txtNameFaculty.ReadOnly = true;
            txtIdFaculty.Text = "";
            txtNameFaculty.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtIdFaculty.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string query = "delete Khoa where makhoa = '" + txtIdFaculty.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                LoadDataDgvInforFaculty();
            }
        }

        private string makhoasuadoi = "";
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            txtIdFaculty.ReadOnly = false;
            txtNameFaculty.ReadOnly = false;
            makhoasuadoi = txtIdFaculty.Text;
        }

        private void FManageFaculty_Load(object sender, EventArgs e)
        {
            LoadDataDgvInforFaculty();
        }

        private void dgvInforFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInforFaculty.CurrentRow != null)
            {
                DataRowView rowView = (DataRowView)dgvInforFaculty.CurrentRow.DataBoundItem;
                DataRow rowcurrent = rowView.Row;
                txtIdFaculty.Text = rowcurrent["makhoa"].ToString();
                txtNameFaculty.Text = rowcurrent["tenkhoa"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnAdd.Enabled == true)
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string query = "insert Khoa (makhoa,tenkhoa)" +
                        " values (@makhoa,@tenkhoa) ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@makhoa", txtIdFaculty.Text);
                    cmd.Parameters.AddWithValue("@tenkhoa", txtNameFaculty.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadDataDgvInforFaculty();
            }
            if(btnEdit.Enabled == true & makhoasuadoi != "")
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string query = "update Khoa set " +
                        "makhoa = @makhoa, " +
                        "tenkhoa = @tenkhoa " +
                        "where makhoa = '"+makhoasuadoi+"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@makhoa", txtIdFaculty.Text);
                    cmd.Parameters.AddWithValue("@tenkhoa", txtNameFaculty.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadDataDgvInforFaculty();
            }
        }
        private void LoadDataDgvInforFaculty()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string query = "select * from Khoa";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dgvInforFaculty.DataSource = tb;
                int soLuongKhoa = tb.Rows.Count;
                txtTotalFaculty.Text = soLuongKhoa.ToString();
            }
        }
    }
}
