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
    public partial class datalist : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select * from tablee2";
            DataSet ds = obj1.Fun_exeAdapter(s);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}