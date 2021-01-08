using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQThucHanhComputer
{
  public   class clsPhongHoc:clsKetNoi
    {
        qlComputerDataContext dt;

        public clsPhongHoc()
        {
            dt = getDatacontex();
        }
        //lay nguyen bang Phong hoc
        public IEnumerable<tblPhonghoc> GetAllPhongHoc()
        {
            IEnumerable<tblPhonghoc> q = from n in dt.tblPhonghocs
                                         select n;
            return q;
        }
        public int LuuTru()
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
               
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi cập nhật " + ex.Message);

            }
        }
    }
}
