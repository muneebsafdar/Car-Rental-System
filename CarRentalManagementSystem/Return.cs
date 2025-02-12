using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            ReturnDL.LoadCarsonrent(ref carsonrent);
            ReturnDL.LoadReturnedCars(ref carsreturned);
            carsonrent.Columns[0].Width = 70;
            carsreturned.Columns[0].Width = 70;

        }

        private void carsonrent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = carsonrent.SelectedRows[0].Cells[0].Value.ToString();
            careregtxt.Text= carsonrent.SelectedRows[0].Cells[1].Value.ToString();
            nametxtx.Text = carsonrent.SelectedRows[0].Cells[2].Value.ToString();
            retuenadate.Text = carsonrent.SelectedRows[0].Cells[5].Value.ToString();
            DateTime date1 = retuenadate.Value.Date;
            DateTime date2 = DateTime.Now.Date;
            TimeSpan t = date2 - date1;
            int t2 = Convert.ToInt32(t.TotalDays);
            if (t2 <= 0)
            {
                delaytxt.Text = "0";
                finetxt.Text = "0";
                totalamounttxt.Text= carsonrent.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                delaytxt.Text = t2.ToString();
                finetxt.Text = (1000* t2).ToString();
                totalamounttxt.Text = (int.Parse(carsonrent.SelectedRows[0].Cells[4].Value.ToString())+ (1000 * t2)).ToString();
            }
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            if (careregtxt.Text==null || careregtxt.Text == "")
            {
                MessageBox.Show("Fill All Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                ReturnDL.ReturnCar(idtxt.Text, careregtxt.Text, nametxtx.Text, retuenadate, finetxt.Text, delaytxt.Text, totalamounttxt.Text);
                ReturnDL.LoadCarsonrent(ref carsonrent);
                ReturnDL.LoadReturnedCars(ref carsreturned);
            }
            
        }

    }
}
