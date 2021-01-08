using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQThucHanhComputer
{
    public class clsDangNhap
    {
        string userName, passWord;
        public clsDangNhap()
        {
        }
        public clsDangNhap(string strUser, string strPass)
        {
            UserName = strUser;
            PassWord = strPass;
        }
        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
    }
}
