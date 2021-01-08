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
    public partial class frmPhongMay : Form
    {
        BindingSource bsPH;
        IEnumerable<tblPhonghoc> listPH;
        clsPhongHoc p;
        public frmPhongMay()
        {
            InitializeComponent();
            p = new clsPhongHoc();
            bsPH = new BindingSource();
        }
       
        private void frmPhongMay_Load(object sender, EventArgs e)
        {
            listPH = p.GetAllPhongHoc();
            bsPH.DataSource = listPH;//buoc 1
            dgrPhongHoc.DataSource = bsPH;// buoc 2
            bindingNavigatorPhongHoc.BindingSource = bsPH;// buoc 3
            FormatLuoi(dgrPhongHoc);
        }
        void FormatLuoi(DataGridView dgr)
        {

            dgr.Columns["msPhong"].HeaderText = "Mã phòng";
            dgr.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgr.Columns["TenPhong"].Width = 200;
            dgr.Columns["ToaNha"].HeaderText = "Tòa Nhà";
            dgr.Columns["TangLau"].HeaderText = "Tầng Lầu";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dgrPhongHoc.EndEdit();
            p.LuuTru();
            this.DialogResult = DialogResult.OK;
        }

        private void frmPhongMay_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgrPhongHoc.EndEdit();
            p.LuuTru();
            this.DialogResult = DialogResult.OK;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }
    }
}
