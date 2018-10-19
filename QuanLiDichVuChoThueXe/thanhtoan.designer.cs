namespace QuanLiDichVuChoThueXe
{
    partial class thanhtoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtkt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbkh = new System.Windows.Forms.Label();
            this.txtnameKH = new System.Windows.Forms.TextBox();
            this.lbcmnd = new System.Windows.Forms.Label();
            this.lbpbd = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtphibd = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.lbmaphieu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkt
            // 
            this.txtkt.Location = new System.Drawing.Point(0, 37);
            this.txtkt.Name = "txtkt";
            this.txtkt.Size = new System.Drawing.Size(163, 20);
            this.txtkt.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Location = new System.Drawing.Point(0, 73);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(75, 40);
            this.btnkiemtra.TabIndex = 2;
            this.btnkiemtra.Text = "Kiểm Tra";
            this.btnkiemtra.UseVisualStyleBackColor = true;
            this.btnkiemtra.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xem danh sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lập Phiếu Thanh Toán";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbkh
            // 
            this.lbkh.AutoSize = true;
            this.lbkh.Location = new System.Drawing.Point(402, 31);
            this.lbkh.Name = "lbkh";
            this.lbkh.Size = new System.Drawing.Size(73, 13);
            this.lbkh.TabIndex = 5;
            this.lbkh.Text = "Khách Hàng :";
            this.lbkh.Visible = false;
            // 
            // txtnameKH
            // 
            this.txtnameKH.Location = new System.Drawing.Point(511, 28);
            this.txtnameKH.Name = "txtnameKH";
            this.txtnameKH.ReadOnly = true;
            this.txtnameKH.Size = new System.Drawing.Size(163, 20);
            this.txtnameKH.TabIndex = 6;
            this.txtnameKH.Visible = false;
            // 
            // lbcmnd
            // 
            this.lbcmnd.AutoSize = true;
            this.lbcmnd.Location = new System.Drawing.Point(402, 73);
            this.lbcmnd.Name = "lbcmnd";
            this.lbcmnd.Size = new System.Drawing.Size(45, 13);
            this.lbcmnd.TabIndex = 7;
            this.lbcmnd.Text = "CMND :";
            this.lbcmnd.Visible = false;
            // 
            // lbpbd
            // 
            this.lbpbd.AutoSize = true;
            this.lbpbd.Location = new System.Drawing.Point(402, 144);
            this.lbpbd.Name = "lbpbd";
            this.lbpbd.Size = new System.Drawing.Size(87, 13);
            this.lbpbd.TabIndex = 8;
            this.lbpbd.Text = "Phí Bảo Dưỡng :";
            this.lbpbd.Visible = false;
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(402, 184);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(62, 13);
            this.lbtongtien.TabIndex = 9;
            this.lbtongtien.Text = "Tổng Tiền :";
            this.lbtongtien.Visible = false;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(511, 66);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.ReadOnly = true;
            this.txtcmnd.Size = new System.Drawing.Size(163, 20);
            this.txtcmnd.TabIndex = 10;
            this.txtcmnd.Visible = false;
            // 
            // txtphibd
            // 
            this.txtphibd.Location = new System.Drawing.Point(511, 141);
            this.txtphibd.Name = "txtphibd";
            this.txtphibd.ReadOnly = true;
            this.txtphibd.Size = new System.Drawing.Size(163, 20);
            this.txtphibd.TabIndex = 11;
            this.txtphibd.Visible = false;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(511, 177);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(163, 20);
            this.txttongtien.TabIndex = 12;
            this.txttongtien.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 213);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(869, 188);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(511, 103);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.ReadOnly = true;
            this.txtmaphieu.Size = new System.Drawing.Size(163, 20);
            this.txtmaphieu.TabIndex = 16;
            this.txtmaphieu.Visible = false;
            // 
            // lbmaphieu
            // 
            this.lbmaphieu.AutoSize = true;
            this.lbmaphieu.Location = new System.Drawing.Point(402, 106);
            this.lbmaphieu.Name = "lbmaphieu";
            this.lbmaphieu.Size = new System.Drawing.Size(58, 13);
            this.lbmaphieu.TabIndex = 15;
            this.lbmaphieu.Text = "Mã Phiếu :";
            this.lbmaphieu.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 363);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtmaphieu);
            this.Controls.Add(this.lbmaphieu);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.txtphibd);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.lbtongtien);
            this.Controls.Add(this.lbpbd);
            this.Controls.Add(this.lbcmnd);
            this.Controls.Add(this.txtnameKH);
            this.Controls.Add(this.lbkh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtkt);
            this.Name = "thanhtoan";
            this.Text = "Lập phiếu thanh toán";
            this.Load += new System.EventHandler(this.thanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbkh;
        private System.Windows.Forms.TextBox txtnameKH;
        private System.Windows.Forms.Label lbcmnd;
        private System.Windows.Forms.Label lbpbd;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txtphibd;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label lbmaphieu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
    }
}