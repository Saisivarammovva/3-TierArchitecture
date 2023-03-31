using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class RegiserationBLL
    {
        DAL.RegistrationDAL regdal=new DAL.RegistrationDAL();


        public void InsertDetails(string FirstName, string LastName, String DateOfBirth, bool MaleChecked, bool FemaleChecked, string EMail)
        {
            try
            {

                string gender = string.Empty;
                if (MaleChecked)
                {
                    gender = "male";
                }
                else if (FemaleChecked)
                {
                    gender = "female";
                }

                regdal.InsertDetails(FirstName, LastName, DateOfBirth, gender, EMail);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        public DataSet Getdetails()
        {
            DataSet ds = regdal.GridView1();
            return ds;
        }

    }
    
}
