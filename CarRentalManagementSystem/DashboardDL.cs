using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class DashboardDL
    {
        static string connection = "Data Source=DESKTOP-B4HF2L6\\SQLEXPRESS;Initial Catalog=CarRentalDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        static SqlConnection conn = new SqlConnection(connection);

        public static void Loaddashboard(ref System.Windows.Forms.Label cars, ref System.Windows.Forms.Label cust, ref System.Windows.Forms.Label user, ref System.Windows.Forms.Label sales)
        {
            conn.Open();
            string query = "select count(RegNo) from CarsInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            var a = cmd.ExecuteScalar();
            cars.Text = a.ToString();

            query = "select count(id) from Customers";
            cmd = new SqlCommand(query, conn);
            a = cmd.ExecuteScalar();
            cust.Text = a.ToString();

            query = "select count(id) from Users";
            cmd = new SqlCommand(query, conn);
            a = cmd.ExecuteScalar();
            user.Text = a.ToString();

            DateTime currentDate = DateTime.Now;
            string sqlQuery = "SELECT SUM(TotalPaidAmount) FROM ReturnTable WHERE MONTH(ReturnDate) = @CurrentMonth";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
            {
                sqlCommand.Parameters.AddWithValue("@CurrentMonth", currentDate.Month);

                object result = sqlCommand.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    sales.Text = "0";
                }
                else
                {
                    sales.Text = result.ToString();
                }
            }




            conn.Close();
        }
    }
}
