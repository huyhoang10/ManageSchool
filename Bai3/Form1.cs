using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Bai3
{
    public partial class FSearchStudent : Form
    {
        public FSearchStudent()
        {
            InitializeComponent();
        }

        private List<string> datacmbIdSV = new List<string>();
        ConnectDatabase kn = new ConnectDatabase();
        private void FSearchStudent_Load(object sender, EventArgs e)
        {

            cmbMSSV.Items.Clear();
            LoadCmbIdSV();
        }

        private void LoadCmbIdSV()
        {
            string query = "select masv from SinhVien";
            DataTable tb = kn.TaoBang(query);
            foreach (DataRow row in tb.Rows)
            {
                cmbMSSV.Items.Add(row["masv"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "select * from SinhVien where masv = '" + cmbMSSV.Text.ToString() + "'";
            SqlDataReader reader = kn.Timkiem(query);
            while (reader.Read())
            {
                txtName.Text = reader["ho"].ToString() + " " + reader["ten"].ToString();
                txtSex.Text = reader["phai"].ToString();
                dtpBirthday.Text = reader["ngaysinh"].ToString();
                txtIdFaculty.Text = reader["makhoa"].ToString();
            }
            string quyeryLoadDgv = "with DiemThiSV as(select diemthi.mamon,diemthi.diemthi from " +
                "Diemthi inner join SinhVien " +
                "on Diemthi.masv = SinhVien.masv " +
                "where SinhVien.masv = '" + cmbMSSV.Text.ToString() + "') " +
                "select Monhoc.mamon,Monhoc.tenmon,diemthi from DiemThiSV " +
                "inner join Monhoc " +
                "on DiemThiSV.mamon = Monhoc.mamon";
            gdvInforSubject.DataSource = kn.TaoBang(quyeryLoadDgv);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
