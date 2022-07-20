using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calma
{
    class functions
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            return conn;
        }
        public DataSet GetData(String query)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dt = new DataSet())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        public void setData(String query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("Data Processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
