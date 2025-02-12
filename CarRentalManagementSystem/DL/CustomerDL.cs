using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DL
{
    internal class CustomerDL
    {
        static string connection = "Data Source=DESKTOP-B4HF2L6\\SQLEXPRESS;Initial Catalog=CarRentalDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        static SqlConnection conn = new SqlConnection(connection);
        public static void AddCustomer(string id, string name, string address, string phone)
        {
            conn.Open();
            string query = $"INSERT INTO Customers VALUES('{id}', '{name}', '{address}', '{phone}')";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }
        static public void ShowDataInGridView(ref Guna.UI2.WinForms.Guna2DataGridView g)
        {
            conn.Open();
            string Query = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds.Tables[0];
            conn.Close();
        }
        static public void DeleteCustomer(string id)
        {
            conn.Open();
            string query = "delete from Customers where id='" + id + "'";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }
        static public void Updatecustomer(string id, string name, string address, string phone)
        {
            conn.Open();
            string query = $"UPDATE Customers SET id = '{id}', CustName = '{name}', CustAddress = '{address}', phone = '{phone}' WHERE id = '{id}'";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }
        public static void cloaseconnection()
        {
            conn.Close();
        }
    }
}
