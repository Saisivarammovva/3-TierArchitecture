using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RegistrationDAL
    {
        public void InsertDetails(string FirstName, string LastName, string DateOfBirth, string Gender, string EMail)
        {
            try
            {

                string sp_connect = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;
                SqlConnection con = new SqlConnection(sp_connect);
                SqlCommand cmd = new SqlCommand("Registration_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@EMail", EMail);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public DataSet GridView1()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString.Trim());
            SqlDataAdapter da = new SqlDataAdapter("get_details1", conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"form1");
            return ds;
        }
    }
}
