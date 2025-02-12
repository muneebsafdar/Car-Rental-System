using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.BL
{
    internal class RentalBL
    {
        static public int Validate(string carreg, string custid, string custtname, string price)
        {
            int confirm = 0;
            if (carreg == "" )
            {
                confirm = 1;
                return confirm;
            }
            else if (custid == "")
            {
                confirm = 2;
                return confirm;
            }
            else if (custtname == "")
            {
                confirm = 3;
                return confirm;
            }
            else if (price == "")
            {
                confirm = 4;
                return confirm;
            }
            else
            {
                return confirm;
            }
        }
    }
}
