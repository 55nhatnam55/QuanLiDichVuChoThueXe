using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDichVuChoThueXe
{
    public partial class phieuthue : Form
    {
        public phieuthue()
        {
            InitializeComponent();
        }
        private QL_ThuexeotoEntities connectdb = new QL_ThuexeotoEntities();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var ds = from pt in connectdb.tbl_PHIEUTHUE
                      select pt;
            dataGridView1.DataSource = ds.ToList();

            dataGridView1.Columns[0].HeaderText = "Mã phiếu";
            dataGridView1.Columns[1].HeaderText = "Số xe";
            dataGridView1.Columns[2].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[3].HeaderText = "Ngày Lập Phiếu";
            dataGridView1.Columns[4].HeaderText = "Số ngày mướn";
     
        }

        void loaddb()
        {
            BindingList<tbl_PHIEUTHUE> db = new BindingList<tbl_PHIEUTHUE>(); // ket noi sql DataSource
            var connect = connectdb.tbl_PHIEUTHUE; // ket noi du lieu database
            db = new BindingList<tbl_PHIEUTHUE>(connect.ToList());
            dataGridView1.DataSource = db;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {


            if (Int32.Parse(txtsnm.Text) > 10 && kiemtra(txtsoxe.Text) == "xe máy" || ((Int32.Parse(txtsnm.Text) > 7 || Int32.Parse(txtsnm.Text)<1)  && kiemtraoto(txtsoxe.Text) != null) || kiemtrabanglai(txtsoxe.Text)==null)
            {
                MessageBox.Show("Không thêm được!!!");
            }
            else
            {
                try
                {

                    tbl_PHIEUTHUE hh = new tbl_PHIEUTHUE();
                    hh.MaKH = txtmkh.Text;
                    hh.MaPhieu = txtmaphieu.Text;
                    hh.NgayLapPhieu = DateTime.Parse(txtnlp.Text);
                    hh.SoNgayMuon = Int32.Parse(txtsnm.Text);
                    hh.SoXe = txtsoxe.Text.ToString();
                    connectdb.tbl_PHIEUTHUE.Add(hh);
                    connectdb.SaveChanges();
                    loaddb();
                    MessageBox.Show("đã thêm");
                }
                catch (Exception)
                {

                    MessageBox.Show("không thêm được");

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }
        void xoa()
        {
            try
            {
                string maphieu = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbl_PHIEUTHUE xe = connectdb.tbl_PHIEUTHUE.Single(p => p.MaPhieu.Equals(maphieu));                            
                connectdb.tbl_PHIEUTHUE.Remove(xe);               
                connectdb.SaveChanges();
                loaddb();
                MessageBox.Show("Da xoa");
            }
            catch (Exception)
            {

                MessageBox.Show("khong xóa được");

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maphieu = dataGridView1.CurrentRow.Cells[0].Value.ToString();         
            tbl_PHIEUTHUE hh = connectdb.tbl_PHIEUTHUE.Single(p => p.MaPhieu.Equals(maphieu));         
            txtmaphieu.Text = hh.MaPhieu;
            txtmkh.Text = hh.MaKH;
            txtnlp.Text = hh.NgayLapPhieu.ToString();
            txtsnm.Text = hh.SoNgayMuon.ToString();
            txtsoxe.Text = hh.SoXe;          
        }

      private string kiemtra(string a)
        {
          tbl_THONGTINXE tt = connectdb.tbl_THONGTINXE.Single(p => p.SoXe.Equals(a));
          return tt.MaLoai;
        }
        private string kiemtraoto(string a)
        {
            tbl_THONGTINXE tt = connectdb.tbl_THONGTINXE.Single(p => p.SoXe.Equals(a));
            if(tt.MaLoai.Contains("chổ"))            
                return tt.MaLoai;
            return null;
            
        }
        private string kiemtrabanglai(string a)
        {
            tbl_THONGTINXE tt = connectdb.tbl_THONGTINXE.Single(p => p.SoXe.Equals(a));
            tbl_LOAIXE lx = connectdb.tbl_LOAIXE.Single(q => q.MaLoai.Equals(tt.MaLoai));
            tbl_BANGLAI bl = connectdb.tbl_BANGLAI.Single(r => r.LoaiXe.Equals(lx.MaLoai));
            tbl_KHACHHANG kh = connectdb.tbl_KHACHHANG.Single(e => e.MaKH.Equals(txtmkh.Text));
            if (kh.BangLai == bl.YeuCauBangLai)
                return bl.YeuCauBangLai;
            return null;
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            formmain main = new formmain();
            main.Show();
        }
    }
}
