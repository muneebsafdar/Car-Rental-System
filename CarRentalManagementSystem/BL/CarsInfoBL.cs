using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    internal class CarsInfoBL
    {
        static public int Validate(string reg, string brand, string model, string price, string avail)
        {
            int confirm = 0;
            if (reg == "")
            {
                confirm = 1;
                return confirm;
            }
            else if (brand == "")
            {
                confirm = 2;
                return confirm;
            }
            else if (model == "")
            {
                confirm = 3;
                return confirm;
            }
            else if (price == "")
            {
                confirm = 4;
                return confirm;
            }
            else if (avail == "")
            {
                confirm = 5;
                return confirm;
            }
            else
            {
                return confirm;
            }
        }
    }
}
