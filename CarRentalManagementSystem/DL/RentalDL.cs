using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1.DL
{
    internal class RentalDL
    {
        static string connection = "Data Source=DESKTOP-B4HF2L6\\SQLEXPRESS;Initial Catalog=CarRentalDatabase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        static SqlConnection conn = new SqlConnection(connection);
        public static void fillcarcombo(ref Guna2ComboBox ch)
        {
            conn.Open();
            string query = $"select RegNo from CarsInfo where Available = 'Yes'";
            SqlCommand cmd=new SqlCommand(query, conn);
            SqlDataReader dr;
            dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                ch.Items.Add(dr["RegNo"].ToString());
            }
            conn.Close();
        }
        public static void fillcarcomboForDelete(ref Guna2ComboBox ch)
        {
            conn.Open();
            string query = $"select RegNo from CarsInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ch.Items.Add(dr["RegNo"].ToString());
            }
            conn.Close();
        }
        public static void fillcustcombo(ref Guna2ComboBox ch)
        {
            conn.Open();
            string query = $"select id from Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ch.Items.Add(dr["id"].ToString());
            }
            conn.Close();
        }
        public static void AddRental(string carreg, string custtname, Guna2DateTimePicker rentdate, Guna2DateTimePicker returndate, string price)
        {
            conn.Open();
            string rentDateString = rentdate.Value.ToString("yyyy-MM-dd");
            string returnDateString = returndate.Value.ToString("yyyy-MM-dd");

            string query = $"INSERT INTO Rental VALUES ('{carreg}', '{custtname}', '{rentDateString}', {int.Parse(price)}, '{returnDateString}')";
            string query2 = $"UPDATE CarsInfo SET Available = 'No' WHERE RegNo = '{carreg}'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            conn.Close();
        }


        public static void UpdateRental(string id,string carreg, string custtname, Guna2DateTimePicker rentdate, Guna2DateTimePicker returndate, string price)
        {
            conn.Open();
            string query = $"UPDATE Rental SET CarReg='{carreg}', CustName='{custtname}', RentDate='{rentdate.Value}', RentFee={int.Parse(price)}, ReturnDate='{returndate.Value}' WHERE Rentid='{id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteRental(string id,string carreg)
        {
            conn.Open();
            string query = $"delete from Rental where Rentid='{id}'";
            string query2 = $"update CarsInfo set Available='Yes' where RegNo='{carreg}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();

        }
        public static void ShowCustname(ref Guna2TextBox text,string id)
        {
            conn.Open();
            string query = $"SELECT CustName FROM Customers WHERE id = '{id}'";
            SqlCommand cmd = new SqlCommand (query, conn);
            var data=cmd.ExecuteScalar();
            text.Text=data.ToString();
            conn.Close();
        }
        static public void ShowDataInGridView(ref Guna.UI2.WinForms.Guna2DataGridView g)
        {
            conn.Open();
            string Query = "select * from Rental";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            var ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
