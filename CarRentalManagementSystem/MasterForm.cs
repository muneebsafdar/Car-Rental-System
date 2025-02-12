using CarRentalManagementSystem;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width , Screen.PrimaryScreen.Bounds.Height );
            this.Location = new System.Drawing.Point(0, 0);
            guna2CirclePictureBox3.Left = this.Width - guna2CirclePictureBox3.Width;


        }

        public void WhichformtoOpen(int op)
        {
            //if (op == 1)
            //{
            //    Carsbtn_Click(null, EventArgs.Empty);
            //}
            //else if (op == 2)
            //{
            //    customersbtn_Click(null, EventArgs.Empty);
            //}
            //else if (op == 3)
            //{
            //    rentalbtn_Click(null, EventArgs.Empty);
            //}
            //else if (op == 4)
            //{
            //    rentalbtn_Click(null, EventArgs.Empty);
            //}
            //else if (op == 5)
            //{
            //    Usersbtn_Click(null, EventArgs.Empty);
            //}
            //else if (op == 6)
            //{
            //    dashboard_Click(null, EventArgs.Empty);
            //}
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            clearPanel();
            DashBoard childForm = new DashBoard();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = Mainpanel.Width;
            childForm.Height = Mainpanel.Height;
            Mainpanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            clearPanel();
            Return childForm = new Return();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = Mainpanel.Width;
            childForm.Height = Mainpanel.Height;
            Mainpanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void rentalbtn_Click(object sender, EventArgs e)
        {
            clearPanel();
            Rantal childForm = new Rantal();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = Mainpanel.Width;
            childForm.Height = Mainpanel.Height;
            Mainpanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            clearPanel();
            Customer childForm = new Customer();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = Mainpanel.Width;
            childForm.Height = Mainpanel.Height;
            Mainpanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            clearPanel();
            Users childForm = new Users();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = Mainpanel.Width;
            childForm.Height = Mainpanel.Height;
            Mainpanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void clearPanel()
        {
            Mainpanel.Controls.Clear();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            clearPanel();
            DashBoard childForm = new DashBoard();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = Mainpanel.Width;
            childForm.Height = Mainpanel.Height;
            Mainpanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void Carsbtn_Click_1(object sender, EventArgs e)
        {
            clearPanel();
            CarsInfo childForm = new CarsInfo();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = Mainpanel.Width;
            childForm.Height = Mainpanel.Height;
            Mainpanel.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
