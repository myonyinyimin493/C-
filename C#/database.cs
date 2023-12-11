using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace assignment
{
    class database
    {
        public void savepassword (reg pa)
        {
            SqlConnection l = new SqlConnection();
            l.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cm = new SqlCommand();
            cm.Connection = l;
            cm.CommandText = "Insert into password Values('" + pa.Name + "', '" + pa.Password + "')";

            l.Open();
            cm.ExecuteNonQuery();
            l.Close();
        }
        public void deletepassword(reg cs)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete password";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable searchpassword()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select * from password";
            DataSet ds = new DataSet();
            sda.Fill(ds, "password");
            DataTable dt = ds.Tables["password"];
            return dt;

        }
        public DataTable searchitem()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select * from admin";
            DataSet ds = new DataSet();
            sda.Fill(ds, "admin");
            DataTable dt = ds.Tables["admin"];
            return dt;

        }
        public void Saveitem(adminn cu)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into admin Values( '" + cu.Name + "', " + cu.Price + "," + cu.Qty + ")";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable Displayitem()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "select * from admin";
            DataSet ds = new DataSet();
            sda.Fill(ds, "admin");
            DataTable dt = ds.Tables["admin"];
            return dt;
        }
        public void deleteitem(string cs)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from admin where ItemID=" + "'" + cs + "'";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateitem(admindic c)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update admin Set Itemname='" + c.Name + "',IPrice=" + c.Price + ",IQty=" + c.Qty + " Where ItemID=" + c.id;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void updateitemded(Itemdeuction c)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update admin Set IQty=" + c.Qty + " Where ItemID=" + c.id;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable Searching(string s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select * from admin where ItemID='" + s + "'";
            DataSet ds = new DataSet();
            sda.Fill(ds, "admin");
            DataTable dt = ds.Tables["admin"];
            return dt;

        }

        public void savecasher(casheer la)
        {
            SqlConnection l = new SqlConnection();
            l.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cm = new SqlCommand();
            cm.Connection = l;
            cm.CommandText = "Insert into casher Values('" + la.CName + "', '" + la.Vouncher + "'," + la.id + ", '" + la.iName + "'," + la.Price + "," + la.Qty + "," + la.Amount + ", getDate())";

            l.Open();
            cm.ExecuteNonQuery();
            l.Close();
        }

        public void savevouncher(Vouncher lb)
        {
            SqlConnection l = new SqlConnection();
            l.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";
            SqlCommand cm = new SqlCommand();
            cm.Connection = l;
            cm.CommandText = "Insert into sear Values('" + lb.VOU + "',"+lb.Subtot +","+lb.Ta+","+lb.Tot+","+lb.dIs+","+lb.Pay+")";

            l.Open();
            cm.ExecuteNonQuery();
            l.Close();
        }


        public DataTable searchvouncher()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select * from sear";
            DataSet ds = new DataSet();
            sda.Fill(ds, "sear");
            DataTable tt = ds.Tables["sear"];
            return tt;

        }

        public DataTable showsearching(string s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HDV7NRU;Initial Catalog=C#;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select * from casher where VouncherID='" + s + "'";
            DataSet ds = new DataSet();
            sda.Fill(ds, "casher");
            DataTable at = ds.Tables["casher"];
            return at;

        }
    }
}
