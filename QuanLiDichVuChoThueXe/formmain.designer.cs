namespace QuanLiDichVuChoThueXe
{
    partial class formmain
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
            this.btnds = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnds
            // 
            this.btnds.Location = new System.Drawing.Point(71, 12);
            this.btnds.Name = "btnds";
            this.btnds.Size = new System.Drawing.Size(148, 146);
            this.btnds.TabIndex = 0;
            this.btnds.Text = "Danh Sách Xe Cho Thuê";
            this.btnds.UseVisualStyleBackColor = true;
            this.btnds.Click += new System.EventHandler(this.btnds_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(235, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(148, 146);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Tra Cứu xe";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 146);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lập Phiếu Thuê";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(235, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 146);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lập Phiếu Thanh Toán";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 340);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnds);
            this.Name = "formmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formmain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnds;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}