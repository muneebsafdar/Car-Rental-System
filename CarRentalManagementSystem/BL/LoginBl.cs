using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.BL
{
    internal class LoginBl
    {
        public static int validate(string uid, string pass)
        {
            int checking = 0;
            if (uid == "")
            {
                checking = 1;
                return checking;
            }
            else if (pass == "")
            {
                checking = 2;
                return checking;
            }
            else if (LoginDL.userCheckLogin(uid, pass))
            {
                checking = 3;
                return checking;
            }else if(LoginDL.AdminCheckLogin(uid,pass))
            {
                checking = 4;
                return checking;
            }
            else
            {
                return 0;
            }
        }
    }


}
