using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1.DL
{
    internal class ReturnDL
    {
        static string connection = "Data Source=DESKTOP-B4HF2L6\\SQLEXPRESS;Initial Catalog=CarRentalDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        static SqlConnection conn = new SqlConnection(connection);
        public static void LoadCarsonrent(ref Guna.UI2.WinForms.Guna2DataGridView g)
        {
            conn.Open();
            string Query = "select * from Rental";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds.Tables[0];
            conn.Close();
        }
        public static void LoadReturnedCars(ref Guna.UI2.WinForms.Guna2DataGridView g)
        {
            conn.Open();
            string Query = "select * from ReturnTable";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds.Tables[0];
            conn.Close();
        }
        public static void ReturnCar(string returnid,string carreg,string custname,Guna2DateTimePicker returndate,string fine,string delay,string totalamount)
        {
            conn.Open();
            string query = $"insert into ReturnTable values ({int.Parse(returnid)},'{carreg}','{custname}','{returndate.Value.ToString("yyyy-MM-dd")}',{int.Parse(fine)},{int.Parse(delay)},{int.Parse(totalamount)})";
            string query2 = $"delete from Rental where Rentid={int.Parse(returnid)}";
            string query3 = $"update CarsInfo set Available='Yes' where RegNo='{carreg}'";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            cmd= new SqlCommand(query2,conn);
            cmd.ExecuteNonQuery();
            cmd= new SqlCommand(query3,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
