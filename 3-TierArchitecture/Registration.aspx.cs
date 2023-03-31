using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace _3_TierArchitecture
{
    public partial class Registration : System.Web.UI.Page
    {
        BLL.RegiserationBLL regbal=new BLL.RegiserationBLL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Getdetails1();
            }
        }      
        
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                regbal.InsertDetails(txtfname.Text, txtlname.Text, txtdob.Text, rbtnmale.Checked, rbtnfemale.Checked, txtemail.Text);

                txtfname.Text = "";
                txtlname.Text = "";
                txtdob.Text = "";
                rbtnmale.Text = "";
                rbtnfemale.Text = "";
                txtemail.Text = "";

                string message = "Your details have been saved successfully.";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "');";
                script += "window.location = '";
                script += Request.Url.AbsoluteUri;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtdob.Text = string.Empty;
            rbtnmale.Checked = false;
            rbtnfemale.Checked= false;
            txtemail.Text = string.Empty;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
       public void Getdetails1()
        {
            DataSet ds = regbal.Getdetails();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}