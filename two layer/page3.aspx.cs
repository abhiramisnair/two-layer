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
    public partial class page3 : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select name,age,address,photo from tablee2 where id=" + Session["uid"] + "";
            SqlDataReader dr = obj1.Fn_exReader(sel);
            while (dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }
            DataSet ds = obj1.Fun_exeAdapter(sel);
            
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}