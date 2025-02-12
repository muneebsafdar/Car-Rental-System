using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class Form1 : Form
    {
        bool c = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Progressload.Start();
        }
        private void Progressload_Tick(object sender, EventArgs e)
        {

                progressvalue.Text = "Loading..." + (Progressbar.Value);
                if (Progressbar.Value == 100)
                {
                    Progressload.Stop();
                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }
            Progressbar.Value = Progressbar.Value + 1;

        }
    }
}
