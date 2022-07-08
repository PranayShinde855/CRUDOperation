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
    public partial class StudentsList : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString); 
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentsDetails", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnRegStud_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StudentsRegistration.aspx");
        }
        protected void ikbtnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if(id > 0)
            {
                Session["Id"] = id;
                Response.Redirect("~/StudentsRegistration.aspx");
            }
            else
            {
                //Code
            }
        }

        protected void ikbtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (id > 0)
            {
                Session["Id"] = id;
                SqlCommand cmd = new SqlCommand("Delete StudentsDetails where Id = '"+ id +"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            LoadData();
        }
    }
}