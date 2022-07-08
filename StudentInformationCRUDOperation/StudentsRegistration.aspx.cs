using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationCRUDOperation
{
    public partial class StudentsRegistration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["Id"]);
            if (!IsPostBack)
            {
                if(id > 0)
                {
                    BindData(id);
                }
                else
                {
                    ClearAll();
                }
            }
        }

        public void ClearAll()
        {
            txtName.Text = "";
            txtAddrerss.Text = "";
            txtEmail.Text = "";
            txtMobileNumber.Text = "";
            txtPassword.Attributes["value"] = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["Id"]);
            if (id <= 0)
            {
                //Save
                SqlCommand cmd = new SqlCommand("Insert into StudentsDetails Values(@Name, @Address, @Mob,  @Email, @Pass)", con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddrerss.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Mob", txtMobileNumber.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                lblMessage.Text = "Student Saved Successfully";
            }
            else
            {
                //Update
                SqlCommand cmd = new SqlCommand("Update StudentsDetails set Name= @Name, Address=@Address" +
                    "MobileNumber=@Mob, Email = @Email, Password=@Password where Id = '"+ id +"'", con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddrerss.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Mob", txtMobileNumber.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                lblMessage.Text = "Student Updated Successfully";
            }
            ClearAll();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        protected void btnStdList_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StudentsList.aspx");
            ClearAll();
        }

        private void BindData(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentsDetails where Id = '" + id +"'",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtName.Text = dr["Name"].ToString();
                txtAddrerss.Text = dr["Address"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtMobileNumber.Text = dr["MobileNumber"].ToString();
                string s = dr["password"].ToString();
                txtPassword.Attributes["Value"] = s;
            }
            con.Close();
        }
    }
}