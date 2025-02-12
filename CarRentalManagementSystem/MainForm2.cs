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
    public partial class MainForm2 : Form
    {
        MasterForm m = new MasterForm();
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            m.WhichformtoOpen(1);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            m.WhichformtoOpen(2);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            m.WhichformtoOpen(3);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            m.WhichformtoOpen(4);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            m.WhichformtoOpen(5);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            m.WhichformtoOpen(6);
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
