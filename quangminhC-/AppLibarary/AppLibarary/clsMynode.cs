using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibarary
{
    class clsMynode 
    {
        private string myBookShelftID;

        public clsMynode()
        {

        }
        public string MyBookShelftID
        {
            get
            {
                return myBookShelftID;
            }

            set
            {
                myBookShelftID = value;
            }
        }
    }
}
