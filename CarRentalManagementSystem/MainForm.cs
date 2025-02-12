using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          // this.Size = new System.Drawing.Size(720, 520);
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            

        }
    }
}
