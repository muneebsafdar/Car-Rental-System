using CarRentalManagementSystem;
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
    public partial class UserMasterform : Form
    {
        public UserMasterform()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Location = new System.Drawing.Point(0, 0);
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
        private void clearPanel()
        {
            Mainpanel.Controls.Clear();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserMasterform_Load(object sender, EventArgs e)
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

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

