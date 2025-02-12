using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DL
{
    internal class UserloadDL
    {
        static string connection = "Data Source=DESKTOP-B4HF2L6\\SQLEXPRESS;Initial Catalog=CarRentalDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        static SqlConnection conn = new SqlConnection(connection);
        static public void AddUser(string id,string username, string pass)
        {
            conn.Open();
            string query = "INSERT INTO Users VALUES('" + id + "','" + username + "','" + pass + "')";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }
        static public void UpdateUser(string id, string username, string pass)
        {
            conn.Open();
            string query = "UPDATE Users SET UserName = '" + username + "', Pass = '" + pass + "' WHERE id = '" + id + "'";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }


        static public void DeleteUser(string id)
        {
            conn.Open();
            string query = "delete from Users where id='" + id + "'";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }

        static public void ShowDataInGridView(ref Guna.UI2.WinForms.Guna2DataGridView g)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string Query = "select * from Users";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            var ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
