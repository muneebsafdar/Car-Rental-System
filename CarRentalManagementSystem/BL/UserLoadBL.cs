using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    internal class UserLoadBL
    {
        static public int Validate(string id, string user, string pass)
        {
            int confirm = 0;
            if (id=="")
            {
                confirm = 1 ;
                return confirm;
            }else if (user=="")
            {
                confirm = 2;
                return confirm;
            }
            else if (pass=="")
            {
                confirm = 3;
                return confirm;
            }
            else
            {
                return confirm;
            }
        }
    }
}
