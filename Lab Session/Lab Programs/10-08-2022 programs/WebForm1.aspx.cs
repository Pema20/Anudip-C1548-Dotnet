using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int res = int.Parse(TextBox1.Text) / int.Parse(TextBox2.Text);




            TextBox3.Text = res.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int res=int.Parse(TextBox1.Text) + int.Parse(TextBox2.Text);

           

            
            TextBox3.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int res = int.Parse(TextBox1.Text) - int.Parse(TextBox2.Text);




            TextBox3.Text = res.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int res = int.Parse(TextBox1.Text) * int.Parse(TextBox2.Text);




            TextBox3.Text = res.ToString();
        }
    }
}