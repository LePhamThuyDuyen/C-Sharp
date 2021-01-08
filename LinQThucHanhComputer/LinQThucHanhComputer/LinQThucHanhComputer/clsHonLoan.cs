using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQThucHanhComputer
{
    class clsHonLoan:clsKetNoi
    {
        qlComputerDataContext dt;
        public clsHonLoan()
        {
            dt = getDatacontex();
        }
        public IEnumerable<dynamic> GetMayTinhPhongHocHonLoan()
        {
           
              var  q = from n in dt.tblPhonghocs
                       join x in dt.tblMaytinhs
                       on n.msPhong equals x.msPhong
                    select new {aaaChuYTen=n.tenPhong, x.msMay, x.Monitor, x.CPU };
            //aaaChuYTen tự đặt tên mới sau này phải theo tên này
            return q;
        }
        public IEnumerable<dynamic> GetTenDauMayTinhPhongHocHonLoan( string strTenDau)
        {
            //Becasue EF can't translate that extension method to SQL.
            //Simplest way to fix it is to shift to Linq-to-Objects using AsEnumerable()
            //chú ý AsEnumerable()
            var q = from n in dt.tblPhonghocs.AsEnumerable()
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong 
                    where x.CPU.FirstWord().Equals(strTenDau)
                    select  new { n.tenPhong, x.msMay, x.Monitor, x.CPU };
            return q.ToList();
        }
        public IEnumerable<dynamic> GetTenCuoiMayTinhPhongHocHonLoan(string strTenCuoi)
        {

            var q = from n in dt.tblPhonghocs.AsEnumerable()
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong
                    where x.CPU.LastWordCuaTui().Equals(strTenCuoi)
                    select new { n.tenPhong, x.msMay, x.Monitor, x.CPU };
            return q;
        }
        public IEnumerable<dynamic> GetMayTinhPhongHocHonLoanTheoPhong(string strMaPhong)
        {

            var q = from n in dt.tblPhonghocs
                    where n.msPhong == strMaPhong
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong
                  
                    select new { n.tenPhong, x.msMay, x.Monitor, x.CPU }
                    ;
            return q;
        }
        public IEnumerable<dynamic> GetOrderMayTinhPhongHocHonLoanTheoPhong(string strMaPhong)
        {

            var q = from n in dt.tblPhonghocs
                    where n.msPhong == strMaPhong
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong
                    orderby x.Monitor
                    select new { n.tenPhong, x.msMay, x.Monitor, x.CPU }
                    ;
            return q;
        }
        public IEnumerable<dynamic> GetChuaDauMayTinhPhongHocHonLoan(string strTenStart)
        {

            var q = from n in dt.tblPhonghocs
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong
                    where x.CPU.StartsWith(strTenStart)
                    select new { n.tenPhong, x.msMay, x.Monitor, x.CPU };
            return q;
        }
        public IEnumerable<dynamic> GetCoChuaMayTinhPhongHocHonLoan(string strChua)
        {

            var q = from n in dt.tblPhonghocs
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong
                    where x.CPU.Contains(strChua)
                    select new { n.tenPhong, x.msMay, x.Monitor, x.CPU };
            return q;
        }
    }
}
