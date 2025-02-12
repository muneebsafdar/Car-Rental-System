using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1
{
    public partial class Rantal : Form
    {
        public Rantal()
        {
            InitializeComponent();
        }

        string id = "";
        private void Rantal_Load(object sender, EventArgs e)
        {
            RentalDL.fillcarcombo(ref carregcombo);
            RentalDL.fillcustcombo(ref custidcombo);
            RentalDL.ShowDataInGridView(ref Carsrentgridview);
            Carsrentgridview.Columns[0].Width = 70;

        }
        private bool Validation()
        {
            lblcarreg.Text = "";
            custidlbl.Text = "";
            namelbl.Text = "";
            pricelbl.Text = "";
            int confirm = RentalBL.Validate(carregcombo.Text, custidcombo.Text, nametxtx.Text, pricetxt.Text);
            if (confirm == 1)
            {
                lblcarreg.Text = "Please fill this";
                return false;
            }
            else if (confirm == 2)
            {
                custidlbl.Text = "Please fill this";
                return false;
            }
            else if (confirm == 3)
            {
                namelbl.Text = "Please fill this";
                return false;
            }
            else if (confirm == 4)
            {
                pricelbl.Text = "Please fill this";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            bool ok = Validation();
            if (ok)
            {
                RentalDL.AddRental(carregcombo.Text, nametxtx.Text, Rentadate, retuenadate, pricetxt.Text);
                RentalDL.ShowDataInGridView(ref Carsrentgridview);
                clear();
            }
        }


        private void Carsrentgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addbtn.Enabled = true;
            carregcombo.Enabled = true;
            carregcombo.Items.Clear();
            RentalDL.fillcarcomboForDelete(ref carregcombo);

            id = Carsrentgridview.SelectedRows[0].Cells[0].Value.ToString();
            carregcombo.Text = Carsrentgridview.SelectedRows[0].Cells[1].Value.ToString();
            nametxtx.Text = Carsrentgridview.SelectedRows[0].Cells[2].Value.ToString();
            Rentadate.Value = Convert.ToDateTime(Carsrentgridview.SelectedRows[0].Cells[3].Value);
            retuenadate.Value = Convert.ToDateTime(Carsrentgridview.SelectedRows[0].Cells[5].Value);
            pricetxt.Text = Carsrentgridview.SelectedRows[0].Cells[4].Value.ToString();

            addbtn.Enabled = false;
            carregcombo.Enabled = false;
            custidcombo.Enabled = false;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (carregcombo.Text == "" || nametxtx.Text == "" || pricetxt.Text == "")
            {
                MessageBox.Show("Fill All Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                RentalDL.DeleteRental(id, carregcombo.Text);
                RentalDL.ShowDataInGridView(ref Carsrentgridview);
                clear();
                addbtn.Enabled = true;
                carregcombo.Enabled = true;
                custidcombo.Enabled = true;
            }

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (carregcombo.Text==""|| nametxtx.Text==""|| pricetxt.Text=="")
            {
                MessageBox.Show("Fill All Fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                RentalDL.UpdateRental(id, carregcombo.Text, nametxtx.Text, Rentadate, retuenadate, pricetxt.Text);
                carregcombo.Items.Clear();
                RentalDL.ShowDataInGridView(ref Carsrentgridview);
                RentalDL.fillcarcombo(ref carregcombo);
                addbtn.Enabled = true;
                carregcombo.Enabled = true;
                custidcombo.Enabled = true;
                clear();
            }
           

        }

        private void ChangeNameOfCust(object sender, EventArgs e)
        {
            RentalDL.ShowCustname(ref nametxtx, custidcombo.Text);
        }

        private void clear()
        {
            carregcombo.Items.Clear();
            custidcombo.Items.Clear();
            RentalDL.fillcarcombo(ref carregcombo);
            RentalDL.fillcustcombo(ref custidcombo);
            nametxtx.Text = "";
            pricetxt.Text = "";
        }
        private void label7_Click(object sender, EventArgs e)
        {
            addbtn.Enabled = true;
            carregcombo.Enabled = true;
            custidcombo.Enabled = true;
            clear();
        }

        private void priceValid(object sender, KeyPressEventArgs e)
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
