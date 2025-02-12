using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;
using Guna.UI2.WinForms;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size(1509, 687);    
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            UserloadDL.ShowDataInGridView(ref UsersDataGridView);
            id.Text = ""; 
            username.Text = ""; 
            password.Text = "";
        }
        private void addbtn_Click(object sender, EventArgs e)
        {

            int confirm=UserLoadBL.Validate(id.Text,username.Text,password.Text);
            if (confirm == 1)
            {
                label6.Text = "Please fill this";
                label7.Text = "";
                label8.Text = "";
            }
            else if (confirm == 2)
            {
                label6.Text = "";
                label7.Text = "";
                label8.Text = "Please fill this";
            }
            else if(confirm == 3)
            {
                label6.Text = "";
                label7.Text = "Please fill this";
                label8.Text = "";
            }
            else
            {
                UserloadDL.AddUser(id.Text, username.Text, password.Text);
                LoadUsersData();
            }

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            int confirm = UserLoadBL.Validate(id.Text, username.Text, password.Text);
            if (confirm == 1)
            {
                label6.Text = "Please fill this";
                label7.Text = "";
                label8.Text = "";
            }
            else if (confirm == 2)
            {
                label6.Text = "";
                label7.Text = "";
                label8.Text = "Please fill this";
            }
            else if (confirm == 3)
            {
                label6.Text = "";
                label7.Text = "Please fill this";
                label8.Text = "";
            }
            else
            {
                UserloadDL.UpdateUser(id.Text, username.Text, password.Text);
                LoadUsersData();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int confirm = UserLoadBL.Validate(id.Text, username.Text, password.Text);
            if (confirm == 1)
            {
                label6.Text = "Please fill this";
                label7.Text = "";
                label8.Text = "";
            }
            else if (confirm == 2)
            {
                label6.Text = "";
                label7.Text = "";
                label8.Text = "Please fill this";
            }
            else if (confirm == 3)
            {
                label6.Text = "";
                label7.Text = "Please fill this";
                label8.Text = "";
            }
            else
            {
                UserloadDL.DeleteUser(id.Text);
                LoadUsersData();
            }
        }

        


        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = UsersDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            username.Text = UsersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            password.Text = UsersDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            id.Text = "";
            username.Text = "";
            password.Text = "";
        }
    }
}
