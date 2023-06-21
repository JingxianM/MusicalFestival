using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Web;
using System.Data;


namespace GUI
{
    public static class dbConnection
    {

        public static MySqlConnection con =
               con = new MySqlConnection("server=studmysql01.fhict.local;" +
                            "database=dbi387232;" +
                            "user id=dbi387232;" +
                            "password=gigi123;" +
                            "connect timeout=10;");


        public static void OpenConnection()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }
        public static int ExecuteScalar(string query)
        {
            int num;
            MySqlCommand cmd = new MySqlCommand(query, con);
            num = (int)cmd.ExecuteScalar();
            return num;
        }
        public static void ExecuteQueries(MySqlCommand cmd)
        {
            cmd.ExecuteNonQuery();

        }
        public static MySqlDataReader DataReader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public static object ShowDataInGridView(string Query_)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(Query_, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

    }
}
