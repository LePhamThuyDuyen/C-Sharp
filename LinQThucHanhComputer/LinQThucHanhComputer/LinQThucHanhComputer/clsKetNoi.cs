using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQThucHanhComputer
{
   public   class clsKetNoi
    {
        qlComputerDataContext dt;
        public qlComputerDataContext getDatacontex()
        {
            string str = @"Data Source=DESKTOP-5UEUS4J\LEDUYEN;Initial Catalog=ComputerManager;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            dt = new qlComputerDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
