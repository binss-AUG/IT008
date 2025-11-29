using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    class DBhelper
    {
        private static string strConn = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;

        public DataTable getTable(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(dt);
                }    
            }    

            return dt;
        }

        public bool exeQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        MessageBox.Show("MSSV đã tồn tại!");
                        return false;
                    }
                }
            }    
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open(); 
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
