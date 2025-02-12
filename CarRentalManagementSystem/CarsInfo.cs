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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class CarsInfo : Form
    {
        //CarsInfoBL CarsInfoBL = new CarsInfoBL();
        public CarsInfo()
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
            int confirm = CarsInfoBL.Validate(regnotext.Text, brandtext.Text, modeltext.Text, pricetext.Text, availcombo.Text);
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
            else if (confirm == 5)
            {
                available.Text = "Please fill this";
                return false;
            }
            else
            {
                return true;
            }
        }
        private void cleartextboxes()
        {
            regnotext.Text = "";
            brandtext.Text = "";
            modeltext.Text = "";
            pricetext.Text = "";
            availcombo.Text = null;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            bool ok = Validation();
            if (ok)
            {
                try
                {
                    CarsInfoDL.AddCarsInfo(regnotext.Text, brandtext.Text, modeltext.Text, pricetext.Text, availcombo.SelectedItem.ToString());
                    CarsInfoDL.ShowDataInGridView(ref CarsDataGridView);
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
                    CarsInfoDL.cloaseconnection();
                }
            }
        }

        private void CarsInfo_Load(object sender, EventArgs e)
        {
            CarsInfoDL.ShowDataInGridView(ref CarsDataGridView);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (regnotext.Text=="" || brandtext.Text=="" || modeltext.Text=="" || pricetext.Text=="" || availcombo.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Fill All Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CarsInfoDL.DeleteCar(regnotext.Text);
                CarsInfoDL.ShowDataInGridView(ref CarsDataGridView);
                cleartextboxes();
            }
            
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (regnotext.Text == "" || brandtext.Text == "" || modeltext.Text == "" || pricetext.Text == "" || availcombo.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Fill All Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CarsInfoDL.upadte(regnotext.Text, brandtext.Text, modeltext.Text, pricetext.Text, availcombo.SelectedItem.ToString());
                CarsInfoDL.ShowDataInGridView(ref CarsDataGridView);
                cleartextboxes();
            }
        }

        private void CarsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            regnotext.Text = CarsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            brandtext.Text = CarsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            modeltext.Text = CarsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            pricetext.Text = CarsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            availcombo.Text = CarsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void updatecarsDatagrid(object sender, EventArgs e)
        {
            if (availableoption.Text== "Available")
            {
                CarsInfoDL.updategridOnOption("Yes", ref CarsDataGridView);
            }
            else if(availableoption.Text == "Rented")
            {
                CarsInfoDL.updategridOnOption("No",ref CarsDataGridView);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CarsInfoDL.ShowDataInGridView(ref CarsDataGridView);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            regnotext.Text = "";
            brandtext.Text = "";
            modeltext.Text = "";
            pricetext.Text = "";
            availcombo.SelectedIndex = -1;
        }

        private void checkingPriceValid(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                // Check if the key pressed is a digit (0-9)
                if (!char.IsDigit(e.KeyChar))
                {
                    // If the key is not a digit, handle the event so the character is not entered
                    e.Handled = true;
                }
            }
        }
    }
}
