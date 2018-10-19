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
    public partial class thanhtoan : Form
    {

        string tenkh, cmnd, songaymuon, dongiangay, maphieu, ngaylapphieu;
        int songay, dongia, count = 0;

        public thanhtoan()
        {
            InitializeComponent();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            formmain main = new formmain();
            main.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (count == 1)
            {
                
                songaymuon = dataGridView2.Rows[0].Cells[5].Value.ToString();
                dongiangay = dataGridView2.Rows[0].Cells[7].Value.ToString();
                maphieu = dataGridView2.Rows[0].Cells[3].Value.ToString();
                tenkh = dataGridView2.Rows[0].Cells[0].Value.ToString();
                cmnd = dataGridView2.Rows[0].Cells[1].Value.ToString();
                ngaylapphieu = dataGridView2.Rows[0].Cells[4].Value.ToString();
                songay = int.Parse(songaymuon);
                dongia = int.Parse(dongiangay);
            }
            if (count ==2)
            {
                
                songaymuon = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                dongiangay = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                maphieu = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                tenkh = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                cmnd = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                ngaylapphieu = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                songay = int.Parse(songaymuon);
                dongia = int.Parse(dongiangay);
            }
        }

        QL_ThuexeotoEntities conectdb = new QL_ThuexeotoEntities();
        
        private void thanhtoan_Load(object sender, EventArgs e)
        {
            var ds = from tt in conectdb.tbl_PHIEUTHUE
                     select tt;
            dataGridView1.DataSource = ds.ToList();
            dataGridView2.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            var ds = (from tt in conectdb.tbl_THONGTINXE
                      join pt in conectdb.tbl_PHIEUTHUE on tt.SoXe equals pt.SoXe
                      join kh in conectdb.tbl_KHACHHANG on pt.MaKH equals kh.MaKH
                      select new { kh.TenKH, kh.CMND, pt.MaKH, pt.MaPhieu, pt.NgayLapPhieu, pt.SoNgayMuon, tt.TenXe, tt.DonGiaNgay }).Where
                      (p => p.MaKH.Equals(txtkt.Text));
            dataGridView2.DataSource = ds.ToList();            
            dataGridView2.Columns[0].Width= 150;
            if (ds.Count() == 1)
            {
                count = 1;              
            } 
            if(ds.Count()>1)
            {
                count = 2;                
            }
                                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbkh.Visible = true;
            lbcmnd.Visible = true;
            lbpbd.Visible = true;
            lbtongtien.Visible = true;
            txtcmnd.Visible = true;
            txtnameKH.Visible = true;
            txtphibd.Visible = true;
            txttongtien.Visible = true;
            txtmaphieu.Visible = true;
            lbmaphieu.Visible = true;
            if (ngaylapphieu.Contains("02/14") || ngaylapphieu.Contains("04/30") || ngaylapphieu.Contains("12/22") || ngaylapphieu.Contains("05/01"))
            {
                txtcmnd.Text = cmnd;
                txtnameKH.Text = tenkh;
                txttongtien.Text = (dongia * songay).ToString();
            }
                if (count == 1)
            {
                txtcmnd.Text = cmnd;
                txtnameKH.Text = tenkh;
                txtmaphieu.Text = maphieu;
                txtphibd.Text = (dongia * 5 / 100).ToString();
                int phibd = Int32.Parse(txtphibd.Text);
                txttongtien.Text = (dongia * songay + phibd).ToString();
            }
            else if(count>1) 
            {
                txtcmnd.Text = cmnd;
                txtnameKH.Text = tenkh;
                txtmaphieu.Text = maphieu;
                txttongtien.Text = ((dongia * songay) - (dongia * 5 / 100)).ToString();

            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbl_PHIEUTHUE b = conectdb.tbl_PHIEUTHUE.Single(p => p.MaPhieu.Equals(a));
            txtkt.Text = b.MaKH;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thanhtoan_Load(sender,e);
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }
    }
}
