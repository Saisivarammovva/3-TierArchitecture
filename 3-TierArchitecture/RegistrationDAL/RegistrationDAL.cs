using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace _3_TierArchitecture
{
    public class RegistrationDAL
    {

        public void InsertDetails(string FirstName, string LastName, String DateOfBirth, string Gender, string EMail)
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

    }
}