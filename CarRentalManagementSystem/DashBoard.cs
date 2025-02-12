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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)

        {
            guna2Panel1.BackColor = Color.DeepPink;
            guna2Panel1.FillColor = Color.DeepPink;
            guna2Panel1.BorderRadius = 20;
            DashboardDL.Loaddashboard(ref label1, ref label32, ref label5,ref salethismoth);
        }
    }
}
