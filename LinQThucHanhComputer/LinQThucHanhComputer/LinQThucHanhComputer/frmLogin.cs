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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int dem = 0;
       public   clsDangNhap DangNhap;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //thoa man ??
            if (txtName.Text.Trim().Length == 0 || txtPass.Text.Length == 0)
            {
                dem++;
                MessageBox.Show("???");
            }
            else if (txtName.Text.Equals("LanRung") && txtPass.Text.Trim().Equals("RungLan"))

            {
                DangNhap = new clsDangNhap(txtName.Text.Trim(), txtPass.Text.Trim());
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                dem++;
                MessageBox.Show("???");
            }
            if (dem == 3)
            {
                MessageBox.Show("over lần???");
                this.Close();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
