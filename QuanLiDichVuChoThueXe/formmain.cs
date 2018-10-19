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
    public partial class formmain : Form
    {
        public formmain()
        {
            InitializeComponent();
        }

        private void btnds_Click(object sender, EventArgs e)
        {
            danhsachthuexe ds = new danhsachthuexe();
            this.Hide();
            ds.Show();
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            searching search = new searching();
            this.Hide(); search.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phieuthue phieu = new phieuthue();
            this.Hide(); phieu.Show();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thanhtoan tinh = new thanhtoan();
            this.Hide(); tinh.Show();
         
        }
    }
}
