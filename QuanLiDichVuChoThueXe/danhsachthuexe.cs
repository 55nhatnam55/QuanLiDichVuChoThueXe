using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDichVuChoThueXe
{
    public partial class danhsachthuexe : Form
    {
        public danhsachthuexe()
        {
            InitializeComponent();
        }
        private QL_ThuexeotoEntities connectdb = new QL_ThuexeotoEntities();
        
        private void danhsachthuexe_Load(object sender, EventArgs e)
        {
            var query =from nv in connectdb.tbl_THONGTINXE                        
                       select nv ;//Where(p => p.TenXe.Contains(b.Trim()));
            dataGridView1.DataSource = query.ToList();
            dataGridView1.Columns[0].HeaderText = "Số xe";
            dataGridView1.Columns[1].HeaderText = "Mã Loại";
            dataGridView1.Columns[2].HeaderText = "Tên xe";
            dataGridView1.Columns[3].HeaderText = "Đơn giá ngày";
            dataGridView1.Columns[4].HeaderText = "Chủ xe";
            dataGridView1.Columns[5].HeaderText = "Năm sản xuất";
        }
        void loaddb()
        {
            
            BindingList<tbl_THONGTINXE> db = new BindingList<tbl_THONGTINXE>(); // ket noi sql DataSource
            var connect = connectdb.tbl_THONGTINXE; // ket noi du lieu database
            db = new BindingList<tbl_THONGTINXE>(connect.ToList());
            dataGridView1.DataSource = db;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string soxe = dataGridView1.CurrentRow.Cells[0].Value.ToString();// lay gia tri cell 0 trong bang dataGrid
            tbl_THONGTINXE hh = connectdb.tbl_THONGTINXE.Single(p => p.SoXe.Equals(soxe));// dieu kien Mahh = mahang get
            txtsoxe.Text = hh.SoXe;
            txtmaloai.Text = hh.MaLoai;
            txtchuxe.Text = hh.ChuXe;
            txtdongia.Text = hh.DonGiaNgay.ToString();
            txtnsx.Text = hh.NamSX.ToString();
            txttenxe.Text = hh.TenXe;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtnsx.Text) < 2005)
            {
                MessageBox.Show("không sửa được!");
            }
            try
            {
                string soxe = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbl_THONGTINXE hh = connectdb.tbl_THONGTINXE.Single(p => p.SoXe.Equals(soxe));
                if (txtmaloai.Text.Length != 0)
                {
                    hh.MaLoai = txtmaloai.Text;
                }
                hh.ChuXe = txtchuxe.Text;
                hh.DonGiaNgay = Int32.Parse(txtdongia.Text);
                hh.NamSX = int.Parse(txtnsx.Text);
                hh.TenXe = txttenxe.Text;
                hh.SoXe = txtsoxe.Text;
                connectdb.SaveChanges();
                loaddb();
                MessageBox.Show("Cap Nhat Thanh Cong!!!");
            }
            catch
            {
                MessageBox.Show("Chưa Cập Nhật!!!");

            }
        }
           private void xoa()
        {
            try
            {
                string soxe = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbl_THONGTINXE xe = connectdb.tbl_THONGTINXE.Single(p => p.SoXe.Equals(soxe));
                connectdb.tbl_THONGTINXE.Remove(xe);
                connectdb.SaveChanges();
                loaddb();
                MessageBox.Show("Da xoa");
            }
            catch (Exception)
            {

                MessageBox.Show("khong xóa được");

            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

       

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(int.Parse (txtnsx.Text)<2005)
            {
                MessageBox.Show("không thêm được!");
            }

            try
            {
                tbl_THONGTINXE hh = new tbl_THONGTINXE(); // tạo obj mới
                hh.SoXe = txtsoxe.Text.ToString();
                hh.MaLoai = txtmaloai.Text;
                hh.ChuXe = txtchuxe.Text;
                hh.DonGiaNgay = Int32.Parse(txtdongia.Text);
                hh.NamSX = int.Parse(txtnsx.Text);
                hh.TenXe = txttenxe.Text;
                connectdb.tbl_THONGTINXE.Add(hh);
                connectdb.SaveChanges();
                loaddb();
                MessageBox.Show("đã thêm");               
            }
            catch (Exception)
            {

                MessageBox.Show("không thêm được");

            }


        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            formmain main = new formmain();
            main.Show();
        }
    }
}
