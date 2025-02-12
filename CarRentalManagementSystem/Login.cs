using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.BL;

namespace CarRentalManagementSystem
{
    public partial class Login : Form
    {
        int formop = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;

        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            password.Text = "";
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string Uid= Username.Text;
            string pass=password.Text;
            int check = LoginBl.validate(Uid, pass);
            if (check==1) 
            {
                firstbox.Text = "!Please fill this";
                secondbox.Text = "";
                Username.Focus();
            }
            else if(check==2)
            {
                secondbox.Text = "!Please fill this";
                firstbox.Text = "";
                password.Focus();
            }
            else if(check==3)
            {
                UserMasterform masterForm = new UserMasterform();
                this.Hide();
                masterForm.ShowDialog();
                this.Close();
            }
            else if (check==4)
            {
                MasterForm masterForm = new MasterForm();
                this.Hide();
                masterForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong pass or username");
            }
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public  void start()
        //{
        //    if (formop == 3)
        //    {
        //        UserMasterform masterForm = new UserMasterform();
        //        Application.Run(masterForm);
        //    }else if (formop==4)
        //    {
        //        MasterForm masterForm = new MasterForm();
        //        Application.Run(masterForm);
        //    }
            
        //}
    }
}
