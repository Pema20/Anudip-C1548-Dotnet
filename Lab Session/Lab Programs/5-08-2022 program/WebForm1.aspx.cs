using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication3
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        int i;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employee_table values(@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("@p1", TextBox5.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
            cmd.Parameters.AddWithValue("@p4", TextBox4.Text);
            i = cmd.ExecuteNonQuery();
            if (i != 0)
                Response.Write("<script>alert ('Record inserted')</script>");
            else
                Response.Write(" <script> alert('error') </script> ");


            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employee_table", con);
            SqlDataReader dr = cmd.ExecuteReader();

            GridView1.DataBind();
            con.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int i;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from employee_table where id=@p1", con);
            cmd.Parameters.AddWithValue("@p1", 7);
 i= cmd.ExecuteNonQuery();
            if (i != 0)
                Response.Write("<script>alert ('Record deleted')</script>");
            else
                Response.Write(" <script> alert('not found') </script> ");


            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\WebApplication3\\WebApplication3\\App_Data\\Database1.mdf;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("update employee_table set Employeename='sharon' where Id=4", con);
                i = cmd.ExecuteNonQuery();
                if (i != 0)
                    Response.Write("Record Updated successfully");
                else
                    Response.Write("Record not updated");

            }
            catch (SqlException se) { Response.Write(se.Message); }
            finally
            {
                con.Close();

            }



        }

    }
}
    

    