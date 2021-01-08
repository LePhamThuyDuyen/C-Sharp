using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQThucHanhComputer
{
    public partial class frmDuLieuHonLoan : Form
    {
        string strMaPhong = "";
        clsHonLoan hLoan;
        public frmDuLieuHonLoan()
        {
            InitializeComponent();
        }
        public frmDuLieuHonLoan(string strMa)// thêm vào
        {
            strMaPhong = strMa;
            InitializeComponent();
            this.Text = "Bạn vừa truyền vào " + strMa;
            btnTheoMaPhong.Text = "Theo mã " + strMa;
        }
        private void frmDuLieuHonLoan_Load(object sender, EventArgs e)
        {
            hLoan = new clsHonLoan();
            dgrHonLoan.DataSource = hLoan.GetMayTinhPhongHocHonLoan();
        }

        private void btnTheoMaPhong_Click(object sender, EventArgs e)
        {
            dgrHonLoan.DataSource = hLoan.GetMayTinhPhongHocHonLoanTheoPhong(strMaPhong);
        }

        private void btnOrderCoMa_Click(object sender, EventArgs e)
        {
            dgrHonLoan.DataSource = hLoan.GetOrderMayTinhPhongHocHonLoanTheoPhong(strMaPhong);
        }

        private void btnCPUTuDau_Click(object sender, EventArgs e)
        {
            string strCPUTenDau= txtGiaTri.Text ;
            dgrHonLoan.DataSource = hLoan.GetTenDauMayTinhPhongHocHonLoan(strCPUTenDau);
            
        }

        private void btnCPUTuCuoi_Click(object sender, EventArgs e)
        {
            string strCPUTenCuoi = txtGiaTri.Text;
            dgrHonLoan.DataSource = hLoan.GetTenCuoiMayTinhPhongHocHonLoan(strCPUTenCuoi);
        }

        private void cbuChuaDau_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCPUCoChua_Click(object sender, EventArgs e)
        {
            string strCPUCoChua = txtGiaTri.Text;
            MessageBox.Show("cuoi:" + strCPUCoChua.LastWordCuaTui() + ":aa");
            dgrHonLoan.DataSource = hLoan.GetCoChuaMayTinhPhongHocHonLoan(strCPUCoChua);
            
        }

        private void btncpuChuaDau_Click(object sender, EventArgs e)
        {
            string strCPUchuaDau = txtGiaTri.Text;
            dgrHonLoan.DataSource = hLoan.GetChuaDauMayTinhPhongHocHonLoan(strCPUchuaDau);
        }
    }
}
