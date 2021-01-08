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
    public partial class frmTimKiemAutocomlet : Form
    {
        public frmTimKiemAutocomlet()
        {
            InitializeComponent();
        }
        clsPhongHoc p;
        clsMayTinh m;
        private void frmTimKiemAutocomlet_Load(object sender, EventArgs e)
        {
            radTheoMa.Checked = true;
            p = new clsPhongHoc();
            m = new clsMayTinh();
            lvwDSMay.LargeImageList = imgLon;
            lvwDSMay.SmallImageList = imgNho;
            TaoTieuDeCot(lvwDSMay);
            IEnumerable<tblPhonghoc> dsP = p.GetAllPhongHoc();
            lstDSPhong.DisplayMember = "TenPhong";//ten field hien ra
            lstDSPhong.ValueMember = "msPhong";// ten field ma chon ten lay ma
            lstDSPhong.DataSource = dsP;// nguon du lieu
            txtDULieuTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDULieuTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        private void lstDSPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMaPhong;
            if (lstDSPhong.SelectedIndex >= 0)//co chon
            {
                strMaPhong = lstDSPhong.SelectedValue.ToString();
                IEnumerable<tblMaytinh> dsMay;

                dsMay = m.GetMayTinhThuocPhong(strMaPhong);
                LoadMayToListView(lvwDSMay, dsMay);
                XuLyHoTroAutocomlet();                               
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

        private void radTheoMa_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }
        void XuLyHoTroAutocomlet()
        {
            string strMaPhong;
            
            IEnumerable<tblMaytinh> dsMay;
            if (lstDSPhong.SelectedIndex >= 0)
            {
                strMaPhong = lstDSPhong.SelectedValue.ToString();
                dsMay = m.GetMayTinhThuocPhong(strMaPhong);
                txtDULieuTim.AutoCompleteCustomSource.Clear();
                if (radTheoMa.Checked)
                {
                    foreach (tblMaytinh mt in dsMay)
                    {
                        txtDULieuTim.AutoCompleteCustomSource.Add(mt.msMay);
                    }
                }
                else//theo CPU
                {
                    foreach (tblMaytinh mt in dsMay)
                    {
                        txtDULieuTim.AutoCompleteCustomSource.Add(mt.CPU);
                    }
                }
            }
        }

        private void radTheoCPU_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string strThongTinTim = txtDULieuTim.Text;
            int viTriTim = TimKiem(strThongTinTim);
            int viTriChonTruoc;
            //if(viTriTim!=-1)//tim thay
            if (viTriTim >= 0)
            {
                if (lvwDSMay.SelectedItems.Count > 0)
                {
                    viTriChonTruoc = lvwDSMay.SelectedIndices[0];
                    lvwDSMay.Items[viTriChonTruoc].Selected = false;
                }
                lvwDSMay.Items[viTriTim].Selected = true;
                lvwDSMay.Focus();
            }
        }
        int TimKiem(string strGiaTriTim)
        {
            tblMaytinh mt;
            for (int i = 0; i < lvwDSMay.Items.Count; i++)
            {
                mt = (tblMaytinh)lvwDSMay.Items[i].Tag;
                if (radTheoMa.Checked)
                {
                    if (mt.msMay.Equals(strGiaTriTim))
                        return i;
                }
                else
                {
                    if (mt.CPU.Equals(strGiaTriTim))
                        return i;
                }
            }
            return -1;
        }

        private void txtDULieuTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
