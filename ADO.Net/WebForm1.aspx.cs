using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                TextBox1.Focus();
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("select country,id from table_1", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DropDownList1.DataTextField = "country";
                    DropDownList1.DataValueField = "id";

                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (IsPostBack == true)
            //{
               // Response.Write(TextBox1.Text + "<br/>");
               //Response.Write(DropDownList1.SelectedItem.Text + "<br/>");
                //Response.Write(DropDownList1.SelectedIndex + "<br/>");

                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string insertString = "insert into Table_3 values(@cc, @Text)";
                    SqlCommand cmd = new SqlCommand(insertString, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@cc", Convert.ToInt64(DropDownList1.SelectedItem.Value));
                    cmd.Parameters.AddWithValue("@Text", TextBox1.Text);
                    cmd.ExecuteNonQuery();


                    /* Session["TextBox"] = TextBox1.Text;
                     Session["DDlist"] = DropDownList1.SelectedItem.Text;
                    Response.Write(Session["TextBox"]);
                    Response.Write(Session["DDlist"]);
                    */

                //}
            }
            Response.Redirect("WebForm2.aspx");
        }
    }
}