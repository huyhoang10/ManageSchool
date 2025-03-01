using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class ConnectDatabase
    {
        string connstring = "Data Source=.;Initial Catalog=QuanLyTruongHoc;Integrated Security=True;Trust Server Certificate=True";
        public SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyTruongHoc;Integrated Security=True;Trust Server Certificate=True");
        public void myconnect()
        {
            conn.Open();
        }
        public void myclose()
        {
            conn.Close();
        }
        public DataTable TaoBang(string query)
        {
            //myconnect();
            DataTable tb = new DataTable();
            using(SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
                adapter.Fill(tb);
                return tb;
            }
        }

        public SqlDataReader Timkiem(string query) {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con); 
            return cmd.ExecuteReader();
            
        }
    }
}
