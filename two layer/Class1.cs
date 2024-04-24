using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace two_layer
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;
            



        public Class1()
        {
            con = new SqlConnection(@"server=DESKTOP-65I62IQ\SQLEXPRESS;database=assignment data;Integrated security=true");
        }
        public int Fn_NonQuery(string sqlquery)/* insert/delete/update use this*/
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand(sqlquery, con);
                con.Open ();
           int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string  Fn_exscalar(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand(sqlquery, con);
                con.Open();
            string s= cmd.ExecuteScalar ().ToString ();
            con.Close();
            return s;
        }
        public SqlDataReader  Fn_exReader (string sqlquery)
        {
            if(con.State ==ConnectionState.Open)
            {
                con.Close();
            }
             cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet  Fun_exeAdapter(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
           SqlDataAdapter  da = new SqlDataAdapter (sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }
}