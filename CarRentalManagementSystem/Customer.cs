using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            regnomlabel.Text = "";
            brandlabel.Text = "";
            modellabel.Text = "";
            pricelabel.Text = "";
            available.Text = "";
            int confirm = CustomerBL.Validate(custidtxt.Text, Nametxt.Text, adresstext.Text, phonetxt.Text);
            if (confirm == 1)
            {
                regnomlabel.Text = "Please fill this";
                return false;
            }
            else if (confirm == 2)
            {
                brandlabel.Text = "Please fill this";
                return false;
            }
            else if (confirm == 3)
            {
                modellabel.Text = "Please fill this";
                return false;
            }
            else if (confirm == 4)
            {
                pricelabel.Text = "Please fill this";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cleartextboxes()
        {
            custidtxt.Text = "";
            adresstext.Text = "";
            Nametxt.Text = "";
            phonetxt.Text = "";
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerDL.ShowDataInGridView(ref CustomerDataGridView);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            bool ok = Validation();
            if (ok)
            {
                try
                {
                    CustomerDL.AddCustomer(custidtxt.Text, Nametxt.Text, adresstext.Text, phonetxt.Text);
                    CustomerDL.ShowDataInGridView(ref CustomerDataGridView);
                    cleartextboxes();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Registration number already exists. Please enter a different one.", "Duplicate Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while adding the car record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    CustomerDL.cloaseconnection();
                }

            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (custidtxt.Text=="" || Nametxt.Text==""|| adresstext.Text==""| phonetxt.Text=="")
            {
                MessageBox.Show("Fill All Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CustomerDL.Updatecustomer(custidtxt.Text, Nametxt.Text, adresstext.Text, phonetxt.Text);
                CustomerDL.ShowDataInGridView(ref CustomerDataGridView);
                cleartextboxes();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (custidtxt.Text == "" || Nametxt.Text == "" || adresstext.Text == "" | phonetxt.Text == "")
            {
                MessageBox.Show("Fill All Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CustomerDL.DeleteCustomer(custidtxt.Text);
                CustomerDL.ShowDataInGridView(ref CustomerDataGridView);
                cleartextboxes();
            }
        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            custidtxt.Text = CustomerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Nametxt.Text = CustomerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            adresstext.Text = CustomerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            phonetxt.Text = CustomerDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            custidtxt.Text = "";
            Nametxt.Text = "";
            adresstext.Text = "";
            phonetxt.Text = "";
        }
    }
}
