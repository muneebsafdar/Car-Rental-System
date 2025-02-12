using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.DL
{
    internal class CarsInfoDL
    {
        static string connection = "Data Source=DESKTOP-B4HF2L6\\SQLEXPRESS;Initial Catalog=CarRentalDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        static SqlConnection conn = new SqlConnection(connection);
        public static void AddCarsInfo(string reg, string brand, string model, string price, string avail)
        {
            conn.Open();
            string query = "insert into CarsInfo values('" + reg + "','" + brand + "','" + model + "','" + avail + "','" + price + "')";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }
        static public void ShowDataInGridView(ref Guna.UI2.WinForms.Guna2DataGridView g)
        {
            conn.Open();
            string Query = "select * from CarsInfo";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            var ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds.Tables[0];
            conn.Close();
        }
        static public void DeleteCar(string regno)
        {
            conn.Open();
            string query = "delete from CarsInfo where RegNo='" + regno + "'";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }
        static public void upadte(string reg, string brand, string model, string price, string avail)
        {
            conn.Open();
            string query = $"UPDATE CarsInfo SET RegNo = '{reg}', Brand = '{brand}', Model = '{model}', Available = '{avail}', Price = '{price}' WHERE RegNo = '{reg}'";
            SqlCommand cms = new SqlCommand(query, conn);
            cms.ExecuteNonQuery();
            conn.Close();
        }
        public static void updategridOnOption(string op, ref Guna.UI2.WinForms.Guna2DataGridView g)
        {
            conn.Open();
            string Query = $"select * from CarsInfo where Available='{op}'";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            var ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds.Tables[0];
            conn.Close();
        }
        public static void cloaseconnection()
        {
            conn.Close();
        }
    }
}
