using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQThucHanhComputer
{
    class clsMayTinh : clsKetNoi
    {
        qlComputerDataContext dt;
        public clsMayTinh()
        {
            dt = getDatacontex();
        }
        //lay nguyen bang Phong hoc
        public IEnumerable<tblMaytinh> GetMayTinhThuocPhong(string strMaPhong)
        {
            IEnumerable<tblMaytinh> q;
            if (strMaPhong.Equals(""))//chon goc
                q = from n in dt.tblMaytinhs
                    select n;
            else
                q = from n in dt.tblMaytinhs
                    where n.msPhong.Equals(strMaPhong)
                    select n;


            return q;
        }
        public tblMaytinh checkIfExist(string strMaMay)
        {
            //tblMaytinh mttemp = dt.tblMaytinhs.Where(x => x.msMay == maMay).FirstOrDefault();
            tblMaytinh mttemp = (from n in dt.tblMaytinhs
                                 where n.msMay.Equals(strMaMay)
                                 select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

            // doi thanh  return mttemp;
        }
        public int insertMayTinh(tblMaytinh mt)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(mt.msMay) != null)// thay
                    return 0;
                else
                {
                    dt.tblMaytinhs.InsertOnSubmit(mt);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi không sửa được " + ex.Message);

            }
        }
        public bool Sua(tblMaytinh mtSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblMaytinh> tam = (from n in dt.tblMaytinhs
                                              where n.msMay == mtSua.msMay
                                              select n);
                //thầy mới sửa 4 field các ban có thể sửa thêm
                //riệng mã không sửa
                tam.First().CPU = mtSua.CPU;
                tam.First().HardDisk = mtSua.HardDisk;
                tam.First().RAM = mtSua.RAM;
                tam.First().VGA = mtSua.VGA;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi khong sửa duoc");

            }
        }

        public int deleteMayTinh(tblMaytinh mt)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(mt.msMay) != null)// thay
                {
                    dt.tblMaytinhs.DeleteOnSubmit(mt);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi không sửa được " + ex.Message);

            }
        }
        public List<tblMaytinh> GetMayTinhThuocPhongLambda(string maphonghoc)
        {
            var dsmaytinh = dt.tblMaytinhs.Where(x => x.msPhong == maphonghoc).ToList();
            List<tblMaytinh> ls = new List<tblMaytinh>();
            return dsmaytinh.ToList();
        }
    }
}
