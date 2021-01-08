using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibarary
{
    class clsLogin
    {
        string user;
        string pass;

        public clsLogin() { }

        public clsLogin(string user, string pass) {
            this.user = user;
            this.pass = pass;
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

    }
}
