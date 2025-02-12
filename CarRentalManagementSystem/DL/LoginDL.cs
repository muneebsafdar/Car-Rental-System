using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.DL
{
    internal class LoginDL
    {
        static string connection = "Data Source=DESKTOP-B4HF2L6\\SQLEXPRESS;Initial Catalog=CarRentalDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        public static bool userCheckLogin(string uname, string Pass)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            string QUERY = "select count(*) from Users where UserName='" + uname + "'and Pass='" + Pass + "'";
            SqlCommand cms = new SqlCommand(QUERY, conn);
            int confirmation = (int)cms.ExecuteScalar();
            if (confirmation == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public static bool AdminCheckLogin(string uname, string Pass)
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                string QUERY = "select count(*) from Admin where UserName='" + uname + "'and Pass='" + Pass + "'";
                SqlCommand cms = new SqlCommand(QUERY, conn);
                int confirmation = (int)cms.ExecuteScalar();
                if (confirmation == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
    }
}
