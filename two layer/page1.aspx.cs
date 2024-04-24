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
    public partial class page1 : System.Web.UI.Page
    {

         Class1 obj1 =new Class1 ();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string strinsert = "insert into tablee2 values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + path + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj1.Fn_NonQuery (strinsert);
            if (i == 1)
            {
                Label1.Text = "insert";
            }
        }
    }
}