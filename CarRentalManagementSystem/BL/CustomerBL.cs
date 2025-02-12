using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    internal class CustomerBL
    {
        static public int Validate(string id, string name, string adress, string phone)
        {
            int confirm = 0;
            if (id == "")
            {
                confirm = 1;
                return confirm;
            }
            else if (name == "")
            {
                confirm = 2;
                return confirm;
            }
            else if (adress == "")
            {
                confirm = 3;
                return confirm;
            }
            else if (phone == "")
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
