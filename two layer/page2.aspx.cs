using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace two_layer
{
    public partial class page2 : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select count (id) from tablee2 where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
            string cid = obj1.Fn_exscalar(s);
            if (cid == "1")
            {
                int id1 = 0;
                string str = "select id from tablee2 where username='"+TextBox1.Text +"'and password='"+TextBox2.Text+ "'";
                SqlDataReader dr = obj1.Fn_exReader(str);
                while (dr.Read())
                {
                    id1 = Convert.ToInt32(dr["id"].ToString());
                }
                Session["uid"] = id1;
                Response.Redirect("page3.aspx");
            }
        }
    }
}