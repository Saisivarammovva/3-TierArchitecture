using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_TierArchitecture
{
    public class RegistrationBAL
    {

        RegistrationDAL regdal = new RegistrationDAL();

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
            catch(Exception ex)
            {
                throw (ex);
            }

        }
    }
}