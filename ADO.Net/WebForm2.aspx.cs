using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)            // To load the page only first time 
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    SqlDataReader rdr = null;

                    SqlCommand cmd = new SqlCommand("select t.ITEXT,c.COUNTRY from  table_3 t left join Table_1 c on t.CCode=c.ID", con);

                    // execute the command
                    rdr = cmd.ExecuteReader();

                    // iterate through results, printing each to Web Page
                    while (rdr.Read())
                    {
                        string desc = rdr["ITEXT"].ToString();
                        string cntry = rdr["COUNTRY"].ToString();

                        Label1.Text = desc;
                        Label2.Text = cntry;

                        //Response.Write(desc + "           "+cntry);  
                        //Response.Write("<br/>");
                    }


                    //string Name = Request.QueryString["name"];
                    //string Country = Request.QueryString["country"];
                    //Response.Write(Name);
                    //Response.Write(Country);

                    
                }
            }
        }
    }
}