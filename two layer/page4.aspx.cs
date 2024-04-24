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
    public partial class page4 : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string s = "select id ,name from tablee2";
                DataSet ds = obj1.Fun_exeAdapter(s);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "-select-");

            }
            

           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;


            string sl = "select * from tablee2 where id='" + DropDownList1.SelectedItem.Value + "'";
            DataSet ds = obj1.Fun_exeAdapter(sl);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}