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
    public partial class frmQLComputer : Form
    {
        public frmQLComputer()
        {
            InitializeComponent();
        }
        clsPhongHoc p;
        clsMayTinh m;
        TreeNode nGoc;
        private void frmQLComputer_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            lvwDSMay.LargeImageList = imgLon;
            lvwDSMay.SmallImageList = imgNho;
            TaoTieuDeCot(lvwDSMay);
            nGoc = new TreeNode("Danh Sach Phong");
            p = new clsPhongHoc();
            m = new clsMayTinh();
            trePhong.ImageList = imgTree;//co 2 hinh
            IEnumerable<tblPhonghoc> ds = p.GetAllPhongHoc();
            LoadPhongToTree(trePhong, ds);
        }
        void TaoTieuDeCot(ListView lvw)
        {
            //tao cot
            lvw.Columns.Add("Ma máy", 100);
            lvw.Columns.Add("CPU", 100);
            lvw.Columns.Add("HardDisk", 200);
            lvw.Columns.Add("Bộ nhớ RAM", 200);
            lvw.Columns.Add("VGa", 100);
            lvw.Columns.Add("Monitor", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

        }
        void LoadPhongToTree(TreeView tre, IEnumerable<tblPhonghoc> dsP)
        {
            tre.Nodes.Clear();
            nGoc.Nodes.Clear();//xoa cac con
            TreeNode nCon;
            foreach (tblPhonghoc p in dsP)
            {
                nCon = new TreeNode();
                nCon.Text = p.tenPhong;
                nCon.ImageIndex = 0;// hing chua chon va node
                nCon.SelectedImageIndex = 1;// hinh dang chon node
                nCon.Tag = p.msPhong;
                nGoc.Nodes.Add(nCon);
            }
            //goc co nhieu con
            tre.Nodes.Add(nGoc);
            tre.ExpandAll();//bung cac con ra

        }

        private void trePhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IEnumerable<tblMaytinh> dsMay;
            string strMaPhong = "";
            if (trePhong.SelectedNode != null)//co chon
            {
                if (trePhong.SelectedNode.Level == 0)//goc
                    strMaPhong = "";
                else
                {
                    strMaPhong = trePhong.SelectedNode.Tag.ToString();

                }
                dsMay = m.GetMayTinhThuocPhong(strMaPhong);
                //dsMay = m.GetMayTinhThuocPhongLambda(strMaPhong);

                LoadMayToListView(lvwDSMay, dsMay);
            }

        }
        void LoadMayToListView(ListView lvw, IEnumerable<tblMaytinh> dsMay)
        {
            lvw.Items.Clear();
            ListViewItem ItemMayTinh;
            foreach (tblMaytinh mt in dsMay)
            {
                ItemMayTinh = GreateItem(mt);
                lvw.Items.Add(ItemMayTinh);
            }
        }
        ListViewItem GreateItem(tblMaytinh mt)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(mt.msMay);
            lvwItem.SubItems.Add(mt.CPU);
            lvwItem.SubItems.Add(mt.HardDisk);
            lvwItem.SubItems.Add(mt.RAM);
            lvwItem.SubItems.Add(mt.VGA);
            lvwItem.SubItems.Add(mt.Monitor);
            lvwItem.Tag = mt;//nhet vao de su dung muc dich khac (mu dich 1)
            lvwItem.ImageIndex = 0;
            return lvwItem;
            ;
        }

        private void lvwDSMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblMaytinh mt = null;
            if (lvwDSMay.SelectedItems.Count > 0)//co chon
            {
                mt = (tblMaytinh)lvwDSMay.SelectedItems[0].Tag;
                MayTinhToTextBox(mt);
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }
        void MayTinhToTextBox(tblMaytinh mt)
        {
            txtMsMay.Text = mt.msMay;
            txtCPU.Text = mt.CPU;
            txtHard.Text = mt.HardDisk;
            txtRam.Text = mt.RAM;
            txtVGA.Text = mt.VGA;
            txtMonitor.Text = mt.Monitor;
            txtPhong.Text = mt.msPhong;

        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDSMay.View = View.LargeIcon;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDSMay.View = View.SmallIcon;
        }

        private void menuDetail_Click(object sender, EventArgs e)
        {
            lvwDSMay.View = View.Details;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemAutocomlet frm = new frmTimKiemAutocomlet();
            frm.ShowDialog();
            // frm.Show();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {

            frmPhongMay frm = new LinQThucHanhComputer.frmPhongMay();
            //frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<tblPhonghoc> dsP = p.GetAllPhongHoc();
                LoadPhongToTree(trePhong, dsP);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //txtCPU.Clear();//xoa trang de nhap moi
            //txtMsMay.Clear();
            //sv tu lam tiep
            if (!btnThem.Text.Equals("Hủy Thêm"))
            {
                btnLuu.Enabled = true;
                btnThem.Text = "Hủy Thêm";
            }
            else
            {
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";

            }
        }
        tblMaytinh TaoMayTinh()
        {
            //Buoc 1 
            tblMaytinh mt = new tblMaytinh();
            mt.msMay = txtMsMay.Text;
            mt.CPU = txtCPU.Text;
            mt.HardDisk = txtHard.Text;
            mt.Monitor = txtMonitor.Text;
            mt.RAM = txtRam.Text;
            mt.VGA = txtVGA.Text;
            mt.msPhong = trePhong.SelectedNode.Tag.ToString();
            return mt;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (trePhong.SelectedNode.Level == 1)
            {
                tblMaytinh mt = TaoMayTinh();
                m.insertMayTinh(mt);
                IEnumerable<tblMaytinh> dsMay = m.GetMayTinhThuocPhong(trePhong.SelectedNode.Tag.ToString());
                LoadMayToListView(lvwDSMay, dsMay);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            tblMaytinh mt;
            int vitTriThuc;
            if (lvwDSMay.SelectedItems.Count > 0)//co chon
            {
                dlgHoiXoa = MessageBox.Show("Bạn chắc xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwDSMay.SelectedItems.Count; i++)
                    {
                        vitTriThuc = lvwDSMay.SelectedIndices[i];
                        mt = (tblMaytinh)lvwDSMay.Items[vitTriThuc].Tag;
                        m.deleteMayTinh(mt);
                    }
                    IEnumerable<tblMaytinh> dsMay = m.GetMayTinhThuocPhong(trePhong.SelectedNode.Tag.ToString());
                    LoadMayToListView(lvwDSMay, dsMay);
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tblMaytinh mt = TaoMayTinh();
            m.Sua(mt);
            //sửa xong load lại
            IEnumerable<tblMaytinh> dsMay = m.GetMayTinhThuocPhong(trePhong.SelectedNode.Tag.ToString());
            LoadMayToListView(lvwDSMay, dsMay);
            btnSua.Enabled = false;


        }

        private void btnTruyenDLHLoan_Click(object sender, EventArgs e)
        {
            if (trePhong.SelectedNode != null)
            {
                if (trePhong.SelectedNode.Level == 1)
                {
                    string strMaPhong = trePhong.SelectedNode.Tag.ToString();
                    frmDuLieuHonLoan frm = new frmDuLieuHonLoan(strMaPhong);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
        }

        private void txtCPU_Leave(object sender, EventArgs e)
        {
            string strCPU = txtCPU.Text;
            if (strCPU.FulNameCheckCuaTui() == false)
            {
                MessageBox.Show("??");
                txtCPU.SelectAll();
                txtCPU.Focus();
            }
        }

        private void txtCPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhong_Click(object sender, EventArgs e)
        {

        }
    }
}

