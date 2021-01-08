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
    public partial class frmMainQLMayTinh : Form
    {
        public frmMainQLMayTinh()
        {
            InitializeComponent();
        }
        public frmMainQLMayTinh(clsDangNhap obj)
        {
            InitializeComponent();
            this.Text = "Ban vừa đăng nhập user " + obj.UserName + " và pass " + obj.PassWord;
        }
        private void frmMainQLMayTinh_Load(object sender, EventArgs e)
        {

        }
        bool KiemTraTonTaiForm(string frmTenForm)
        {
            //MdiParent.MdiChildren tap cac con
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frm))
                {
                    frm.Activate();//sang len
                    return true;
                }
            }
            return false;
        }
        private void mnuUngDungCapNhatMay_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmQLComputer") == false)
            {
                frmQLComputer frm = new frmQLComputer();
                frm.Name = "frmComputer";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
